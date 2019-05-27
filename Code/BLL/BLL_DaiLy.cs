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
        private DAL_DaiLy _daily;
        public List<DTO_DaiLy> LayDanhSachDaiLy()
        {
            _daily = new DAL_DaiLy();
            return _daily.LayDanhSachDaiLy();
        }
    }
}
