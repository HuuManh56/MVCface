namespace sms.GUI
{
    partial class frmHocKy
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
            this.btnXoaHk = new System.Windows.Forms.Button();
            this.btnSuaHK = new System.Windows.Forms.Button();
            this.btnThem_HK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNamHk = new System.Windows.Forms.ComboBox();
            this.dgvHocKy = new System.Windows.Forms.DataGridView();
            this.txtTenHK = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaHk);
            this.splitContainer1.Panel1.Controls.Add(this.btnSuaHK);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem_HK);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenHK);
            this.splitContainer1.Panel1.Controls.Add(this.cmbNamHk);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHocKy);
            this.splitContainer1.Size = new System.Drawing.Size(890, 268);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnXoaHk
            // 
            this.btnXoaHk.Location = new System.Drawing.Point(242, 192);
            this.btnXoaHk.Name = "btnXoaHk";
            this.btnXoaHk.Size = new System.Drawing.Size(75, 32);
            this.btnXoaHk.TabIndex = 4;
            this.btnXoaHk.Text = "Xóa";
            this.btnXoaHk.UseVisualStyleBackColor = true;
            this.btnXoaHk.Click += new System.EventHandler(this.btnXoaHk_Click);
            // 
            // btnSuaHK
            // 
            this.btnSuaHK.Location = new System.Drawing.Point(136, 192);
            this.btnSuaHK.Name = "btnSuaHK";
            this.btnSuaHK.Size = new System.Drawing.Size(75, 32);
            this.btnSuaHK.TabIndex = 4;
            this.btnSuaHK.Text = "Sửa";
            this.btnSuaHK.UseVisualStyleBackColor = true;
            this.btnSuaHK.Click += new System.EventHandler(this.btnSuaHK_Click);
            // 
            // btnThem_HK
            // 
            this.btnThem_HK.Location = new System.Drawing.Point(32, 192);
            this.btnThem_HK.Name = "btnThem_HK";
            this.btnThem_HK.Size = new System.Drawing.Size(75, 32);
            this.btnThem_HK.TabIndex = 4;
            this.btnThem_HK.Text = "Thêm";
            this.btnThem_HK.UseVisualStyleBackColor = true;
            this.btnThem_HK.Click += new System.EventHandler(this.btnThem_HK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học kỳ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm học";
            // 
            // cmbNamHk
            // 
            this.cmbNamHk.FormattingEnabled = true;
            this.cmbNamHk.Location = new System.Drawing.Point(122, 35);
            this.cmbNamHk.Name = "cmbNamHk";
            this.cmbNamHk.Size = new System.Drawing.Size(195, 24);
            this.cmbNamHk.TabIndex = 0;
            this.cmbNamHk.Text = "Chọn năm học ";
            this.cmbNamHk.SelectedIndexChanged += new System.EventHandler(this.cmbNamHk_SelectedIndexChanged);
            // 
            // dgvHocKy
            // 
            this.dgvHocKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocKy.Location = new System.Drawing.Point(0, 0);
            this.dgvHocKy.Name = "dgvHocKy";
            this.dgvHocKy.RowTemplate.Height = 24;
            this.dgvHocKy.Size = new System.Drawing.Size(525, 268);
            this.dgvHocKy.TabIndex = 0;
            this.dgvHocKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocKy_CellClick);
            // 
            // txtTenHK
            // 
            this.txtTenHK.FormattingEnabled = true;
            this.txtTenHK.Items.AddRange(new object[] {
            "HK1",
            "HK2",
            "HK Hè",
            "HK Tối"});
            this.txtTenHK.Location = new System.Drawing.Point(122, 112);
            this.txtTenHK.Name = "txtTenHK";
            this.txtTenHK.Size = new System.Drawing.Size(100, 24);
            this.txtTenHK.TabIndex = 0;
            this.txtTenHK.SelectedIndexChanged += new System.EventHandler(this.cmbNamHk_SelectedIndexChanged);
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 268);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHocKy";
            this.Text = "frmHocKy";
            this.Load += new System.EventHandler(this.frmHocKy_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocKy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnXoaHk;
        private System.Windows.Forms.Button btnSuaHK;
        private System.Windows.Forms.Button btnThem_HK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNamHk;
        private System.Windows.Forms.DataGridView dgvHocKy;
        private System.Windows.Forms.ComboBox txtTenHK;
    }
}