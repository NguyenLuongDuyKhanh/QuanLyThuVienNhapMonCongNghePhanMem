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


    }
}
