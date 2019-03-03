namespace StudentManagementSystem.View
{
    partial class frmLopHocPhan
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
            this.txtTenLopHP = new System.Windows.Forms.TextBox();
            this.txtMaLopHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChonHocPhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHkNam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTenLopHP
            // 
            this.txtTenLopHP.Location = new System.Drawing.Point(165, 155);
            this.txtTenLopHP.Name = "txtTenLopHP";
            this.txtTenLopHP.ReadOnly = true;
            this.txtTenLopHP.Size = new System.Drawing.Size(225, 22);
            this.txtTenLopHP.TabIndex = 1;
            // 
            // txtMaLopHP
            // 
            this.txtMaLopHP.Location = new System.Drawing.Point(165, 110);
            this.txtMaLopHP.Name = "txtMaLopHP";
            this.txtMaLopHP.Size = new System.Drawing.Size(100, 22);
            this.txtMaLopHP.TabIndex = 0;
            this.txtMaLopHP.TextChanged += new System.EventHandler(this.txtMaLopHP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên lớp học phần";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 220);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 34);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(91, 220);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(93, 34);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã lớp học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Học phần";
            // 
            // cmbChonHocPhan
            // 
            this.cmbChonHocPhan.FormattingEnabled = true;
            this.cmbChonHocPhan.Location = new System.Drawing.Point(165, 56);
            this.cmbChonHocPhan.Name = "cmbChonHocPhan";
            this.cmbChonHocPhan.Size = new System.Drawing.Size(225, 24);
            this.cmbChonHocPhan.TabIndex = 14;
            this.cmbChonHocPhan.SelectedIndexChanged += new System.EventHandler(this.cmbChonHocPhan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Học kỳ được chọn";
            // 
            // txtHkNam
            // 
            this.txtHkNam.Location = new System.Drawing.Point(165, 21);
            this.txtHkNam.Name = "txtHkNam";
            this.txtHkNam.ReadOnly = true;
            this.txtHkNam.Size = new System.Drawing.Size(225, 22);
            this.txtHkNam.TabIndex = 0;
            // 
            // frmLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 275);
            this.Controls.Add(this.cmbChonHocPhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLopHP);
            this.Controls.Add(this.txtHkNam);
            this.Controls.Add(this.txtMaLopHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Name = "frmLopHocPhan";
            this.Text = "Lớp học phần";
            this.Load += new System.EventHandler(this.frmLopHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTenLopHP;
        public System.Windows.Forms.TextBox txtMaLopHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChonHocPhan;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtHkNam;
    }
}