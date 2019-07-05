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

namespace GUI
{
    public partial class ucChinhSuaQuyDinh : UserControl
    {
        BUS_QuyDinh xldl = new BUS_QuyDinh();
        DTO_QuyDinh dl = new DTO_QuyDinh();
        public ucChinhSuaQuyDinh()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void UcChinhSuaQuyDinh_Load(object sender, EventArgs e)
        {
            xldl.Load_Select(dl);
            txtTuoiToiThieu.DataBindings.Clear();
            txtTuoiToiDa.DataBindings.Clear();
            txtThoiHanThe.DataBindings.Clear();
            txtNamXuatban.DataBindings.Clear();
            txtSoNgayMuonToiDa.DataBindings.Clear();
            txtSoSachMuonToiDa.DataBindings.Clear();

            txtTuoiToiThieu.DataBindings.Add("Text", xldl.Load_Select(dl), "TuoiToiThieu");
            txtTuoiToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "TuoiToiDa");
            txtThoiHanThe.DataBindings.Add("Text", xldl.Load_Select(dl), "ThoiHanThe");
            txtNamXuatban.DataBindings.Add("Text", xldl.Load_Select(dl), "NamXuatBan");
            txtSoNgayMuonToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "SoSachMuonToiDa");
            txtSoSachMuonToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "SoNgayMuonToiDa");

            dtgTheLoai.DataSource = xldl.dtgLoad_Select(dl);
        }

        private void BtLuu_Click(object sender, EventArgs e)
        {
            if (txtTuoiToiThieuThayDoi.Text == "" || txtTuoiToiDaThayDoi.Text == "" || txtThoiHanTheThayDoi.Text == "" || txtNamXuatBanThayDoi.Text == "" || txtSoNgayMuonToiDaThayDoi.Text == "" || txtSoSachMuonToiDaThayDoi.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(Convert.ToInt32(txtTuoiToiThieuThayDoi.Text) > Convert.ToInt32(txtTuoiToiDaThayDoi.Text))
            {
                MessageBox.Show("Sai giới hạn tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                dl.TuoiToiThieuThayDoi = Convert.ToInt32(txtTuoiToiThieuThayDoi.Text);
                dl.TuoiToiDaThayDoi = Convert.ToInt32(txtTuoiToiDaThayDoi.Text);
                dl.ThoiHanTheThayDoi = Convert.ToInt32(txtThoiHanTheThayDoi.Text);
                dl.NamXuatBanThayDoi = Convert.ToInt32(txtNamXuatBanThayDoi.Text);
                dl.SoSachMuonToiDaThayDoi = Convert.ToInt32(txtSoSachMuonToiDaThayDoi.Text);
                dl.SoNgayMuonToiDaThayDoi = Convert.ToInt32(txtSoNgayMuonToiDaThayDoi.Text);


                xldl.CapNhatThayDoi_INSERT(dl);

                xldl.Load_Select(dl);
                txtTuoiToiThieu.DataBindings.Clear();
                txtTuoiToiDa.DataBindings.Clear();
                txtThoiHanThe.DataBindings.Clear();
                txtNamXuatban.DataBindings.Clear();
                txtSoNgayMuonToiDa.DataBindings.Clear();
                txtSoSachMuonToiDa.DataBindings.Clear();

                txtTuoiToiThieu.DataBindings.Add("Text", xldl.Load_Select(dl), "TuoiToiThieu");
                txtTuoiToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "TuoiToiDa");
                txtThoiHanThe.DataBindings.Add("Text", xldl.Load_Select(dl), "ThoiHanThe");
                txtNamXuatban.DataBindings.Add("Text", xldl.Load_Select(dl), "NamXuatBan");
                txtSoNgayMuonToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "SoNgayMuonToiDa");
                txtSoSachMuonToiDa.DataBindings.Add("Text", xldl.Load_Select(dl), "SoSachMuonToiDa");

            }

        }

        private void DtgTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtThemTheLoai_Click(object sender, EventArgs e)
        {

        }

        private void BtThemTheLoai_Click_1(object sender, EventArgs e)
        {
            if (txtThemTheLoai.Text == "")
            {
                MessageBox.Show("Điền đi rồi mới thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dl.TheLoaiThayDoi = Convert.ToString(txtThemTheLoai.Text);
                xldl.CapNhatTheLe_INSERT(dl);
            }
            dtgTheLoai.DataSource = xldl.dtgLoad_Select(dl);
        }
    }
}
