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
    public partial class frmPhieuThu : Form
    {
        #region prop
        private BLL_DaiLy daily = new BLL_DaiLy();
        private BLL_PhieuThu pt = new BLL_PhieuThu();
        #endregion
        #region method
        public frmPhieuThu() {
            InitializeComponent();
        }
        private void frmPhieuThu_Load(object sender, EventArgs e) {
            loadsource();
            dtpkNgayThu.Value = DateTime.Now;
        }
        private void btnXacNhan_Click(object sender, EventArgs e) {
            if(numSoTien.Value > 0 && cbDaiLy.Text != "") 
                {
                DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                phieuthu.MaDL = long.Parse(cbDaiLy.SelectedValue.ToString());
                phieuthu.Ngaythu = dtpkNgayThu.Value;
                phieuthu.Sotien = uint.Parse(numSoTien.Value.ToString());

                    if(pt.themPhieuThu(phieuthu )) {
                    MessageBox.Show("Thêm phiếu thu thành công!");
                    this.Close();
                    } else {
                    MessageBox.Show("Thêm phiếu thu thất bại \nvui lòng kiểm tra lại!");
                    return;
                }
                }else {
                MessageBox.Show("Bạn chưa nhận đủ thông tin !");
                return;
            }
        }
        private void loadsource() {
            cbDaiLy.DataSource = daily.LayDanhSachDaiLy();
            cbDaiLy.DisplayMember = "TenDaiLy";
            cbDaiLy.ValueMember = "Id";
            txtDiaChi.DataBindings.Add(new Binding("text", cbDaiLy.DataSource, "DiaChi"));
            txtSDT.DataBindings.Add(new Binding("text", cbDaiLy.DataSource, "Sdt"));
        }
        #endregion
    }
}
