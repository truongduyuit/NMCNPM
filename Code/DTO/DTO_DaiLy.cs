using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DaiLy
    {
        
        private long id;

        private string tenDaiLy;
  
        private long maLoaiDL;

        private string sdt;

        private string diaChi;

        private long maQuan;

        private DateTime ngayTiepNhan;

        private uint tongNo;

        [DisplayName("Mã đại lý")]
        public long Id { get => id; set => id = value; }

        [DisplayName("Tên Đại Lý")]
        public string TenDaiLy { get => tenDaiLy; set => tenDaiLy = value; }

        [DisplayName("Mã Loại Đại Lý")]
        public long MaLoaiDL { get => maLoaiDL; set => maLoaiDL = value; }

        [DisplayName("Số điện Thoại")]
        public string Sdt { get => sdt; set => sdt = value; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get => diaChi; set => diaChi = value; }

        [DisplayName("Mã Quận")]
        public long MaQuan { get => maQuan; set => maQuan = value; }

        [DisplayName("Ngày Tiếp Nhận")]
        public DateTime NgayTiepNhan { get => ngayTiepNhan; set => ngayTiepNhan = value; }

        [DisplayName("Tổng Nợ")]
        public uint TongNo { get => tongNo; set => tongNo = value; }
    }
}
