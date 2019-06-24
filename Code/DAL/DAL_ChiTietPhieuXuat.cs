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
            query += " select * from tblChiTietPX";
            

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
                                //DTO_ChiTietPhieuXuat ctpx = new DTO_ChiTietPhieuXuat();
                                //ctpx.Id = long.Parse(reader["id"].ToString());
                                //ctpx.MaPx = long.Parse(reader["maPX"].ToString());
                                //ctpx.MaDvt = long.Parse(reader["maDVT"].ToString());
                                //ctpx.MaMh = long.Parse(reader["maMH"].ToString());
                                //ctpx.SoLuong = (int)reader.GetInt32(4);
                                //ctpx.ThanhTien = (uint)reader.GetDecimal(5);
                                //ds.Add(ctpx);
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
        public List<DTO_ChiTietPhieuXuat> timkiem(string tukhoa)
        {
            List<DTO_ChiTietPhieuXuat> ds = new List<DTO_ChiTietPhieuXuat>();

            string query = string.Empty;
            query += "select * from [tblChiTietPX] ";
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
                                ctpx.SoLuong = (int)reader.GetInt32(4);
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
