using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTO_MatHang
    {
        private long maMatHang;

        private string tenMatHang;

        private uint dongia;

        private long maDVT;

        [DisplayName("Mã Mặt Hàng")]
        public long MaMatHang { get => maMatHang; set => maMatHang = value; }

        [DisplayName("Tên Mặt Hàng")]
        public string TenMatHang { get => tenMatHang; set => tenMatHang = value; }

        [DisplayName("Đơn Giá")]
        public uint Dongia { get => dongia; set => dongia = value; }
        public long MaDVT { get => maDVT; set => maDVT = value; }
    }
}
