using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sms.Entities;
using System.Windows.Forms;

namespace sms.DAO
{
    class LopDAO
    {
        private MyDBContext db;

        public LopDAO()
        {
            db= new MyDBContext();
        }

        public int Insert(Lop _lop)
        {
            int ret = 0;
            try
            {
                db.Lops.Add(_lop);
                ret = db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
            }
            return ret;
        }

        public int Update(Lop _lop)
        {
            int ret = 0;
            Lop lop = db.Lops.Find(_lop.ID);
            if (lop != null)
            {
                lop.IDView = _lop.IDView;
                lop.TenLop = _lop.TenLop;
                ret = db.SaveChanges();
            }
            return ret;
        }

        public int Delete(int id)
        {
            int ret = 0;
            Lop lop = db.Lops.Find(id);
            if (lop != null)
            {
                db.Lops.Remove(lop);
                ret = db.SaveChanges();
            }
            return ret;
        }

        public List<Lop> GetAll()
        {
            List<Lop> list = db.Lops.ToList();
            return list;
        }

        public Lop GetById(int id)
        {
            Lop lop = db.Lops.Find(id);
            return lop;

        }
        public List<Lop> GetByNienKhoa(int NienKhoaId)
        {
            List<Lop> list = db.Lops.SqlQuery("SELECT * FROM Lop WHERE NienKhoaID = @param",new  SqlParameter("param",NienKhoaId)).ToList();
            return list;
        }
    }
}
