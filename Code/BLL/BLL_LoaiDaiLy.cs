using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_LoaiDaiLy
    {
        private DAL_LoaiDaiLy ldl = new DAL_LoaiDaiLy();

        public List<DTO_LoaiDaiLy> LayDanhSachLoaiDaiLy()
        {
            return ldl.LayDanhSachLoaiDaiLy();
        }
        public bool ThemLoaiDaiLy(DTO_LoaiDaiLy loaidl)
        {
            return ldl.ThemLoaiDaiLy(loaidl);
        }
        public bool XoaLoaiDaiLy(long id)
        {
            return ldl.XoaLoaiDaiLy(id);
        }
        public bool SuaLoaiDaiLy(DTO_LoaiDaiLy loaidl)
        {
            return ldl.SuaLoaiDaiLy(loaidl);
        }
        public List<DTO_LoaiDaiLy> TimKiem(string tukhoa)
        {
            return ldl.TimKiemLoaiDaiLy(tukhoa);
        }
    }
}
