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
    public class DAL_ThoiGian
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_ThoiGian()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public bool ThemMocThoiGian(DTO_ThoiGian tg)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblThoiGian] values (@thang, @nam)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@thang", tg.Thang);
                    cmd.Parameters.AddWithValue("@nam", tg.Nam);

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

        public List<DTO_ThoiGian> LayDanhSachThoiGian()
        {
            string query = string.Empty;
            query += "SELECT * FROM [tblThoiGian] ";
            List<DTO_ThoiGian> ltg = new List<DTO_ThoiGian>();

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

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DTO_ThoiGian tg = new DTO_ThoiGian();
                                tg.Id = long.Parse(reader["id"].ToString());
                                tg.Thang = reader.GetInt32(1);
                                tg.Nam = reader.GetInt32(2);
                                ltg.Add(tg);
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                        return ltg;
                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }
                }
            }
        }

        public long LayMaThoiGian(int thang, int nam)
        {
            string query = string.Empty;
            query += "SELECT [id] FROM [tblThoiGian] WHERE [thang] = @thang and [nam] = @nam";
            long id = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                id = long.Parse(reader["id"].ToString());
                            }
                        }
                        conn.Close();
                        conn.Dispose();
                        return id;
                    }
                    catch
                    {
                        conn.Close();
                        return -1;
                    }
                }
            }
        }
    }
}
