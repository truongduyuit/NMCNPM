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
    public class DAL_ChiTietPhieuXuat
    {
        private string connectionString;

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_ChiTietPhieuXuat()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DTO_ChiTietPhieuXuat> LayDanhSachChiTiet()
        {
            List<DTO_ChiTietPhieuXuat> ds = new List<DTO_ChiTietPhieuXuat>();

            string query = string.Empty;
            query = "SELECT * FROM tblChiTietPX";

            using (SqlConnection con = new SqlConnection(connectionString))
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
                            while (reader.Read())
                            {
                                DTO_ChiTietPhieuXuat ctpx = new DTO_ChiTietPhieuXuat();
                                ctpx.Id = long.Parse(reader["id"].ToString());
                                ctpx.MaPx = long.Parse(reader["maPX"].ToString());
                                ctpx.MaDvt = long.Parse(reader["maDVT"].ToString());
                                ctpx.MaMh = long.Parse(reader["maMH"].ToString());
                                ctpx.SoLuong = int.Parse(reader["soLuong"].ToString());
                                ctpx.ThanhTien = (uint)reader.GetDecimal(5);
                                ds.Add(ctpx);
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
        public bool ThemChiTiet(DTO_ChiTietPhieuXuat chitiet)
        {

            string query = string.Empty;
            query += "INSERT [dbo].[tblChiTietPX] ([maPX], [maDVT], [maMH], [soLuong],[thanhTien])";
            query += "VALUES (@mapx, @madvt, @mamh, @soluong, @thanhTien)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@mapx", chitiet.MaPx);
                    cmd.Parameters.AddWithValue("@madvt",chitiet.MaDvt);
                    cmd.Parameters.AddWithValue("@mamh", chitiet.MaMh);
                    cmd.Parameters.AddWithValue("@soluong", chitiet.SoLuong);
                    cmd.Parameters.AddWithValue("@thanhTien", Decimal.Parse(chitiet.ThanhTien.ToString()));
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
        public bool XoaChiTiet(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblChiTietPX] where [id] = @id";

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
        public bool SuaChiTietPX(DTO_ChiTietPhieuXuat ctpx)
        {
            string query = string.Empty;
            query = "UPDATE [tblChiTietPX] " +
                "SET [maDVT] = @madvt , [maMH] = @mamh, [soLuong] = @soluong " +
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

                    cmd.Parameters.AddWithValue("@madvt", ctpx.MaDvt);
                    cmd.Parameters.AddWithValue("@mamh", ctpx.MaMh);
                    cmd.Parameters.AddWithValue("@soluong", ctpx.SoLuong);
                    cmd.Parameters.AddWithValue("@id", ctpx.Id);


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
        public List<DTO_ChiTietPhieuXuat> timkiem(string tukhoa)
        {
            List<DTO_ChiTietPhieuXuat> ds = new List<DTO_ChiTietPhieuXuat>();

            string query = string.Empty;
            query += "SELECT * FROM [tblChiTietPX]";
            query += "WHERE [maPX] = @tukhoa";
       

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DTO_ChiTietPhieuXuat ctpx = new DTO_ChiTietPhieuXuat();
                                ctpx.Id = long.Parse(reader["id"].ToString());
                                ctpx.MaPx = long.Parse(reader["maPX"].ToString());
                                ctpx.MaDvt = long.Parse(reader["maDVT"].ToString());
                                ctpx.MaMh = long.Parse(reader["maMH"].ToString());
                                ctpx.SoLuong = int.Parse(reader["soLuong"].ToString());
                                ctpx.ThanhTien = (uint)reader.GetDecimal(5);
                                ds.Add(ctpx);
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
