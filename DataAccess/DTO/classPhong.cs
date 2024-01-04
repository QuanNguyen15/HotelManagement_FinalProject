using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classPhong
    {
        public int idPhong { get; set; }
        public string tenPhong { get; set; }

        public string trangThai { get; set; }
        public int idLoaiPhong { get; set; }
        public bool isDelete { get; set; }

        public classPhong()
        {

        }
        public classPhong(int idPhong, string tenPhong, string trangThai, int idLoaiPhong,bool isDelete)
        {
            this.idPhong = idPhong;
            this.tenPhong = tenPhong;
            this.trangThai = trangThai;
            this.idLoaiPhong = idLoaiPhong;
            this.isDelete = isDelete;
        }

        public classPhong(string tenPhong, int idLoaiPhong)
        {
            this.tenPhong = tenPhong;
            this.idLoaiPhong = idLoaiPhong;
        }
    }
}
