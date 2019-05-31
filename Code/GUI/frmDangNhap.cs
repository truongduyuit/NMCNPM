using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        private BLL_Account acc = new BLL_Account();

        public delegate void GetInfoUser(string data);
        public GetInfoUser user;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (acc.CheckLogin(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
            {
                user(txtTaiKhoan.Text);
                MessageBox.Show("Đăng nhập thành công", "Xin chào", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại", "Đăng nhập thất bại", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
            this.CancelButton = btnHuy;
        }
    }
}
