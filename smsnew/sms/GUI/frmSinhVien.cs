using DirectShowLib;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.DAO;
using sms.Entities;
using System.Globalization;

namespace sms.GUI
{
    public partial class frmSinhVien : Form
    {
        private Capture capture;         // camera input
        private bool captureInProcess = false;
        private bool picProcess = false;
        private HaarCascade haar; // detector faces
        private Image<Gray, Byte> objFace;
        Image<Bgr, Byte> ImageFrame;
        //List<SinhVien> listSV = new List<SinhVien>();
        List<Image<Gray, byte>> listImg = new List<Image<Gray, byte>>();
        Image<Bgr, Byte>[] EXFace;
        int FaceNum = 0;
        int stt = 1;
        DsDevice[] multiCam;
        string text;
        private int id = -1, idLop;
        public frmSinhVien()
        {
            InitializeComponent();
            loadListCam();
        }
        public frmSinhVien(int idLop)
        {
            InitializeComponent();
            loadListCam();
            this.idLop = idLop;
            LopDAO lopDao = new LopDAO();
            Lop lop = lopDao.GetById(idLop);
            if (lop != null)
                txtLop.Text = lop.TenLop;

        }

        public frmSinhVien(SinhVien _sinhVien)
        {
            LopDAO lopDao = new LopDAO();
            InitializeComponent();
            loadListCam();
            id = _sinhVien.ID;
            idLop = (int)_sinhVien.LopID;
            txtHoTen.Text = _sinhVien.HoTen;
            Lop lop = lopDao.GetById((int)_sinhVien.LopID);
            txtLop.Text = lop.TenLop;
            txtNgaySinh.Text = ((DateTime)_sinhVien.NgaySinh).ToString("dd/MM/yyyy"); ;
            MemoryStream stream = new MemoryStream(_sinhVien.image);
            Image<Gray, byte> img = new Image<Gray, byte>(new Bitmap(stream));
            imgTrain.Image = img;
            if (_sinhVien.GioiTinh == 1)
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
            id = -1;
            captureInProcess = false;
        }

