using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS_PhanQuyen xldl = new BUS_PhanQuyen();
        DTO_PhanQuyen dl = new DTO_PhanQuyen();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            cbTaiKhoan.DataSource = xldl.TaiKhoan_Select(dl);
            cbTaiKhoan.DisplayMember = "TaiKhoan";
            dtgDangNhap.DataSource = xldl.DangNhap_Select(dl);
        }
        public void KiemTra_Quyen()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtTaiKhoan.DataBindings.Add("Text", dtgDangNhap.DataSource, "TaiKhoan");
            txtQuanLy.DataBindings.Clear();
            txtQuanLy.DataBindings.Add("Text", xldl.QuanLy_PQ(dl), "Trang_QuanLy");
            txtNhanVien.DataBindings.Clear();
            txtNhanVien.DataBindings.Add("Text", xldl.NhanVien_PQ(dl), "Trang_NhanVien");
        }
        // Biến phân quyền
        public static Boolean PQ_QuanLy;
        public static Boolean PQ_NhanVien;
        public void DangNhap()
        {
            dl.TaiKhoan = cbTaiKhoan.Text;
            dl.MatKhau = txtMatKhau.Text;
            try
            {
                if (txtMatKhau.Text == "")
                {
                    throw new Exception("Chưa Nhập Mật Khẩu");
                }
                else//nếu txt không trống 
                {
                    dtgDangNhap.DataSource = xldl.TK_Check(dl);// thì hàm Tk_check sẽ kiểm tra dữ liệu ở csdl...
                    if (dtgDangNhap.RowCount == 2)//kiểm tra tồn tại trong dtgDangNhap
                    {
                        KiemTra_Quyen();
                        if (cbTaiKhoan.Text == txtTaiKhoan.Text)//nếu txtTaiKhoản = tài khoản nào đuọc đăng nhập
                        {
                            PQ_QuanLy = Convert.ToBoolean(txtQuanLy.Text);
                            PQ_NhanVien = Convert.ToBoolean(txtNhanVien.Text);
                        }
                        frmHeThong main = new frmHeThong();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void BtDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void CbTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))// bắt lỗi khi nhập kí tự vào combobox TaiKhoan
            {
                MessageBox.Show("Mời Chọn", "Thông Báo", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
