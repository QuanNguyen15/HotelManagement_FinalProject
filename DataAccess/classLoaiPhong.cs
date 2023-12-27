using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classLoaiPhong
    {
        public int id {  get; set; }
        public string tenLoaiPhong {  get; set; }
        public decimal donGia {  get; set; }
        public int soNguoiMax {  get; set; }
        public int soGiuong {  get; set; }

        public classLoaiPhong() { }
        public classLoaiPhong(int id, string tenLoaiPhong, decimal donGia, int soNguoiMax, int soGiuong)
        {
            this.id = id;
            this.tenLoaiPhong = tenLoaiPhong;
            this.donGia = donGia;
            this.soNguoiMax = soNguoiMax;
            this.soGiuong = soGiuong;
        }
    }
}
