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
using DAL;
using DTO;

namespace GUI
{
    public partial class frmMatHang : Form
    {
        private BLL_MatHang matHang = new BLL_MatHang();
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        public frmMatHang() {
            InitializeComponent();
        }
        private void SetDefault(bool status) {
            this.txtMaMatHang.Enabled = false;
            this.txtTenMatHang.Enabled = status;
            this.txtDonGia.Enabled = status;
            this.cbDVT.Enabled = status;
            
        }
        private void ResetValue() {
            this.txtMaMatHang.Text = string.Empty;
            this.txtTenMatHang.Text = string.Empty;
            this.txtDonGia.Text = string.Empty;
           
        }

        private void frmmahang_Load(object sender, EventArgs e) {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (matHang.LayDanhSachMatHang() != null && donvitinh.hienthidanhsach() != null) {
                this.dataMatHang.DataSource = matHang.LayDanhSachMatHang();
                this.cbDVT.DataSource = donvitinh.hienthidanhsach();
                cbDVT.DisplayMember = "ten";
                cbDVT.ValueMember = "id";
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            SetDefault(false);
        }

        private void dataMatHang_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (btnThemMatHang.Text == "Thêm Mặt Hàng" && btnSua.Text == "Sửa") {
                try {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataMatHang.Rows[index];
                    cbDVT.SelectedValue = row.Cells[3].Value;
                    this.txtMaMatHang.Text = row.Cells[0].Value.ToString();
                    this.txtTenMatHang.Text = row.Cells[1].Value.ToString();
                    this.txtDonGia.Text = row.Cells[2].Value.ToString();
                    } catch {
                    return;
                }
            }
        }
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private bool KiemTra() {
            if (string.IsNullOrEmpty(txtTenMatHang.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập tên mặt hàng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text.Trim())) {
                MessageBox.Show("Bạn phải nhập đơn giá!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.Focus();
                return false;
            }
            
            //if (txtSoDienThoai.Text.Trim().Length != 10)
            //{
            //    MessageBox.Show("Số điện thoại không đúng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtSoDienThoai.Focus();
            //    return false;
            //}
            return true;
        }
        private void btnThemMatHang_Click(object sender, EventArgs e) {
            if (btnThemMatHang.Text == "Thêm Mặt Hàng") {
                btnThemMatHang.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenMatHang.Focus();
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm mặt hàng", "THÊM MẶT HÀNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (KiemTra()) {
                        DTO_MatHang dl = new DTO_MatHang();
                        dl.TenMatHang = this.txtTenMatHang.Text;
                        dl.Dongia = uint.Parse(this.txtDonGia.Text);
                        dl.MaDVT = long.Parse(this.cbDVT.SelectedValue.ToString());
                        

                        if (matHang.ThemMatHang(dl)) {
                            btnThemMatHang.Text = "Thêm Mặt Hàng";
                            btnXoa.Text = "Xóa";

                            dataMatHang.DataSource = matHang.LayDanhSachMatHang();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm mặt hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                MessageBox.Show("Vui lòng chọn Mặt Hàng để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            } else {
                if (btnSua.Text == "Sửa") {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemMatHang.Enabled = false;
                    SetDefault(true);
                } else {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK) {
                        DTO_MatHang mh = new DTO_MatHang();
                        mh.MaMatHang = long.Parse(this.txtMaMatHang.Text);
                        mh.TenMatHang = this.txtTenMatHang.Text;
                        mh.Dongia = uint.Parse(this.txtDonGia.Text);
                        mh.MaDVT = long.Parse(this.cbDVT.SelectedValue.ToString());

                        if (matHang.SuaMatHang(mh)) {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemMatHang.Enabled = true;

                            dataMatHang.DataSource = matHang.LayDanhSachMatHang();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                            
                        } else {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật đại lý thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtMaMatHang_TextChanged(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            } else {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtTimKiem.Text)) {
                dataMatHang.DataSource = matHang.LayDanhSachMatHang();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            } else {
                dataMatHang.DataSource = matHang.TimKiemMatHang(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e) {
            txtTimKiem.Text = string.Empty;
           dataMatHang.DataSource = matHang.LayDanhSachMatHang();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e) {

            if (btnXoa.Text == "Xóa") {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa đại lý", "XÓA ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    if (matHang.XoaMatHang(long.Parse(txtMaMatHang.Text))) {
                        dataMatHang.DataSource = matHang.LayDanhSachMatHang();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataMatHang.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa mặt hàng thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else {
                        MessageBox.Show("Xóa mặt hàng thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } else {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK) {
                    btnThemMatHang.Text = "Thêm Mặt Hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemMatHang.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaMatHang.Text)) {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                    btnXoa.Enabled = btnSua.Enabled = true;
                }

            }
        }
    }
}
