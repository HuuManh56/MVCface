namespace sms.GUI
{
    partial class frmHocPhan
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmbTinChi = new System.Windows.Forms.ComboBox();
            this.TxtTenHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.dgvHocPHan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPHan)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbTinChi);
            this.splitContainer1.Panel1.Controls.Add(this.TxtTenHP);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.BtnThem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHocPHan);
            this.splitContainer1.Size = new System.Drawing.Size(864, 291);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmbTinChi
            // 
            this.cmbTinChi.FormattingEnabled = true;
            this.cmbTinChi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbTinChi.Location = new System.Drawing.Point(26, 153);
            this.cmbTinChi.Name = "cmbTinChi";
            this.cmbTinChi.Size = new System.Drawing.Size(121, 24);
            this.cmbTinChi.TabIndex = 3;
            // 
            // TxtTenHP
            // 
            this.TxtTenHP.Location = new System.Drawing.Point(26, 65);
            this.TxtTenHP.Name = "TxtTenHP";
            this.TxtTenHP.Size = new System.Drawing.Size(206, 22);
            this.TxtTenHP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số DVHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên học phần";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(216, 226);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(122, 226);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(26, 226);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 32);
            this.BtnThem.TabIndex = 0;
            this.BtnThem.Text = "Thêm ";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvHocPHan
            // 
            this.dgvHocPHan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPHan.Location = new System.Drawing.Point(0, 0);
            this.dgvHocPHan.Name = "dgvHocPHan";
            this.dgvHocPHan.RowTemplate.Height = 24;
            this.dgvHocPHan.Size = new System.Drawing.Size(520, 291);
            this.dgvHocPHan.TabIndex = 0;
            this.dgvHocPHan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocPHan_CellClick);
            // 
            // frmHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 291);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học phần";
            this.Load += new System.EventHandler(this.frmHocPhan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPHan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmbTinChi;
        private System.Windows.Forms.TextBox TxtTenHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.DataGridView dgvHocPHan;
    }
}