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
    public partial class frmQuyDinh : Form
    {
        private BLL_QuyDinh qdd = new BLL_QuyDinh();

        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            LoadDefault(false);
            LoadData();
        }

        private void LoadDefault(bool status)
        {
            txtSLDonViTinh.Enabled = status;
            txtSLMatHang.Enabled = status;
            txtSoDLToiDa.Enabled = status;
            txtSoLuongQuan.Enabled = status;

            btnXacNhan.Enabled = true;
            btnHuy.Enabled = status;
        }

        private void LoadData()
        {
            DTO_QuyDinh qd = qdd.QuyDinh();
            txtSoDLToiDa.Text = qd.SoDLToiDa.ToString();
            txtSoLuongQuan.Text = qd.SoQuan.ToString();
            txtSLMatHang.Text = qd.SoMatHang.ToString();
            txtSLDonViTinh.Text = qd.SoDVT.ToString();
        }

        private DTO_QuyDinh QuyDinh()
        {
            DTO_QuyDinh q = new DTO_QuyDinh();
            q.SoDLToiDa = int.Parse(txtSoDLToiDa.Text);
            q.SoDVT = int.Parse(txtSLDonViTinh.Text);
            q.SoMatHang = int.Parse(txtSLMatHang.Text);
            q.SoQuan = int.Parse(txtSoLuongQuan.Text);
            return q;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (btnXacNhan.Text == "Chỉnh sửa")
            {
                btnXacNhan.Text = "Lưu";
                LoadDefault(true);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thay đổi quy định ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);               
                if(result == DialogResult.OK)
                {
                    if (qdd.ChinhSuaQuyDinh(QuyDinh()))
                    {                        
                        MessageBox.Show("Chỉnh sửa quy định thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa quy định thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnXacNhan.Text = "Chỉnh sửa";
                    LoadData();
                    LoadDefault(false);
                }               
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LoadData();
                LoadDefault(false);
            }
        }
    }
}
