using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class classDichVuPhong
    {
        public int idDichVuPhong { get; set; }
        public int idDatPhong { get; set; }
        public int soLuong { get; set; }
        public bool isDelete { get; set; }

        public classDichVuPhong()
        {
        }

        public classDichVuPhong(int idDichVuPhong, int idDatPhong, int soLuong, bool isDelete)
        {
            this.idDichVuPhong = idDichVuPhong;
            this.idDatPhong = idDatPhong;
            this.soLuong = soLuong;
            this.isDelete = isDelete;
        }

    }
}
