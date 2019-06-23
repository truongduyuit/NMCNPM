using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_PhieuThu
    {
        #region prop
        private long id;
        private DateTime ngaythu;
        private long maDL;
        private uint sotien;
        [DisplayName("Mã phiếu thu")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Ngày thu")]
        public DateTime Ngaythu { get => ngaythu; set => ngaythu = value; }
        [DisplayName("Mã đại lý")]
        public long MaDL { get => maDL; set => maDL = value; }
        [DisplayName("Số tiền")]
        public uint Sotien { get => sotien; set => sotien = value; }
        #endregion
    }
}
