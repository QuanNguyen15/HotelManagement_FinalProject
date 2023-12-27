using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classHoaDon
    {
        public int idHoaDon {  get; set; }
        public int idDatPhong {  get; set; }
        public int idKhachHang {  get; set; }
        public int idTaiKhoan {  get; set; }
        public string tenHoaDon { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public string hinhThucThanhToan { get; set; }

        public classHoaDon() { }
        public classHoaDon(int idHoaDon, int idDatPhong, int idKhachHang, int idTaiKhoan, string tenHoaDon, DateTime ngayThanhToan, string hinhThucThanhToan)
        {
            this.idHoaDon = idHoaDon;
            this.idDatPhong = idDatPhong;
            this.idKhachHang = idKhachHang;
            this.idTaiKhoan = idTaiKhoan;
            this.tenHoaDon = tenHoaDon;
            this.ngayThanhToan = ngayThanhToan;
            this.hinhThucThanhToan = hinhThucThanhToan;
        }
    }
}
