using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCaoCongNo
    {
        private long id;

        private long maDL;

        private uint noDau;

        private uint phatSinh;

        private uint noCuoi;

        private long maTG;

        [DisplayName("Mã công nợ")]
        public long Id { get => id; set => id = value; }

        [DisplayName("Mã đại lý")]
        public long MaDL { get => maDL; set => maDL = value; }

        [DisplayName("Nợ đầu")]
        public uint NoDau { get => noDau; set => noDau = value; }

        [DisplayName("Nợ phát sinh")]
        public uint PhatSinh { get => phatSinh; set => phatSinh = value; }

        [DisplayName("Nợ cuối")]
        public uint NoCuoi { get => noCuoi; set => noCuoi = value; }

        [DisplayName("Mã thời gian")]
        public long MaTG { get => maTG; set => maTG = value; }
    }
}
