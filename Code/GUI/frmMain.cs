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
                frmDaiLy frm = new frmDaiLy();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
            {
            if (KiemTraTonTai("frmdoimatkhau") == null) {
                frmdoimatkhau frm = new frmdoimatkhau();
                
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnMatHang_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frmmathang") == null) {
                frmmathang frm = new frmmathang();

                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnBaoCaoDoanhSo_ItemClick(object sender, ItemClickEventArgs e) {
            if (KiemTraTonTai("frbaocaodoanhso") == null) {
                frmbaocaodoanhso frm = new frmbaocaodoanhso();

                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}