using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuMuon
    {
        public int ID_PhieuMuonSach { get; set; }
        public int ID_TheDocGia { get; set; }
        public int ID_Sach { get; set; }
        public String Ten_NguoiMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayHenTra { get; set; }
        public int Sl_SachMuon { get; set; }
        public String GhiChu { get; set; }
        public String TrangThai_PhieuMuon { get; set; }
}
}
