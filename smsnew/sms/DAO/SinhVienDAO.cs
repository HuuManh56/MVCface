using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sms.Entities;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Drawing.Charts;
using sms.Entities.ViewModel;

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
                List<SV_LHP> list = db.SV_LHP.Where(x => x.SinhVienID == id).ToList();
                var value = db.SV_LHP.RemoveRange(list);
                List<DiemDanh> list2 = db.DiemDanhs.Where(x => x.SinhVienID == id).ToList();
                var value2 = db.DiemDanhs.RemoveRange(list2);
                db.SinhViens.Remove(sinhVien);
                ret = db.SaveChanges();
            }
            return ret;
        }

        public int DeleteSVLHP(int idLHP, int idSV)
        {
            int ret = 0;
            try
            {
                List<SV_LHP> list = db.SV_LHP.Where(x => x.SinhVienID == idSV && x.LopHocPhanID==idLHP).ToList();
                var value= db.SV_LHP.RemoveRange(list);
                List<DiemDanh> list2 = db.DiemDanhs.Where(x => x.SinhVienID == idSV && x.LopHocPhanID == idLHP).ToList();
                var value2 = db.DiemDanhs.RemoveRange(list2);
                ret = db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return ret;
        }

        public List<SinhVien> GetAll()
        {
            List<SinhVien> list = db.SinhViens.ToList();
            return list;
        }

        public List<SinhVien> GetByClassID2(int id)
        {
            // List<SinhVien> list = new List<SinhVien>();
            var list = db.SinhViens.SqlQuery("Select * from SinhVien where LopID=@param",
                 new SqlParameter("param", id)).ToList();

            return list;
        }


        public SinhVien GetByID(int id)
        {
            return db.SinhViens.Find(id);
        }

        public List<SinhVienLHPVM> GetAllByLHP(int idLHP)

        {
            var lst = from a in db.SV_LHP
                      join b in db.SinhViens on a.SinhVienID equals b.ID
                      join c in db.Lops on b.LopID equals c.ID
                      join d in db.DiemDanhs on b.ID equals d.SinhVienID into gbid
                      where a.LopHocPhanID == idLHP 

                      select new SinhVienLHPVM
                      {
                          ID = b.ID,
                          HoTen = b.HoTen,
                          GioiTinh = (b.GioiTinh == 1 ? "Nam" : "Nữ")
                          ,
                          NgaySinh = (DateTime)b.NgaySinh,
                          Diem1 = (double)a.Diem1
                          ,
                          Diem2 = (double)a.Diem2,
                          Diem3 = (double)a.Diem3,
                          Lop = c.TenLop,
                          SoBuoiNghi = (int)gbid.Sum(x => x.TinhTrang)
                      };
            return lst.ToList();
        }

        public List<SinhVienVM> GetByClassID(int id)
        {
            /* List<SinhVien> list = new List<SinhVien>();
             list =db.SinhViens.SqlQuery("Select * from SinhVien where LopID=@param",
                 new SqlParameter("param", id)).ToList();*/
            var lst = from a in db.SinhViens
                      join b in db.SV_LHP on a.ID equals b.SinhVienID
                      where b.LopHocPhanID == id
                      select new SinhVienVM
                      {
                          ID = a.ID,
                          image = a.image
                          ,
                          NgaySinh = (DateTime)a.NgaySinh
                          ,
                          LopID = (int)a.LopID,
                          GioiTinh = (int)a.GioiTinh
                          ,
                          HoTen = a.HoTen

                      };

            return lst.ToList();
            // return list;
        }
    }
}
