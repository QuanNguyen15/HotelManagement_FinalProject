using DataAccess;
using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSSanPham
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSSanPham()
        {
        }

        public DataTable getSanPham()
        {

            DBSanPham dbSanPham = new DBSanPham(serverName.userName, "HOTELS");
            DataTable getDatatable = dbSanPham.getDataTable();
            dt = getDatatable;
            return dt;
        }

        public DataTable searchSanPham(classSanPham sanpham) {

            DBSanPham dbSanPham = new DBSanPham(serverName.userName, "HOTELS");
            DataTable getDatatable = dbSanPham.searchSanPam(sanpham);
            return getDatatable;
        }

        public List<classSanPham> ConvertDataTableToPhongList(DataTable dataTable)
        {
            List<classSanPham> listSanPham = new List<classSanPham>();

            foreach (DataRow row in dataTable.Rows)
            {
                classSanPham sanPham = new classSanPham();
                {
                    int id = Convert.ToInt32(row["idSanPham"]);
                    string tenSanPham = row["tenSanPham"].ToString();
                    decimal dongGia = Convert.ToDecimal(row["dongGia"]);
                };

                listSanPham.Add(sanPham);
            }

            return listSanPham;
        }
        public bool deleteSanPham(classSanPham sanpham)
        {
            DBSanPham dbSanPham = new DBSanPham(serverName.userName, "HOTELS");
            return dbSanPham.DeleteSanPham(sanpham);
        }
    }
}
