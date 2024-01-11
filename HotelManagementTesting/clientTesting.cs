using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementTesting
{
    [TestClass]
    public class clientTesting
    {

        ServerName serName = new ServerName();
        DBKhachHang khachHang;

        public clientTesting()
        {

            khachHang = new DBKhachHang(serName.userNameTest, serName.dataBaseTesting);

        }


        [TestMethod()]
        [DataRow("John Doe", "Male", "123456789", "1234567890", "john@example.com", "123 Main St")]
        [DataRow("Jane Doe", "Female", "987654321", "0987654321", "jane@example.com", "456 Oak St")]
        [DataRow("Bob Smith", "Male", "456123789", "8765432109", "bob@example.com", "789 Pine St")]
        public void InsertKhachHang(string hoTen, string gioiTinh, string soCCCD, string dienThoai, string email, string diaChi)
        {
            classKhachHang khachHangObject = new classKhachHang
            {
                hoTen = hoTen,
                gioiTinh = gioiTinh,
                soCCCD = soCCCD,
                dienThoai = dienThoai,
                email = email,
                diaChi = diaChi
            };

            Assert.IsTrue(khachHang.AddKhachHang(khachHangObject));
        }

        [TestMethod()]
        [DataRow(1)] 
        [DataRow(2)] // Test case with idKhachHang = 2
        [DataRow(3)] // Test case with idKhachHang = 3
        public void DeleteKhachHang(int idKhachHang)
        {
            classKhachHang khachHangObject = new classKhachHang
            {
                idKhachHang = idKhachHang
            };
            Assert.IsTrue(khachHang.DeleteKhachHang(khachHangObject));
    }


            [TestMethod()]
            [DataRow(1, "John Doe", "Male", "1234567890", "john@example.com", "123 Main St")]
            [DataRow(2, "Jane Doe", "Female", "0987654321", "jane@example.com", "456 Oak St")]
            [DataRow(3, "Bob Smith", "Male", "8765432109", "bob@example.com", "789 Pine St")]
            public void UpdateKhachHang(int idKhachHang, string hoTen, string gioiTinh, string dienThoai, string email, string diaChi)
            {
                classKhachHang khachHangObject = new classKhachHang
                {
                    idKhachHang = idKhachHang,
                    hoTen = hoTen,
                    gioiTinh = gioiTinh,
                    dienThoai = dienThoai,
                    email = email,
                    diaChi = diaChi
                };

                Assert.IsTrue(khachHang.UpdateKhachHang(khachHangObject));
            }
        
    }
}