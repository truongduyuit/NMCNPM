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
    public class DAL_Quan
    {
        private string connectionString;
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public DAL_Quan()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public bool ThemQuan(DTO_Quan q)
        {

            string query = string.Empty;
            query += "INSERT INTO [tblQuan] ([tenQuan]) ";
            query += "VALUES (@tenquan)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenquan", q.TenQuan);
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
        public bool XoaQuan(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblQuan] where [id] = @id";

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
        public bool SuaQuan(DTO_Quan q)
        {
            string query = string.Empty;
            query = "UPDATE [tblQuan] " +
                "SET [tenQuan] = @tenquan" +
                " WHERE [id] = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tenquan", q.TenQuan);
                    
                    cmd.Parameters.AddWithValue("@id", q.Id);

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
        public List<DTO_Quan> TimKiemQuan(string tukhoa)
        {
            List<DTO_Quan> ds = new List<DTO_Quan>();
            long tk;
            string query = string.Empty;
            if (long.TryParse(tukhoa, out tk))
            {
                query += "SELECT * FROM [tblQuan]";
                query += "WHERE [id]= @tukhoa";
            }
            else
            {
                query += "SELECT * FROM [tblQuan]";
                query += "WHERE [tenQuan] = @tukhoa";
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
                                DTO_Quan q = new DTO_Quan();
                                q.Id = long.Parse(reader["id"].ToString());
                                q.TenQuan = reader.GetString(1);
                                ds.Add(q);
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
        public List<DTO_Quan> LayDanhSachQuan()
        {
            List<DTO_Quan> quans = new List<DTO_Quan>();
            string query = "SELECT * FROM tblQuan";

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
                                DTO_Quan quan = new DTO_Quan();
                                quan.Id = long.Parse(reader["id"].ToString());
                                quan.TenQuan = reader.GetString(1);
                                quans.Add(quan);
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
            return quans;
        }
        
    }
}
