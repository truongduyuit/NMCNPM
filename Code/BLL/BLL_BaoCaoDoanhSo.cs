using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class BLL_BaoCaoDoanhSo
    {
        #region prop
        private DAL_BaoCaoDoanhSo bcds = new DAL_BaoCaoDoanhSo();
        #endregion
        #region method
        public List<DTO_BaoCaoDoanhSo> hienthidoanhso(int startmonth,int startyear,int endmonth,int endyear) {
            return bcds.hienthidoanhso(startmonth, startyear, endmonth, endyear);
        }
        public uint hienthitongdoanhthu() {
            return bcds.hienthitongdoanhthu();
        }
        #endregion
    }
}
