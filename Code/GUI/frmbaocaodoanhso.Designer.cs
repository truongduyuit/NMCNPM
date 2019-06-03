namespace GUI
{
    partial class frmbaocaodoanhso
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
            this.BtnBaoCao = new System.Windows.Forms.Button();
            this.dtpkNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpkNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongdoanhthu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datadoanhthu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadoanhthu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBaoCao
            // 
            this.BtnBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaoCao.Location = new System.Drawing.Point(446, 68);
            this.BtnBaoCao.Name = "BtnBaoCao";
            this.BtnBaoCao.Size = new System.Drawing.Size(75, 26);
            this.BtnBaoCao.TabIndex = 0;
            this.BtnBaoCao.Text = "Báo cáo";
            this.BtnBaoCao.UseVisualStyleBackColor = true;
            this.BtnBaoCao.Click += new System.EventHandler(this.BtnBaoCao_Click);
            // 
            // dtpkNgayBatDau
            // 
            this.dtpkNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayBatDau.Location = new System.Drawing.Point(185, 71);
            this.dtpkNgayBatDau.Name = "dtpkNgayBatDau";
            this.dtpkNgayBatDau.Size = new System.Drawing.Size(180, 20);
            this.dtpkNgayBatDau.TabIndex = 1;
            // 
            // dtpkNgayKetThuc
            // 
            this.dtpkNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpkNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayKetThuc.Location = new System.Drawing.Point(608, 71);
            this.dtpkNgayKetThuc.Name = "dtpkNgayKetThuc";
            this.dtpkNgayKetThuc.Size = new System.Drawing.Size(184, 20);
            this.dtpkNgayKetThuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng doanh thu :";
            // 
            // txttongdoanhthu
            // 
            this.txttongdoanhthu.Location = new System.Drawing.Point(293, 28);
            this.txttongdoanhthu.Name = "txttongdoanhthu";
            this.txttongdoanhthu.Size = new System.Drawing.Size(149, 20);
            this.txttongdoanhthu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBaoCao);
            this.panel2.Controls.Add(this.dtpkNgayBatDau);
            this.panel2.Controls.Add(this.dtpkNgayKetThuc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 100);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txttongdoanhthu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 90);
            this.panel3.TabIndex = 12;
            // 
            // datadoanhthu
            // 
            this.datadoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datadoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datadoanhthu.Location = new System.Drawing.Point(0, 0);
            this.datadoanhthu.Name = "datadoanhthu";
            this.datadoanhthu.Size = new System.Drawing.Size(967, 358);
            this.datadoanhthu.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datadoanhthu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 358);
            this.panel1.TabIndex = 14;
            // 
            // frmbaocaodoanhso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmbaocaodoanhso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmbaocaodoanhso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadoanhthu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBaoCao;
        private System.Windows.Forms.DateTimePicker dtpkNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpkNgayKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttongdoanhthu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datadoanhthu;
        private System.Windows.Forms.Panel panel1;
    }
}