using System;
using System.Collections.Generic;
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

        public long Id { get => id; set => id = value; }
        public DateTime Ngaythu { get => ngaythu; set => ngaythu = value; }
        public long MaDL { get => maDL; set => maDL = value; }
        public uint Sotien { get => sotien; set => sotien = value; }
        #endregion
    }
}
