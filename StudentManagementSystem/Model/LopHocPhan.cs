using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class LopHocPhan
    {
        private int _id;
        private String _TenLopHocPhan;
        private int _HocPhan_HocKyID;
        private String _CodeView;
        public LopHocPhan()
        {

        }
        public LopHocPhan(int _id, String _TenLopHocPhan, int _HocPhan_HocKyID,String _CodeView)
        {
            this._id = _id;
            this._TenLopHocPhan = _TenLopHocPhan;
            this._HocPhan_HocKyID = _HocPhan_HocKyID;
            this._CodeView = _CodeView;
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
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

        public int HocPhan_HocKyID
        {
            get
            {
                return _HocPhan_HocKyID;
            }

            set
            {
                _HocPhan_HocKyID = value;
            }
        }

        public string CodeView
        {
            get
            {
                return _CodeView;
            }

            set
            {
                _CodeView = value;
            }
        }
    }
}
