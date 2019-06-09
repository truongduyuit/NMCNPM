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
   public class DAL_PhieuThu
    {
        #region prop
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
        #endregion
        #region method
        public DAL_PhieuThu() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool ThemPhieuThu(DTO_PhieuThu pt) {

            string query = string.Empty;
            query += "INSERT INTO tblPhieuThu ([ngayThu],[maDL],[soTienThu]) ";
            query += " VALUES (@ngaythu, @madl, @sotien)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@ngaythu", pt.Ngaythu);
                    cmd.Parameters.AddWithValue("@madl",pt.MaDL);
                    cmd.Parameters.AddWithValue("@sotien", decimal.Parse(pt.Sotien.ToString()));

                    try {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0) {
                        con.Close();
                        con.Dispose();
                        return true;
                    } else {
                        con.Close();
                        return false;
                    }
                    } catch {
                    con.Close();
                    return false;
                }
               }
            }
        }
        #endregion
    }
}
