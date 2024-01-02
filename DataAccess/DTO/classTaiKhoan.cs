using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classTaiKhoan
    {
        public int id { get; set; }
        public string userName {  get; set; }
        public string password { get; set; }
        public int idCongty {  get; set; }

        public int idNhanVien {  get; set; }
        public int idRole {  get; set; }

        public classTaiKhoan() { }

        public classTaiKhoan(int id, string userName, string password, int idCongty, int idNhanVien, int idRole)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.idCongty = idCongty;
            this.idNhanVien = idNhanVien;
            this.idRole = idRole;
        }
    }
}
