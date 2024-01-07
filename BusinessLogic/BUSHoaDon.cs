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

        public DataTable getBillDetail(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBillDetail(Object);
            dt = getDatatable;
            return dt;
        }

        public DataTable getBillDichVuDetail(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.getBillDichVuDetail(Object);
            dt = getDatatable;
            return dt;
        }

        public DataTable SearchHoaDonPhongBySoHoaDonNew(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.SearchHoaDonPhongBySoHoaDonNew(Object);
            dt = getDatatable;
            return dt;
        }
        public string SelectTongTienDichVuPhongByMonth(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.SelectTongTienDichVuPhongByMonth(Object);

            // Kiểm tra xem DataTable có dữ liệu hay không
            if (getDatatable != null && getDatatable.Rows.Count > 0)
            {
                // Chuyển giá trị từ DataTable thành chuỗi và trả về
                return getDatatable.Rows[0][0].ToString();
            }

            // Nếu không có dữ liệu, trả về chuỗi trống hoặc một giá trị mặc định khác tùy thuộc vào yêu cầu của bạn
            return string.Empty;
        }

        public string SelectTongTienPhongByMonth(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.SelectTongTienPhongByMonth(Object);

            if (getDatatable != null && getDatatable.Rows.Count > 0)
            {
                return getDatatable.Rows[0][0].ToString();
            }

            return string.Empty;
        }

        public string SelectSoPhongByMonth(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.SelectSoPhongByMonth(Object);

            if (getDatatable != null && getDatatable.Rows.Count > 0)
            {
                return getDatatable.Rows[0][0].ToString();
            }

            return string.Empty;
        }

        public DataTable SelectHoaDonByMonthAndYear(classHoaDon Object)
        {
            DBHoaDon dBHoaDon = new DBHoaDon(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBHoaDon.SelectHoaDonByMonthAndYear(Object);
            dt = getDatatable;
            return dt;
        }
    }
}
