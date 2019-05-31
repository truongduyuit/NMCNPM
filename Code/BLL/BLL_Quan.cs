using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Quan
    {
        private DAL_Quan quan = new DAL_Quan();

        public List<DTO_Quan> LayDanhSachQuan()
        {
            return quan.LayDanhSachQuan();
        }
    }
}
