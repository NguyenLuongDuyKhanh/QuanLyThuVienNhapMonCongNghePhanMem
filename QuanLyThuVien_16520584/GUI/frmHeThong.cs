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

            ucLapTheDocGia1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucTimSach1.Hide();
            ucTiepNhanSachMoi1.Show();

           
        }

        private void BtLapThe_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height =  btLapTheDocGia.Height; pnSlide_R.Height = btLapTheDocGia.Height;
            pnSlide_L.Top = btLapTheDocGia.Top; pnSlide_R.Top = btLapTheDocGia.Top;

            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucTimSach1.Hide();
            ucLapTheDocGia1.Show();
        }

        private void BtNhanTraSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btNhanTraSach.Height; pnSlide_R.Height = btNhanTraSach.Height;
            pnSlide_L.Top = btNhanTraSach.Top; pnSlide_R.Top = btNhanTraSach.Top;

            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucLapTheDocGia1.Hide();
            ucTimSach1.Hide();
            ucPhieuTraSach1.Show();
        }

        private void BtThongKeSachTre_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btThongKeSachTre.Height; pnSlide_R.Height = btThongKeSachTre.Height;
            pnSlide_L.Top = btThongKeSachTre.Top; pnSlide_R.Top = btThongKeSachTre.Top;

            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucLapTheDocGia1.Hide();
            ucTimSach1.Hide();
            ucThongKeTraSachTre1.Show();
        }

        private void BtThongKeSachMuon_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btThongKeSachMuon.Height; pnSlide_R.Height = btThongKeSachMuon.Height;
            pnSlide_L.Top = btThongKeSachMuon.Top; pnSlide_R.Top = btThongKeSachMuon.Top;

            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucPhieuTraSach1.Hide();
            ucLapTheDocGia1.Hide();
            ucTimSach1.Hide();
            ucThongKeMuonSach1.Show();
        }

        private void BtLapTheDocGia_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btLapTheDocGia.Height; pnSlide_R.Height = btLapTheDocGia.Height;
            pnSlide_L.Top = btLapTheDocGia.Top; pnSlide_R.Top = btLapTheDocGia.Top;

            //frmLapTheDocGia lapTheDocGia = new frmLapTheDocGia();
            //lapTheDocGia.ShowDialog();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucPhieuTraSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucTimSach1.Hide();
            ucLapTheDocGia1.Show();
        }

        private void BtTrangChu_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btTrangChu.Height; pnSlide_R.Height = btTrangChu.Height;
            pnSlide_L.Top = btTrangChu.Top; pnSlide_R.Top = btTrangChu.Top;

            ucLapTheDocGia1.Hide();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucTimSach1.Hide();
        }

        private void BtTraCuuSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btTraCuuSach.Height; pnSlide_R.Height = btTraCuuSach.Height;
            pnSlide_L.Top = btTraCuuSach.Top; pnSlide_R.Top = btTraCuuSach.Top;

            ucLapTheDocGia1.Hide();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucPhieuPhat1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();

            //ucTraCuuSach1.Show();
            ucTimSach1.Show();

        }

        private void BtChoMuonSach_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btChoMuonSach.Height; pnSlide_R.Height = btChoMuonSach.Height;
            pnSlide_L.Top = btChoMuonSach.Top; pnSlide_R.Top = btChoMuonSach.Top;

            ucLapTheDocGia1.Hide();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuPhat1.Hide();
            ucPhieuTraSach1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucTimSach1.Hide();

            ucPhieuMuonSach1.Show();
        }

        private void BtLapPhieuPhat_Click(object sender, EventArgs e)
        {
            pnSlide_L.Height = btLapPhieuPhat.Height; pnSlide_R.Height = btLapPhieuPhat.Height;
            pnSlide_L.Top = btLapPhieuPhat.Top; pnSlide_R.Top = btLapPhieuPhat.Top;
            ucTimSach1.Hide();
            ucLapTheDocGia1.Hide();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();

            ucPhieuPhat1.Show();
        }

        private void FrmHeThong_Load(object sender, EventArgs e)
        {
            ucLapTheDocGia1.Hide();
            ucTiepNhanSachMoi1.Hide();
            ucPhieuMuonSach1.Hide();
            ucPhieuTraSach1.Hide();
            ucPhieuPhat1.Hide();
            ucTraCuuSach1.Hide();
            ucThongKeMuonSach1.Hide();
            ucThongKeTraSachTre1.Hide();
            ucTimSach1.Hide();
            btChinhSua.Visible = frmDangNhap.PQ_QuanLy;
           

            lbNgay.Text = DateTime.Now.ToString("dddd,dd/MM/yyyy", new CultureInfo("vi-VN"));
        }

        private void UcLapTheDocGia1_Load(object sender, EventArgs e)
        {

        }

        private void UcTiepNhanSachMoi1_Load(object sender, EventArgs e)
        {

        }

        private void UcThongKeMuonSach1_Load(object sender, EventArgs e)
        {

        }

        private void FrmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.Show();
            this.Hide();
        }
    }
}
