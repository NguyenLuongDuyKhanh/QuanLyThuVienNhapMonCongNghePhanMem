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
        }

        private void BtLuu_Click(object sender, EventArgs e)
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
        }
    }
}
