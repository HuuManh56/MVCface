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
            this._IDHocKy = "";
            this._IDHocPhan = "";
            this.TenHocPhan = "";
            this.SoTC = 0;

        }
        public HocPhan(string IdHP)
        {
            this._IDHocPhan = IdHP;
        }

        public HocPhan(string IdHP, String TenHocPhan, int SoTC, string IDHocky)
        {
            
            this._IDHocPhan = IdHP.ToUpper();
            this._TenHocPhan = TenHocPhan;
            this._SoTC = SoTC;
            this._IDHocKy = IDHocky.ToUpper();
        }
        public string IDHocPhan
        {
            get
            {
                
                return _IDHocPhan;
            }
            set
            {
                
                value = _IDHocPhan;
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
