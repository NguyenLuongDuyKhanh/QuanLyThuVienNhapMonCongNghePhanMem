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

            cboTacGia.DataSource = xldl.ChonTacGiaSach_Select(dl);
            cboTacGia.DisplayMember = "Ten_TacGia";
            cboTacGia.ValueMember = "ID_TacGia";

            dtgSach.DataSource = xldl.Sach_Select(dl);
        }

        private void BtHoanTat_Click(object sender, EventArgs e)
        {
            //dl.ID_Sach = Convert.ToInt32(cboLoaiDocGia.SelectedValue.ToString());
        }
    }
}
