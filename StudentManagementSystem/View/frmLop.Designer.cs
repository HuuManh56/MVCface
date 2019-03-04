namespace StudentManagementSystem.View
{
    partial class frmLop
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
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLopCN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Khoa = new System.Windows.Forms.Label();
            this.cmbChonKhoa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(135, 99);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(257, 22);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtMaLopCN
            // 
            this.txtMaLopCN.Location = new System.Drawing.Point(135, 56);
            this.txtMaLopCN.Name = "txtMaLopCN";
            this.txtMaLopCN.Size = new System.Drawing.Size(145, 22);
            this.txtMaLopCN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Lớp";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(256, 147);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 34);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(92, 147);
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
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã Lớp CN";
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(27, 19);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(45, 17);
            this.Khoa.TabIndex = 9;
            this.Khoa.Text = "Khóa ";
            // 
            // cmbChonKhoa
            // 
            this.cmbChonKhoa.FormattingEnabled = true;
            this.cmbChonKhoa.Location = new System.Drawing.Point(135, 19);
            this.cmbChonKhoa.Name = "cmbChonKhoa";
            this.cmbChonKhoa.Size = new System.Drawing.Size(121, 24);
            this.cmbChonKhoa.TabIndex = 13;
            this.cmbChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbChonKhoa_SelectedIndexChanged);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 224);
            this.Controls.Add(this.cmbChonKhoa);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLopCN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.Khoa);
            this.Controls.Add(this.label1);
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lớp chuyên ngành";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTenLop;
        public System.Windows.Forms.TextBox txtMaLopCN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.ComboBox cmbChonKhoa;
    }
}