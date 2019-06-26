using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_ThoiGian
    {
        private DAL_ThoiGian tg = new DAL_ThoiGian();

        public List<DTO_ThoiGian> LayDanhSachThoiGian()
        {
            return tg.LayDanhSachThoiGian();
        }

        public long LayMaThoiGian(int thang, int nam)
        {
            return tg.LayMaThoiGian(thang, nam);
        }
    }
}
