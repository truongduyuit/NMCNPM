namespace GUI
{
    partial class frmChiTietPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuXuat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaChiTiet = new System.Windows.Forms.TextBox();
            this.cbbMaMatHang = new System.Windows.Forms.ComboBox();
            this.cbbMaDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataChiTietPhieuXuat = new System.Windows.Forms.DataGridView();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuatFile);
            this.panel1.Controls.Add(this.txtMaChiTiet);
            this.panel1.Controls.Add(this.cbbMaMatHang);
            this.panel1.Controls.Add(this.cbbMaDonViTinh);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtThanhTien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemChiTiet);
            this.panel1.Controls.Add(this.txtMaPhieuXuat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 554);
            this.panel1.TabIndex = 19;
            // 
            // txtMaChiTiet
            // 
            this.txtMaChiTiet.Location = new System.Drawing.Point(147, 89);
            this.txtMaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChiTiet.Name = "txtMaChiTiet";
            this.txtMaChiTiet.Size = new System.Drawing.Size(220, 22);
            this.txtMaChiTiet.TabIndex = 29;
            this.txtMaChiTiet.TextChanged += new System.EventHandler(this.TxtMaChiTiet_TextChanged);
            // 
            // cbbMaMatHang
            // 
            this.cbbMaMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaMatHang.FormattingEnabled = true;
            this.cbbMaMatHang.Location = new System.Drawing.Point(147, 204);
            this.cbbMaMatHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaMatHang.Name = "cbbMaMatHang";
            this.cbbMaMatHang.Size = new System.Drawing.Size(220, 24);
            this.cbbMaMatHang.TabIndex = 28;
            // 
            // cbbMaDonViTinh
            // 
            this.cbbMaDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDonViTinh.FormattingEnabled = true;
            this.cbbMaDonViTinh.Location = new System.Drawing.Point(147, 164);
            this.cbbMaDonViTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaDonViTinh.Name = "cbbMaDonViTinh";
            this.cbbMaDonViTinh.Size = new System.Drawing.Size(220, 24);
            this.cbbMaDonViTinh.TabIndex = 27;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(147, 251);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(220, 22);
            this.txtSoLuong.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(24, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã mặt hàng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã đơn vị tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(149, 290);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(217, 22);
            this.txtThanhTien.TabIndex = 15;
            this.txtThanhTien.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thành tiền:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(203, 423);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 65);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(15, 423);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 65);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTiet.ImageOptions.Image")));
            this.btnThemChiTiet.Location = new System.Drawing.Point(15, 341);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(165, 65);
            this.btnThemChiTiet.TabIndex = 16;
            this.btnThemChiTiet.Text = "Thêm chi tiết phiếu ";
            this.btnThemChiTiet.Click += new System.EventHandler(this.BtnThemChiTiet_Click);
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(147, 124);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(220, 22);
            this.txtMaPhieuXuat.TabIndex = 8;
            this.txtMaPhieuXuat.TextChanged += new System.EventHandler(this.TxtMaPhieuXuat_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(24, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã chi tiết phiếu xuất:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu xuất:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT PHIẾU XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataChiTietPhieuXuat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 554);
            this.panel3.TabIndex = 18;
            // 
            // dataChiTietPhieuXuat
            // 
            this.dataChiTietPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataChiTietPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataChiTietPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChiTietPhieuXuat.Location = new System.Drawing.Point(396, 0);
            this.dataChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataChiTietPhieuXuat.Name = "dataChiTietPhieuXuat";
            this.dataChiTietPhieuXuat.RowTemplate.Height = 24;
            this.dataChiTietPhieuXuat.Size = new System.Drawing.Size(671, 554);
            this.dataChiTietPhieuXuat.TabIndex = 2;
            this.dataChiTietPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataChiTietPhieuXuat_CellClick);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(202, 341);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(165, 65);
            this.btnXuatFile.TabIndex = 30;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // frmChiTietPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietPhieuXuat";
            this.Text = "CHI TIẾT PHIẾU XUẤT";
            this.Load += new System.EventHandler(this.FrmChiTietPhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataChiTietPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemChiTiet;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataChiTietPhieuXuat;
        private System.Windows.Forms.ComboBox cbbMaMatHang;
        private System.Windows.Forms.ComboBox cbbMaDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
    }
}