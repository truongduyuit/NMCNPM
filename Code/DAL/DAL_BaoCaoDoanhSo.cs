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
  public  class DAL_BaoCaoDoanhSo
    {
        private string connectionString;

        public string ConnectionString {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public List<DTO_BaoCaoDoanhSo> list = new List<DTO_BaoCaoDoanhSo>();
        public DAL_BaoCaoDoanhSo() {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public List<DTO_BaoCaoDoanhSo> hienthidoanhso(int startmonth, int startyear, int endmonth, int endyear) 
            {
            List<DTO_BaoCaoDoanhSo> List = new List<DTO_BaoCaoDoanhSo>();

            String query = string.Empty;
            query = "Select * from tblBaoCaodoanhso where matg in (select id from tblthoigian where (thang >= @startmonth and nam = @startyear) and ( thang <= @endmonth and nam = @endyear ) or ( thang < @startmonth and nam > @startyear and thang <= @endmonth and nam = @endyear ))";

            using (SqlConnection con = new SqlConnection(connectionString)) {
                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@startmonth", startmonth);
                    cmd.Parameters.AddWithValue("@startyear", startyear);
                    cmd.Parameters.AddWithValue("@endmonth", endmonth);
                    cmd.Parameters.AddWithValue("@endyear", endyear);
                    try {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows == true) {
                            while (reader.Read()) {
                                DTO_BaoCaoDoanhSo dl = new DTO_BaoCaoDoanhSo();
                                dl.Id = long.Parse(reader["id"].ToString());
                                dl.Madaily = long.Parse(reader["maDL"].ToString());
                            dl.Tyle = float.Parse(reader["tyle"].ToString());
                                dl.Sophieuxuat = int.Parse(reader["soPhieuXuat"].ToString());
                                dl.Tongtrigia = (uint)reader.GetDecimal(3);

                                List.Add(dl);
                            }
                        }
                        con.Close();
                        con.Dispose();
                    } catch {
                        con.Close();
                        return null;
                    }
                    list = List;
                    return List;
                }
            }
        }

        public uint hienthitongdoanhthu() {
            uint tong = 0;
            if( list.Count != 0)
            for (int i = 0; i < list.Count; i++)
                tong += list[i].Tongtrigia;
            return tong;
        }
    }
}

