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
    public class BUSDichVu
    {
        ServerName serverName = new ServerName();

        DataTable dt = null;

        public BUSDichVu()
        {
        }

        public DataTable getDichVu()
        {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable =dbDichVu.getDataTable();
            dt = getDatatable;
            return dt;
        }


        public DataTable getLoaiDichVu()
        {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.getLoaiDichVu();
            dt = getDatatable;
            return dt;
        }

        public DataTable searchSanPham(classDichVu dichVu) {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.searchDichVu(dichVu);
            return getDatatable;
        }

        public List<classDichVu> ConvertDataTableToPhongList(DataTable dataTable)
        {
            List<classDichVu> listDichVu = new List<classDichVu>();

            foreach (DataRow row in dataTable.Rows)
            {
                classDichVu dichVu = new classDichVu();
                {
                    int id = Convert.ToInt32(row["idSanPham"]);
                    string tenSanPham = row["tenSanPham"].ToString();
                    decimal dongGia = Convert.ToDecimal(row["dongGia"]);
                };

                listDichVu.Add(dichVu);
            }

            return listDichVu;
        }
        public bool deleteDichVu(classDichVu dichVu)
        {
            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            return dbDichVu.DeleteDichVu(dichVu);
        }

        public bool addDichVu(classDichVu dichVu)
        {
            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            return dbDichVu.AddDichVu(dichVu);
        }

        public DataTable getDichVubyLoai(classDichVu dichVu)
        {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.getDicVuByLoai(dichVu);
            return getDatatable;
        }

        public DataTable getNameAndPrice()
        {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.getNameAndPrice();
            dt = getDatatable;
            return dt;
        }

        public DataTable SearchDichVuByNameAndLoai(classDichVu dichVu)
        {

            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.SearchDichVuByNameAndLoai(dichVu);
            return getDatatable;
        }

        public DataTable getTenPriceDichVuByName(classDichVu dichVu)
        {
            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDichVu.getTenPriceDichVuByName(dichVu);
            return getDatatable;
        }

        public bool DeleteDichVuPhongByRoomAndService(classDichVu dichVu)
        {
            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            return dbDichVu.DeleteDichVuPhongByRoomAndService(dichVu);
        }

        public bool AddDichVuPhongByRoomAndService(classDichVu dichVu)
        {
            DBDichVu dbDichVu = new DBDichVu(serverName.userName, serverName.nameDataBase);
            return dbDichVu.AddDichVuPhongByRoomAndService(dichVu);
        }
    }
}
