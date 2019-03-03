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
        public int Kiemtra(string ID)
        {
            if( ID != null && ID.Length>3)
            {
                return 1;
            }
            else
            {
                DialogResult result= MessageBox.Show(" ID không được bỏ trống và ID phải có độ dài bằng 3","thong bao",MessageBoxButtons.OK);
                if(result== DialogResult.OK)
                {
                   
                }
                return -1;
            }
        }
        public LopHocPhan(string _id, string _IDHP, String _TenLopHocPhan)
        {
            int red=Kiemtra(_id);
            if (red > 0)
            {
                this._IDLopHP = _id.ToUpper();
            }
            
            this._TenLopHocPhan = _TenLopHocPhan;
            this._IDHP = _IDHP.ToUpper();
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
