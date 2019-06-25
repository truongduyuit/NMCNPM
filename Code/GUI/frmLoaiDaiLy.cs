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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmLoaiDaiLy : Form
    {
        private BLL_LoaiDaiLy LoaiDaiLy = new BLL_LoaiDaiLy();
        public frmLoaiDaiLy()
        {
            InitializeComponent();
        }
        private void SetDefault(bool status)
        {
            this.txtMaLoaiDaiLy.Enabled = false;

            this.txtTenLoaiDaiLy.Enabled = status;
            this.txtNoToiDa.Enabled = status;
        }
        private void ResetValue()
        {
            this.txtMaLoaiDaiLy.Text = string.Empty;
            this.txtTenLoaiDaiLy.Text = string.Empty;
            this.txtNoToiDa.Text = "0";
        }

        private void FrmLoaiDaiLy_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (LoaiDaiLy.LayDanhSachLoaiDaiLy() != null)
            {
                this.dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenLoaiDaiLy.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên loại đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLoaiDaiLy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNoToiDa.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập nợ tối đa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoToiDa.Focus();
                return false;
            }

            return true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm Loại Đại Lý")
            {
                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenLoaiDaiLy.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm đại lý", "THÊM ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_LoaiDaiLy ldl = new DTO_LoaiDaiLy();
                        ldl.TenLoaiDaiLy = this.txtTenLoaiDaiLy.Text;
                        ldl.NoToiDa = uint.Parse(this.txtNoToiDa.Text);
                        if (LoaiDaiLy.ThemLoaiDaiLy(ldl))
                        {
                            btnThem.Text = "Thêm Loại Đại Lý";
                            btnXoa.Text = "Xóa";

                            dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaLoaiDaiLy.Text))
                            {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm đại lý thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiDaiLy.Text))
            {
                MessageBox.Show("Vui lòng chọn loại đại lý để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThem.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_LoaiDaiLy ldl = new DTO_LoaiDaiLy();
                        ldl.Id = long.Parse(this.txtMaLoaiDaiLy.Text);
                        ldl.TenLoaiDaiLy = this.txtTenLoaiDaiLy.Text;
                        ldl.NoToiDa = uint.Parse(this.txtNoToiDa.Text);

                        if (LoaiDaiLy.SuaLoaiDaiLy(ldl))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThem.Enabled = true;

                            dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật loại đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật đại lý thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa loại đại lý", "XÓA LOẠI ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (LoaiDaiLy.XoaLoaiDaiLy(long.Parse(txtMaLoaiDaiLy.Text)))
                    {
                        dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa loại đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa loại đại lý thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThem.Text = "Thêm Loại Đại Lý";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThem.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaLoaiDaiLy.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void DataLoaiDaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Text == "Thêm Loại Đại Lý" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataLoaiDaiLy.Rows[index];
                    this.txtMaLoaiDaiLy.Text = row.Cells[0].Value.ToString();
                    this.txtTenLoaiDaiLy.Text = row.Cells[1].Value.ToString();
                    this.txtNoToiDa.Text = row.Cells[2].Value.ToString();


                }
                catch
                {
                    return;
                }
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                dataLoaiDaiLy.DataSource = LoaiDaiLy.TimKiem(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void BtnTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dataLoaiDaiLy.DataSource = LoaiDaiLy.LayDanhSachLoaiDaiLy();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataLoaiDaiLy.DataSource];
            myCurrencyManager.Refresh();
        }

        private void TxtMaLoaiDaiLy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiDaiLy.Text))
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
    }
}
