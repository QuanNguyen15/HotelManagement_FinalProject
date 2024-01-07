﻿using BusinessLogic;
using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmBillDetail : Form
    {
        BUSPhong busPhong = new BUSPhong();
        BUSHoaDon busHoaDon=new BUSHoaDon();
        BUSHoaDonPhong busHoaDonPhong = new BUSHoaDonPhong();
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

            DataTable dtGridDichVu = busHoaDon.getBillDichVu(hoaDon);
            dataGridView1.DataSource = dtGridDichVu;

            DataTable dtDonGiaPhong = busPhong.GetDonGiaByIdPhong(room);
            decimal donGiaPhong = Convert.ToDecimal(dtDonGiaPhong.Rows[0][0]);
            decimal tongTienDichVu = 0;
            decimal TongNgayThuc = decimal.Parse(lbNumday.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra xem dòng có được chọn hay không
                if (!row.IsNewRow)
                {
                    // Kiểm tra giá trị cột có thể được chuyển đổi thành decimal hay không
                    if (row.Cells["TongDonGia"].Value != null && Decimal.TryParse(row.Cells["TongDonGia"].Value.ToString(), out decimal giaTri))
                    {
                        // Tính tổng
                        tongTienDichVu += giaTri;
                    }
                }
            }

            decimal tongHoaDon = (TongNgayThuc * donGiaPhong) + tongTienDichVu;
            
            lbTotal.Text = tongHoaDon.ToString();



            string idHoaDon = dtBill.Rows[0]["idHoaDon"].ToString();
            string idDatPhong = dtBill.Rows[0]["idDatPhong"].ToString();

            int parsedIdHoaDon = int.Parse(idHoaDon);
            int parsedIdDatPhong = int.Parse(idDatPhong);

            /*   DateTime thoiGianChuyenDoi;
               thoiGianChuyenDoi = DateTime.ParseExact(chuoiThoiGian, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);*/


           classHoaDonPhong hoaDonPhong = new classHoaDonPhong(parsedIdHoaDon, parsedIdDatPhong, tongHoaDon, thoiGianThuc);
            busHoaDonPhong.UpdateHoaDonPhong(hoaDonPhong);


            room.trangThai = "Maintenaning";
            busPhong.updatePhong(room);


        }
    }
    }
