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
    public class BUSPhong
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSPhong()
        {
        }

        public DataTable getPhong()
        {

            DBPhong dbPhong = new DBPhong(serverName.userName, "HOTELS");
            DataTable getDatatable = dbPhong.getDataTable();
            dt = getDatatable;
            return dt;
        }
        public List<classPhong> getSanPhamToList()
        {
            DBSanPham dbSanPham = new DBSanPham(serverName.userName, "HOTELS");
            DataTable dataTable = dbSanPham.getDataTable();

            List<classPhong> phongList = ConvertDataTableToPhongList(dataTable);
            return phongList;
        }

        public List<classPhong> ConvertDataTableToPhongList(DataTable dataTable)
        {
            List<classPhong> phongList = new List<classPhong>();

            foreach (DataRow row in dataTable.Rows)
            {
                classPhong phong = new classPhong
                {
                    id = Convert.ToInt32(row["IdPhong"]),
                    tenPhong = row["TenPhong"].ToString(),
                    trangThai = row["trangThai"].ToString(),
                    idLoaiPhong = Convert.ToInt32(row["IdLoaiPhong"])
                };

                phongList.Add(phong);
            }

            return phongList;
        }

    }
}
