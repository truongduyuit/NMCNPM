using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_BaoCaoCongNo
    {
        private DAL_BaoCaoCongNo c = new DAL_BaoCaoCongNo();

        public List<DTO_BaoCaoCongNo> DanhSachCongNo()
        {
            return c.DanhSachCongNo();
        }

        public bool ThemCongNo(DTO_BaoCaoCongNo cn)
        {
            return c.ThemCongNo(cn);
        }

        public bool SuaCongNo(DTO_BaoCaoCongNo cn)
        {
            return c.SuaCongNo(cn);
        }

        public bool XoaCongNo(long id)
        {
            return c.XoaCongNo(id);
        }

        public List<DTO_BaoCaoCongNo> TimKiemCongNo(long tukhoa, int loai)
        {
            return c.TimKiemCongNo(tukhoa, loai);
        }
    }
}
