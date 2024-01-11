using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataAccess.DAL;
using BusinessLogic;
using DataAccess;

namespace HotelManagementTesting
{
    [TestClass]
    public class roomTesting
    {
        DBPhong dbPhong = new DBPhong(ServerName.userNameTest, ServerName.nameDataBaseTest);

        [TestMethod()]
        [DataRow("Room11", 1)]
        [DataRow("Room12", 2)]
        [DataRow("Room13", 3)]
        [DataRow("Room14", 1)]

        public void insertRoomTesting(string tenPhong, int idLoaiPhong)
        {
            classPhong phong = new classPhong(tenPhong, idLoaiPhong);
            Assert.IsTrue(dbPhong.AddPhong(phong));
        }
    }
}
