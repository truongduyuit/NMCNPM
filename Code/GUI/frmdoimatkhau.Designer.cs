namespace GUI
{
    partial class frmdoimatkhau
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmnewPass = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btnConfirm.Location = new System.Drawing.Point(159, 408);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(128, 30);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(23, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(23, 182);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(191, 20);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(23, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtNewpass
            // 
            this.txtNewpass.Location = new System.Drawing.Point(23, 261);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.PasswordChar = '*';
            this.txtNewpass.Size = new System.Drawing.Size(191, 20);
            this.txtNewpass.TabIndex = 2;
            this.txtNewpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(23, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // txtConfirmnewPass
            // 
            this.txtConfirmnewPass.Location = new System.Drawing.Point(26, 346);
            this.txtConfirmnewPass.Name = "txtConfirmnewPass";
            this.txtConfirmnewPass.PasswordChar = '*';
            this.txtConfirmnewPass.Size = new System.Drawing.Size(188, 20);
            this.txtConfirmnewPass.TabIndex = 3;
            this.txtConfirmnewPass.UseSystemPasswordChar = true;
            // 
            // btncancel
            // 
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btncancel.Location = new System.Drawing.Point(23, 408);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(128, 30);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên tài khoản";
            // 
            // txtaccount
            // 
            this.txtaccount.Location = new System.Drawing.Point(23, 111);
            this.txtaccount.Name = "txtaccount";
            this.txtaccount.Size = new System.Drawing.Size(191, 20);
            this.txtaccount.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmdoimatkhau
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(299, 450);
            this.Controls.Add(this.txtConfirmnewPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaccount);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmdoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmnewPass;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaccount;
        private System.Windows.Forms.Label label5;
    }
}