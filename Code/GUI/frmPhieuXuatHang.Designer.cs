﻿namespace GUI
{
    partial class frmPhieuXuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuatHang));
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.dNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.txtTongTriGia = new System.Windows.Forms.TextBox();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.cbbMaDaiLy = new System.Windows.Forms.ComboBox();
            this.dataPhieuXuat = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuXuat)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(154, 361);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 53);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(19, 361);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 53);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDaiLy.ImageOptions.Image")));
            this.btnThemPhieu.Location = new System.Drawing.Point(21, 304);
            this.btnThemPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(257, 53);
            this.btnThemPhieu.TabIndex = 16;
            this.btnThemPhieu.Text = "Thêm phiếu xuất hàng";
            this.btnThemPhieu.Click += new System.EventHandler(this.BtnThemPhieu_Click);
            // 
            // dNgayTiepNhan
            // 
            this.dNgayTiepNhan.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dNgayTiepNhan.Location = new System.Drawing.Point(112, 151);
            this.dNgayTiepNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dNgayTiepNhan.Name = "dNgayTiepNhan";
            this.dNgayTiepNhan.Size = new System.Drawing.Size(165, 20);
            this.dNgayTiepNhan.TabIndex = 17;
            // 
            // txtTongTriGia
            // 
            this.txtTongTriGia.Location = new System.Drawing.Point(112, 195);
            this.txtTongTriGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTriGia.Name = "txtTongTriGia";
            this.txtTongTriGia.Size = new System.Drawing.Size(166, 20);
            this.txtTongTriGia.TabIndex = 12;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(111, 114);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(166, 20);
            this.txtMaPhieuXuat.TabIndex = 9;
            this.txtMaPhieuXuat.TextChanged += new System.EventHandler(this.TxtMaPhieuXuat_TextChanged);
            // 
            // cbbMaDaiLy
            // 
            this.cbbMaDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDaiLy.FormattingEnabled = true;
            this.cbbMaDaiLy.Location = new System.Drawing.Point(111, 73);
            this.cbbMaDaiLy.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMaDaiLy.Name = "cbbMaDaiLy";
            this.cbbMaDaiLy.Size = new System.Drawing.Size(166, 21);
            this.cbbMaDaiLy.TabIndex = 10;
            // 
            // dataPhieuXuat
            // 
            this.dataPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuXuat.Location = new System.Drawing.Point(0, 56);
            this.dataPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dataPhieuXuat.Name = "dataPhieuXuat";
            this.dataPhieuXuat.RowTemplate.Height = 24;
            this.dataPhieuXuat.Size = new System.Drawing.Size(500, 454);
            this.dataPhieuXuat.TabIndex = 2;
            this.dataPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPhieuXuat_CellClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng trị giá:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã phiếu xuất:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đại lý:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU XUẤT HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dataPhieuXuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 512);
            this.panel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày tiếp nhận:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemChiTiet);
            this.panel1.Controls.Add(this.btnInPhieu);
            this.panel1.Controls.Add(this.btnTimPhieu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemPhieu);
            this.panel1.Controls.Add(this.dNgayTiepNhan);
            this.panel1.Controls.Add(this.txtTongTriGia);
            this.panel1.Controls.Add(this.cbbMaDaiLy);
            this.panel1.Controls.Add(this.txtMaPhieuXuat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 512);
            this.panel1.TabIndex = 17;
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.Location = new System.Drawing.Point(21, 251);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(122, 34);
            this.btnTimPhieu.TabIndex = 21;
            this.btnTimPhieu.Text = "Tim phiếu xuất";
            this.btnTimPhieu.UseVisualStyleBackColor = true;
            this.btnTimPhieu.Click += new System.EventHandler(this.BtnTimPhieu_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Location = new System.Drawing.Point(156, 251);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(122, 34);
            this.btnInPhieu.TabIndex = 22;
            this.btnInPhieu.Text = "In phiếu xuất";
            this.btnInPhieu.UseVisualStyleBackColor = true;
            this.btnInPhieu.Click += new System.EventHandler(this.BtnInPhieu_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(19, 429);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(259, 23);
            this.btnXemChiTiet.TabIndex = 23;
            this.btnXemChiTiet.Text = "Xem chi tiết phiếu xuất hàng";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.BtnXemChiTiet_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 54);
            this.panel2.TabIndex = 3;
            // 
            // frmPhieuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuXuatHang";
            this.Text = "frmPhieuXuatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPhieuXuatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuXuat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieu;
        private System.Windows.Forms.DateTimePicker dNgayTiepNhan;
        private System.Windows.Forms.TextBox txtTongTriGia;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.ComboBox cbbMaDaiLy;
        private System.Windows.Forms.DataGridView dataPhieuXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnTimPhieu;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Panel panel2;
    }
}