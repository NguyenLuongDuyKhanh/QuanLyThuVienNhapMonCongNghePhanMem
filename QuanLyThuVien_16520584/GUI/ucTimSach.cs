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
    public partial class ucTimSach : UserControl
    {
        BUS_Sach xldl = new BUS_Sach();
        DTO_Sach dl = new DTO_Sach();
        public ucTimSach()
        {
            InitializeComponent();
        }

        private void UcTimSach_Load(object sender, EventArgs e)
        {
            dtgThongTinSach.DataSource = xldl.AllSach_Select(dl);
        }

        private void BtTim_Click(object sender, EventArgs e)
        {
            if (cbTimTheo.SelectedItem.ToString() == "Tên sách")
            {
                dl.TuKhoa = txtTimTuKhoa.Text;
                dtgThongTinSach.DataSource = xldl.Sach_TenSach_Select(dl);
            }
        }

        private void CbTimTheo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTimTuKhoa_TextChanged(object sender, EventArgs e)
        {
            if (cbTimTheo.SelectedItem.ToString() == "Tên sách")
            {
                dl.TuKhoa = txtTimTuKhoa.Text;
                dtgThongTinSach.DataSource = xldl.Sach_TenSach_Select(dl);
            }
        }
    }
}
