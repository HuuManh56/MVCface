﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sms.DAO;
using sms.Entities;
namespace sms.GUI
{
    public partial class frmLopHP : Form
    {
        public frmLopHP()
        {
            InitializeComponent();
        }

        private void frmLopHP_Load(object sender, EventArgs e)
        {
            LopHpDAO lopHpDAO = new LopHpDAO();
            dgvLopHP.DataSource = lopHpDAO.GetAll();
           

        }
    }
}
