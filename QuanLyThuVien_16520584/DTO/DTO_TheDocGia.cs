/* Author:NguyenLuongDuyKhanh
* Falcuty of Computer Engineering
* SE104J23PMCL.1 2nd Semester 2018-2019
* QuanLythuvien
*/

/******************************************************************************/
/*                                  DTO Layer                                 */
/******************************************************************************/

/*Contant DTO class:
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

namespace DTO
{
    public class DTO_TheDocGia
    {
        public int ID_LoaiDocGia { get; set; }
        public String Ten_LoaiDocGia { get; set; }
        public String GhiChu_LoaiDocGia { get; set; }
        public String TrangThai_LoaiDocGia { get; set; }
        public int ID_TheDocGia { get; set; }
        public String HoTen_DocGia { get; set; }
        public DateTime NgaySinh_DocGia { get; set; }
        public String DiaChi_DocGia { get; set; }
        public String Email_DocGia { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public String TrangThai_TheDocGia { get; set; }
    }
}
