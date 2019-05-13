using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sms.Entities;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sms.DAO
{
    class SinhVienDAO
    {
        private MyDBContext db;

        public SinhVienDAO()
        {
            db = new MyDBContext();
        }

        public int Insert(SinhVien _sinhVien)
        {
            int ret = 0;
            try
            {
                db.SinhViens.Add(_sinhVien);
                ret = db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
            }
            return ret;
        }

        public int Update(SinhVien _sinhVien)
        {
            int ret = 0;
            SinhVien sinhVien = db.SinhViens.Find(_sinhVien.ID);
            if (sinhVien != null)
            {
                sinhVien.HoTen = _sinhVien.HoTen;
                sinhVien.NgaySinh = _sinhVien.NgaySinh;
                sinhVien.GioiTinh = _sinhVien.GioiTinh;
                sinhVien.LopID = _sinhVien.LopID;
                sinhVien.image = _sinhVien.image;
                ret = db.SaveChanges();
            }
            return ret;
        }

        public int Delete(int id)
        {
            int ret = 0;
            SinhVien sinhVien = db.SinhViens.Find(id);
            if (sinhVien != null)
            {
                db.SinhViens.Remove(sinhVien);
                ret = db.SaveChanges();
            }
            return ret;
        }

        public List<SinhVien> GetAll()
        {
            List<SinhVien> list = db.SinhViens.ToList();
            return list;
        }

        public List<SinhVien> GetByClassID(int id)
        {
            List<SinhVien> list = new List<SinhVien>();
            list =db.SinhViens.SqlQuery("Select * from SinhVien where LopID=@param",
                new SqlParameter("param", id)).ToList();
            return list;
        }

        public SinhVien GetByID(int id)
        {
            return db.SinhViens.Find(id);
        }
    }
}
