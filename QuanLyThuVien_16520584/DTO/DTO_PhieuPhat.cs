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
    class DTO_PhieuPhat
    {
        public int ID_PhieuThu { get; set; }
        public int ID_PhieuTraSach { get; set; }
        public int SoTienThu { get; set; }
        public String Ten_NguoiNopTien { get; set; }
        public int DaThu { get; set; }
        public String TrangThai_PhieuThuTienPhat { get; set; }
}
}
