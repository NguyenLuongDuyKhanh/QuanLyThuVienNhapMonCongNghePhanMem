﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class ucPhieuMuonSach : UserControl
    {
        BUS_TheDocGia xldl = new BUS_TheDocGia();
        DTO_TheDocGia dl = new DTO_TheDocGia();
        public ucPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
