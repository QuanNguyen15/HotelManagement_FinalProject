using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HotelManagementTesting
{
    [TestClass]
    public class facilityTesting
    {

        ServerName serName = new ServerName();
        DBThietBi thietBi;

        public facilityTesting() {

            thietBi = new DBThietBi(serName.userNameTest, serName.dataBaseTesting);
      
        }

        [TestMethod()]
        [DataRow("Laptop", 1)]
        [DataRow("Camera ", 2)]
        [DataRow("Radio", 3)]
        [DataRow("Phone" , 1)]
        public void insertRoomTesting(string tenThietBi, double donGia)
        {
            classThietBi classthietBi = new classThietBi(tenThietBi,(decimal) donGia);
            Assert.IsTrue(thietBi.AddThietBi(classthietBi));
        }

        [TestMethod()]
        [DataRow(1,"Laptop", 1)]
        [DataRow(2,"Camera ", 2)]
        [DataRow(3,"Radio", 3)]
        [DataRow(4,"Phone", 1)]
        public void UpdateTesting(int id ,string tenThietBi, double donGia)
        {
            classThietBi classthietBi = new classThietBi(id,tenThietBi, (decimal)donGia);
            Assert.IsTrue(thietBi.UpdateThietBi(classthietBi));
        }


        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        public void deleteTesting(int id)
        {
            classThietBi classthietBi = new classThietBi(id);
            Assert.IsTrue(thietBi.DeleteThietBi(classthietBi));
        }

    }
}
