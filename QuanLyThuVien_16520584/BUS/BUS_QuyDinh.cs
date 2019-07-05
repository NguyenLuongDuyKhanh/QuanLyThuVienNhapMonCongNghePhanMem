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
    }

    
}
