using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class classHoaDonPhong
    {
        public int idHoaDon {  get; set; }
        public int idDatPhong { get; set; }

        public classHoaDonPhong()
        {
        }

        public classHoaDonPhong(int idHoaDon, int idDatPhong)
        {
            this.idHoaDon = idHoaDon;
            this.idDatPhong = idDatPhong;
        }
    }
}
