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
   
    public partial class frmChiTietPhieuXuat : Form
    {
        private  string id;
        public string Id { get => id; set => id = value; }
        private BLL_ChiTietPhieuXuat chitietphieuxuat = new BLL_ChiTietPhieuXuat();
        private BLL_DonViTinh dvt = new BLL_DonViTinh();
        private BLL_MatHang mh = new BLL_MatHang();
 
        public frmChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        private void SetDefault(bool status)
        {
            this.txtMaPhieuXuat.Enabled = false;
            this.txtDonGia.Enabled = status;

            this.txtSoLuong.Enabled = status;
            this.txtMaChiTiet.Enabled = status;
            this.cbbMaDonViTinh.Enabled = status;
            this.cbbMaMatHang.Enabled = status;
            this.txtDonGia.Enabled = status;
        }

        private void ResetValue()
        {
            this.txtMaPhieuXuat.Text = string.Empty;
            this.txtDonGia.Text = string.Empty;
            this.txtSoLuong.Text = string.Empty;
            this.txtMaChiTiet.Text = string.Empty;
            this.cbbMaDonViTinh.SelectedValue = string.Empty;
            this.cbbMaMatHang.SelectedValue = string.Empty;
            this.txtDonGia.Text = "0";

        }

        private void TxtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            txtMaPhieuXuat.Text = id;
            
           
            if (chitietphieuxuat.TimKiemChiTiet(txtMaPhieuXuat.Text) != null)
            {
                this.dataChiTietPhieuXuat.DataSource = chitietphieuxuat.TimKiemChiTiet(txtMaPhieuXuat.Text);

                List<DTO_DonViTinh> listDVT = dvt.hienthidanhsach();
                List<DTO_MatHang> listMH = mh.LayDanhSachMatHang();
                

                if (listDVT == null || listMH == null)
                {
                    MessageBox.Show("Có lỗi khi lấy dữ liệu");
                    return;
                }
               
                cbbMaDonViTinh.DataSource = new BindingSource(listDVT, String.Empty);
                cbbMaDonViTinh.DisplayMember = "Ten";
                cbbMaDonViTinh.ValueMember = "Id";
                
                cbbMaMatHang.DataSource = new BindingSource(listMH, String.Empty);
                cbbMaMatHang.DisplayMember = "TenMatHang";
                cbbMaMatHang.ValueMember = "maMatHang";
                

                CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataChiTietPhieuXuat.DataSource];
                myCurrencyManager.Refresh();
            }
            else
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetDefault(false);
        }

        private void DataChiTietPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = this.dataChiTietPhieuXuat.Rows[index];
                this.txtMaPhieuXuat.Text = row.Cells[1].Value.ToString();
                this.txtDonGia.Text = row.Cells[5].Value.ToString();
                this.txtSoLuong.Text = row.Cells[4].Value.ToString();
                this.txtMaChiTiet.Text = row.Cells[0].Value.ToString();
                this.cbbMaDonViTinh.SelectedValue = row.Cells[2].Value;
                this.cbbMaMatHang.SelectedValue = row.Cells[3].Value;
            }
            catch
            {
                return;
            }
        }
    }
}
