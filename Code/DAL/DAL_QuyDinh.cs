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
    public class DAL_QuyDinh
    {
        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_QuyDinh()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public DTO_QuyDinh QuyDinh()
        {
            string query = string.Empty;
            query = "SELECT * FROM tblThamSo";

            DTO_QuyDinh qd = new DTO_QuyDinh();

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
                                qd.Id = long.Parse(reader["id"].ToString());
                                qd.SoQuan = reader.GetInt32(1);
                                qd.SoDLToiDa = reader.GetInt32(2);
                                qd.SoMatHang = reader.GetInt32(3);
                                qd.SoDVT = reader.GetInt32(4);
                            }
                            conn.Close();
                            conn.Dispose();
                            return qd;
                        }

                    }
                    catch
                    {
                        conn.Close();
                        return null;
                    }
                    
                }
            }              
            return qd;
        }

        public bool ChinhSuaQuyDinh(DTO_QuyDinh qd)
        {
            string query = string.Empty;
            query += "UPDATE [tblThamSo] ";
            query += "SET [soQuan] = @soquan , [soDLToiDa] = @sodltoida, [soMH] = @somh, [soDVT] = @sodvt";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@soquan", qd.SoQuan);
                    cmd.Parameters.AddWithValue("@sodltoida", qd.SoDLToiDa);
                    cmd.Parameters.AddWithValue("@somh", qd.SoMatHang);
                    cmd.Parameters.AddWithValue("@sodvt", qd.SoDVT);

                    try
                    {
                        conn.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            conn.Close();
                            conn.Dispose();
                            return true;
                        }
                    }
                    catch
                    {
                        conn.Close();
                        return false;
                    }
                }
            }

                return true;
        }
    }
}
