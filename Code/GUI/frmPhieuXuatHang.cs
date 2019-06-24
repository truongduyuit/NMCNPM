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
    
    public partial class frmPhieuXuatHang : Form
    {
        private BLL_PhieuXuatHang phieuxuat = new BLL_PhieuXuatHang();
        private BLL_DaiLy daily = new BLL_DaiLy();
        private void SetDefault(bool status)
        {

            this.txtMaPhieuXuat.Enabled = false;
            this.dNgayTiepNhan.Enabled = false;
            this.txtTongTriGia.Enabled = status;
        }

        private void ResetValue()
        {

            this.txtMaPhieuXuat.Text = string.Empty;
            this.dNgayTiepNhan.Value = DateTime.Now.ToLocalTime();
            this.txtTongTriGia.Text = "0";

            this.dNgayTiepNhan.Value = DateTime.Now.ToLocalTime();
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(cbbMaDaiLy.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập Mã Phiếu xuất", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhieuXuat.Focus();
                return false;
            }

            return true;
        }
        public frmPhieuXuatHang()
        {
            InitializeComponent();
        }

        private void BtnTimPhieu_Click(object sender, EventArgs e)
        {

            if (phieuxuat.TimKiempxh(txtMaPhieuXuat.Text) != null)
            {
                dataPhieuXuat.DataSource = phieuxuat.TimKiempxh(cbbMaDaiLy.Text);

                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuXuat.DataSource];
                myCurrencyManager.Refresh();

            }

            if (dataPhieuXuat.RowCount < 1)
            {
                MessageBox.Show("Không tìm thấy Phiếu Xuất của đại lý này");
            }
        }

        private void BtnInPhieu_Click(object sender, EventArgs e)
        {

        }

        private void BtnThemPhieu_Click(object sender, EventArgs e)
        {
            if (btnThemPhieu.Text == "Thêm phiếu xuất hàng")
            {
                btnThemPhieu.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtMaPhieuXuat.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm đại lý", "THÊM ĐẠI LÝ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_PhieuXuatHang pxh = new DTO_PhieuXuatHang();

                        pxh.MaDl = long.Parse(this.cbbMaDaiLy.Text);
                        pxh.NgayLapPhieu = this.dNgayTiepNhan.Value;
                        pxh.TongTriGia = uint.Parse(this.txtTongTriGia.Text);

                        if (phieuxuat.ThemPhieuXuat(pxh))
                        {
                            btnThemPhieu.Text = "Thêm phiếu xuất hàng";
                            btnXoa.Text = "Xóa";

                            dataPhieuXuat.DataSource = phieuxuat.laydanhsach();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuXuat.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            MessageBox.Show("Thêm phiếu xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm phiếu xuất thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
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
                    btnThemPhieu.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_PhieuXuatHang pxh = new DTO_PhieuXuatHang();
                        pxh.Id = long.Parse(this.txtMaPhieuXuat.Text);
                        pxh.MaDl = long.Parse(this.cbbMaDaiLy.Text);
                        pxh.TongTriGia = uint.Parse(this.txtTongTriGia.Text);

                        if (phieuxuat.SuaPhieuXuat(pxh))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                            btnThemPhieu.Enabled = true;

                            dataPhieuXuat.DataSource = phieuxuat.laydanhsach();
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuXuat.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật Phiếu xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            SetDefault(false);
                            ResetValue();
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Cập nhật phiếu xuất thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa Phiếu xuất hàng", "XÓA Phiếu Xuất hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (phieuxuat.XoaPhieuXuat(long.Parse(txtMaPhieuXuat.Text)))
                    {
                        dataPhieuXuat.DataSource = phieuxuat.laydanhsach();

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataPhieuXuat.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa phiếu xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu xuất thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemPhieu.Text = "Thêm phiếu xuất hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemPhieu.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
           
            frmChiTietPhieuXuat frm1 = new frmChiTietPhieuXuat();
            frm1.Id = txtMaPhieuXuat.Text;
            
            frm1.ShowDialog();
            
        }

        private void TxtMaPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXemChiTiet.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnXemChiTiet.Enabled = true;
            }
        }

        private void DataPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietPhieuXuat frm = new frmChiTietPhieuXuat();
            if (btnThemPhieu.Text == "Thêm phiếu xuất hàng" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataPhieuXuat.Rows[index];
                    this.txtMaPhieuXuat.Text = row.Cells[0].Value.ToString();
                    
                    this.txtTongTriGia.Text = row.Cells[3].Value.ToString();

                    this.dNgayTiepNhan.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                }
                catch
                {
                    return;
                }
            }
            btnXemChiTiet.Visible = true;
            
        }

        private void FrmPhieuXuatHang_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnXemChiTiet.Enabled = false;
            List<DTO_DaiLy> listDl = daily.LayDanhSachDaiLy();
            cbbMaDaiLy.DataSource = new BindingSource(listDl, string.Empty);
            cbbMaDaiLy.DisplayMember = "Id";

            SetDefault(false);
        }
    }
}
