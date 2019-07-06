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

namespace GUI
{
    public partial class ucThongKeMuonSach : UserControl
    {
        BUS_PhieuMuon xldl = new BUS_PhieuMuon();
        DTO_PhieuMuon dl = new DTO_PhieuMuon();
        public ucThongKeMuonSach()
        {
            InitializeComponent();
        }

        private void UcThongKeMuonSach_Load(object sender, EventArgs e)
        {
            cboTheLoai.DataSource = xldl.ChonTheLoaiSach_Select(dl);
            cboTheLoai.DisplayMember = "Ten_TheLoaiSach";
            cboTheLoai.ValueMember = "ID_TheLoaiSach";

            dtgPhieuMuon.DataSource = xldl.LoadPhieuMuon_Select(dl);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void CboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl.LayTheLoaiThongKe =  Convert.ToString (cboTheLoai.Text);
            txtKetQua.DataBindings.Clear();
            txtKetQua.DataBindings.Add("Text", xldl.ShowKetQua_Select(dl), "KetQua");
            dtgPhieuMuon.DataSource = xldl.LoadPhieuMuon_Select(dl);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl.LayNgayMuon = Convert.ToInt32(cboThang.Text);
            txtKetQua.DataBindings.Clear();
            txtKetQua.DataBindings.Add("Text", xldl.ShowKetQua_Select(dl), "KetQua");         
            dtgPhieuMuon.DataSource = xldl.LoadPhieuMuon_Select(dl);
        }
    }
}
