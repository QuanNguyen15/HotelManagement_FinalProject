using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmBillDetail : Form
    {
        BUSHoaDon busHoaDon=new BUSHoaDon();
        classPhong room;
        tabRoom roomTab;
        public frmBillDetail(classPhong cPhong , tabRoom tRoom)
        {
            room = cPhong;
            roomTab = tRoom;    
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            string tenRoom = room.tenPhong;
            classHoaDon hoaDon=new classHoaDon();
            hoaDon.tenHoaDon = tenRoom;
            DataTable dtBill= busHoaDon.getBill(hoaDon);


            if (dtBill.Columns.Contains("KhachHang"))
            {
                string clientt = dtBill.Rows[0]["KhachHang"].ToString();
                lbClientFullname.Text = clientt;
                string soHoaDon = dtBill.Rows[0]["soHoaDonNew"].ToString();
                lbIdBill.Text = soHoaDon;
                string staff = dtBill.Rows[0]["tenNhanVien"].ToString();
                lbStaffFullname.Text = staff;
                string idPhong = dtBill.Rows[0]["idPhong"].ToString();
                lbIdRoom.Text = idPhong;
                string soLuong = dtBill.Rows[0]["soNguoi"].ToString();
                lbNumpeople.Text = soLuong;
                string ngayThuc = dtBill.Rows[0]["SoNgayThuc"].ToString();
                lbNumday.Text = ngayThuc;
            }
            // Lấy thời gian thực
            DateTime thoiGianThuc = DateTime.Now;
            string chuoiThoiGian = thoiGianThuc.ToString("yyyy /MM/dd HH:mm:ss");

            lbDateBill.Text = chuoiThoiGian;
        }
    }
    }
