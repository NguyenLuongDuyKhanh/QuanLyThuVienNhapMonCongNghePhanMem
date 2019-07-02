using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Sach
    {
        //Table TheLoaiSach
        public int  ID_TheLoaiSach { get; set; }
        public String Ten_TheLoaiSach { get; set; }
        public String TrangThai_TheLoaiSach { get; set; }

        //Table NhaXuatBan
        public int ID_NXB { get; set; }
        public String Ten_NXB { get; set; }
        public String TrangThai_NXB { get; set; }
        //Table Tacgia
        public int ID_TacGia { get; set; }
        public String Ten_TacGia { get; set; }
        public String DiaChi_TacGia { get; set; }
        public String SDT_TacGia { get; set; }
        public String TrangThai_TacGia { get; set; }
        //Table Sach
        public int ID_Sach { get; set; }
        public String Ten_Sach { get; set; }
        public int Gia { get; set; }
        public int Sl_Nhap { get; set; }
        public String MoTa { get; set; }
        public int NamXuatBan { get; set; }
        public DateTime NgayNhap { get; set; }
        public String TrangThai_Sach { get; set; }
        public String TrangThai_MuonSach { get; set; }
}
}
