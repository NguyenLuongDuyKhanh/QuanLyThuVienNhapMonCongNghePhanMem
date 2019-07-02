using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmPhieuMuonSach : Form
    {
        BUS_TheDocGia xldl = new BUS_TheDocGia();
        DTO_TheDocGia dl = new DTO_TheDocGia();
        public frmPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPhieuMuonSach_Load(object sender, EventArgs e)
        {
            cboMaDocGia.DataSource = xldl.ChonLoaiDocGia_Select(dl);

        }

        private void CboMaSachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
