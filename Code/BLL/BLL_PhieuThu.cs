﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BLL_PhieuThu
    {
        #region prop
        private DAL_PhieuThu pt = new DAL_PhieuThu();
        #endregion
        #region method
        public bool themPhieuThu(DTO_PhieuThu phieuthu) {
            return pt.ThemPhieuThu(phieuthu);
        }

        public List<DTO_PhieuThu> LayDanhSachPhieuThu() {
            return pt.LayDanhSachPhieuThu();
        }

        public bool XoaPhieuThu(long id) {
            return pt.XoaPhieuThu(id);
        }

        public bool SuaPhieuThu(DTO_PhieuThu s) {
            return pt.SuaPhieuThu(s);
        }
        public uint LayTongThu(long madl, int thang, int nam)
        {
            return pt.TongThu(madl, thang, nam);
        }
        #endregion
    }
}
