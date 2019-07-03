using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhanQuyen
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_PhanQuyen dl = new DTO_PhanQuyen();
        public DataTable DangNhap_Select(DTO_PhanQuyen dl)
        {
            return xl.table_Select("select* from PhanQuyen");
        }
        public DataTable TaiKhoan_Select(DTO_PhanQuyen dl)
        {
            return xl.table_Select("select distinct TaiKhoan from PhanQuyen");
        }
        public DataTable TK_Check(DTO_PhanQuyen dl)
        {
            return xl.table_Select("select * from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MatKhau='" + dl.MatKhau + "'");
        }
        public DataTable QuanLy_PQ(DTO_PhanQuyen dl)
        {
            return xl.table_Select("select Trang_QuanLy from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MatKhau='" + dl.MatKhau + "'");
        }
        public DataTable NhanVien_PQ(DTO_PhanQuyen dl)
        {
            return xl.table_Select("select Trang_NhanVien from PhanQuyen where TaiKhoan=N'" + dl.TaiKhoan + "' and MatKhau='" + dl.MatKhau + "'");
        }
       
    }
}
