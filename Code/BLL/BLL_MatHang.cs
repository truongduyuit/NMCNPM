using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class BLL_MatHang
    {
        private DAL_Mathang mathang = new DAL_Mathang();
        public List<DTO_MatHang> LayDanhSachMatHang() {
            return mathang.LayDanhSachMatHang();
        }

        public bool ThemMatHang(DTO_MatHang dl) {
            return mathang.ThemMatHang(dl);
        }

        public bool XoaMatHang(long id) {
            return mathang.XoaMatHang(id);
        }

        public bool SuaMatHang(DTO_MatHang dl) {
             return mathang.SuaMatHang(dl);
        }

        public List<DTO_MatHang> TimKiemMatHang(string tukhoa) {
             return mathang.TimKiemMatHang(tukhoa);
        }
    }
}
