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
    public class BUS_QuyDinh
    {
        DAO_KetNoi xl = new DAO_KetNoi();
        DTO_QuyDinh dl = new DTO_QuyDinh();

        public DataTable Load_Select(DTO_QuyDinh dl)
        {
            return xl.table_Select("select * from QuyDinh");
        }

        public void CapNhatThayDoi_INSERT(DTO_QuyDinh dl)
        {
            //"set dateformat dmy Insert into PhieuMuonSach Values ('" + dl.ID_TheDocGia + "',N'" + dl.ID_Sach + "','" + dl.Ten_NguoiMuon + "','" + dl.NgayMuon + "','" + dl.NgayHenTra + "','" + dl.Sl_SachMuon + "','" + dl.GhiChu + "','" + dl.TrangThai_PhieuMuon + "')"
            xl.table_Command(" UPDATE QuyDinh SET TuoiToiDa = '"+dl.TuoiToiDaThayDoi+"', TuoiToiThieu = '"+dl.TuoiToiThieuThayDoi+"',ThoiHanThe ='"+dl.ThoiHanTheThayDoi+"', NamXuatBan ='"+dl.NamXuatBanThayDoi+"', SoSachMuonToiDa = '"+dl.SoSachMuonToiDaThayDoi+"', SoNgayMuonToiDa = '"+dl.SoNgayMuonToiDaThayDoi+"' WHERE ID_QuyDinh = 1");
        }

        public DataTable dtgLoad_Select(DTO_QuyDinh dl)
        {
            return xl.table_Select("select ID_TheLoaiSach,Ten_TheLoaiSach from TheLoaiSach");
        }

        public void CapNhatTheLe_INSERT(DTO_QuyDinh dl)
        {
            //"set dateformat dmy Insert into PhieuMuonSach Values ('" + dl.ID_TheDocGia + "',N'" + dl.ID_Sach + "','" + dl.Ten_NguoiMuon + "','" + dl.NgayMuon + "','" + dl.NgayHenTra + "','" + dl.Sl_SachMuon + "','" + dl.GhiChu + "','" + dl.TrangThai_PhieuMuon + "')"
            xl.table_Command(" insert into TheLoaiSach values('"+dl.TheLoaiThayDoi+"','')");
        }
    }

    
}
