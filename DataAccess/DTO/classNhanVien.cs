using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classNhanVien
    {
        public int idNhanVien { get; set; }
        public string hoTen { get; set; }
        public string soCCCD { get; set; }
        public string dienThoai { get; set; }
        public string email { get; set; }
        public bool isDelete { get; set; }

        public classNhanVien() { }

        public classNhanVien(int idNhanVien, string hoTen, string soCCCD, string dienThoai, string email, bool isDelete)
        {
            this.idNhanVien = idNhanVien;
            this.hoTen = hoTen;
            this.soCCCD = soCCCD;
            this.dienThoai = dienThoai;
            this.email = email;
            this.isDelete = isDelete;
        }
    }
}
