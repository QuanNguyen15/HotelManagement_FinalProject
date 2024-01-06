using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class classDichVu
    {
        public int idDichVu {  get; set; }
        public string tenDichVu {  get; set; }
        public string loaiDichVu { get; set; }
        public decimal donGia {  get; set; }


        public classDichVu() { }

        public classDichVu(int idDichVu, string tenDichVu, string loaiDichVu, decimal donGia)
        {
            this.idDichVu = idDichVu;
            this.tenDichVu = tenDichVu;
            this.loaiDichVu = loaiDichVu;
            this.donGia = donGia;
        }
    }

}
