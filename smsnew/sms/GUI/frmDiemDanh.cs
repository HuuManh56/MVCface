using DirectShowLib;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using sms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.DAO;
using System.IO;
using sms.Entities.ViewModel;

namespace sms.GUI
{
    public partial class frmDiemDanh : Form
    {
        private Capture capture;         // camera input
        private bool captureInProcess = false;
        private bool picProcess = false;
        private HaarCascade haar; // detector faces
        private Image<Gray, Byte> objFace;
        Image<Bgr, Byte> ImageFrame;
        Image<Gray, Byte> img;

        //List<SinhVien> listSV = new List<SinhVien>();
        List<Image<Gray, byte>> listImg = new List<Image<Gray, byte>>();
        List<string> listID = new List<string>();
        Image<Bgr, Byte>[] EXFace;
        int FaceNum = 0;
        int stt = 1;
        DsDevice[] multiCam;
        string text;
        int tag;
        //SqlConnection connect;
        //ConnectDB cn = new ConnectDB();
        string sql;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_SIMPLEX, 2d, 0.5d);
        private int idLop;
        List<SinhVienVM> list = new List<SinhVienVM>();

        public frmDiemDanh(int _idLop)
        {
            InitializeComponent();
            loadListCam();
            this.idLop = _idLop;
            loadListSV();
            insertDate(_idLop);
        }

        void loadListSV()
        {
            SinhVienDAO sinhVienDao = new SinhVienDAO();
            list = sinhVienDao.GetByClassID(this.idLop);

            foreach (var item in list)
            {
                listID.Add(item.ID.ToString());
                //  listID.Add(item.HoTen);
                MemoryStream stream = new MemoryStream(item.image);
                img = new Image<Gray, byte>(new Bitmap(stream));
                listImg.Add(img);
            }
        }
        void loadListCam()
        {
            multiCam = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            string name = "";
            int i = 1;
            foreach (DsDevice cam in multiCam)
            {
                name = i + ":" + cam.Name;
                cbCamIndex.Items.Add(name);
            }
        }
        public void ProcessFrame(object sender, EventArgs arg)
        {
            if (!picProcess)
            {
                ImageFrame = capture.QueryFrame();
                imgCamera.Image = ImageFrame;
                RecognitionFace();
            }
        }
        public void RecognitionFace()
        {
            if (ImageFrame != null)
            {
                Image<Gray, Byte> grayFrame = ImageFrame.Convert<Gray, Byte>();
                var faces = grayFrame.DetectHaarCascade(haar, 1.3, 4,
                                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                                new Size(25, 25))[0];   // mang chua cac khuon mat phat hien duoc
                                                        /*
                                                            haar: trained data
                                                            1.1: Scale Increase Rate (1.1,1.2,1.3,1.4) càng nhỏ: phát hiện được nhiều khuôn mặt -> chậm hơn. 
                                                            4:  Minimum Neighbors Threshold 0->4  giá trị cao phát hiện chặt chẽ hơn
                                                            CANNY_PRUNING:  (0)
                                                            new Size(25, 25): size of the smallest face to search for. mặc định 25x25
                                                         */

                int check = 1;
                foreach (var f in faces)
                {

                    check = 0;
                    //  imgTrain.Image = ImageFrame.Copy(f.rect).Convert<Bgr, Byte>().Resize(148,
                    //                                      161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC); // hien thi 1 khuon mat len imgTrain => nhap thong tin
                    objFace = ImageFrame.Copy(f.rect).Convert<Gray, Byte>().Resize(148,
                                                       161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    ImageFrame.Draw(f.rect, new Bgr(Color.Red), 3); // danh dau khuon mat phat hien
                    if (listID.Count != 0)
                    {
                        MCvTermCriteria term = new MCvTermCriteria(listID.Count, 0.001);
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(listImg.ToArray(), listID.ToArray(), ref term);
                        string sv;
                        sv = recognizer.Recognize(objFace);
                        //showInfo(sv);
                        SetInput(findOne(Int32.Parse(sv)));
                        ImageFrame.Draw(sv, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                    }

                }

                if (check == 1)
                {
                    clearInput();
                }
            }

        }

        private void frmDiemDanh_Load(object sender, EventArgs e)
        {
            //haar = new HaarCascade("haarcascade_frontalface_default.xml");
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureInProcess = false;
            if (capture != null)
            {

                capture = null;
            }

            try
            {
                capture = new Capture(cbCamIndex.SelectedIndex);
                Application.Idle += ProcessFrame;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SetInput(SinhVienVM sinhVien)
        {
            if (sinhVien == null)
            {
                return;
            }
            LopDAO lopDao = new LopDAO();
            txtHoTen.Text = sinhVien.HoTen;
            txtLop.Text = lopDao.GetById((int)sinhVien.LopID).TenLop;
            txtNgaySinh.Text = ((DateTime)sinhVien.NgaySinh).ToString("dd/MM/yyyy");
            txtMSV.Text = sinhVien.ID.ToString();
            if (sinhVien.GioiTinh == 1)
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }

        }
        private void clearInput()
        {
            txtHoTen.Text = "";
            //  txtLop.Text ="";
            txtNgaySinh.Text = "";
            radNu.Checked = true;
            radNam.Checked = true;
            txtMSV.Text = "";
            txtLop.Text = "";
        }

        SinhVienVM findOne(int id)
        {
            SinhVienVM sinhVien = new SinhVienVM();
            foreach (var item in list)
            {
                if (item.ID == id)
                {
                    sinhVien = item;
                    LopHpDAO dao = new LopHpDAO();
                    dao.UpdateTT(id, idLop);
                    break;
                }
            }

            return sinhVien;

        }

        private void frmDiemDanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
                capture.Dispose();
        }



        private void insertDate(int _idLop)
        {
            LopHpDAO dao = new LopHpDAO();
            if (dao.isNew(_idLop))
            {
                dao.insertDate(listID, _idLop);
            }
        }

        private void frmDiemDanh_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
                capture.Dispose();
        }
    }

}
