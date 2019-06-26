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
    public partial class frmDaiLy : Form
    {
        private BLL_DaiLy daily = new BLL_DaiLy();
        private BLL_Quan quan = new BLL_Quan();
        private BLL_LoaiDaiLy ldl = new BLL_LoaiDaiLy();
        public frmDaiLy()
        {
            InitializeComponent();
        }

        private void SetDefault(bool status)
        {
            this.txtMaDaiLy.Enabled = false;
            this.date.Enabled = false;

            this.txtTenDaiLy.Enabled = status;
            this.txtDiaChi.Enabled = status;
            this.txtSoDienThoai.Enabled = status;
            this.cbLoaiDaiLy.Enabled = status;
            this.cbQuan.Enabled = status;
            this.txtTongNo.Enabled = status;
        }

        private void ResetValue()
        {
            this.txtMaDaiLy.Text = string.Empty;
            this.txtTenDaiLy.Text = string.Empty;
            this.txtDiaChi.Text = string.Empty;
            this.txtSoDienThoai.Text = string.Empty;
            this.cbLoaiDaiLy.SelectedValue = string.Empty;
            this.cbQuan.SelectedValue = string.Empty;
            this.txtTongNo.Text = "0";

            this.date.Value = DateTime.Now.ToLocalTime();
        }

        private void frmDaiLy_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            if (daily.LayDanhSachDaiLy() != null)
            {
                this.dataDaiLy.DataSource = daily.LayDanhSachDaiLy();
                this.dataDaiLy.Columns["MaLoaiDL"].Visible = false;
                this.dataDaiLy.Columns["MaQuan"].Visible = false;

                List<DTO_Quan> listQuan = quan.LayDanhSachQuan();
                List<DTO_LoaiDaiLy> listLDL = ldl.LayDanhSachLoaiDaiLy();

                if(listQuan == null || listLDL == null)
                {
                    MessageBox.Show("Có lỗi khi lấy dữ liệu");
                    return;
                }

                cbQuan.DataSource = new BindingSource(listQuan, String.Empty);
                cbQuan.DisplayMember = "TenQuan";
                cbQuan.ValueMember = "Id";

                cbLoaiDaiLy.DataSource = new BindingSource(listLDL, String.Empty);
                cbLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
                cbLoaiDaiLy.ValueMember = "Id";

                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }

        private void dataDaiLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (btnThemDaiLy.Text == "Thêm Đại Lý" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataDaiLy.Rows[index];
                    this.txtMaDaiLy.Text = row.Cells[0].Value.ToString();
                    this.txtTenDaiLy.Text = row.Cells[1].Value.ToString();
                    this.txtDiaChi.Text = row.Cells[4].Value.ToString();
                    this.txtSoDienThoai.Text = row.Cells[3].Value.ToString();
                    this.cbLoaiDaiLy.SelectedValue = row.Cells[2].Value;
                    this.cbQuan.SelectedValue = row.Cells[5].Value;
                    this.txtTongNo.Text = row.Cells[7].Value.ToString();

                    this.date.Value = DateTime.Parse(row.Cells[6].Value.ToString());
                }
                catch
                {
                    return;
                }
            }

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTenDaiLy.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập tên đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDaiLy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbLoaiDaiLy.Text.Trim()))
            {
                MessageBox.Show("Bạn phải chọn loại đại lý", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLoaiDaiLy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbQuan.Text.Trim()))
            {
                MessageBox.Show("Bạn phải chọn quận", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbQuan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoDienThoai.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoDienThoai.Focus();
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

        private void btnThemDaiLy_Click(object sender, EventArgs e)
        {
            if (btnThemDaiLy.Text == "Thêm Đại Lý")
            {
                btnThemDaiLy.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtTenDaiLy.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm đại lý", "THÊM ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_DaiLy dl = new DTO_DaiLy();
                        dl.TenDaiLy = this.txtTenDaiLy.Text;
                        dl.MaLoaiDL = long.Parse(this.cbLoaiDaiLy.SelectedValue.ToString());
                        dl.MaQuan = long.Parse(this.cbQuan.SelectedValue.ToString());
                        dl.DiaChi = this.txtDiaChi.Text;
                        dl.Sdt = this.txtSoDienThoai.Text;
                        dl.NgayTiepNhan = this.date.Value;
                        dl.TongNo = uint.Parse(this.txtTongNo.Text);

                        if (daily.ThemDaiLy(dl))
                        {
                            btnThemDaiLy.Text = "Thêm Đại Lý";
                            btnXoa.Text = "Xóa";

                            dataDaiLy.DataSource = daily.LayDanhSachDaiLy();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaDaiLy.Text))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa đại lý", "XÓA ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (daily.XoaDaiLy(long.Parse(txtMaDaiLy.Text)))
                    {
                        dataDaiLy.DataSource = daily.LayDanhSachDaiLy();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa đại lý thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemDaiLy.Text = "Thêm Đại Lý";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemDaiLy.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaDaiLy.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void txtTienNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDaiLy.Text))
            {
                MessageBox.Show("Vui lòng chọn đại lý để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemDaiLy.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_DaiLy dl = new DTO_DaiLy();
                        dl.Id = long.Parse(this.txtMaDaiLy.Text);
                        dl.TenDaiLy = this.txtTenDaiLy.Text;
                        dl.MaLoaiDL = long.Parse(this.cbLoaiDaiLy.SelectedValue.ToString());
                        dl.Sdt = this.txtSoDienThoai.Text;
                        dl.DiaChi = this.txtDiaChi.Text;
                        dl.MaQuan = long.Parse(this.cbQuan.SelectedValue.ToString());                                             
                        dl.TongNo = uint.Parse(this.txtTongNo.Text);

                        if (daily.SuaDaiLy(dl))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemDaiLy.Enabled = true;

                            dataDaiLy.DataSource = daily.LayDanhSachDaiLy();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật đại lý thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void txtMaDaiLy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDaiLy.Text))
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dataDaiLy.DataSource = daily.LayDanhSachDaiLy();
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                dataDaiLy.DataSource = daily.TimKiemDaiLy(txtTimKiem.Text);
                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
                myCurrencyManager.Refresh();
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dataDaiLy.DataSource = daily.LayDanhSachDaiLy();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataDaiLy.DataSource];
            myCurrencyManager.Refresh();
        }
    }
}
