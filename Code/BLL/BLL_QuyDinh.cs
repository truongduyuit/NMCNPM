using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_QuyDinh
    {
        private DAL_QuyDinh qd = new DAL_QuyDinh();
        public DTO_QuyDinh QuyDinh()
        {
            return qd.QuyDinh();
        }
        public bool ChinhSuaQuyDinh(DTO_QuyDinh q)
        {
            return qd.ChinhSuaQuyDinh(q);
        }
    }
}