        public void loadListCam()
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
                DetectFaces_cam();
            }

        }
        private void DetectFaces_cam()
        {
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
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


                if (faces.Length != 0)
                {

                    //btnChup.Enabled = true;
                    //if (captureInProcess == true)
                    //    btnChup.Enabled = false;
                    // captureInProcess = false;

                    //  if(face.rect!=null)
                    if ((captureInProcess == false))
                    {
                        imgTrain.Image = ImageFrame.Copy(faces[0].rect).Convert<Bgr, Byte>().Resize(148,
                                                        161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC); // hien thi 1 khuon mat len imgTrain => nhap thong tin
                        objFace = ImageFrame.Copy(faces[0].rect).Convert<Gray, Byte>().Resize(148,
                                                                161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        captureInProcess = true;
                    }
                    ImageFrame.Draw(faces[0].rect, new Bgr(Color.Red), 3); // danh dau khuon mat phat hien

                    //nhap(objFace);
                }
                else
                {
                    if (captureInProcess == false)
                    {
                        imgTrain.Image = null;
                        // btnChup.Enabled = false;
                    }
                }
            }


        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //  btnChup.Enabled = true;
            picProcess = false;
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

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            //haar = new HaarCascade("haarcascade_frontalface_default.xml");
            haar = new HaarCascade("haarcascade_frontalface_alt_tree.xml");
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            ofdMoFile.ShowDialog();
            string file = ofdMoFile.FileName;
            try
            {
                Image imgInput = Image.FromFile(ofdMoFile.FileName);
                ImageFrame = new Image<Bgr, byte>(new Bitmap(imgInput));
                imgCamera.Image = ImageFrame;
                DetectFaces_pic();
            }

            catch (Exception ex)
            {
                // to do some thing
            }
        }

        public void DetectFaces_pic()
        {
            picProcess = true;
            //   btnChup.Enabled = false;
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


                if (faces.Length > 0)
                {
                    MessageBox.Show("Số khuôn mặt được phát hiện: " + faces.Length);


                    EXFace = new Image<Bgr, Byte>[faces.Length];
                    int i = 0;
                    foreach (var face in faces)
                    {
                        EXFace[i] = ImageFrame.Copy(face.rect).Convert<Bgr, Byte>().Resize(148,
                               161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        i++;
                        ImageFrame.Draw(face.rect, new Bgr(Color.Blue), 3); // danh dau khuon mat phat hien
                    }
                    imgCamera.Image = ImageFrame;

                    imgTrain.Image = EXFace[FaceNum];
                    objFace = EXFace[FaceNum].Convert<Gray, Byte>();
                    // FaceNum++;
                    if ((faces.Length > 1))
                    {
                        btnNext.Enabled = true;
                        btnPrev.Enabled = false;
                    }
                    else
                    {
                        btnNext.Enabled = false;
                        btnPrev.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Không có khuôn mặt!");
                }

                /*   ImageFrame.Draw(faces[0].rect, new Bgr(Color.Red), 3);
                   imgTrain.Image = ImageFrame.Copy(faces[0].rect).Convert<Bgr, Byte>().Resize(148,
                                                                 161, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);*/

                txtHoTen.Focus();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            if (FaceNum > 0)
            {
                FaceNum--;
                imgTrain.Image = EXFace[FaceNum];
            }
            else
            {
                btnPrev.Enabled = false;
            }
            if (FaceNum == 0)
                btnPrev.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;
            if (FaceNum < EXFace.Length - 1)
            {
                FaceNum++;
                imgTrain.Image = EXFace[FaceNum];
            }
            if (FaceNum == EXFace.Length - 1)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnChup_Click(object sender, EventArgs e)
        {
            captureInProcess = true;
            txtHoTen.Focus();
            //   btnChup.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            captureInProcess = false;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuTiepTuc_Click(object sender, EventArgs e)
        {
            add(false);
        }

        private void add(bool isClose)
        {
            if (imgTrain == null)
            {
                MessageBox.Show("Chưa có hình ảnh", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Chưa nhận Họ và tên", "Thông báo");
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNgaySinh.Text))
            {
                MessageBox.Show("Chưa nhập ngày sinh", "Thông báo");
                txtNgaySinh.Focus();
                return;
            }

            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính", "Thông báo");
                return;
            }


            MemoryStream stream = new MemoryStream();
            int width1 = Convert.ToInt32(imgTrain.Width);
            int height1 = Convert.ToInt32(imgTrain.Height);
            int width = 148;
            int height = 161;
            Bitmap bmp = new Bitmap(width, height);
            imgTrain.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
            bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();

            SinhVienDAO sinhVienDao = new SinhVienDAO();
            SinhVien sinhVien = new SinhVien();
            try
            {
                sinhVien.NgaySinh = Convert.ToDateTime(txtNgaySinh.Text, new CultureInfo("vi-VN")).Date;

            }
            catch
            {
                MessageBox.Show("Ngày sinh không đúng định dạng", "Thông báo");
                return;
            }

            sinhVien.HoTen = txtHoTen.Text;
            sinhVien.GioiTinh = (radNu.Checked == true) ? 0 : 1;
            sinhVien.LopID = this.idLop;
            sinhVien.image = pic;
            int ret = 0;
            if (id == -1)
            {
                ret = sinhVienDao.Insert(sinhVien);
            }
            else
            {
                sinhVien.ID = this.id;
                ret = sinhVienDao.Update(sinhVien);
            }

            if (ret <= 0)
            {
                MessageBox.Show("Không thể lưu dữ liệu", "Thông báo");
            }

            if (isClose)
            {
                this.Dispose();
            }
            else
            {
                clearInput();
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void btnLuuThoat_Click(object sender, EventArgs e)
        {
            add(true);
        }

        private void frmSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (capture != null)
                capture.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (capture != null)
                capture.Dispose();
            this.Dispose();
        }

        private void txtNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
