using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmChiTietPhieuXuat : Form
    {
        private BLL_DonViTinh donvitinh = new BLL_DonViTinh();
        private BLL_MatHang mathang = new BLL_MatHang();
        private BLL_LoaiDaiLy ldl = new BLL_LoaiDaiLy();
        private BLL_ChiTietPhieuXuat chitiet = new BLL_ChiTietPhieuXuat();
        private string id;
        public string Id { get => id; set => id = value; }
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        private void SetDefault(bool status)
        {
            this.txtMaPhieuXuat.Enabled = false;
       

            this.txtMaChiTiet.Enabled = false;
            this.cbbMaDonViTinh.Enabled = status;
            this.cbbMaMatHang.Enabled = status;
            this.txtSoLuong.Enabled = status;
            this.txtThanhTien.Enabled = false;
           
        }

        private void ResetValue()
        {
            this.txtMaPhieuXuat.Text = string.Empty;
            this.txtMaChiTiet.Text = string.Empty;
            this.cbbMaDonViTinh.SelectedValue = string.Empty;
            this.cbbMaMatHang.SelectedValue = string.Empty;
            this.txtThanhTien.Text = "0";
            this.txtSoLuong.Text = string.Empty;
        }
        private void FrmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            txtMaPhieuXuat.Text = id;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            if (dataChiTietPhieuXuat.Rows.Count == 0)
            {
                btnXuatFile.Enabled = false;
            }
            if (chitiet.timkiem(txtMaPhieuXuat.Text) != null)
            {
                this.dataChiTietPhieuXuat.DataSource = chitiet.timkiem(txtMaPhieuXuat.Text);

                List<DTO_DonViTinh> listdvt = donvitinh.hienthidanhsach();
                List<DTO_MatHang> listmh = mathang.LayDanhSachMatHang();

                if (listdvt == null || listmh == null)
                {
                    MessageBox.Show("Có lỗi khi lấy dữ liệu");
                    return;
                }

                cbbMaDonViTinh.DataSource = new BindingSource(listdvt, String.Empty);
                cbbMaDonViTinh.DisplayMember = "Ten";
                cbbMaDonViTinh.ValueMember = "Id";

                cbbMaMatHang.DataSource = new BindingSource(listmh, String.Empty);
                cbbMaMatHang.DisplayMember = "TenMatHang";
                cbbMaMatHang.ValueMember = "MaMatHang";

                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChiTietPhieuXuat.DataSource];
                myCurrencyManager.Refresh();
               
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }
        private bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return false;
            }
            
            return true;
        }

        private void DataChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThemChiTiet.Text == "Thêm chi tiết phiếu xuất hàng" && btnSua.Text == "Sửa")
            {
                try
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = this.dataChiTietPhieuXuat.Rows[index];
                    this.txtMaChiTiet.Text = row.Cells[0].Value.ToString();
                    this.txtMaPhieuXuat.Text = row.Cells[1].Value.ToString();
                   
                    this.txtThanhTien.Text = row.Cells[5].Value.ToString();
                    this.cbbMaDonViTinh.SelectedValue = row.Cells[2].Value;
                    this.cbbMaMatHang.SelectedValue = row.Cells[3].Value;
                    this.txtSoLuong.Text = row.Cells[4].Value.ToString();

                }
                catch
                {
                    return;
                }
            }
        }

        private void BtnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (btnThemChiTiet.Text == "Thêm chi tiết phiếu xuất hàng")
            {
                btnThemChiTiet.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";
                btnXoa.Enabled = true;
                SetDefault(true);
                txtSoLuong.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm chi tiết phiếu xuất", "THÊM CHI TIẾT PHIẾU XUẤT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (KiemTra())
                    {
                        DTO_ChiTietPhieuXuat ctpx = new DTO_ChiTietPhieuXuat();
                       ctpx.MaPx = long.Parse(this.txtMaPhieuXuat.Text);
                        ctpx.MaDvt = long.Parse(this.cbbMaDonViTinh.SelectedValue.ToString());
                        ctpx.MaMh = long.Parse(this.cbbMaMatHang.SelectedValue.ToString());
                        ctpx.SoLuong = int.Parse(this.txtSoLuong.Text);
                        ctpx.ThanhTien = uint.Parse(this.txtThanhTien.Text);
                      

                        if (chitiet.ThemChiTietPX(ctpx))
                        {
                            btnThemChiTiet.Text = "Thêm chi tiết phiếu xuất hàng";
                            btnXoa.Text = "Xóa";

                            dataChiTietPhieuXuat.DataSource = chitiet.timkiem(txtMaPhieuXuat.Text);
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChiTietPhieuXuat.DataSource];
                            myCurrencyManager.Refresh();

                            SetDefault(false);
                            ResetValue();

                            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
                            {
                                btnXoa.Enabled = false;
                            }

                            MessageBox.Show("Thêm chi tiết phiếu xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại quy định và dữ liệu", "Thêm chi tiết phiếu xuất thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                }

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
            {
                MessageBox.Show("Vui lòng chọn mã phiếu xuất để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetDefault(true);
            }
            else
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Cập nhật";
                    btnXoa.Text = "Hủy";
                    btnThemChiTiet.Enabled = false;
                    SetDefault(true);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DTO_ChiTietPhieuXuat ctpx = new DTO_ChiTietPhieuXuat();
                        ctpx.Id = long.Parse(this.txtMaChiTiet.Text);
                        ctpx.MaDvt = long.Parse(this.cbbMaDonViTinh.SelectedValue.ToString());
                        ctpx.MaMh = long.Parse(this.cbbMaMatHang.SelectedValue.ToString());
                        ctpx.SoLuong = int.Parse(this.txtSoLuong.Text);

                        if (chitiet.SuaChiTietPX(ctpx))
                        {
                            btnSua.Text = "Sửa";
                            btnXoa.Text = "Xóa";
                           btnThemChiTiet.Enabled = true;

                            dataChiTietPhieuXuat.DataSource =chitiet.timkiem(txtMaPhieuXuat.Text);
                            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChiTietPhieuXuat.DataSource];
                            myCurrencyManager.Refresh();

                            MessageBox.Show("Cập nhật chi tiết phiếu xuất thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void TxtMaPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                //btnXuatFile.Enabled = false;
            }
            else
            {
                //btnXuatFile.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết phiếu xuất", "XÓA CHI TIẾT PHIẾU XUẤT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (chitiet.XoaChiTietPX(long.Parse(txtMaChiTiet.Text)))
                    {
                        dataChiTietPhieuXuat.DataSource = chitiet.timkiem(txtMaPhieuXuat.Text);

                        CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChiTietPhieuXuat.DataSource];
                        myCurrencyManager.Refresh();

                        MessageBox.Show("Xóa chi tiết thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa chi tiết thất bài", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy", "HỦY THAO TÁC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    btnThemChiTiet.Text = "Thêm chi tiết phiếu xuất hàng";
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    //btnSua.Enabled = true;
                    btnThemChiTiet.Enabled = true;
                    if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
                    {
                        btnXoa.Enabled = false;
                    }
                    SetDefault(false);
                    ResetValue();
                }

            }
        }

        private void TxtMaChiTiet_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuXuat.Text))
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

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument; //add the document to the dialog box

                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt); //add an event handler that will do the printing
                                                                                                               //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }
        }

        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("CHI TIẾT PHIẾU XUẤT", new Font("Courier New", 28), new SolidBrush(Color.Black), startX, startY);
            string top = "Mặt hàng".PadRight(20) + "Đơn vị tính".PadRight(20) + "Số Lượng".PadRight(20)+"Thành tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("--------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent

            foreach (DataGridViewRow row in dataChiTietPhieuXuat.Rows)
            {               
                graphic.DrawString(mathang.LayDanhSachMatHang(long.Parse(row.Cells[3].Value.ToString())), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(donvitinh.LayDonViTinh(long.Parse(row.Cells[2].Value.ToString())), font, new SolidBrush(Color.Black), startX + 200, startY + offset);
                graphic.DrawString(row.Cells[4].Value.ToString(), font, new SolidBrush(Color.Black), startX + 450, startY + offset);
                graphic.DrawString(row.Cells[5].Value.ToString(), font, new SolidBrush(Color.Black), startX + 650, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            }
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("--------------------------------------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20; //make some room so that the total stands out.

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Đại lý: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtMaPhieuXuat.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("Nhân viên: ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(txtSoLuong.Text, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            //offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            //graphic.DrawString("Ngày (mm/dd/yyyy):  ", font, new SolidBrush(Color.Black), startX, startY + offset);
            //graphic.DrawString(txtThanhTien.Value.ToShortDateString(), font, new SolidBrush(Color.Black), startX + 250, startY + offset);


            offset = offset + (int)FontHeight + 25; //make the spacing consistent              
            graphic.DrawString("Trân thành cảm ơn quý khách hàng!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
