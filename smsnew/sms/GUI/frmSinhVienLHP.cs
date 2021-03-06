﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.DAO;
using sms.Entities;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Globalization;

namespace sms.GUI
{
    public partial class frmSinhVienLHP : Form
    {
        private int idLHP;
        private bool found = false;
        public frmSinhVienLHP()
        {
            InitializeComponent();
        }

        public frmSinhVienLHP(LopHocPhan lopHocPhan)
        {
            InitializeComponent();
            this.Text = "Cập nhật sinh viên lớp học phần - " + lopHocPhan.TenLopHocPhan;
            this.idLHP = lopHocPhan.ID; 
        }

        private void frmSinhVienLHP_Load(object sender, EventArgs e)
        {

        }

        private void txtMSV_TextChanged(object sender, EventArgs e)
        {
            SinhVienDAO dao = new SinhVienDAO();
            int id;
            if (!string.IsNullOrEmpty(txtMSV.Text))
            {
                id = Int32.Parse(txtMSV.Text);
                SinhVien sinhVien = dao.GetByID(id);
                if (sinhVien != null)
                {
                    found = true;
                    LopDAO lopDao = new LopDAO();
                    txtHoTen.Text = sinhVien.HoTen;
                    txtNgaySinh.Text = ((DateTime)sinhVien.NgaySinh).ToString("dd/MM/yyyy");
                    MemoryStream stream = new MemoryStream(sinhVien.image);
                    Image<Gray, byte> img = new Image<Gray, byte>(new Bitmap(stream));
                    imgSV.Image = img;
                    Lop lop = lopDao.GetById((int)sinhVien.LopID);
                    if (lop != null)
                    {
                        txtLop.Text = lop.TenLop;
                    }
                    if (sinhVien.GioiTinh == 1)
                    {
                        radNam.Checked = true;
                    }
                    else
                    {
                        radNu.Checked = true;
                    }
                }
                else
                {
                    ClearInput();
                }
            }
            else
            {
                ClearInput();
            }
             
        }

        private void ClearInput()
        {

            found = false;
            txtHoTen.Text = "";
            txtMSV.Text = "";
            txtLop.Text = "";
            txtNgaySinh.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            imgSV.Image = null;
            txtMSV.Focus();
        }

        private void add(bool isClose)
        {
            int ret;
            if (found)
            {
                SV_LHP svLhp = new SV_LHP();
                svLhp.SinhVienID = Int32.Parse(txtMSV.Text);
                svLhp.LopHocPhanID = this.idLHP;
                svLhp.Diem1 = 0;
                svLhp.Diem2 = 0;
                svLhp.Diem3 = 0;

                

                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC GetDate @idLop"
                    , new object[] { idLHP });

                if (data.Rows.Count!=0)
                {
              //      int nghi = Int32.Parse(data.Rows[0][0].ToString());
                    MyDBContext db = new MyDBContext();

                    for (int i=0; i<data.Rows.Count; i++)
                    {
                        DiemDanh diemDanh = new DiemDanh();
                        diemDanh.SinhVienID = Int32.Parse(txtMSV.Text);
                        diemDanh.LopHocPhanID = this.idLHP;
                        diemDanh.TinhTrang = 1;
                        diemDanh.Ngay = DateTime.Parse((data.Rows[i][0].ToString()), CultureInfo.InvariantCulture);
                        db.DiemDanhs.Add(diemDanh);
                    }
                    
                    
                    ret = db.SaveChanges();
                }
                

                
                SinhVienLHPDAO dao = new SinhVienLHPDAO();
                 ret = dao.Insert(svLhp);
                if (ret>0)
                {
                    if (isClose)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        ClearInput();
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi ghi dữ liệu");
                }
            }
            

        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            add(false);
        }

        private void btnLuuThoat_Click(object sender, EventArgs e)
        {
            add(true);
        }
    }
}
