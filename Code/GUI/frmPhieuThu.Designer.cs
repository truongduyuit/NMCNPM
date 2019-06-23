namespace GUI
{
    partial class frmPhieuThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numSoTien = new System.Windows.Forms.NumericUpDown();
            this.dtpkNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbDaiLy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPhieuThu = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieuThu = new DevExpress.XtraEditors.SimpleButton();
            this.dataPhieuThu = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataPhieuThu);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 542);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThemPhieuThu);
            this.panel3.Controls.Add(this.numSoTien);
            this.panel3.Controls.Add(this.dtpkNgayThu);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.cbDaiLy);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 456);
            this.panel3.TabIndex = 0;
            // 
            // numSoTien
            // 
            this.numSoTien.Location = new System.Drawing.Point(104, 240);
            this.numSoTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSoTien.Name = "numSoTien";
            this.numSoTien.Size = new System.Drawing.Size(180, 20);
            this.numSoTien.TabIndex = 4;
            // 
            // dtpkNgayThu
            // 
            this.dtpkNgayThu.CustomFormat = "dd/mm/yyyy - hh:mm";
            this.dtpkNgayThu.Enabled = false;
            this.dtpkNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayThu.Location = new System.Drawing.Point(104, 158);
            this.dtpkNgayThu.Name = "dtpkNgayThu";
            this.dtpkNgayThu.Size = new System.Drawing.Size(180, 20);
            this.dtpkNgayThu.TabIndex = 3;
            this.dtpkNgayThu.Value = new System.DateTime(2019, 6, 9, 10, 56, 28, 0);
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(104, 118);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(104, 198);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(180, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // cbDaiLy
            // 
            this.cbDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDaiLy.FormattingEnabled = true;
            this.cbDaiLy.Location = new System.Drawing.Point(104, 77);
            this.cbDaiLy.Name = "cbDaiLy";
            this.cbDaiLy.Size = new System.Drawing.Size(180, 21);
            this.cbDaiLy.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày thu tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đại lý:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPhieuThu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 86);
            this.panel2.TabIndex = 0;
            // 
            // lbPhieuThu
            // 
            this.lbPhieuThu.AutoSize = true;
            this.lbPhieuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuThu.Location = new System.Drawing.Point(438, 29);
            this.lbPhieuThu.Name = "lbPhieuThu";
            this.lbPhieuThu.Size = new System.Drawing.Size(124, 25);
            this.lbPhieuThu.TabIndex = 0;
            this.lbPhieuThu.Text = "PHIẾU THU";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(161, 382);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 53);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(26, 382);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 53);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemPhieuThu
            // 
            this.btnThemPhieuThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDaiLy.ImageOptions.Image")));
            this.btnThemPhieuThu.Location = new System.Drawing.Point(27, 305);
            this.btnThemPhieuThu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuThu.Name = "btnThemPhieuThu";
            this.btnThemPhieuThu.Size = new System.Drawing.Size(257, 53);
            this.btnThemPhieuThu.TabIndex = 21;
            this.btnThemPhieuThu.Text = "Thêm Phiếu Thu";
            this.btnThemPhieuThu.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // dataPhieuThu
            // 
            this.dataPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhieuThu.Location = new System.Drawing.Point(327, 86);
            this.dataPhieuThu.Name = "dataPhieuThu";
            this.dataPhieuThu.Size = new System.Drawing.Size(673, 456);
            this.dataPhieuThu.TabIndex = 1;
            this.dataPhieuThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuThu_CellClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(104, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 20);
            this.txtId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id:";
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 542);
            this.Controls.Add(this.panel1);
            this.Name = "frmPhieuThu";
            this.Text = "frmPhieuThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numSoTien;
        private System.Windows.Forms.DateTimePicker dtpkNgayThu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbDaiLy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPhieuThu;
        private System.Windows.Forms.DataGridView dataPhieuThu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuThu;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
    }
}