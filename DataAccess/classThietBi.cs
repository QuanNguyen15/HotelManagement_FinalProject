using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classThietBi
    {
        public int id { get; set; }
        public string tenThietBi {  get; set; }
        public decimal dongGia {  get; set; }

        public classThietBi() { }
        public classThietBi(int id, string tenThietBi, decimal dongGia)
        {
            this.id = id;
            this.tenThietBi = tenThietBi;
            this.dongGia = dongGia;
        }
    }
}
