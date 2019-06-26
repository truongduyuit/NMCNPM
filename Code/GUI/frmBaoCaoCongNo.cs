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
    public partial class frmBaoCaoCongNo : Form
    {
        private BLL_DaiLy dl = new BLL_DaiLy();
        private BLL_PhieuThu ptb = new BLL_PhieuThu();
        private BLL_PhieuXuatHang pxb = new BLL_PhieuXuatHang();
        private BLL_ThoiGian thoigian = new BLL_ThoiGian();
        private BLL_BaoCaoCongNo cn = new BLL_BaoCaoCongNo();

        public frmBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void frmBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            cbDaiLy.DataSource = new BindingSource(dl.LayDanhSachDaiLy(), String.Empty);
            cbDaiLy.DisplayMember = "TenDaiLy";
            cbDaiLy.ValueMember = "Id";

            cbThoiGian.DataSource = new BindingSource(thoigian.LayDanhSachThoiGian(), String.Empty);
            cbThoiGian.DisplayMember = "ThoiGian";
            cbThoiGian.ValueMember = "Id";

            LoadDefault(false);
            txtPhatSinh.Enabled = false;
            txtNoCuoi.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadDefault(bool status)
        {
            dataCongNo.DataSource = cn.DanhSachCongNo();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataCongNo.DataSource];
            myCurrencyManager.Refresh();

            cbThoiGian.Enabled = status;
            cbDaiLy.Enabled = status;
            txtNoDau.Enabled = status;
            txtMa.Enabled = false;
        }

        private void Reset()
        {
            txtMa.Text = string.Empty;
            txtNoDau.Text = "0";
            txtPhatSinh.Text = "0";
            txtNoCuoi.Text = "0";
            btnThemCongNo.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemCongNo.Text = "Thêm Công Nợ";
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
        }

        private void CapNhatPhatSinh()
        {
            try
            {
                string[] arrListStr = cbThoiGian.Text.Split('/');
                txtPhatSinh.Text = pxb.LayTongXuat(long.Parse(cbDaiLy.SelectedValue.ToString()), int.Parse(arrListStr[0]), int.Parse(arrListStr[1])).ToString();
            }
            catch
            {

            }
        }

        private void txtNoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbThoiGian_SelectedValueChanged(object sender, EventArgs e)
        {
            CapNhatPhatSinh();
        }

        private void cbDaiLy_SelectedValueChanged(object sender, EventArgs e)
        {
            CapNhatPhatSinh();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                LoadDefault(true);
                btnSua.Text = "Cập nhật";
                btnXoa.Text = "Hủy";
                btnThemCongNo.Enabled = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    DTO_BaoCaoCongNo bccn = new DTO_BaoCaoCongNo();
                    bccn.Id = long.Parse(txtMa.Text);
                    bccn.MaDL = long.Parse(cbDaiLy.SelectedValue.ToString());
                    bccn.NoDau = uint.Parse(txtNoDau.Text);
                    bccn.PhatSinh = uint.Parse(txtPhatSinh.Text);
                    bccn.NoCuoi = uint.Parse(txtNoCuoi.Text);
                    bccn.MaTG = long.Parse(cbThoiGian.SelectedValue.ToString());
                    if (cn.SuaCongNo(bccn))
                    {                       
                        MessageBox.Show("Cập nhật công nợ thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật công nợ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Reset();
                    LoadDefault(false);
                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa  ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (cn.XoaCongNo(long.Parse(txtMa.Text)))
                    {
                        MessageBox.Show("Xóa công nợ thành công", "Thông báo", MessageBoxButtons.OK);
                      
                    }
                    else
                    {
                        MessageBox.Show("Xóa công nợ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Reset();
                    LoadDefault(false);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemCongNo.Text = "Thêm Công Nợ";
                    btnXoa.Text = "Xóa";
                    btnXoa.Enabled = false;
                    Reset();
                    LoadDefault(false);
                }
            }
        }

        private void btnThemCongNo_Click(object sender, EventArgs e)
        {
            if (btnThemCongNo.Text == "Thêm Công Nợ")
            {
                btnThemCongNo.Text = "Lưu";
                btnXoa.Text = "Hủy";
                txtMa.Text = string.Empty;
                LoadDefault(true);
                btnXoa.Enabled = true;
                cbDaiLy.SelectedIndex = 1;
                cbDaiLy.SelectedIndex = 0;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn lưu ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    DTO_BaoCaoCongNo bccn = new DTO_BaoCaoCongNo();
                    bccn.MaDL = long.Parse(cbDaiLy.SelectedValue.ToString());
                    bccn.NoDau = uint.Parse(txtNoDau.Text);
                    bccn.PhatSinh = uint.Parse(txtPhatSinh.Text);
                    bccn.NoCuoi = uint.Parse(txtNoCuoi.Text);
                    bccn.MaTG = long.Parse(cbThoiGian.SelectedValue.ToString());
                    if (cn.ThemCongNo(bccn))
                    {
                        btnThemCongNo.Text = "Thêm Công Nợ";                        
                        MessageBox.Show("Thêm công nợ thành công", "Thông báo", MessageBoxButtons.OK);                        
                    }
                    else
                    {
                        MessageBox.Show("Thêm công nợ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Reset();
                    LoadDefault(false);
                }
            }
        }

        private void txtNoDau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (long.Parse(cbDaiLy.SelectedValue.ToString()) % 1 == 0)
                {
                    string[] arrListStr = cbThoiGian.Text.Split('/');
                    uint tt = ptb.LayTongThu(long.Parse(cbDaiLy.SelectedValue.ToString()), int.Parse(arrListStr[0]), int.Parse(arrListStr[1]));
                    
                    txtNoCuoi.Text = (long.Parse(txtNoDau.Text) + long.Parse(txtPhatSinh.Text) - long.Parse(tt.ToString())).ToString();
                }
            }
            catch
            {

            }
            
        }

        private void dataCongNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemCongNo.Text == "Thêm Công Nợ" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataCongNo.Rows[index];
                    this.txtMa.Text = row.Cells[0].Value.ToString();
                    this.cbDaiLy.SelectedValue = long.Parse(row.Cells[1].Value.ToString());
                    this.txtNoDau.Text = row.Cells[2].Value.ToString();
                    this.txtPhatSinh.Text = row.Cells[3].Value.ToString();
                    this.txtNoCuoi.Text = row.Cells[4].Value.ToString();
                    this.cbThoiGian.SelectedValue = long.Parse(row.Cells[5].Value.ToString());
                }
                catch
                {
                    return;
                }
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (txtMa.Text != string.Empty)
            {
                btnSua.Enabled = true;  
                
                if (btnXoa.Text == "Xóa")
                {
                    btnXoa.Enabled = true;
                }
            }
            else
            {
                btnSua.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string s1 = "/";
            string s2 = txtTimKiem.Text;

            if (s2.Contains(s1))
            {
                try
                {
                    string[] arrListStr = txtTimKiem.Text.Split('/');
                    dataCongNo.DataSource = cn.TimKiemCongNo(thoigian.LayMaThoiGian(int.Parse(arrListStr[0]), int.Parse(arrListStr[1])), 1);
                }
                catch
                {
                    List<DTO_BaoCaoCongNo> lcn = new List<DTO_BaoCaoCongNo>();
                    dataCongNo.DataSource =  lcn;
                }
            }
            else
            {
                try
                {
                    dataCongNo.DataSource = cn.TimKiemCongNo(long.Parse(txtTimKiem.Text), 0);
                }
                catch
                {
                    List<DTO_BaoCaoCongNo> lcn = new List<DTO_BaoCaoCongNo>();
                    dataCongNo.DataSource = lcn;
                }
            }

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataCongNo.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            dataCongNo.DataSource = cn.DanhSachCongNo();
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataCongNo.DataSource];
            myCurrencyManager.Refresh();
        }

    }
}
