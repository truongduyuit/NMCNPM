using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThoiGian
    {
        private long id;

        private int thang;

        private int nam;

        public long Id { get => id; set => id = value; }
        public int Thang { get => thang; set => thang = value; }
        public int Nam { get => nam; set => nam = value; }
        public string ThoiGian { get => thang.ToString() + " / " + nam.ToString(); }
    }
}
