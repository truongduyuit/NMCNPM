using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuXuat
    {
        private long id;
        private long mapx;
        private long madvt;
        private long mamh;
        private int soluong;
        private uint thanhtien;

        public long Id { get => id; set => id = value; }
        public long MaPx { get => mapx; set => mapx = value; }
        public long MaDvt { get => madvt; set => madvt = value; }
        public long MaMh { get => mamh; set => mamh = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
        public uint ThanhTien { get => thanhtien; set => thanhtien = value; }
    }
}
