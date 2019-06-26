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

        public List<DTO_PhieuThu> LayDanhSachPhieuThu() {
            List<DTO_PhieuThu> ds = new List<DTO_PhieuThu>();

            string query = string.Empty;
            query = "SELECT * FROM tblPhieuThu";

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
                                DTO_PhieuThu pt = new DTO_PhieuThu();
                                pt.Id = long.Parse(reader["id"].ToString());
                                pt.Ngaythu = DateTime.Parse(reader["Ngaythu"].ToString());
                                pt.MaDL = long.Parse(reader["maDL"].ToString());
                                pt.Sotien = (uint)reader.GetDecimal(3);
                                ds.Add(pt);
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

        public bool XoaPhieuThu(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblPhieuThu] where [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool SuaPhieuThu(DTO_PhieuThu pt) {
            string query = string.Empty;
            query = "UPDATE [tblPhieuThu] " +
                "SET [soTienThu] = @sotien " +
                "WHERE [id] = @id";
            

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@sotien", Decimal.Parse(pt.Sotien.ToString()));
                    cmd.Parameters.AddWithValue("@id", pt.Id);

                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
                            con.Close();
                            return false;
                        }
                    }
                    catch
                    {
                        con.Close();
                        return false;
                    }
                }
            }
        }

        public uint TongThu(long madl, int thang, int nam)
        {
            uint tt = 0;
            string query = string.Empty;
            query += "select sum(soTienThu) from tblPhieuThu ";
            query += "where maDL =@madl and MONTH(ngayThu) = @thang and YEAR(ngayThu) = @nam";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@madl", madl);
                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);

                    try
                    {
                        con.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tt = (uint)reader.GetDecimal(0);
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch
                    {
                        con.Close();
                    }
                }
            }

            return tt;
        }
        #endregion
    }
}
