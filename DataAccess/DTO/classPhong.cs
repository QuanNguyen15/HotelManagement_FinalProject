using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classPhong
    {
        public int id { get; set; }
        public string tenPhong { get; set; }

        public string trangThai { get; set; }
        public int idLoaiPhong { get; set; }

        public classPhong()
        {

        }
        public classPhong(int id, string tenPhong, string trangThai, int idLoaiPhong)
        {
            this.id = id;
            this.tenPhong = tenPhong;
            this.trangThai = trangThai;
            this.idLoaiPhong = idLoaiPhong;
        }

        public classPhong(string tenPhong, int idLoaiPhong)
        {
            this.tenPhong = tenPhong;
            this.idLoaiPhong = idLoaiPhong;
        }
    }
}
