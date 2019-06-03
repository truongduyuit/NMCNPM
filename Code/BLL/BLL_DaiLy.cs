using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
  public class BLL_DaiLy
    {
        private DAL_DaiLy daily = new DAL_DaiLy();
        public List<DTO_DaiLy> LayDanhSachDaiLy()
        {
            return daily.LayDanhSachDaiLy();
        }

        public bool ThemDaiLy(DTO_DaiLy dl)
        {
            return daily.ThemDaiLy(dl);
        }

        public bool XoaDaiLy(long id)
        {
            return daily.XoaDaiLy(id);
        }

        public bool SuaDaiLy(DTO_DaiLy dl)
        {
            return daily.SuaDaiLy(dl);
        }

        public List<DTO_DaiLy> TimKiemDaiLy(string tukhoa)
        {
            return daily.TimKiemDaiLy(tukhoa);
        }
    }
}
