using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_DonViTinh
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_DonViTinh() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_DonViTinh> LayDanhSachMatHang() {
            List<DTO_DonViTinh> ds = new List<DTO_DonViTinh>();

            string query = string.Empty;
            query = "SELECT * FROM tblDonViTinh";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_DonViTinh dvt = new DTO_DonViTinh();
                                dvt.Id = long.Parse(reader["id"].ToString());
                                dvt.Ten = reader.GetString(1);
                                ds.Add(dvt);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    } catch {
                        con.Close();
                        return null;
                    }
                }
            }

            return ds;
        }
    }
}
