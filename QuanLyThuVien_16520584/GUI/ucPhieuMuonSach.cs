using System;
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
        BUS_PhieuMuon xldl = new BUS_PhieuMuon();
        DTO_PhieuMuon dl = new DTO_PhieuMuon();
        public ucPhieuMuonSach()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ucPhieuMuonSach_Load(object sender, EventArgs e)
        {
            cboMaDocGia.DataSource = xldl.DocGia_Select(dl);
            cboMaDocGia.DisplayMember = "HoTen_DocGia";
            cboMaDocGia.ValueMember = "ID_TheDocGia";

            cboMaSachMuon.DataSource = xldl.Sach_Select(dl);
            cboMaSachMuon.DisplayMember = "Ten_Sach";
            cboMaSachMuon.ValueMember = "ID_Sach";

            dtgPhieuMuonSach.DataSource = xldl.ChonSachMuon_Select(dl);
        }

        private void BTHoanTat_Click(object sender, EventArgs e)
        {
            dl.ID_TheDocGia = Convert.ToInt32(cboMaDocGia.SelectedValue.ToString());
            dl.ID_Sach = Convert.ToInt32(cboMaSachMuon.SelectedValue.ToString());
            dl.Ten_NguoiMuon = Convert.ToString(xldl.NguoiMuon_Select(dl)); //Sao chưa đúng?!
            dl.NgayMuon = Convert.ToDateTime(dpkNgayMuon.Text);
            dl.NgayHenTra = Convert.ToDateTime("23/2/2020");
            dl.Sl_SachMuon = Convert.ToInt32("1");
            dl.GhiChu = Convert.ToString("hahaha");
            dl.TrangThai_PhieuMuon = "";

            xldl.LapPhieuMuon_INSERT(dl);
            dtgPhieuMuonSach.DataSource = xldl.ChonSachMuon_Select(dl);
        }
    }
}
