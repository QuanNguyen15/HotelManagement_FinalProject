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
        public string maCongTy {  get; set; }
        public string maDonVi {  get; set; }
        public int idNhanVien {  get; set; }
        public bool isGroup {  get; set; }
        public bool disable { get; set;}

        public classTaiKhoan() { }
        public classTaiKhoan(int id, string userName, string password, string maCongTy, string maDonVi, int idNhanVien, bool isGroup, bool disable)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.maCongTy = maCongTy;
            this.maDonVi = maDonVi;
            this.idNhanVien = idNhanVien;
            this.isGroup = isGroup;
            this.disable = disable;
        }
    }
}
