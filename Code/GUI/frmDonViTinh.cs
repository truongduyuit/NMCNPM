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
using DTO;

namespace GUI
{
    public partial class frmDonViTinh : Form
    {
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void txtMaDonViTinh_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDonViTinh.Text))
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenDonViTinh.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDonViTinh.Focus();
                return false;
            }
            return true;
        }

        private void SetDefault(bool status)
        {
            this.txtMaDonViTinh.Enabled = false;

            this.txtTenDonViTinh.Enabled = status;

        }
        private void ResetValue()
        {
            this.txtMaDonViTinh.Text = string.Empty;
            this.txtTenDonViTinh.Text = string.Empty;
        }

        private void btnThemDonViTinh_Click(object sender, EventArgs e)
        {
            if (btnThemDonViTinh.Text == "Thêm Đơn Vị Tính")
            {
                btnThemDonViTinh.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenDonViTinh.Focus();
                txtTenDonViTinh.Text = "";
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm đơn vị tính", "THÊM ĐƠN VỊ TÍNH", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_DonViTinh dvt = new DTO_DonViTinh();
                        dvt.Ten = this.txtTenDonViTinh.Text;


                        if (donvitinh.ThemDonViTinh(dvt))
                        {
                            btnThemDonViTinh.Text = "Thêm Đơn Vị Tính";
                            btnXoa.Text = "Xóa";

                            dataDonViTinh.DataSource = donvitinh.hienthidanhsach();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDonViTinh.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaDonViTinh.Text))
                            {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm đơn vị tính thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm đơn vị tính thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDonViTinh.Text))
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemDonViTinh.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_DonViTinh dvt = new DTO_DonViTinh();
                        dvt.Id = long.Parse(this.txtMaDonViTinh.Text);
                        dvt.Ten = this.txtTenDonViTinh.Text;


                        if (donvitinh.SuaDonViTinh(dvt))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnSua.Enabled = true;

                            dataDonViTinh.DataSource = donvitinh.hienthidanhsach();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDonViTinh.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật đơn vị tính thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            btnThemDonViTinh.Enabled = true;
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                            SetDefault(false);
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật đơn vị tính thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa đơn vị tính", "XÓA ĐƠN VỊ TÍNH", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (donvitinh.XoaDonViTinh(long.Parse(txtMaDonViTinh.Text)))
                    {
                        dataDonViTinh.DataSource = donvitinh.hienthidanhsach();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDonViTinh.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa đơn vị tính thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btnThemDonViTinh.Enabled = true;
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn vị tính thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemDonViTinh.Text = "Thêm Đơn Vị Tính";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemDonViTinh.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaDonViTinh.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (donvitinh.hienthidanhsach() != null)
            {
                this.dataDonViTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.dataDonViTinh.DataSource = donvitinh.hienthidanhsach();
                //this.dataDonViTinh.DataSource= 
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDonViTinh.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }

        private void dataDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemDonViTinh.Text == "Thêm Đơn Vị Tính" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataDonViTinh.Rows[index];
                    this.txtMaDonViTinh.Text = row.Cells[0].Value.ToString();
                    this.txtTenDonViTinh.Text = row.Cells[1].Value.ToString();

                }
                catch
                {
                    return;
                }
            }
        }
    }
}
