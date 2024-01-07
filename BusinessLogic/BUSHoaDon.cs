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
    public class BUSHoaDon
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSHoaDon()
        {
        }

        public DataTable getHoaDonChiTiet()
        {

            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getDataTable();

            dt = getDatatable;
            return dt;
        }

        public DataTable getHoaDon()
        {

            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getDataHoaDon();

            dt = getDatatable;
            return dt;
        }

        public DataTable searchHoaDon(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.searchHoaDon(Object);

            dt = getDatatable;
            return dt;
        }
        public DataTable getBooking(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBooKing(Object);

            dt = getDatatable;
            return dt;
        }

        public DataTable getBookinglable(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBooKinglable(Object);

            dt = getDatatable;
            return dt;
        }

        public DataTable serchBooking(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.searchBooking(Object);
            dt = getDatatable;
            return dt;
        }

        public string maxHoaDon()
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getMaxHoaDon();
            dt = getDatatable;
            string tenHoaDonAsString = getDatatable.Rows[0]["idBill"].ToString();
            return tenHoaDonAsString;
        }

        public bool creatHoaDon(classHoaDon hoaDon)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            return dBHoaDon.CreateHoaDon(hoaDon);
        }

        public bool deleteBooking(classHoaDon hoaDon)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            return dBHoaDon.DeleteBooking(hoaDon);
        }

        public DataTable getBill(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBill(Object);
            dt = getDatatable;
            return dt;
        }
      
        public DataTable getBillDichVu(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBillDichVu(Object);
            dt = getDatatable;
            return dt;
        }
    }
}
