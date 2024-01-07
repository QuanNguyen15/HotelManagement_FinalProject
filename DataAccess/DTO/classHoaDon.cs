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
/*        public int idDatPhong {  get; set; }*/
        public int idKhachHang {  get; set; }
/*        public int idTaiKhoan {  get; set; }*/
        public string tenHoaDon { get; set; }
        public DateTime ngayThanhToan { get; set; }
        public string hinhThucThanhToan { get; set; }
        public decimal tongTien { get; set; }   
        public int soHoaDon { get; set; }   
        public classHoaDon() { }

        public classHoaDon(int idHoaDon, int idKhachHang, string tenHoaDon, DateTime ngayThanhToan, string hinhThucThanhToan, decimal tongTien)
        {
            this.idHoaDon = idHoaDon;
            this.idKhachHang = idKhachHang;
            this.tenHoaDon = tenHoaDon;
            this.ngayThanhToan = ngayThanhToan;
            this.hinhThucThanhToan = hinhThucThanhToan;
            this.tongTien = tongTien;
        }
    }
}
