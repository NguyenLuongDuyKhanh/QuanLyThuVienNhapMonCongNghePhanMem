using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void BtBack_Click(object sender, EventArgs e)
        {
            pnBangDieuKhien_Show.Hide();
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            pnBangDieuKhien_Show.Show();
        }

        private void BtNTiepNhanSachMoi_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btNTiepNhanSachMoi.Height; pnSlide_R.Height = btNTiepNhanSachMoi.Height;
            pnSlide_L.Top = btNTiepNhanSachMoi.Top; pnSlide_R.Top = btNTiepNhanSachMoi.Top;

           
        }

        private void BtLapThe_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height =  btLapTheDocGia.Height; pnSlide_R.Height = btLapTheDocGia.Height;
            pnSlide_L.Top = btLapTheDocGia.Top; pnSlide_R.Top = btLapTheDocGia.Top;
        }

        private void BtNhanTraSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btNhanTraSach.Height; pnSlide_R.Height = btNhanTraSach.Height;
            pnSlide_L.Top = btNhanTraSach.Top; pnSlide_R.Top = btNhanTraSach.Top;
        }

        private void BtThongKeSachTre_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btThongKeSachTre.Height; pnSlide_R.Height = btThongKeSachTre.Height;
            pnSlide_L.Top = btThongKeSachTre.Top; pnSlide_R.Top = btThongKeSachTre.Top;
        }

        private void BtThongKeSachMuon_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btThongKeSachMuon.Height; pnSlide_R.Height = btThongKeSachMuon.Height;
            pnSlide_L.Top = btThongKeSachMuon.Top; pnSlide_R.Top = btThongKeSachMuon.Top;
        }

        private void BtLapTheDocGia_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btLapTheDocGia.Height; pnSlide_R.Height = btLapTheDocGia.Height;
            pnSlide_L.Top = btLapTheDocGia.Top; pnSlide_R.Top = btLapTheDocGia.Top;

            //frmLapTheDocGia lapTheDocGia = new frmLapTheDocGia();
            //lapTheDocGia.ShowDialog();

            ucLapTheDocGia1.Show();
        }

        private void BtTrangChu_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btTrangChu.Height; pnSlide_R.Height = btTrangChu.Height;
            pnSlide_L.Top = btTrangChu.Top; pnSlide_R.Top = btTrangChu.Top;
        }

        private void BtTraCuuSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btTraCuuSach.Height; pnSlide_R.Height = btTraCuuSach.Height;
            pnSlide_L.Top = btTraCuuSach.Top; pnSlide_R.Top = btTraCuuSach.Top;
        }

        private void BtChoMuonSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btChoMuonSach.Height; pnSlide_R.Height = btChoMuonSach.Height;
            pnSlide_L.Top = btChoMuonSach.Top; pnSlide_R.Top = btChoMuonSach.Top;
        }

        private void BtLapPhieuPhat_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btLapPhieuPhat.Height; pnSlide_R.Height = btLapPhieuPhat.Height;
            pnSlide_L.Top = btLapPhieuPhat.Top; pnSlide_R.Top = btLapPhieuPhat.Top;
        }

        private void FrmHeThong_Load(object sender, EventArgs e)
        {
            ucLapTheDocGia1.Hide();
            lbNgay.Text = DateTime.Now.ToString("dddd,dd/MM/yyyy", new CultureInfo("vi-VN"));
        }

        private void UcLapTheDocGia1_Load(object sender, EventArgs e)
        {

        }
    }
}
