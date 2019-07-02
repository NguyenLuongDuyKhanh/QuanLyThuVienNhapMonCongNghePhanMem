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
        DTO_TheDocGia dl = new DTO_TheDocGia();

        public DataTable ChonTheLoaiSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select ID_TheLoaiSach,Ten_TheLoaiSach from TheLoaiSach");
        }

        public DataTable ChonTacGiaSach_Select(DTO_Sach dl)
        {
            return xl.table_Select("select ID_TacGia,Ten_TacGia from TacGia");
        }
    }
}
