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

        public decimal tienPhong { get; set; }  

        public DateTime ngayDatPhong { get; set; }

        public classHoaDonPhong()
        {
        }

        public classHoaDonPhong(int idHoaDon, int idDatPhong , decimal tienPhong, DateTime ngayDatPhong)
        {
            this.idHoaDon = idHoaDon;
            this.idDatPhong = idDatPhong;
            this.tienPhong = tienPhong;
            this.ngayDatPhong = ngayDatPhong;
        }
    }
}
