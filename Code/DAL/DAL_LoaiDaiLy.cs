using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.ComponentModel;
using System.Data;
using System.Drawing;


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
        public bool ThemLoaiDaiLy(DTO_LoaiDaiLy ldl)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblLoaiDaiLy] ([tenLDL], [noToiDa]) ";
            query += "VALUES (@tenldl, @notoida)";
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenldl", ldl.TenLoaiDaiLy);
                    cmd.Parameters.AddWithValue("@notoida", decimal.Parse(ldl.NoToiDa.ToString()));

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
        public bool SuaLoaiDaiLy(DTO_LoaiDaiLy ldl)
        {
            string query = string.Empty;
            query = "UPDATE [tblLoaiDaiLy] " +
                "SET [tenLDL] = @tenldl , [noToiDa] = @notoida " +
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

                    cmd.Parameters.AddWithValue("@tenldl", ldl.TenLoaiDaiLy);
                    cmd.Parameters.AddWithValue("@noToiDa", Decimal.Parse(ldl.NoToiDa.ToString()));
                    cmd.Parameters.AddWithValue("@id", ldl.Id);

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
        public bool XoaLoaiDaiLy(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblLoaiDaiLy] where [id] = @id";

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
        public List<DTO_LoaiDaiLy> TimKiemLoaiDaiLy(string tukhoa)
        {
            List<DTO_LoaiDaiLy> ds = new List<DTO_LoaiDaiLy>();
            long tk;
            string query = string.Empty;
            if (long.TryParse(tukhoa, out tk))
            {
                query += "SELECT * FROM [tblLoaiDaiLy]";
                query += "WHERE [id]= @tukhoa";
            }
            else
            {
                query += "SELECT * FROM [tblLoaiDaiLy]";
                query += "WHERE [tenLDL] = @tukhoa";
            }
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
                                DTO_LoaiDaiLy ldl = new DTO_LoaiDaiLy();
                                ldl.Id = long.Parse(reader["id"].ToString());
                                ldl.TenLoaiDaiLy = reader.GetString(1);
                                ldl.NoToiDa = (uint)reader.GetDecimal(2);
                                ds.Add(ldl);
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
