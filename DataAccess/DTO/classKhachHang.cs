using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classKhachHang
    {
        public int id { get; set; }
        public string hoTen {  get; set; }
        public string soCCCD {  get; set; }
        public string dienThoai {  get; set; }
        public string email {  get; set; }
        public string diaChi {  get; set; }

        public classKhachHang() { }
        public classKhachHang(int id, string hoTen, string soCCCD, string dienThoai, string email, string diaChi)
        {
            this.id = id;
            this.hoTen = hoTen;
            this.soCCCD = soCCCD;
            this.dienThoai = dienThoai;
            this.email = email;
            this.diaChi = diaChi;
        }
    }
}
