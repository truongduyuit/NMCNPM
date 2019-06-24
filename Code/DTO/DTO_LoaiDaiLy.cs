using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
    public class DTO_LoaiDaiLy
    {
        private long id;

        private string tenLoaiDaiLy;

        private uint noToiDa;
        [DisplayName("Mã Loại Đại Lý")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Tên Loại Đại Lý")]
        public string TenLoaiDaiLy { get => tenLoaiDaiLy; set => tenLoaiDaiLy = value; }
        [DisplayName("Nợ tối đa")]
        public uint NoToiDa { get => noToiDa; set => noToiDa = value; }
    }
}
