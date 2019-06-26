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
    public class DAL_DaiLy
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_DaiLy()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_DaiLy> LayDanhSachDaiLy() {
            List<DTO_DaiLy> ds = new List<DTO_DaiLy>();

            string query = string.Empty;
            query = "SELECT * FROM tblDaiLy";

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
                                DTO_DaiLy dl = new DTO_DaiLy();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenDaiLy = reader.GetString(1);
                                dl.MaLoaiDL = long.Parse(reader["maLoaiDL"].ToString());
                                dl.Sdt = reader.GetString(3);
                                dl.DiaChi = reader.GetString(4);
                                dl.MaQuan = long.Parse(reader["maQuan"].ToString());
                                dl.NgayTiepNhan = reader.GetDateTime(6);
                                dl.TongNo = (uint)reader.GetDecimal(7);
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

        public bool ThemDaiLy(DTO_DaiLy dl)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblDaiLy] ([tenDL], [maLoaiDL], [sdt], [diaChi], [maQuan], [ngayTiepNhan], [tongNo]) ";
            query += "VALUES (@tendl, @maloaidl, @sdt, @diachi, @maquan, @ngaytiepnhan, @tongno)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tendl", dl.TenDaiLy);
                    cmd.Parameters.AddWithValue("@maloaidl", dl.MaLoaiDL);
                    cmd.Parameters.AddWithValue("@sdt", dl.Sdt);
                    cmd.Parameters.AddWithValue("@diachi", dl.DiaChi);
                    cmd.Parameters.AddWithValue("@maquan", dl.MaQuan);
                    cmd.Parameters.AddWithValue("@ngaytiepnhan", dl.NgayTiepNhan);
                    cmd.Parameters.AddWithValue("@tongno", Decimal.Parse(dl.TongNo.ToString()));

                    try
                    {
                        con.Open();
                       if (cmd.ExecuteNonQuery() > 0)
                       {
                            con.Close();
                            con.Dispose();
                            return true;
                       }
                        else
                        {
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

        public bool XoaDaiLy(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblDaiLy] WHERE [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        else
                        {
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

        public bool SuaDaiLy(DTO_DaiLy dl)
        {
            string query = string.Empty;
            query = "UPDATE [tblDaiLy] " +
                "SET [tenDL] = @tendl , [maLoaiDL] = @maldl, [sdt] = @sdt, [diaChi] = @diachi, [maQuan] = @maquan, [tongNo] = @tongno " +
                "WHERE [id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tendl", dl.TenDaiLy);
                    cmd.Parameters.AddWithValue("@maldl", dl.MaLoaiDL);
                    cmd.Parameters.AddWithValue("@sdt", dl.Sdt);
                    cmd.Parameters.AddWithValue("@diachi", dl.DiaChi);
                    cmd.Parameters.AddWithValue("@maquan", dl.MaQuan);
                    cmd.Parameters.AddWithValue("@tongno", Decimal.Parse(dl.TongNo.ToString()));
                    cmd.Parameters.AddWithValue("@id", dl.Id);

                    try
                    {
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            con.Dispose();
                            return true;
                        }
                        else
                        {
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

        public List<DTO_DaiLy> TimKiemDaiLy(string tukhoa)
        {
            List<DTO_DaiLy> ds = new List<DTO_DaiLy>();

            string query = string.Empty;            
            query += "SELECT * FROM [tblDaiLy]";
            query += "WHERE [tenDL] like '%' + @tukhoa + '%' " +
                "OR [sdt] like '%' + @tukhoa + '%' " +
                "OR [diaChi] like '%' + @tukhoa + '%' ";
            long tk;
            if (long.TryParse(tukhoa, out tk))
            {
                query += "OR [id] like '%' + @tukhoa + '%' " +
                    "OR[maLoaiDL] like '%' + @tukhoa + '%' " +
                    "OR [maQuan] like '%' + @tukhoa + '%' ";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
                    cmd.Parameters.AddWithValue("@tk", tk);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DTO_DaiLy dl = new DTO_DaiLy();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenDaiLy = reader.GetString(1);
                                dl.MaLoaiDL = long.Parse(reader["maLoaiDL"].ToString());
                                dl.Sdt = reader.GetString(3);
                                dl.DiaChi = reader.GetString(4);
                                dl.MaQuan = long.Parse(reader["maQuan"].ToString());
                                dl.NgayTiepNhan = reader.GetDateTime(6);
                                dl.TongNo = (uint)reader.GetDecimal(7);
                                ds.Add(dl);
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

            return ds;
        }
    }
}
