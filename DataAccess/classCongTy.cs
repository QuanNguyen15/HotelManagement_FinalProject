using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classCongTy
    {
        public int Id { get; set; }
        public string MaCongTy { get; set; }
        public string TenCongTy { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public classCongTy()
        {

        }

        public classCongTy(int id, string maCongTy, string tenCongTy, string dienThoai, string fax, string email, string diaChi)
        {
            Id = id;
            MaCongTy = maCongTy;
            TenCongTy = tenCongTy;
            DienThoai = dienThoai;
            Fax = fax;
            Email = email;
            DiaChi = diaChi;
        }
        public void hello()
        {

        }
    }
}
