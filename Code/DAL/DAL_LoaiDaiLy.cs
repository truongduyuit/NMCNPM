using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_LoaiDaiLy
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_LoaiDaiLy()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_LoaiDaiLy> LayDanhSachLoaiDaiLy()
        {
            List<DTO_LoaiDaiLy> ls = new List<DTO_LoaiDaiLy>();

            string query = "SELECT * FROM tblLoaiDaiLy";

            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while(reader.Read())
                            {
                                DTO_LoaiDaiLy ldl = new DTO_LoaiDaiLy();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.TenLoaiDaiLy = reader.GetString(1);
                                ldl.NoToiDa = (uint)reader.GetDecimal(2);
                                ls.Add(ldl);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                        return null;
                    }
                }

            }

            return ls;
        }
    }
}
