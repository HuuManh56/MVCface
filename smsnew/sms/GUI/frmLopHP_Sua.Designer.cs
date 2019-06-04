namespace sms.GUI
{
    partial class frmLopHP_Sua
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
            this.cmbHP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLopHP = new System.Windows.Forms.TextBox();
            this.txtNamHK = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtMaLopHP = new System.Windows.Forms.TextBox();
            this.lbTenLopHP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbHP
            // 
            this.cmbHP.FormattingEnabled = true;
            this.cmbHP.Location = new System.Drawing.Point(208, 124);
            this.cmbHP.Name = "cmbHP";
            this.cmbHP.Size = new System.Drawing.Size(225, 24);
            this.cmbHP.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Năm học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Học kỳ được chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Học phần";
            // 
            // txtTenLopHP
            // 
            this.txtTenLopHP.Location = new System.Drawing.Point(208, 221);
            this.txtTenLopHP.Name = "txtTenLopHP";
            this.txtTenLopHP.ReadOnly = true;
            this.txtTenLopHP.Size = new System.Drawing.Size(225, 22);
            this.txtTenLopHP.TabIndex = 28;
            // 
            // txtNamHK
            // 
            this.txtNamHK.Location = new System.Drawing.Point(208, 40);
            this.txtNamHK.Name = "txtNamHK";
            this.txtNamHK.ReadOnly = true;
            this.txtNamHK.Size = new System.Drawing.Size(225, 22);
            this.txtNamHK.TabIndex = 25;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(208, 80);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(225, 22);
            this.txtHocKy.TabIndex = 26;
            // 
            // txtMaLopHP
            // 
            this.txtMaLopHP.Location = new System.Drawing.Point(208, 176);
            this.txtMaLopHP.Name = "txtMaLopHP";
            this.txtMaLopHP.Size = new System.Drawing.Size(100, 22);
            this.txtMaLopHP.TabIndex = 27;
            this.txtMaLopHP.TextChanged += new System.EventHandler(this.txtMaLopHP_TextChanged);
            // 
            // lbTenLopHP
            // 
            this.lbTenLopHP.AutoSize = true;
            this.lbTenLopHP.Location = new System.Drawing.Point(56, 224);
            this.lbTenLopHP.Name = "lbTenLopHP";
            this.lbTenLopHP.Size = new System.Drawing.Size(119, 17);
            this.lbTenLopHP.TabIndex = 32;
            this.lbTenLopHP.Text = "Tên lớp học phần";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Mã lớp học phần";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(313, 270);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 34);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(59, 270);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(93, 34);
            this.btnXacNhan.TabIndex = 29;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmLopHP_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 345);
            this.Controls.Add(this.cmbHP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLopHP);
            this.Controls.Add(this.txtNamHK);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtMaLopHP);
            this.Controls.Add(this.lbTenLopHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "frmLopHP_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa lớp học phần";
            this.Load += new System.EventHandler(this.frmLopHP_Sua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTenLopHP;
        public System.Windows.Forms.TextBox txtNamHK;
        public System.Windows.Forms.TextBox txtHocKy;
        public System.Windows.Forms.TextBox txtMaLopHP;
        private System.Windows.Forms.Label lbTenLopHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        public System.Windows.Forms.ComboBox cmbHP;
    }
}