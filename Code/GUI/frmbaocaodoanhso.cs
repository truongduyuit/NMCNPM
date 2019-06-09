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
namespace GUI
{
    public partial class frmbaocaodoanhso : Form
    {
        BLL_BaoCaoDoanhSo baocao = new BLL_BaoCaoDoanhSo();
        public frmbaocaodoanhso() {
            InitializeComponent();
        }

        private void BtnBaoCao_Click(object sender, EventArgs e) {
            if (Validation()) {
                int sm = dtpkNgayBatDau.Value.Month;
                int sy = dtpkNgayBatDau.Value.Year;
                int em = dtpkNgayKetThuc.Value.Month;
                int ey = dtpkNgayKetThuc.Value.Year;
                if (baocao.hienthidoanhso(sm, sy, em, ey) != null) {
                    datadoanhthu.DataSource = baocao.hienthidoanhso(sm, sy, em, ey);
                    this.datadoanhthu.Columns["maTG"].Visible = false;
                } else
                    MessageBox.Show("rỗng");
                hienthidoanhthu();
            }
            else {
                MessageBox.Show("Thời gian bắt đầu phải trước thời gian kết thúc!");
                datadoanhthu.DataSource = null;
            }
        }

        private bool Validation() {
            if (dtpkNgayKetThuc.Value >= dtpkNgayBatDau.Value)
                return true;
            return false;
        }

        private void hienthidoanhthu() {
            txttongdoanhthu.Text =  baocao.hienthitongdoanhthu() + " Đồng";
        }
    }
}
