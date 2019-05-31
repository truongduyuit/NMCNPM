using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiDaiLy
    {
        private long id;

        private string tenLoaiDaiLy;

        private uint noToiDa;

        public long Id { get => id; set => id = value; }
        public string TenLoaiDaiLy { get => tenLoaiDaiLy; set => tenLoaiDaiLy = value; }
        public uint NoToiDa { get => noToiDa; set => noToiDa = value; }
    }
}
