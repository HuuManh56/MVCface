using System;
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
using System.Globalization;

namespace sms.GUI
{
    public partial class frmDiem : Form
    {
        private int idLHP;
        private int idSV;
        List<DiemDanh> list = new List<DiemDanh>();
        MyDBContext db = new MyDBContext();
        public frmDiem()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(txtDiem1.Tag.ToString());
           
            decimal a = 0, b = 0, c = 0;
            a = Convert.ToDecimal(txtDiem1.Text);
            b = Convert.ToDecimal(txtDiem2.Text);
            c = Convert.ToDecimal(txtDiem3.Text);
            if ( (a<0 || a>10) || (b < 0 || b > 10) || (c < 0 || b > 10))
            {
                MessageBox.Show("Nhập điểm sai");
                return;
            }
            else
            {
                MyDBContext db = new MyDBContext();
                SinhVienLHPDAO svDao = new SinhVienLHPDAO();
                LopHpDAO  lopHpDao =new LopHpDAO();
                LopHocPhan hocPhan= new LopHocPhan();

                hocPhan.ID = lopHpDao.IDLopHP(txtDiem2.Tag + "");
                idLHP = hocPhan.ID;
                    int id1=svDao.GetID(id, hocPhan.ID);// id1 la id trong bảng sv_lhp
                SV_LHP sV_LHP=  db.SV_LHP.Find(id1);
                sV_LHP.Diem1 = a;
                sV_LHP.Diem2 = b;
                sV_LHP.Diem3 = c;
                int ret = db.SaveChanges();
            }
            this.Close();
        }

        private void dgvChiTiet_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            string text = this.Text;
            MessageBox.Show("demo"+text);
        }

        private void dgvChiTiet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string txtDay = dgvChiTiet.Rows[e.RowIndex].Cells[0].Value.ToString();
            DateTime day = Convert.ToDateTime(txtDay, new CultureInfo("en-EN")).Date;
            string  text = dgvChiTiet.Rows[e.RowIndex].Cells[1].Value.ToString();

            DiemDanh diemDanh = db.DiemDanhs.Where(x=>x.SinhVienID==idSV && x.LopHocPhanID==idLHP
                                                      && x.Ngay==day).FirstOrDefault();

            if (text.ToUpper() == "NGHỈ")
                diemDanh.TinhTrang = 1;
            else
            {
                diemDanh.TinhTrang = 0;
            }
            int ret = db.SaveChanges();
            if (ret > 0)
            {
                MessageBox.Show("Cập nhật trạng thái thành công");
            }
        }

        private void frmDiem_Activated(object sender, EventArgs e)
        {
            idSV = Int16.Parse(txtDiem1.Tag.ToString());
            LopHpDAO lopHpDao = new LopHpDAO();
            LopHocPhan hocPhan = new LopHocPhan();

            hocPhan.ID = lopHpDao.IDLopHP(txtDiem2.Tag + "");
            idLHP = hocPhan.ID;
        }
    }
}
