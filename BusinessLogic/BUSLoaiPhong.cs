using DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BUSLoaiPhong
    {
        ServerName serverName = new ServerName();
        DataTable dt = null;

        public BUSLoaiPhong()
        {
        }

        public DataTable getLoaiPhong()
        {

            DBLoaiPhong dBLoaiPhong = new DBLoaiPhong(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dBLoaiPhong.getDataTable();

            dt = getDatatable;
            return dt;
        }
    }
}
