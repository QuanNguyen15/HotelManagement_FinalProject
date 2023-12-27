using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classDonVi
    {
        public int id {  get; set; }
        public string maDonVi {  get; set; }
        public string maCongTy {  get; set; }
        public string tenDonVi {  get; set; }
        public string dienThoai {  get; set; }
        public string fax {  get; set; }
        public string email {  get; set; }
        public string diaChi {  get; set; }

        public classDonVi() { }
        public classDonVi(int id, string maDonVi, string maCongTy, string tenDonVi, string dienThoai, string fax, string email, string diaChi)
        {
            this.id = id;
            this.maDonVi = maDonVi;
            this.maCongTy = maCongTy;
            this.tenDonVi = tenDonVi;
            this.dienThoai = dienThoai;
            this.fax = fax;
            this.email = email;
            this.diaChi = diaChi;
        }
    }
}
