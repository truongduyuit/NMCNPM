namespace GUI
{
    partial class frmBaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoCongNo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCongNo = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhatSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoCuoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoDau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDaiLy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dataCongNo = new System.Windows.Forms.DataGridView();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongNo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbThoiGian);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThemCongNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPhatSinh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNoCuoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNoDau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbDaiLy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 681);
            this.panel1.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(209, 600);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 65);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(30, 600);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(165, 65);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemCongNo
            // 
            this.btnThemCongNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCongNo.ImageOptions.Image")));
            this.btnThemCongNo.Location = new System.Drawing.Point(30, 511);
            this.btnThemCongNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCongNo.Name = "btnThemCongNo";
            this.btnThemCongNo.Size = new System.Drawing.Size(343, 65);
            this.btnThemCongNo.TabIndex = 23;
            this.btnThemCongNo.Text = "Thêm Công Nợ";
            this.btnThemCongNo.Click += new System.EventHandler(this.btnThemCongNo_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Thời gian:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhatSinh
            // 
            this.txtPhatSinh.Location = new System.Drawing.Point(154, 371);
            this.txtPhatSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhatSinh.Name = "txtPhatSinh";
            this.txtPhatSinh.Size = new System.Drawing.Size(220, 22);
            this.txtPhatSinh.TabIndex = 18;
            this.txtPhatSinh.Text = "0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Phát sinh:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoCuoi
            // 
            this.txtNoCuoi.Location = new System.Drawing.Point(153, 441);
            this.txtNoCuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoCuoi.Name = "txtNoCuoi";
            this.txtNoCuoi.Size = new System.Drawing.Size(220, 22);
            this.txtNoCuoi.TabIndex = 16;
            this.txtNoCuoi.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nợ cuối:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoDau
            // 
            this.txtNoDau.Location = new System.Drawing.Point(153, 301);
            this.txtNoDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoDau.Name = "txtNoDau";
            this.txtNoDau.Size = new System.Drawing.Size(220, 22);
            this.txtNoDau.TabIndex = 14;
            this.txtNoDau.Text = "0";
            this.txtNoDau.TextChanged += new System.EventHandler(this.txtNoDau_TextChanged);
            this.txtNoDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoDau_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nợ đầu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaiLy.FormattingEnabled = true;
            this.cbDaiLy.Location = new System.Drawing.Point(154, 231);
            this.cbDaiLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Size = new System.Drawing.Size(220, 24);
            this.cbDaiLy.TabIndex = 12;
            this.cbDaiLy.SelectedValueChanged += new System.EventHandler(this.cbDaiLy_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đại lý:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÔNG NỢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnTatCa);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 89);
            this.panel2.TabIndex = 3;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTatCa.Location = new System.Drawing.Point(737, 41);
            this.btnTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(115, 28);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTimKiem.Location = new System.Drawing.Point(604, 41);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 28);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTimKiem.Location = new System.Drawing.Point(200, 44);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(345, 22);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dataCongNo
            // 
            this.dataCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCongNo.Location = new System.Drawing.Point(400, 89);
            this.dataCongNo.Name = "dataCongNo";
            this.dataCongNo.RowTemplate.Height = 24;
            this.dataCongNo.Size = new System.Drawing.Size(939, 592);
            this.dataCongNo.TabIndex = 4;
            this.dataCongNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCongNo_CellClick);
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Location = new System.Drawing.Point(153, 171);
            this.cbThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(220, 24);
            this.cbThoiGian.TabIndex = 26;
            this.cbThoiGian.SelectedValueChanged += new System.EventHandler(this.cbThoiGian_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(153, 91);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(220, 22);
            this.txtMa.TabIndex = 28;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 681);
            this.Controls.Add(this.dataCongNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "CÔNG NỢ";
            this.Load += new System.EventHandler(this.frmBaoCaoCongNo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCongNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbDaiLy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhatSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoCuoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemCongNo;
        private System.Windows.Forms.DataGridView dataCongNo;
        private System.Windows.Forms.ComboBox cbThoiGian;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
    }
}