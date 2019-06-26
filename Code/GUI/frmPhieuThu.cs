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
            SetDefault(false);
        }
        private void btnXacNhan_Click(object sender, EventArgs e) {
            if (btnThemPhieuThu.Text == "Xác Nhận") {
                if (numSoTien.Value > 0 && cbDaiLy.Text != "") {
                    
                    DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                    phieuthu.MaDL = long.Parse(cbDaiLy.SelectedValue.ToString());
                    phieuthu.Ngaythu = dtpkNgayThu.Value;
                    phieuthu.Sotien = uint.Parse(numSoTien.Value.ToString());

                    if (pt.themPhieuThu(phieuthu)) {
                        MessageBox.Show("Thêm phiếu thu thành công!");
                        dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                    } else {
                        MessageBox.Show("Thêm phiếu thu thất bại \nvui lòng kiểm tra lại!");
                        return;
                    }
                    SetDefault(false);
                    btnThemPhieuThu.Text = "Thêm Phiếu Thu";
                    btnXoa.Text = "Xóa";
                } else {
                    MessageBox.Show("Bạn chưa nhận đủ thông tin !");
                    return;
                }
            } else {
                SetDefault(true);
                btnThemPhieuThu.Text = "Xác Nhận";
                btnXoa.Text = "Hủy";

            }
        }
        private void loadsource() {
            cbDaiLy.DataSource = daily.LayDanhSachDaiLy();
            cbDaiLy.DisplayMember = "TenDaiLy";
            cbDaiLy.ValueMember = "Id";
            txtDiaChi.DataBindings.Add(new Binding("text", cbDaiLy.DataSource, "DiaChi"));
            txtSDT.DataBindings.Add(new Binding("text", cbDaiLy.DataSource, "Sdt"));
            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
        }

        private void dataPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (btnThemPhieuThu.Text == "Thêm Phiếu Thu" && btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataPhieuThu.Rows[index];
                    this.cbDaiLy.SelectedValue= row.Cells[2].Value;
                 
                txtDiaChi.Text = (cbDaiLy.SelectedItem as DTO_DaiLy).DiaChi;
                txtSDT.Text = (cbDaiLy.SelectedItem as DTO_DaiLy).Sdt;
                this.numSoTien.Value = uint.Parse(row.Cells[3].Value.ToString());
                this.txtId.Text = row.Cells[0].Value.ToString();
               } catch {
                    return;
                }
            }

        }
        private void SetDefault(bool status) {
            this.txtId.Enabled = false;
            this.cbDaiLy.Enabled = status;
            this.txtSDT.Enabled = false;
            this.txtDiaChi.Enabled = false;
            dtpkNgayThu.Enabled = false;
            this.numSoTien.Enabled = status;
            dataPhieuThu.Enabled = !status;
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(cbDaiLy.Text)) {
                MessageBox.Show("Vui lòng chọn phiếu thu để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemPhieuThu.Enabled = false;
                    SetDefault(true);
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        DTO_PhieuThu phieuthu = new DTO_PhieuThu();
                        phieuthu.Id = long.Parse(txtId.Text);
                        phieuthu.MaDL = long.Parse(cbDaiLy.SelectedValue.ToString());
                        phieuthu.Ngaythu = dtpkNgayThu.Value;
                        phieuthu.Sotien = uint.Parse(numSoTien.Value.ToString());

                        if (pt.SuaPhieuThu(phieuthu)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemPhieuThu.Enabled = true;

                            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuThu.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            numSoTien.Value = 0;
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật phiếu thu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            if (btnXoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu thu", "XÓA PHIẾU THU", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    try {
                        if (pt.XoaPhieuThu(long.Parse(txtId.Text))) {
                            dataPhieuThu.DataSource = pt.LayDanhSachPhieuThu();

                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuThu.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Xóa phiếu thu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Xóa phiếu thu thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } catch {
                        MessageBox.Show("Vui lòng chọn phiếu thu trước!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThemPhieuThu.Text = "Thêm Phiếu Thu";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemPhieuThu.Enabled = true;
                    if (string.IsNullOrEmpty(txtId.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    numSoTien.Value = 0;
                }

            }
        }
        #endregion
    }
}
