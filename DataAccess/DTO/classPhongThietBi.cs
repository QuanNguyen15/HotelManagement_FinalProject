using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classPhongThietBi
    {
        public int idPhong { get; set; }
        public int idThietBi { get; set; }
        public int soLuong { get; set; }
        public classPhongThietBi() { }

        public classPhongThietBi(int idPhong, int idThietBi, int soLuong)
        {
            this.idPhong = idPhong;
            this.idThietBi = idThietBi;
            this.soLuong = soLuong;
        }
    }
}
