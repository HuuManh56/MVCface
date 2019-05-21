using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.Entities;
using sms.Entities.ViewModel;

namespace sms.DAO
{
    class NienKhoaDAO
    {
        private MyDBContext db;

        public NienKhoaDAO()
        {
            db = new MyDBContext();
        }

        public int Insert(NienKhoa _nienKhoa)
        {
            int ret = 0;
            try
            {
                db.NienKhoas.Add(_nienKhoa);
                ret = db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
            }
            return ret;
        }

        public int Update(NienKhoa _nienKhoa)
        {
            int ret = 0;
            NienKhoa nienKhoa = db.NienKhoas.Find(_nienKhoa.ID);
            if (nienKhoa != null)
            {
                nienKhoa.IDView = _nienKhoa.IDView;
                nienKhoa.Ten = _nienKhoa.Ten;
                ret = db.SaveChanges();
            }
            return ret;
        }

        public int Delete(int id)
        {
            int ret = 0;
            NienKhoa nienKhoa = db.NienKhoas.Find(id);
            if (nienKhoa != null)
            {
                db.NienKhoas.Remove(nienKhoa);
                ret = db.SaveChanges();
            }
            return ret;
        }

        public List<NienKhoa> GetAll()
        {
            List<NienKhoa> list = db.NienKhoas.ToList();
            return list;
        }

        public NienKhoa GetByID(int id)
        {
            NienKhoa nienKhoa;
            nienKhoa = db.NienKhoas.Find(id);
            return nienKhoa;
        }

        public NienKhoa GetByIDView(string idview)
        {
            NienKhoa nienKhoa;
            var list = db.NienKhoas.SqlQuery("Select * from NienKhoa where IDView =@param"
                , new SqlParameter("param",idview)).ToList();
            return (NienKhoa)list[0];
        }

        public List<NienKhoaVM> GetAll2()
        {
            var lst = from a in db.NienKhoas orderby a.IDView select new NienKhoaVM { id = a.ID,idview = a.IDView,ten = a.Ten };
            
            return lst.ToList();
        }
    }
}
