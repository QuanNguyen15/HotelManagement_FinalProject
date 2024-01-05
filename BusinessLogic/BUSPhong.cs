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

            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            DataTable getDatatable = dbPhong.getDataTable();
            dt = getDatatable;
            return dt;
        }
        public List<classPhong> getPhongToList()
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            DataTable dataTable = dbPhong.getDataTable();

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
                    idPhong = Convert.ToInt32(row["IdPhong"]),
                    tenPhong = row["TenPhong"].ToString(),
                    trangThai = row["trangThai"].ToString(),
                    idLoaiPhong = Convert.ToInt32(row["IdLoaiPhong"])
                };

                phongList.Add(phong);
            }

            return phongList;
        }

        public bool addPhong(classPhong Object)
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            return dbPhong.AddPhong(Object);
        }

        public List<classPhong> searchPhong(classPhong Object)
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            DataTable dt = dbPhong.searchPhong(Object);
            List<classPhong> list = ConvertDataTableToPhongList(dt);
            return list;
        }

        public bool updatePhong(classPhong Object)
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            return dbPhong.UpdatePhong(Object);
        }

        public DataTable getRoomAvailable()
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            return dbPhong.getRoomAvailable();
        }

        public DataTable getIdPhong(string name)
        {
            DBPhong dbPhong = new DBPhong(serverName.userName, serverName.nameDataBase);
            return dbPhong.getIdPhong(name);
        }
    }
}
