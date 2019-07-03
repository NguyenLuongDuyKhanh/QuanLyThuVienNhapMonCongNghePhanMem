using DAO;
using DTO;
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
    public class BUS_Sach
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_Sach dl = new DTO_Sach();

        public DataTable ChonTheLoaiSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select ID_TheLoaiSach,Ten_TheLoaiSach from TheLoaiSach");
        }

        public DataTable ChonTacGiaSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select ID_TacGia,Ten_TacGia from TacGia");
        }

        public DataTable Sach_Select(DTO_Sach dl)
        {
            return xl.table_Select(" select ID_Sach,Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,Sl_Nhap,MoTa,NamXuatBan from Sach,TacGia,TheLoaiSach,NhaXuatBan where Sach.ID_TacGia = TacGia.ID_TacGia and Sach.ID_TheLoaiSach=TheLoaiSach.ID_TheLoaiSach and Sach.ID_NXB = NhaXuatBan.ID_NXB order by ID_Sach desc");
        }

        public void Sach_INSERT(DTO_Sach dl)
        {
            xl.table_Command("set dateformat dmy Insert into Sach Values ('" + dl.ID_TheLoaiSach + "',N'" + dl.ID_TacGia + "',1,'" + dl.Ten_Sach + "','" + dl.Gia + "','" + dl.Sl_Nhap + "','" + dl.MoTa + "','" + dl.NamXuatBan + "','" + dl.NgayNhap + "','" + dl.TrangThai_Sach + "','" + dl.TrangThai_MuonSach + "')");
        }
        ////////////////// Luận
        public DataTable AllSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,NamXuatBan,CONVERT(varchar(20),NgayNhap,103) as NgayNhap, TrangThai_MuonSach from TheLoaiSach, TacGia, NhaXuatBan, Sach  where TheLoaiSach.ID_TheLoaiSach = Sach.ID_TheLoaiSach and TacGia.ID_TacGia = Sach.ID_TacGia and NhaXuatBan.ID_NXB = Sach.ID_NXB and TrangThai_Sach = N''");
        }
        public DataTable Sach_TenTheLoai_Select(DTO_Sach dl)
        {
            return xl.table_Select("select Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,NamXuatBan,CONVERT(varchar(20),NgayNhap,103) as NgayNhap, TrangThai_MuonSach from TheLoaiSach, TacGia, NhaXuatBan, Sach  where TheLoaiSach.ID_TheLoaiSach = Sach.ID_TheLoaiSach and TacGia.ID_TacGia = Sach.ID_TacGia and NhaXuatBan.ID_NXB = Sach.ID_NXB and TrangThai_Sach = N'' and Ten_TheLoaiSach like  N'%"+dl.TuKhoa+"%'");
        }
        public DataTable Sach_TenSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,NamXuatBan,CONVERT(varchar(20),NgayNhap,103) as NgayNhap, TrangThai_MuonSach from TheLoaiSach, TacGia, NhaXuatBan, Sach  where TheLoaiSach.ID_TheLoaiSach = Sach.ID_TheLoaiSach and TacGia.ID_TacGia = Sach.ID_TacGia and NhaXuatBan.ID_NXB = Sach.ID_NXB and TrangThai_Sach = N'' and Ten_Sach like  N'%" + dl.TuKhoa + "%'");
        }
        public DataTable Sach_TenTacGia_Select(DTO_Sach dl)
        {
            return xl.table_Select("select Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,NamXuatBan,CONVERT(varchar(20),NgayNhap,103) as NgayNhap, TrangThai_MuonSach from TheLoaiSach, TacGia, NhaXuatBan, Sach  where TheLoaiSach.ID_TheLoaiSach = Sach.ID_TheLoaiSach and TacGia.ID_TacGia = Sach.ID_TacGia and NhaXuatBan.ID_NXB = Sach.ID_NXB and TrangThai_Sach = N'' and Ten_TacGia like  N'%" + dl.TuKhoa + "%'");
        }
        public DataTable Sach_TenNhaXuatBan_Select(DTO_Sach dl)
        {
            return xl.table_Select("select Ten_TheLoaiSach,Ten_TacGia,Ten_NXB,Ten_Sach,Gia,NamXuatBan,CONVERT(varchar(20),NgayNhap,103) as NgayNhap, TrangThai_MuonSach from TheLoaiSach, TacGia, NhaXuatBan, Sach  where TheLoaiSach.ID_TheLoaiSach = Sach.ID_TheLoaiSach and TacGia.ID_TacGia = Sach.ID_TacGia and NhaXuatBan.ID_NXB = Sach.ID_NXB and TrangThai_Sach = N'' and Ten_NXB like  N'%" + dl.TuKhoa + "%'");
        }



    }
}
