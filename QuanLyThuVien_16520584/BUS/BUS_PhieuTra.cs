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
        public DataTable DocGia_Select(DTO_TheDocGia dl)
        {
            return xl.table_Select("select ID_TheDocGia from PhieuMuonSach");
        }

        public DataTable Sach_Select(DTO_TheDocGia dl)
        {
            return xl.table_Select("select ID_Sach from PhieuMuonSach");
        }
    }
}
