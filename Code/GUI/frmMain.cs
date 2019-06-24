using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void SetDefaultOpen(bool status)
        {
            this.btnDangNhap.Enabled = !status;
            this.btnDangXuat.Enabled = status;
            this.btnDoiMatKhau.Enabled = status;
            this.btnQuyDinh.Enabled = status;

            this.tabQuanLy.Visible = status;
            this.tabBaoCao.Visible = status;
        }

        private void DangNhap()
        {
            SetDefaultOpen(false);
            this.infoUser.Caption = "Xin chào, ";
            if (KiemTraTonTai("frmDangNhap") == null)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.MdiParent = this;
                frm.user = new frmDangNhap.GetInfoUser(LoadUserInfo);
                frm.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DangNhap();

            //ucMain uc = new ucMain();
            //uc.Dock = DockStyle.Fill;
            //pnlMain.Controls.Clear();
            //pnlMain.Controls.Add(uc);

            pnlMain.Visible = false;
        }

        private void LoadUserInfo(string data)
        {
            this.infoUser.Caption = "Xin Chào, " + data.ToUpper();
            SetDefaultOpen(true);
        }

        private void btnĐangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {                
                DangNhap();
            }
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {           
            DangNhap();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        public Form KiemTraTonTai(string formName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(formName))
                {
                    frm.BringToFront();
                    return frm;
                }
            }
            return null;
        }

        private void btnDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmDaiLy") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmDaiLy frm = new frmDaiLy();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnLoaiDaiLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(KiemTraTonTai("frmLoaiDaiLy")== null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmLoaiDaiLy frm = new frmLoaiDaiLy();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnQuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmQuan") == null)
            {
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmQuan frm = new frmQuan();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (KiemTraTonTai("frmPhieuXuatHang") == null)
            {
                
                foreach (Form frm1 in MdiChildren)
                {
                    frm1.Close();
                }
                frmPhieuXuatHang frm = new frmPhieuXuatHang();
                frm.MdiParent = this;
                frm.Show();
            }

        }
    }
}