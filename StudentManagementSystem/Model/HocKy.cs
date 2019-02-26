using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class HocKy
    {
        private int _id;
        private String _TenHocKy;
        private int _NamBatDau;
        private int _NamKetThuc;
        public HocKy()
        {

        }
        public HocKy(int _id, String _TenHocKy, int _NamBatDau, int _NamKetThuc)
        {
            this._id = _id;
            this._TenHocKy = _TenHocKy;
            this._NamBatDau = _NamBatDau;
            this._NamKetThuc = _NamKetThuc;
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

        public string TenHocKy
        {
            get
            {
                return _TenHocKy;
            }

            set
            {
                _TenHocKy = value;
            }
        }

        public int NamBatDau
        {
            get
            {
                return _NamBatDau;
            }

            set
            {
                _NamBatDau = value;
            }
        }

        public int NamKetThuc
        {
            get
            {
                return _NamKetThuc;
            }

            set
            {
                _NamKetThuc = value;
            }
        }
    }
}
