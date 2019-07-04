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
    public partial class ucPhieuTraSach : UserControl
    {
        BUS_PhieuTra xldl = new BUS_PhieuTra();
        DTO_PhieuTra dl = new DTO_PhieuTra();
        public ucPhieuTraSach()
        {
            InitializeComponent();
        }

        private void UcPhieuTraSach_Load(object sender, EventArgs e)
        {
            cboDocgia.DataSource = xldl.DocGia_Select(dl);
            cboDocgia.DisplayMember = "ID_TheDocGia";
            cboDocgia.ValueMember = "ID_TheDocGia";

            cboSachtra.DataSource = xldl.Sach_Select(dl);
            cboSachtra.DisplayMember = "ID_Sach";
            cboSachtra.ValueMember = "ID_Sach";

            dtgPhieuTra.DataSource = xldl.ChonSachMuon_Select(dl);
        }
    }
}
