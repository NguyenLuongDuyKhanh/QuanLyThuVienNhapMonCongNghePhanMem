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
        public void LapTheDocGia_INSERT(DTO_TheDocGia dl)
        {
            xl.table_Command("set dateformat dmy Insert into TheDocGia Values ('" + dl.ID_LoaiDocGia+"',N'"+dl.HoTen_DocGia+"','"+dl.NgaySinh_DocGia+ "','" + dl.DiaChi_DocGia + "','" + dl.Email_DocGia + "','" + dl.NgayLapThe + "','" + dl.NgayHetHan + "','"+dl.TrangThai_TheDocGia+ "')");


        }
        public DataTable NgayHetHan_Select(DTO_TheDocGia dl)
        {
            return xl.table_Select("set dateformat dmy  SELECT CONVERT(varchar(20),DATEADD(month,6,'02/07/2019'),103) as NgayHetHan");
        }
        public DataTable TheDocGia_Select(DTO_TheDocGia dl)
        {
            return xl.table_Select(" select ID_TheDocGia,Ten_LoaiDocGia,HoTen_DocGia,NgaySinh_DocGia,DiaChi_DocGia,Email_DocGia,NgayLapThe,NgayHetHan,TrangThai_TheDocGia from TheDocGia, LoaiDocGia where TheDocGia.ID_LoaiDocGia = LoaiDocGia.ID_LoaiDocGia  order by ID_TheDocGia desc");
        }


    }
}
