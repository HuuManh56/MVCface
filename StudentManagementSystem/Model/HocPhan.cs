using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class HocPhan
    {
        private string _IDHocPhan;
        private string _TenHocPhan;
        private string _IDHocKy;
        private int _SoTC;
        public HocPhan()
        {

        }

        public HocPhan(string IdHP, String TenHocPhan, int SoTC, string IDHocky)
        {
            
            this._IDHocPhan = IdHP;
            this._TenHocPhan = TenHocPhan.ToUpper();
            this._SoTC = SoTC;
            this._IDHocKy = IDHocky;
        }
        public string IDHocPhan
        {
            get
            {
                
                return _IDHocPhan;
            }
            set
            {
                string a = _IDHocPhan.ToUpper();
                value = a ;
            }

        }
        public string IDHocKy
        {
            get
            {
                return _IDHocKy;
            }
            set
            {
                value = _IDHocKy;
            }

        }
        public string TenHocPhan
        {
            get
            {
                return _TenHocPhan;
            }
            set
            {
                value = _TenHocPhan;
            }

        }
        public int SoTC
        {
            get
            {
                return _SoTC;
            }
            set
            {
                value = _SoTC;
            }

        }

    }
}
