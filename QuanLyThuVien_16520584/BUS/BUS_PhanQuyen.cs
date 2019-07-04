/* Author:NguyenLuongDuyKhanh
* Falcuty of Computer Engineering
* SE104J23PMCL.1 2nd Semester 2018-2019
* QuanLythuvien
*/

/******************************************************************************/
/*                                  BUS Layer                                 */
/******************************************************************************/

/*Contant BUS class:
 * PhanQuyen        for sign in function
 * PhieuMuon        for Lap phieu muon sach function
 * PhieuPhat        for Lap phieu phat function
 * PhieuTraSach     for Lap phieu tra function
 * Sach             for Tiep nhan, ttra cuu, function
 * TheDocGia        for lap the doc gia function
 *
 */
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
