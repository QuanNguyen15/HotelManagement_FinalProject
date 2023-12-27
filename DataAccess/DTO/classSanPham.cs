using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classSanPham
    {
        public int id {  get; set; }
        public string tenSanPham {  get; set; }
        public decimal dongGia {  get; set; }

        public classSanPham() { }
        public classSanPham(int id, string tenSanPham, decimal dongGia)
        {
            this.id = id;
            this.tenSanPham = tenSanPham;
            this.dongGia = dongGia;
        }
    }

}
