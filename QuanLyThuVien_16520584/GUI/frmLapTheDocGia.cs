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
    public partial class frmLapTheDocGia : Form
    {
        BUS_TheDocGia xldl = new BUS_TheDocGia();
        DTO_TheDocGia dl = new DTO_TheDocGia();
        public frmLapTheDocGia()
        {
            InitializeComponent();
        }

       

        private void FrmLapTheDocGia_Load(object sender, EventArgs e)
        {
            cboLoaiDocGia.DataSource = xldl.ChonLoaiDocGia_Select(dl);
            cboLoaiDocGia.DisplayMember = "Ten_LoaiDocGia";
            cboLoaiDocGia.ValueMember = "ID_LoaiDocGia";
        }
    }
}
