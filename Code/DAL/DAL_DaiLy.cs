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

        public List<DTO_DaiLy> LayDanhSachDaiLy()
        {
            List<DTO_DaiLy> ldl = new List<DTO_DaiLy>();

            string query = string.Empty;
            query = "SELECT * FROM tblDaiLy";

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
                                DTO_DaiLy dl = new DTO_DaiLy();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.TenDaiLy = reader.GetString(1);
                                dl.MaLoaiDL = long.Parse(reader["maLoaiDL"].ToString());
                                dl.Sdt = reader.GetString(3);
                                dl.DiaChi = reader.GetString(4);
                                dl.MaQuan = long.Parse(reader["maQuan"].ToString());
                                dl.NgayTiepNhan = reader.GetDateTime(6);
                                dl.TongNo = (uint)reader.GetDecimal(7);
                                ldl.Add(dl);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }

            return ldl;
        }
    }
}
