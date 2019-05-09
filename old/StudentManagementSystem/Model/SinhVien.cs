
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    class SinhVien
    {
        private string _id;
        private string _HoTen;
        private DateTime _NgaySinh;
        private int _GioiTinh; //0-nu, 1-nam
        private string _lopId;
        private Image<Bgr, Byte> _image;
         

        public string Id
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

        public string HoTen
        {
            get
            {
                return _HoTen;
            }

            set
            {
                _HoTen = value;
            }
        }

        public int GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }

        public string LopId
        {
            get
            {
                return _lopId;
            }

            set
            {
                _lopId = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public Image<Bgr, byte> Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public SinhVien()
        {

        }

        public SinhVien(string _id, string _HoTen, DateTime _NgaySinh, int _GioiTinh, string _lopId, Image<Bgr, Byte> _image)
        {
            this._id = _id;
            this._HoTen = _HoTen;
            this._NgaySinh = _NgaySinh;
            this._GioiTinh = _GioiTinh;
            this._lopId = _lopId;
            this._image = _image;
        }
        
    }
}
