using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTra
    {
        public int ID_PhieuTraSach { get; set; }
        public int ID_PhieuMuonSach { get; set; }
        public String Ten_NguoiTra { get; set; }
        public DateTime NgayTraSach { get; set; }
        public int SachChuaTra { get; set; }
        public int TienPhat { get; set; }
        public String TrangThai_PhieuTraSach { get; set; }
    }
}
