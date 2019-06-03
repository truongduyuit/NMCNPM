using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_BaoCaoDoanhSo
    {
        private long id;

        private int sophieuxuat;

        private long madaily;

        private uint tongtrigia;

        private float tyle;

        private long maTG;

        public long Id { get => id; set => id = value; }
        public int Sophieuxuat { get => sophieuxuat; set => sophieuxuat = value; }
        public long Madaily { get => madaily; set => madaily = value; }
        public uint Tongtrigia { get => tongtrigia; set => tongtrigia = value; }
        public float Tyle { get => tyle; set => tyle = value; }
        public long MaTG { get => maTG; set => maTG = value; }
    }
}
