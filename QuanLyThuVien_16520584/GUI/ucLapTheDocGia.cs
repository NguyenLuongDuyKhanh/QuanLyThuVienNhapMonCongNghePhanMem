 /* Author:NguyenLuongDuyKhanh
 * Falcuty of Computer Engineering
 * SE104J23PMCL.1 2nd Semester 2018-2019
 * QuanLythuvien
 */

/******************************************************************************/
/*                                  GUI Layer                                 */
/******************************************************************************/

/*Contant Program.cs (this file)
 *and user controls file for UI 
 */

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
            txtTuoiToiThieu.DataBindings.Clear();
            txtTuoiToiDa.DataBindings.Clear();
            txtThoiHanThe.DataBindings.Clear();

            txtTuoiToiThieu.DataBindings.Add("Text", xldl.LayTuoiToiThieu_Select(dl), "TuoiToiThieu");
            txtTuoiToiDa.DataBindings.Add("Text", xldl.LayTuoiToiThieu_Select(dl), "TuoiToiDa");
            txtThoiHanThe.DataBindings.Add("Text", xldl.LayTuoiToiThieu_Select(dl), "ThoiHanThe");
            dtgTheDocGia.DataSource = xldl.TheDocGia_Select(dl);
        }

        private void BtLuu_Click(object sender, EventArgs e)
        {
            dl.LayThoiHanThe = Convert.ToInt32(txtThoiHanThe.Text);
            DateTime now = DateTime.Today;
            int age = now.Year - Convert.ToDateTime(dtpNgaySinhDocGia.Text).Year;
            if (txtHoVaTen.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtNgayHetHan.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if( age < Convert.ToInt32(txtTuoiToiThieu.Text))
            {
                MessageBox.Show("Nhỏ tuổi quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (age > Convert.ToInt32(txtTuoiToiDa.Text))
            {
                MessageBox.Show("Lớn tuổi quá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
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
            dl.LayThoiHanThe = Convert.ToInt32(txtThoiHanThe.Text);
            txtNgayHetHan.DataBindings.Clear();
            dl.NgayLapThe = Convert.ToDateTime(dtpNgayLapThe.Text);
            txtNgayHetHan.DataBindings.Add("Text", xldl.NgayHetHan_Select(dl), "NgayHetHan");
     
        }
    }
}
