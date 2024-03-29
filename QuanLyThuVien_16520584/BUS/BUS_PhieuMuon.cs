﻿/* Author:NguyenLuongDuyKhanh
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
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuMuon
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_PhieuMuon dl = new DTO_PhieuMuon();
        public DataTable DocGia_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select ID_TheDocGia,HoTen_DocGia from TheDocGia where TrangThai_TheDocGia =''");
        }

        public DataTable Sach_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select ID_Sach,Ten_Sach from Sach where TrangThai_MuonSach =N''");
        }

        public DataTable ChonSachMuon_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("Select 	ID_PhieuMuonSach,ID_TheDocGia,ID_Sach,NgayMuon,NgayHenTra,GhiChu,TrangThai_PhieuMuon from PhieuMuonSach  order by ID_PhieuMuonSach desc");
        }

        public DataTable NguoiMuon_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("Select 	HoTen_DocGia from TheDocGia where ID_TheDocGia="+dl.ID_TheDocGia+"");
        }

        public void LapPhieuMuon_INSERT(DTO_PhieuMuon dl)
        {
            xl.table_Command("set dateformat dmy Insert into PhieuMuonSach Values ('" + dl.ID_TheDocGia + "',N'" + dl.ID_Sach + "','" + dl.Ten_NguoiMuon + "','" + dl.NgayMuon + "','" + dl.NgayHenTra + "','" + dl.Sl_SachMuon + "','" + dl.GhiChu + "','" + dl.TrangThai_PhieuMuon + "')");


        }

        public DataTable LoadPhieuMuon_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select ID_PhieuMuonSach, HoTen_DocGia,Ten_Sach,Ten_TheLoaiSach,CONVERT(varchar(20),NgayMuon,103) as NgayMuon,GhiChu,TrangThai_PhieuMuon from PhieuMuonSach,TheDocGia,Sach,TheLoaiSach where PhieuMuonSach.ID_TheDocGia=TheDocGia.ID_TheDocGia and Sach.ID_Sach = PhieuMuonSach.ID_Sach and Sach.ID_TheLoaiSach = TheLoaiSach.ID_TheLoaiSach and Ten_TheLoaiSach=N'"+ dl.LayTheLoaiThongKe + "' and DAY(NgayMuon) = "+dl.LayNgayMuon+"");
        }
        public DataTable LoadPhieuMuonTre_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select ID_PhieuMuonSach, HoTen_DocGia, Ten_Sach, Ten_TheLoaiSach, CONVERT(varchar(20), NgayMuon, 103) as NgayMuon,GhiChu,TrangThai_PhieuMuon from PhieuMuonSach,TheDocGia,Sach,TheLoaiSach where PhieuMuonSach.ID_TheDocGia = TheDocGia.ID_TheDocGia and Sach.ID_Sach = PhieuMuonSach.ID_Sach and Sach.ID_TheLoaiSach = TheLoaiSach.ID_TheLoaiSach and TrangThai_PhieuMuon = N'Quá hạn' and NgayMuon ='"+dl.LayNgayThongKe+"'");// and NgayMuon =N'03/07/2019'
        }

        public DataTable ChonTheLoaiSach_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select ID_TheLoaiSach,Ten_TheLoaiSach from TheLoaiSach");
        }

        public DataTable ShowKetQua_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select count(ID_PhieuMuonSach) as KetQua from PhieuMuonSach, TheDocGia, Sach, TheLoaiSach where PhieuMuonSach.ID_TheDocGia = TheDocGia.ID_TheDocGia and Sach.ID_Sach = PhieuMuonSach.ID_Sach and Sach.ID_TheLoaiSach = TheLoaiSach.ID_TheLoaiSach and Ten_TheLoaiSach=N'" + dl.LayTheLoaiThongKe + "' and DAY(NgayMuon) = " + dl.LayNgayMuon + "");
        }

        public DataTable CapNhatQuaHan_Select(DTO_PhieuMuon dl)
        {
            return xl.table_Select("select count(ID_PhieuMuonSach) as KetQua from PhieuMuonSach where ID_TheDocGia ="+dl.ID_TheDocGia+"");
        }

        public void CapNhatDocGia_INSERT(DTO_PhieuMuon dl)
        {
            xl.table_Command("UPDATE TheDocGia SET TrangThai_TheDocGia = N'Quá giới hạn' WHERE ID_TheDocGia = "+dl.ID_TheDocGia+"");


        }
        public void CapNhatSach_INSERT(DTO_PhieuMuon dl)
        {
            xl.table_Command("UPDATE Sach SET TrangThai_MuonSach = N'Đã được mượn' WHERE ID_Sach = " + dl.ID_Sach + "");


        }
    }
}
