using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
   public class BLL_DonViTinh
    {
        private DAL_DonViTinh _dvt = new DAL_DonViTinh();

        public List<DTO_DonViTinh> hienthidanhsach() 
        {
            return _dvt.LayDanhSachMatHang(); ;
        }
        public bool ThemDonViTinh(DTO_DonViTinh dvt)
        {
            return _dvt.ThemDonViTinh(dvt);
        }
        public bool XoaDonViTinh(long id)
        {
            return _dvt.XoaDonViTinh(id);
        }

        public bool SuaDonViTinh(DTO_DonViTinh dvt)
        {
            return _dvt.SuaDonViTinh(dvt);
        }
    }
}
