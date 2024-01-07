using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classThietBi
    {
        public int idThietBi { get; set; }
        public string tenThietBi {  get; set; }
        public decimal donGia {  get; set; }
        public bool isDelete { get; set; }

        public classThietBi() { }

        public classThietBi(int idThietBi, string tenThietBi, decimal donGia)
        {
            this.idThietBi = idThietBi;
            this.tenThietBi = tenThietBi;
            this.donGia = donGia;
        
        }
    }
}
