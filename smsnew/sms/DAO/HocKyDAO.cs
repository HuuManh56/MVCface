using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.Entities;

namespace sms.DAO
{
    class HocKyDAO
    {
        private MyDBContext db;
        public HocKyDAO()
        {
            db = new MyDBContext();
        }
        public List<HocKyLQ> GetALL()
        {
            var lst = from a in db.HocKies select new HocKyLQ { id = a.ID, ten= a.TenHocKy };
           
            return lst.ToList() ;
        }
        public List<NamHocLNQ> Getcode()
        {
            var lst = from a in db.NamHocs  select new NamHocLNQ {id=a.ID, code = a.Code };
           
            return lst.ToList();
        }
        //lấy id theo code namhoc
        public int GetIDNamhoc(string code)
        {
            var vd = db.NamHocs.SqlQuery("select * from NamHoc where NamHoc.Code =@code ", new SqlParameter("code", code)).ToList();
            int id = vd[0].ID;
            return id;
        }
        // lay id hoc ky theo ten và theo code nam hoc
        public int GetIDHocKY( string tenhk, string code)
        {
            int id = GetIDNamhoc( code);
            var lst = db.HocKies.SqlQuery("select * from HocKy where TenHocKy =@tenhk and Id_Namhoc=@id  "
                , new SqlParameter("tenhk", tenhk), new SqlParameter ("id",id)).ToList();
            int IDHK = lst[0].ID;
            return IDHK;
        }
        // lấy ra danh sách học kỳ theo năm học

        public List<HocKyLQ> GetByNamHoc(string code)
        {

            int id = GetIDNamhoc(code);
            var lst = (from p in db.HocKies where p.Id_Namhoc == id select new HocKyLQ { id = p.ID, ten = p.TenHocKy }).ToList();
            return lst;
        }

        public int Insert(HocKy hocKy)
        {
            int ret = 0;
            try
            {
                HocKy obj = new HocKy();
                obj.Id_Namhoc = hocKy.Id_Namhoc;
                obj.TenHocKy = hocKy.TenHocKy;
                db.HocKies.Add(obj);
                
                ret = db.Database.ExecuteSqlCommand("EXEC InsertHocKy @param1, @param2",
                    new SqlParameter("param1",hocKy.Id_Namhoc),
                    new SqlParameter("param2", hocKy.TenHocKy));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
                ret = -1;
            }
            return ret;
        }

        public int Delete(HocKy hocKy)
        {
            int ret = 0;
            try
            {
               // db.HocKies.Remove(db.HocKies.Find(hocKy.ID));
               ret = db.Database.ExecuteSqlCommand("EXEC DeleteHocKy @param"
                   , new SqlParameter("param", hocKy.ID));
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn chưa chọn học kỳ cần sửa", "Thông báo");
                ret = -1;
            }
            return ret;
        }

        public int Update(HocKy  nam)
        {
            int ret = 0;
            try
            {
                HocKy hocKy = db.HocKies.Find(nam.ID);
                hocKy.TenHocKy = nam.TenHocKy;
               
                db.SaveChanges();
                ret = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
                ret = -1;
            }
            return ret;
        }


        /////
        public List<HK1> GetTenHK(string code )
        {
            int id = GetIDNamhoc(code);
            return (from p in db.HocKies
                    where p.Id_Namhoc == id
                    select new HK1 { ten = p.TenHocKy }).ToList();
            
        }
    }
}
