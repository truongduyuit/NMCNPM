namespace GUI
{
    partial class frmDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonViTinh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDonViTinh = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenDonViTinh = new System.Windows.Forms.TextBox();
            this.txtMaDonViTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDonViTinh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemDonViTinh);
            this.panel1.Controls.Add(this.txtTenDonViTinh);
            this.panel1.Controls.Add(this.txtMaDonViTinh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 450);
            this.panel1.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(190, 368);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 65);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(10, 368);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 65);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemDonViTinh
            // 
            this.btnThemDonViTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDonViTinh.ImageOptions.Image")));
            this.btnThemDonViTinh.Location = new System.Drawing.Point(12, 273);
            this.btnThemDonViTinh.Name = "btnThemDonViTinh";
            this.btnThemDonViTinh.Size = new System.Drawing.Size(343, 65);
            this.btnThemDonViTinh.TabIndex = 29;
            this.btnThemDonViTinh.Text = "Thêm Đơn Vị Tính";
            this.btnThemDonViTinh.Click += new System.EventHandler(this.btnThemDonViTinh_Click);
            // 
            // txtTenDonViTinh
            // 
            this.txtTenDonViTinh.Location = new System.Drawing.Point(122, 125);
            this.txtTenDonViTinh.Name = "txtTenDonViTinh";
            this.txtTenDonViTinh.Size = new System.Drawing.Size(220, 22);
            this.txtTenDonViTinh.TabIndex = 28;
            // 
            // txtMaDonViTinh
            // 
            this.txtMaDonViTinh.Location = new System.Drawing.Point(122, 78);
            this.txtMaDonViTinh.Name = "txtMaDonViTinh";
            this.txtMaDonViTinh.Size = new System.Drawing.Size(220, 22);
            this.txtMaDonViTinh.TabIndex = 27;
            this.txtMaDonViTinh.TextChanged += new System.EventHandler(this.txtMaDonViTinh_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên đơn vị tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã đơn vị tính:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 67);
            this.label2.TabIndex = 24;
            this.label2.Text = "ĐƠN VỊ TÍNH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataDonViTinh
            // 
            this.dataDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDonViTinh.Location = new System.Drawing.Point(374, 0);
            this.dataDonViTinh.Name = "dataDonViTinh";
            this.dataDonViTinh.RowTemplate.Height = 24;
            this.dataDonViTinh.Size = new System.Drawing.Size(426, 450);
            this.dataDonViTinh.TabIndex = 4;
            this.dataDonViTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDonViTinh_CellClick);
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataDonViTinh);
            this.Controls.Add(this.panel1);
            this.Name = "frmDonViTinh";
            this.Text = "frmDonViTinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemDonViTinh;
        private System.Windows.Forms.TextBox txtTenDonViTinh;
        private System.Windows.Forms.TextBox txtMaDonViTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataDonViTinh;
    }
}