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
    public class BUSDatPhong
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSDatPhong()
        {
        }

        public DataTable getDatPhong()
        {

            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDatPhong.getDataTable();

            dt = getDatatable;
            return dt;
        }

        public DataTable getDataDatPhong(classDatPhong datphong)
        { 
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.getDataDatPhong(datphong);
        }
        
        public DataTable getDatPhongChiTiet()
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.getDatPhongChiTiet();
        }
        public DataTable searchDatPhong(classDatPhong Object)
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.searchDatPhong(Object);
        }

        public bool addDatPhong(classKhachHang khachHang, classHoaDon hoaDon, classDatPhong datPhong, classTaiKhoan TaiKhoan)
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.AddDatPhong(khachHang, hoaDon, datPhong, TaiKhoan);
        }

        public string getDatPhongMax()
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbDatPhong.getDatPhongMax();
            dt = getDatatable;
            string DatPhongAsString = getDatatable.Rows[0]["BookingID"].ToString();
            return DatPhongAsString;
        }

        public bool creatDatPhong(classDatPhong datPhong)
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.createDatPhong(datPhong);
        }

        public bool UpdateSoNgayThuc(classDatPhong datPhong)
        {
            DBDatPhong dbDatPhong = new DBDatPhong(serverName.userName, serverName.nameDataBase);
            return dbDatPhong.UpdateSoNgayThuc(datPhong);
        }
    }
}
