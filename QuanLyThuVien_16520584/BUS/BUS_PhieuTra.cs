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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BUS_PhieuTra
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_PhieuTra dl = new DTO_PhieuTra();
        public DataTable DocGia_Select(DTO_PhieuTra dl)
        {
            return xl.table_Select("select ID_TheDocGia from PhieuMuonSach");
        }

        public DataTable Sach_Select(DTO_PhieuTra dl)
        {
            return xl.table_Select("select ID_Sach from PhieuMuonSach");
        }

        public DataTable ChonSachMuon_Select(DTO_PhieuTra dl)
        {
            return xl.table_Select("Select     ID_PhieuMuonSach, ID_TheDocGia, ID_Sach, Ten_NguoiMuon, NgayMuon, NgayHenTra, Sl_SachMuon, GhiChu, TrangThai_PhieuMuon from PhieuMuonSach order by ID_PhieuMuonSach desc");
        }
    }
}
