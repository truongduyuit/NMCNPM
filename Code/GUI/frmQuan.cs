using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmQuan : Form
    {
        private BLL_Quan Quan = new BLL_Quan();
        private void SetDefault(bool status)
        {

            this.txtMaQuan.Enabled = false;
            this.txtTenQuan.Enabled = status;

        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtMaQuan.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaQuan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenQuan.Text.Trim()))
            {
                MessageBox.Show("Bạn phải chọn loại đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenQuan.Focus();
                return false;
            }

            return true;
        }
        private void ResetValue()
        {
            this.txtMaQuan.Text = string.Empty;
            this.txtTenQuan.Text = string.Empty;
        }
        public frmQuan()
        {
            InitializeComponent();
        }

        private void BtnThemQuan_Click(object sender, EventArgs e)
        {
            if (btnThemQuan.Text == "Thêm Quận")
            {
                btnThemQuan.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenQuan.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm quận", "THÊM QUẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_Quan q = new DTO_Quan();
                        q.TenQuan = this.txtTenQuan.Text;


                        if (Quan.ThemQuan(q))
                        {
                            btnThemQuan.Text = "Thêm Quận";
                            btnXoa.Text = "Xóa";

                            dataQuan.DataSource = Quan.LayDanhSachQuan();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaQuan.Text))
                            {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm quận thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (string.IsNullOrEmpty(txtMaQuan.Text))
            {
                MessageBox.Show("Vui lòng chọn quận để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemQuan.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_Quan q = new DTO_Quan();
                        q.Id = long.Parse(this.txtMaQuan.Text);
                        q.TenQuan = this.txtTenQuan.Text;

                        if (Quan.SuaQuan(q))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemQuan.Enabled = true;

                            dataQuan.DataSource = Quan.LayDanhSachQuan();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật quận thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật quận thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa quận", "XÓA QUẬN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (Quan.XoaQuan(long.Parse(txtMaQuan.Text)))
                    {
                        dataQuan.DataSource = Quan.LayDanhSachQuan();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa quận thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa quận thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemQuan.Text = "Thêm Quận";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemQuan.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaQuan.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void TxtMaQuan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaQuan.Text))
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

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dataQuan.DataSource = Quan.LayDanhSachQuan();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                dataQuan.DataSource = Quan.TimKiemQuan(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void BtnTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dataQuan.DataSource = Quan.LayDanhSachQuan();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
            myCurrencyManager.Refresh();
        }

        private void DataQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = this.dataQuan.Rows[index];
                this.txtMaQuan.Text = row.Cells[0].Value.ToString();
                this.txtTenQuan.Text = row.Cells[1].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void FrmQuan_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            if (Quan.LayDanhSachQuan() != null)
            {
                this.dataQuan.DataSource = Quan.LayDanhSachQuan();

                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataQuan.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }
    }
}
