using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classCongTy
    {
        public int id { get; set; }
        public string maCongTy { get; set; }
        public string tenCongTy { get; set; }
        public string dienThoai { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public classCongTy()
        {

        }

        public classCongTy(int id, string maCongTy, string tenCongTy, string dienThoai, string fax, string email, string diaChi)
        {
            this.id = id;
            this.maCongTy = maCongTy;
            this.tenCongTy = tenCongTy;
            this.dienThoai = dienThoai;
            this.fax = fax;
            this.email = email;
            this.diaChi = diaChi;
        }
    }
}
