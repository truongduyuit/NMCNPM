using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Quan
    {
        private long id;

        private string tenQuan;

        public long Id { get => id; set => id = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
    }
}
