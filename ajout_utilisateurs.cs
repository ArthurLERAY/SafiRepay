﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFI_Dekstop
{
    public partial class frm_ajoutUser : Form
    {
        public frm_ajoutUser()
        {
            InitializeComponent();
        }

        private void Btn_annulerAjoutUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
