namespace StudentManagementSystem.View
{
    partial class frmHocPhan_Update
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.txtIDHp = new System.Windows.Forms.TextBox();
            this.txtTenHP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTC1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Học kỳ / Năm học";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(200, 33);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.ReadOnly = true;
            this.txtHocKy.Size = new System.Drawing.Size(147, 22);
            this.txtHocKy.TabIndex = 9;
            // 
            // txtIDHp
            // 
            this.txtIDHp.Location = new System.Drawing.Point(200, 82);
            this.txtIDHp.Name = "txtIDHp";
            this.txtIDHp.ReadOnly = true;
            this.txtIDHp.Size = new System.Drawing.Size(119, 22);
            this.txtIDHp.TabIndex = 11;
            // 
            // txtTenHP1
            // 
            this.txtTenHP1.Location = new System.Drawing.Point(200, 124);
            this.txtTenHP1.Name = "txtTenHP1";
            this.txtTenHP1.Size = new System.Drawing.Size(216, 22);
            this.txtTenHP1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên học Phần";
            // 
            // txtSoTC1
            // 
            this.txtSoTC1.Location = new System.Drawing.Point(200, 166);
            this.txtSoTC1.Name = "txtSoTC1";
            this.txtSoTC1.Size = new System.Drawing.Size(53, 22);
            this.txtSoTC1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số tín chỉ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmHocPhan_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.txtIDHp);
            this.Controls.Add(this.txtTenHP1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoTC1);
            this.Controls.Add(this.label3);
            this.Name = "frmHocPhan_Update";
            this.Text = "HocPhan_Update";
            this.Load += new System.EventHandler(this.frmHocPhan_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtHocKy;
        public System.Windows.Forms.TextBox txtIDHp;
        public System.Windows.Forms.TextBox txtTenHP1;
        public System.Windows.Forms.TextBox txtSoTC1;
    }
}