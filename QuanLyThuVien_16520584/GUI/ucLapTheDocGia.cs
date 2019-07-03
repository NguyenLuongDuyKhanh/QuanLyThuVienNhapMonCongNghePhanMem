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
    public partial class ucLapTheDocGia : UserControl
    {
        BUS_TheDocGia xldl = new BUS_TheDocGia();
        DTO_TheDocGia dl = new DTO_TheDocGia();
        public ucLapTheDocGia()
        {
            InitializeComponent();
        }

        private void UcLapTheDocGia_Load(object sender, EventArgs e)
        {
            cboLoaiDocGia.DataSource = xldl.ChonLoaiDocGia_Select(dl);
            cboLoaiDocGia.DisplayMember = "Ten_LoaiDocGia";
            cboLoaiDocGia.ValueMember = "ID_LoaiDocGia";

            dtgTheDocGia.DataSource = xldl.TheDocGia_Select(dl);
        }

        private void BtLuu_Click(object sender, EventArgs e)
        {
            if (txtHoVaTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtNgayHetHan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dl.ID_LoaiDocGia = Convert.ToInt32(cboLoaiDocGia.SelectedValue.ToString());
                dl.HoTen_DocGia = txtHoVaTen.Text;
                dl.NgaySinh_DocGia = Convert.ToDateTime(dtpNgaySinhDocGia.Text);
                dl.DiaChi_DocGia = txtDiaChi.Text;
                dl.Email_DocGia = txtEmail.Text;
                dl.NgayLapThe = Convert.ToDateTime(dtpNgayLapThe.Text);
                dl.NgayHetHan = Convert.ToDateTime(txtNgayHetHan.Text);

                dl.TrangThai_TheDocGia = "";
                xldl.LapTheDocGia_INSERT(dl);
                dtgTheDocGia.DataSource = xldl.TheDocGia_Select(dl);
            }
            

        }

        private void DtpNgayLapThe_ValueChanged(object sender, EventArgs e)
        {

            txtNgayHetHan.DataBindings.Clear();
            dl.NgayLapThe = Convert.ToDateTime(dtpNgayLapThe.Text);
            txtNgayHetHan.DataBindings.Add("Text", xldl.NgayHetHan_Select(dl), "NgayHetHan");
     
        }
    }
}
