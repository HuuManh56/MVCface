using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Model
{
    class LopHocPhan
    {
        private string _IDLopHP;
        private String _TenLopHocPhan;
        private string _IDHP;
       
        public LopHocPhan()
        {

        }
        
        public LopHocPhan(string _id, string _IDHP, String _TenLopHocPhan)
        {
            this._IDLopHP = _id;
            this._TenLopHocPhan = _TenLopHocPhan;
            this._IDHP = _IDHP;
        }

        public string IDLopHP
        {
            get
            {
                return _IDLopHP;
            }

            set
            {
                value = _IDLopHP;
            }
        }

        public string TenLopHocPhan
        {
            get
            {
                return _TenLopHocPhan;
            }

            set
            {
                _TenLopHocPhan = value;
            }
        }

        public string IDHocKyHP
        {
            get
            {
                return _IDHP;
            }

            set
            {
                _IDHP = value;
            }
        }

        
    }
}
