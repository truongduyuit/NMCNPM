namespace GUI
{
    partial class frmQuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuan));
            this.dataQuan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaQuan = new System.Windows.Forms.TextBox();
            this.lbTenQuan = new System.Windows.Forms.Label();
            this.lbMaQuan = new System.Windows.Forms.Label();
            this.lbQuan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemQuan = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataQuan
            // 
            this.dataQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataQuan.Location = new System.Drawing.Point(0, 0);
            this.dataQuan.Margin = new System.Windows.Forms.Padding(2);
            this.dataQuan.Name = "dataQuan";
            this.dataQuan.RowTemplate.Height = 24;
            this.dataQuan.Size = new System.Drawing.Size(500, 378);
            this.dataQuan.TabIndex = 2;
            this.dataQuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataQuan_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataQuan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 378);
            this.panel3.TabIndex = 19;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTimKiem.Location = new System.Drawing.Point(351, 33);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // txtTenQuan
            // 
            this.txtTenQuan.Location = new System.Drawing.Point(111, 114);
            this.txtTenQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(166, 20);
            this.txtTenQuan.TabIndex = 9;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTatCa.Location = new System.Drawing.Point(451, 33);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(86, 23);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.BtnTatCa_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 72);
            this.panel2.TabIndex = 18;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiem.Location = new System.Drawing.Point(71, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // txtMaQuan
            // 
            this.txtMaQuan.Location = new System.Drawing.Point(112, 73);
            this.txtMaQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaQuan.Name = "txtMaQuan";
            this.txtMaQuan.Size = new System.Drawing.Size(166, 20);
            this.txtMaQuan.TabIndex = 8;
            this.txtMaQuan.TextChanged += new System.EventHandler(this.TxtMaQuan_TextChanged);
            // 
            // lbTenQuan
            // 
            this.lbTenQuan.Location = new System.Drawing.Point(16, 114);
            this.lbTenQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenQuan.Name = "lbTenQuan";
            this.lbTenQuan.Size = new System.Drawing.Size(90, 19);
            this.lbTenQuan.TabIndex = 2;
            this.lbTenQuan.Text = "Tên Quận:";
            this.lbTenQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbMaQuan
            // 
            this.lbMaQuan.Location = new System.Drawing.Point(16, 73);
            this.lbMaQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaQuan.Name = "lbMaQuan";
            this.lbMaQuan.Size = new System.Drawing.Size(90, 19);
            this.lbMaQuan.TabIndex = 1;
            this.lbMaQuan.Text = "Mã Quận:";
            this.lbMaQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbQuan
            // 
            this.lbQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuan.Location = new System.Drawing.Point(0, 0);
            this.lbQuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuan.Name = "lbQuan";
            this.lbQuan.Size = new System.Drawing.Size(300, 54);
            this.lbQuan.TabIndex = 0;
            this.lbQuan.Text = "QUẬN";
            this.lbQuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemQuan);
            this.panel1.Controls.Add(this.txtTenQuan);
            this.panel1.Controls.Add(this.txtMaQuan);
            this.panel1.Controls.Add(this.lbTenQuan);
            this.panel1.Controls.Add(this.lbMaQuan);
            this.panel1.Controls.Add(this.lbQuan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 450);
            this.panel1.TabIndex = 20;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(156, 269);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 53);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(21, 269);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 53);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThemQuan
            // 
            this.btnThemQuan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemQuan.ImageOptions.Image")));
            this.btnThemQuan.Location = new System.Drawing.Point(22, 192);
            this.btnThemQuan.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemQuan.Name = "btnThemQuan";
            this.btnThemQuan.Size = new System.Drawing.Size(257, 53);
            this.btnThemQuan.TabIndex = 21;
            this.btnThemQuan.Text = "Thêm Quận";
            this.btnThemQuan.Click += new System.EventHandler(this.BtnThemQuan_Click);
            // 
            // frmQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuan";
            this.Text = "frmQuan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQuan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataQuan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaQuan;
        private System.Windows.Forms.Label lbTenQuan;
        private System.Windows.Forms.Label lbMaQuan;
        private System.Windows.Forms.Label lbQuan;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemQuan;
    }
}