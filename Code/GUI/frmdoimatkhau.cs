using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        #region prop
        private BLL_Account acc = new BLL_Account();
        #endregion
        #region method
        public frmDoiMatKhau() {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e) {
            if(Validated())
                {
                   if(acc.CheckLogin(txtaccount.Text,txtOldPass.Text) == 0)
                    {
                    MessageBox.Show("Mật khẩu hoặc tài khoản không đúng!");

                    return;
                    }
                if (acc.UpdateAccount(txtaccount.Text, txtNewpass.Text) == 1) {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                } else
                    MessageBox.Show("Đổi mật khẩu thất bại!");
                
                }
        }
        private bool Validated() {
            if(string.IsNullOrEmpty(txtOldPass.Text)) 
                {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ!");
                txtOldPass.Focus();
                return false;
                }
            if(string.IsNullOrEmpty(txtNewpass.Text)) 
                {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!");
                txtNewpass.Focus();
                return false;
                }
            if (string.IsNullOrEmpty(txtConfirmnewPass.Text))
                {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới!");
                txtConfirmnewPass.Focus();
                return false;
                }
            if(txtNewpass.Text != txtConfirmnewPass.Text) 
                {
                MessageBox.Show("Nhập lại mật khẩu mới không đúng!");
                txtConfirmnewPass.Focus();
                return false;
                }
            if(txtNewpass.Text == txtOldPass.Text) 
                {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ!");
                txtNewpass.Focus();
                return false;
                }
            return true;
        }
        private void btncancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
    #endregion
}
