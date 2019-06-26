using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_PhieuXuatHang
    {
        private DAL_PhieuXuatHang pxh = new DAL_PhieuXuatHang();
        public List<DTO_PhieuXuatHang> laydanhsach()
        {
            return pxh.LayDanhSachPhieuXuat();
        }
        public List<DTO_PhieuXuatHang> TimKiem(string tukhoa)
        {
            return pxh.TimKiemPhieuXuatHang(tukhoa);
        }
        public bool ThemPhieuXuat(DTO_PhieuXuatHang Phieuxh)
        {
            return pxh.ThemPhieuXuat(Phieuxh);
        }
        public bool SuaPhieuXuat(DTO_PhieuXuatHang Phieuxh)
        {
            return pxh.SuaPhieuXuat(Phieuxh);
        }
        public bool XoaPhieuXuat(long id)
        {
            return pxh.XoaPhieuXuat(id);
        }

        public uint LayTongXuat(long madl, int thang, int nam)
        {
            return pxh.TongXuat(madl, thang, nam);
        }
    }
}
