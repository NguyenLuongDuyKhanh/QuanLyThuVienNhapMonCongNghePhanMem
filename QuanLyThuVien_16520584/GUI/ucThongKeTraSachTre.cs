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
    public partial class ucThongKeTraSachTre : UserControl
    {
        BUS_PhieuMuon xldl = new BUS_PhieuMuon();
        DTO_PhieuMuon dl = new DTO_PhieuMuon();
        public ucThongKeTraSachTre()
        {
            InitializeComponent();
        }

        private void UcThongKeTraSachTre_Load(object sender, EventArgs e)
        {
            dtgThongKeSachTre.DataSource = xldl.LoadPhieuMuonTre_Select(dl);
        }
    }
}
