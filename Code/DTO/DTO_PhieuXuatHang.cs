using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_PhieuXuatHang
    {
        private long id;
        private long madl;
        private DateTime ngaylapphieu;
        private uint tongtrigia;

        public long Id
        { get => id; set => id = value; }
        public long MaDl
        { get => madl; set => madl = value; }
        public DateTime NgayLapPhieu
        { get => ngaylapphieu; set => ngaylapphieu = value; }
        public uint TongTriGia
        { get => tongtrigia; set => tongtrigia = value; }

    }
}
