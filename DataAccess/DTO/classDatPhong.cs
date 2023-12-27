using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classDatPhong
    {
        public int id { get; set; }
        public int idKhachHang { get; set; }
        public int idPhong {  get; set; }
        public DateTime ngayDat {  get; set; }
        public DateTime ngayThuc { get; set; }
        public int idTaiKhoan {  get; set; }
        public int idSanPham {  get; set; }
        public string maConTy {  get; set; }
        public string maDonVi {  get; set; }

        public classDatPhong() { }

        public classDatPhong(int id, int idKhachHang, int idPhong, DateTime ngayDat, DateTime ngayThuc, int idTaiKhoan, int idSanPham, string maConTy, string maDonVi)
        {
            this.id = id;
            this.idKhachHang = idKhachHang;
            this.idPhong = idPhong;
            this.ngayDat = ngayDat;
            this.ngayThuc = ngayThuc;
            this.idTaiKhoan = idTaiKhoan;
            this.idSanPham = idSanPham;
            this.maConTy = maConTy;
            this.maDonVi = maDonVi;
        }
    }
}
