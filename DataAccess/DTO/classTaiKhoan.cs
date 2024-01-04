using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classTaiKhoan
    {
        public int idTaiKhoan { get; set; }
        public string userName {  get; set; }
        public string password { get; set; }

        public int idNhanVien {  get; set; }
        public int idRole {  get; set; }

        public classTaiKhoan() { }

        public classTaiKhoan(int id, string userName, string password, int idNhanVien, int idRole)
        {
            this.idTaiKhoan = id;
            this.userName = userName;
            this.password = password;

            this.idNhanVien = idNhanVien;
            this.idRole = idRole;
        }
    }
}
