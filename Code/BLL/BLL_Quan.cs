using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Quan
    {
        private DAL_Quan quan = new DAL_Quan();

        public List<DTO_Quan> LayDanhSachQuan()
        {
            return quan.LayDanhSachQuan();
        }
        public bool ThemQuan(DTO_Quan q)
        {
            return quan.ThemQuan(q);
        }
        public bool XoaQuan(long id)
        {
            return quan.XoaQuan(id);
        }
        public bool SuaQuan(DTO_Quan q)
        {
            return quan.SuaQuan(q);
        }

        public List<DTO_Quan> TimKiemQuan(string tukhoa)
        {
            return quan.TimKiemQuan(tukhoa);
        }
    }
}
