using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_ChiTietPhieuXuat
    {
        DAL_ChiTietPhieuXuat chitietphieuxuat = new DAL_ChiTietPhieuXuat();
        public List<DTO_ChiTietPhieuXuat> LayDanhSachChiTietPhieuXuat()
        {
            return chitietphieuxuat.LayDanhSachChiTiet();
        }
        public List<DTO_ChiTietPhieuXuat> TimKiemChiTiet(string tukhoa)
        {
            return chitietphieuxuat.timkiem(tukhoa);
        }
    }
}
