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
        public DateTime ngayTra {  get; set; }
        public int ngayThuc { get; set; }
        public int idTaiKhoan {  get; set; }
        public int idSanPham {  get; set; }
        public int idCongTy {  get; set; }
        
        public string tenKhachHang {  get; set; }


    public classDatPhong() { }

        public classDatPhong(int id, int idKhachHang, int idPhong, DateTime ngayDat, DateTime ngayTra, int ngayThuc, int idTaiKhoan, int idSanPham, int idCongTy)
        {
            this.id = id;
            this.idKhachHang = idKhachHang;
            this.idPhong = idPhong;
            this.ngayDat = ngayDat;
            this.ngayTra = ngayTra;
            this.ngayThuc = ngayThuc;
            this.idTaiKhoan = idTaiKhoan;
            this.idSanPham = idSanPham;
            this.idCongTy = idCongTy;
        }
    }
}
