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
   public class DAL_DonViTinh
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public DAL_DonViTinh() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public List<DTO_DonViTinh> LayDanhSachMatHang() {
            List<DTO_DonViTinh> ds = new List<DTO_DonViTinh>();

            string query = string.Empty;
            query = "SELECT * FROM tblDonViTinh";

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
                                DTO_DonViTinh dvt = new DTO_DonViTinh();
                                dvt.Id = long.Parse(reader["id"].ToString());
                                dvt.Ten = reader.GetString(1);
                                ds.Add(dvt);
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

        public string LayDonViTinh(long id)
        {
            string ds = string.Empty;

            string query = string.Empty;
            query = "SELECT * FROM tblDonViTinh WHERE [id] = @id";

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
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                               ds = reader.GetString(1);
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

        public bool ThemDonViTinh(DTO_DonViTinh dvt)
        {
            string query = string.Empty;
            query += "INSERT INTO [tblDonViTinh] ([tenDVT]) ";
            query += "VALUES (@tendvt)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tendvt", dvt.Ten);

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

        public bool XoaDonViTinh(long id)
        {
            string query = string.Empty;
            query += "DELETE FROM [tblDonViTinh] where [id] = @id";

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

        public bool SuaDonViTinh(DTO_DonViTinh dvt)
        {
            string query = string.Empty;
            query = "UPDATE [tblDonViTinh] " + "SET [tenDVT] = @tendl " + "WHERE [id] = @id";
            //query = "SuaDaiLy";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@tendl", dvt.Ten);
                    cmd.Parameters.AddWithValue("@id", dvt.Id);


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
    }
}
