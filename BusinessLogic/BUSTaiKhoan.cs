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
    public class BUSTaiKhoan
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSTaiKhoan()
        {
        }

        public DataTable getTaiKhoan()
        {

            DBTaiKhoan dBTaiKhoan = new DBTaiKhoan(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBTaiKhoan.getDataTable();

            dt = getDatatable;
            return dt;
        }
        public List<classTaiKhoan> checkTaiKhoan(DataTable dt)
        {
            List<classTaiKhoan> listTaiKhoan = new List<classTaiKhoan>();
            foreach (DataRow dtTaiKhoan in dt.Rows)
            {
                classTaiKhoan taiKhoan = new classTaiKhoan();

                // Gán giá trị từ DataRow vào đối tượng classTaiKhoan
                taiKhoan.idTaiKhoan = Convert.ToInt32(dtTaiKhoan["idTaiKhoan"]);
                taiKhoan.userName = dtTaiKhoan["userName"].ToString();
                taiKhoan.password = dtTaiKhoan["password"].ToString();
                taiKhoan.idNhanVien = Convert.ToInt32(dtTaiKhoan["idNhanVien"]);
                taiKhoan.idRole = Convert.ToInt32(dtTaiKhoan["idRole"]);

                // Thêm đối tượng vào danh sách
                listTaiKhoan.Add(taiKhoan);
            }
            return listTaiKhoan;
        }
        public List<classTaiKhoan> getTaiKhoanList()
        {

            DBTaiKhoan dBTaiKhoan = new DBTaiKhoan(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBTaiKhoan.getDataTable();

            dt = getDatatable;

            return checkTaiKhoan(dt);

        }

    }
}
