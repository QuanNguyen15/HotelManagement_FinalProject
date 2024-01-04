using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classLoaiPhong
    {
        public int idLoaiPhong {  get; set; }
        public string tenLoaiPhong {  get; set; }
        public decimal donGia {  get; set; }
        public int soNguoiToiDa {  get; set; }


        public classLoaiPhong() { }

        public classLoaiPhong(int idLoaiPhong, string tenLoaiPhong, decimal donGia, int soNguoiToiDa)
        {
            this.idLoaiPhong = idLoaiPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.donGia = donGia;
            this.soNguoiToiDa = soNguoiToiDa;
        }
    }
}
