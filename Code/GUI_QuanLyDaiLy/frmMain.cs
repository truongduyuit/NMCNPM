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

namespace GUI_QuanLyDaiLy
{
    public partial class frmMain : Form
    {
        private BLL_DaiLy dailyBLL;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dailyBLL = new BLL_DaiLy();

            dataGridView1.Columns.Add("STT", "STT");
            dataGridView1.DataSource = dailyBLL.LayDanhSachDaiLy();

            for (int i=0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i+ 1;
            }

            dataGridView1.Columns["Sdt"].Visible = false;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["NgayTiepNhan"].Visible = false;

            if (dailyBLL.LayDanhSachDaiLy() == null)
            {
                MessageBox.Show("null");
            }
        }


    }
}
