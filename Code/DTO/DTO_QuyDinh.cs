using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QuyDinh
    {
        private long id;

        private int soQuan;

        private int soDLToiDa;

        private int soMatHang;

        private int soDVT;
    
        public long Id { get => id; set => id = value; }

        [DisplayName("Số lượng quận")]
        public int SoQuan { get => soQuan; set => soQuan = value; }

        [DisplayName("Số lượng đại lý tối đa mỗi quận")]
        public int SoDLToiDa { get => soDLToiDa; set => soDLToiDa = value; }

        [DisplayName("Số lượng mặt hàng")]
        public int SoMatHang { get => soMatHang; set => soMatHang = value; }

        [DisplayName("Số lượng đơn vị tính")]
        public int SoDVT { get => soDVT; set => soDVT = value; }
    }
}
