using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_BaoCaoDoanhSo
    {
        #region prop
        private long id;

        private int sophieuxuat;

        private string tendaily;

        private uint tongtrigia;

        private float tyle;

        private long maTG;
        
        [DisplayName("Mã")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Số Phiếu xuất")]
        public int Sophieuxuat { get => sophieuxuat; set => sophieuxuat = value; }
        [DisplayName("Tên đại lý")]
        public string Tendaily { get => tendaily; set => tendaily = value; }
        [DisplayName("Tổng trị giá")]
        public uint Tongtrigia { get => tongtrigia; set => tongtrigia = value; }
        [DisplayName("Tỷ lệ")]
        public float Tyle { get => tyle; set => tyle = value; }
        public long MaTG { get => maTG; set => maTG = value; }
        #endregion
    }
}
