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
  public  class DAL_Mathang
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_Mathang() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
       
        public List<DTO_MatHang> LayDanhSachMatHang() {
            List<DTO_MatHang> ds = new List<DTO_MatHang>();

            string query = string.Empty;
            query = "SELECT * FROM tblMatHang";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try{
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_MatHang dl = new DTO_MatHang();
                                dl.MaMatHang = long.Parse(reader["id"].ToString());
                                dl.TenMatHang = reader.GetString(1);
                                dl.MaDVT = long.Parse(reader["maDonViTinh"].ToString());
                                dl.Dongia = (uint)reader.GetDecimal(3);
                                ds.Add(dl);
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

        public bool ThemMatHang(DTO_MatHang dl) {

            string query = string.Empty;
            query += "INSERT INTO tblMatHang ([tenMatHang],[DonGia],[maDonViTinh]) ";
            query += " VALUES (@tenMH, @DonGia, @madonvitinh)";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tenMH",dl.TenMatHang);
                    cmd.Parameters.AddWithValue("@DonGia", Decimal.Parse(dl.Dongia.ToString()));
                    cmd.Parameters.AddWithValue("@madonvitinh", dl.MaDVT);

                    //   try {
                    con.Open();
                        if (cmd.ExecuteNonQuery() > 0) {
                            con.Close();
                            con.Dispose();
                            return true;
                        } else {
                            con.Close();
                            return false;
                        }
                   // } catch {
                        con.Close();
                        return false;
                    }
                //}
            }
        }

        public bool XoaMatHang(long id) {
            string query = string.Empty;
            query += "DELETE FROM [tblMatHang] where [id] = @id";

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

        public bool SuaMatHang(DTO_MatHang dl) {
            string query = string.Empty;
            query = "UPDATE [tblMatHang] " +
                "SET [tenMatHang] = @tenMatHang ,[maDonViTinh] = @madonvitinh, [DonGia] = @DonGia WHERE [Id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tenMatHang", dl.TenMatHang);
                    cmd.Parameters.AddWithValue("@DonGia", Decimal.Parse(dl.Dongia.ToString()));
                    cmd.Parameters.AddWithValue("@id", dl.MaMatHang);
                    cmd.Parameters.AddWithValue("@madonvitinh", dl.MaDVT);

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

        public List<DTO_MatHang> TimKiemMatHang(string tukhoa) {
            List<DTO_MatHang> ds = new List<DTO_MatHang>();

            string query = string.Empty;
            query += "SELECT * FROM [tblMatHang]";
            query += "WHERE [tenMH] like '%' + @tukhoa + '%'";
                
            long tk;
            if (long.TryParse(tukhoa, out tk)) {
                query += "OR [id] like '%' + @tukhoa + '%' ";
            }

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
                    cmd.Parameters.AddWithValue("@tk", tk);

                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_MatHang dl = new DTO_MatHang();
                                dl.MaMatHang = long.Parse(reader["id"].ToString());
                                dl.TenMatHang = reader.GetString(1);
                                dl.Dongia = (uint)reader.GetDecimal(2);
                                ds.Add(dl);
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
