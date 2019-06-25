namespace GUI
{
    partial class frmLoaiDaiLy
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
            this.dataLoaiDaiLy = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaLoaiDaiLy = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbLoaiDaiLy = new System.Windows.Forms.Label();
            this.txtNoToiDa = new System.Windows.Forms.TextBox();
            this.txtTenLoaiDaiLy = new System.Windows.Forms.TextBox();
            this.lbNoToiDa = new System.Windows.Forms.Label();
            this.lbTenLoaiDaiLy = new System.Windows.Forms.Label();
            this.lbMaLoaiDaiLy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiDaiLy)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLoaiDaiLy
            // 
            this.dataLoaiDaiLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLoaiDaiLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLoaiDaiLy.Location = new System.Drawing.Point(280, 71);
            this.dataLoaiDaiLy.Name = "dataLoaiDaiLy";
            this.dataLoaiDaiLy.Size = new System.Drawing.Size(510, 383);
            this.dataLoaiDaiLy.TabIndex = 5;
            this.dataLoaiDaiLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLoaiDaiLy_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaLoaiDaiLy);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lbLoaiDaiLy);
            this.panel1.Controls.Add(this.txtNoToiDa);
            this.panel1.Controls.Add(this.txtTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbNoToiDa);
            this.panel1.Controls.Add(this.lbTenLoaiDaiLy);
            this.panel1.Controls.Add(this.lbMaLoaiDaiLy);
            this.panel1.Location = new System.Drawing.Point(10, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 458);
            this.panel1.TabIndex = 3;
            // 
            // txtMaLoaiDaiLy
            // 
            this.txtMaLoaiDaiLy.Location = new System.Drawing.Point(119, 85);
            this.txtMaLoaiDaiLy.Name = "txtMaLoaiDaiLy";
            this.txtMaLoaiDaiLy.Size = new System.Drawing.Size(121, 20);
            this.txtMaLoaiDaiLy.TabIndex = 10;
            this.txtMaLoaiDaiLy.TextChanged += new System.EventHandler(this.TxtMaLoaiDaiLy_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(147, 332);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 55);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(40, 332);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 55);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(40, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(200, 55);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm Loại Đại Lý";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // lbLoaiDaiLy
            // 
            this.lbLoaiDaiLy.AutoSize = true;
            this.lbLoaiDaiLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiDaiLy.Location = new System.Drawing.Point(80, 27);
            this.lbLoaiDaiLy.Name = "lbLoaiDaiLy";
            this.lbLoaiDaiLy.Size = new System.Drawing.Size(113, 20);
            this.lbLoaiDaiLy.TabIndex = 6;
            this.lbLoaiDaiLy.Text = "LOẠI ĐẠI LÝ";
            // 
            // txtNoToiDa
            // 
            this.txtNoToiDa.Location = new System.Drawing.Point(119, 146);
            this.txtNoToiDa.Name = "txtNoToiDa";
            this.txtNoToiDa.Size = new System.Drawing.Size(121, 20);
            this.txtNoToiDa.TabIndex = 5;
            // 
            // txtTenLoaiDaiLy
            // 
            this.txtTenLoaiDaiLy.Location = new System.Drawing.Point(119, 118);
            this.txtTenLoaiDaiLy.Name = "txtTenLoaiDaiLy";
            this.txtTenLoaiDaiLy.Size = new System.Drawing.Size(121, 20);
            this.txtTenLoaiDaiLy.TabIndex = 4;
            // 
            // lbNoToiDa
            // 
            this.lbNoToiDa.AutoSize = true;
            this.lbNoToiDa.Location = new System.Drawing.Point(37, 149);
            this.lbNoToiDa.Name = "lbNoToiDa";
            this.lbNoToiDa.Size = new System.Drawing.Size(57, 13);
            this.lbNoToiDa.TabIndex = 2;
            this.lbNoToiDa.Text = "Nợ tối đa :";
            // 
            // lbTenLoaiDaiLy
            // 
            this.lbTenLoaiDaiLy.AutoSize = true;
            this.lbTenLoaiDaiLy.Location = new System.Drawing.Point(37, 118);
            this.lbTenLoaiDaiLy.Name = "lbTenLoaiDaiLy";
            this.lbTenLoaiDaiLy.Size = new System.Drawing.Size(79, 13);
            this.lbTenLoaiDaiLy.TabIndex = 1;
            this.lbTenLoaiDaiLy.Text = "Tên loại đại lý :";
            // 
            // lbMaLoaiDaiLy
            // 
            this.lbMaLoaiDaiLy.AutoSize = true;
            this.lbMaLoaiDaiLy.Location = new System.Drawing.Point(37, 88);
            this.lbMaLoaiDaiLy.Name = "lbMaLoaiDaiLy";
            this.lbMaLoaiDaiLy.Size = new System.Drawing.Size(75, 13);
            this.lbMaLoaiDaiLy.TabIndex = 0;
            this.lbMaLoaiDaiLy.Text = "Mã loại đại lý :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Location = new System.Drawing.Point(280, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 77);
            this.panel2.TabIndex = 4;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatCa.Location = new System.Drawing.Point(414, 27);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(86, 23);
            this.btnTatCa.TabIndex = 7;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.BtnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(314, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(11, 30);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // frmLoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataLoaiDaiLy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmLoaiDaiLy";
            this.Text = "frmLoaiDaiLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLoaiDaiLy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLoaiDaiLy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaLoaiDaiLy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbLoaiDaiLy;
        private System.Windows.Forms.TextBox txtNoToiDa;
        private System.Windows.Forms.TextBox txtTenLoaiDaiLy;
        private System.Windows.Forms.Label lbNoToiDa;
        private System.Windows.Forms.Label lbTenLoaiDaiLy;
        private System.Windows.Forms.Label lbMaLoaiDaiLy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}