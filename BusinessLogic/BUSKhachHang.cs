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
    public class BUSKhachHang
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;
       
        public BUSKhachHang()
        {
        }

        public DataTable getKhachHang()
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBKhachHang.getDataTable();
            dt = getDatatable;
            return dt;
        }

        public List<classKhachHang> listKhachHang(DataTable dt)
        {
            List<classKhachHang> listKhachHang = new List<classKhachHang>();

            foreach (DataRow row in dt.Rows)
            {
                classKhachHang khachHang = new classKhachHang();

                // Gán giá trị từ DataRow vào đối tượng classKhachHang
                khachHang.idKhachHang = Convert.ToInt32(row["idKhachHang"]);
                khachHang.hoTen = row["hoTen"].ToString();
                khachHang.gioiTinh = row["gioiTinh"].ToString();
                khachHang.soCCCD = row["soCCCD"].ToString();
                khachHang.dienThoai = row["dienThoai"].ToString();
                khachHang.email = row["email"].ToString();
                khachHang.diaChi = row["diaChi"].ToString();
                // Thêm đối tượng vào danh sách
                listKhachHang.Add(khachHang);
            }

            return listKhachHang;
        }

        public List<classKhachHang> getlistKhachHang()
            {

            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            DataTable dt = new DataTable();
            dt = dBKhachHang.getDataTable();

            return listKhachHang(dt);

        }


        public bool addKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            return dBKhachHang.AddKhachHang(Object);
        }

        public bool deleteKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            return dBKhachHang.DeleteKhachHang(Object);
        }
        public bool upDateKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            return dBKhachHang.UpdateKhachHang(Object);
        }

        public DataTable searchKhachHang(classKhachHang Object)
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);
            return dBKhachHang.searchKhachHang(Object);
        }

        public int maxKhachHang()
        {
            DBKhachHang dBKhachHang = new DBKhachHang(serverName.userName, serverName.nameDataBase);

           DataTable dt =dBKhachHang.maxKhachHang();
            string idKhachhangString = dt.Rows[0]["idKhachHang"].ToString();
            int idKhachHang = int.Parse(idKhachhangString);
            return idKhachHang;
        }
    }
}
