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
    public class DAL_BaoCaoCongNo
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_BaoCaoCongNo()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_BaoCaoCongNo> DanhSachCongNo()
        {
            List<DTO_BaoCaoCongNo> lcn = new List<DTO_BaoCaoCongNo>();

            string query = string.Empty;
            query = "SELECT * FROM [tblBaoCaoCongNo]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                DTO_BaoCaoCongNo cn = new DTO_BaoCaoCongNo();
                                cn.Id = long.Parse(reader["id"].ToString());
                                cn.MaDL = long.Parse(reader["maDL"].ToString());
                                cn.NoDau = (uint)reader.GetDecimal(2);
                                cn.PhatSinh = (uint)reader.GetDecimal(3);
                                cn.NoCuoi = (uint)reader.GetDecimal(4);
                                cn.MaTG = long.Parse(reader["maTG"].ToString());

                                lcn.Add(cn);
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                        return lcn;
                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
        }

        public bool ThemCongNo(DTO_BaoCaoCongNo cn)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblBaoCaoCongNo] ";
            query += "VALUES (@madl, @nodau, @phatsinh, @nocuoi, @matg)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@madl", cn.MaDL);
                    cmd.Parameters.AddWithValue("@nodau", Decimal.Parse(cn.NoDau.ToString()));
                    cmd.Parameters.AddWithValue("@phatsinh", Decimal.Parse(cn.PhatSinh.ToString()));
                    cmd.Parameters.AddWithValue("@nocuoi", Decimal.Parse(cn.NoCuoi.ToString()));
                    cmd.Parameters.AddWithValue("@matg", cn.MaTG);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            conn.Dispose();
                            return true;
                        }
                        else
                            return false;
                    }
                    catch
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
        }

        public bool SuaCongNo(DTO_BaoCaoCongNo cn)
        {
            string query = string.Empty;
            query = "UPDATE [tblBaoCaoCongNo] ";
            query += "SET [maDL] = @madl, [noDau] = @nodau, [phatSinh] = @phatsinh, [noCuoi] = @nocuoi, [maTG] = @matg ";
            query += "WHERE [id] = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", cn.Id);
                    cmd.Parameters.AddWithValue("@madl", cn.MaDL);
                    cmd.Parameters.AddWithValue("@nodau", Decimal.Parse(cn.NoDau.ToString()));
                    cmd.Parameters.AddWithValue("@phatsinh", Decimal.Parse(cn.PhatSinh.ToString()));
                    cmd.Parameters.AddWithValue("@nocuoi", Decimal.Parse(cn.NoCuoi.ToString()));
                    cmd.Parameters.AddWithValue("@matg", cn.MaTG);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            conn.Dispose();
                            return true;
                        }
                        else
                            return false;
                    }
                    catch
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
        }

        public bool XoaCongNo(long id)
        {
            string query = string.Empty;
            query = "DELETE FROM [tblBaoCaoCongNo] ";
            query += "WHERE [id] = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            conn.Dispose();
                            return true;
                        }
                        else
                            return false;
                    }
                    catch
                    {
                        conn.Close();
                        return false;
                    }
                }
            }
        }

        public List<DTO_BaoCaoCongNo> TimKiemCongNo(long tukhoa, int loai)
        {
            List<DTO_BaoCaoCongNo> lcn = new List<DTO_BaoCaoCongNo>();

            string query = string.Empty;
            if (loai == 1)
            {
                query = "SELECT * FROM [tblBaoCaoCongNo] WHERE [maTG] = @tukhoa ";
            }
            else
            {
                query = "SELECT * FROM [tblBaoCaoCongNo] WHERE [maDL] = @tukhoa ";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tukhoa", tukhoa);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DTO_BaoCaoCongNo cn = new DTO_BaoCaoCongNo();
                                cn.Id = long.Parse(reader["id"].ToString());
                                cn.MaDL = long.Parse(reader["maDL"].ToString());
                                cn.NoDau = (uint)reader.GetDecimal(2);
                                cn.PhatSinh = (uint)reader.GetDecimal(3);
                                cn.NoCuoi = (uint)reader.GetDecimal(4);
                                cn.MaTG = long.Parse(reader["maTG"].ToString());

                                lcn.Add(cn);
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                        return lcn;
                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
        }
    }
}
