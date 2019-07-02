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
    public class BUS_TheDocGia
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_TheDocGia dl = new DTO_TheDocGia();
        public DataTable ChonLoaiDocGia_Select(DTO_TheDocGia dl)
        {
            return xl.table_Select("select ID_LoaiDocGia,Ten_LoaiDocGia from LoaiDocGia where  TrangThai_LoaiDocGia=N''");
        }
        public void GioHang_INSERT(DTO_TheDocGia dl)
        {
            xl.table_Command("Insert into TheDocGia Values ('"+dl.ID_LoaiDocGia+"',N'"+dl.HoTen_DocGia+"','"+dl.NgaySinh_DocGia+ "','" + dl.DiaChi_DocGia + "','" + dl.Email_DocGia + "','" + dl.NgayLapThe + "','" + dl.NgayHetHan + "',''");
    
        }
    }
}
