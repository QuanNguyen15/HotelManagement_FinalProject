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

        public bool trangThai { get; set; }
        public int idLoaiPhong { get; set; }

        public classPhong()
        {

        }
    }
}
