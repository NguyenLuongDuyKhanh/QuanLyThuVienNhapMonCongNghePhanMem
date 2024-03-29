﻿/* Author:NguyenLuongDuyKhanh
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
    public partial class ucTiepNhanSachMoi : UserControl
    {
        BUS_Sach xldl = new BUS_Sach();
        DTO_Sach dl = new DTO_Sach();

        public ucTiepNhanSachMoi()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucTiepNhanSachMoi_Load(object sender, EventArgs e)
        {
            cboTheLoaiSach.DataSource = xldl.ChonTheLoaiSach_Select(dl);
            cboTheLoaiSach.DisplayMember = "Ten_TheLoaiSach";
            cboTheLoaiSach.ValueMember = "ID_TheLoaiSach";

            txtGioiHanXuatBan.DataBindings.Clear();

            txtGioiHanXuatBan.DataBindings.Add("Text", xldl.LayGioiHanXuatBan_Select(dl), "NamXuatBan");

            cboTacGia.DataSource = xldl.ChonTacGiaSach_Select(dl);
            cboTacGia.DisplayMember = "Ten_TacGia";
            cboTacGia.ValueMember = "ID_TacGia";

            dtgSach.DataSource = xldl.Sach_Select(dl);
        }

        private void BtHoanTat_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Today;
            if (now.Year - Convert.ToInt32(txtNamXuatBan.Text)> Convert.ToInt32(txtGioiHanXuatBan.Text))
            {
                MessageBox.Show("Sách quá cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                dl.LayGioiHanXuatBan = Convert.ToInt32(txtGioiHanXuatBan.Text);

                dl.ID_TheLoaiSach = Convert.ToInt32(cboTheLoaiSach.SelectedValue.ToString());
                dl.ID_TacGia = Convert.ToInt32(cboTacGia.SelectedValue.ToString());
                //dl.ID_NXB = txtNhaXuatBan;
                dl.Ten_Sach = txtTenSach.Text;
                dl.Gia = Convert.ToInt32(txtTriGia.Text);
                dl.Sl_Nhap = 0;
                dl.MoTa = txtMoTa.Text;
                dl.NamXuatBan = Convert.ToInt32(txtNamXuatBan.Text);
                dl.NgayNhap = Convert.ToDateTime(dtpNgayNhap.Text);
                dl.TrangThai_Sach = "";
                dl.TrangThai_MuonSach = "";
                xldl.Sach_INSERT(dl);
                dtgSach.DataSource = xldl.Sach_Select(dl);
            }

        }

        private void DtgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
