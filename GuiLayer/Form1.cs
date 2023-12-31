﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using ServiceStack;

namespace GuiLayer
{
    public partial class Form1 : Form
    {
        BUSCongTy congty =new BUSCongTy();
        BUSNhanVien nhanVien = new BUSNhanVien();
        BUSDatPhong bNDatPhong = new BUSDatPhong();
        BUSDonVi bUSDonVi = new BUSDonVi();
        BUSHoaDon bUSHoaDon = new BUSHoaDon();
        BUSKhachHang bUSKhachHang = new BUSKhachHang();
        BUSLoaiPhong bUSLoaiPhong = new BUSLoaiPhong();
        BUSDatPhong bUSDatPhong = new BUSDatPhong();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            DataTable dt2 = null;
            dt = nhanVien.getNhanVien();
            dataGridView1.DataSource = dt;

            classDatPhong datPhong = new classDatPhong();
            datPhong.idPhong = 1;
            datPhong.ngayDat = DateTime.Parse("2023-01-01 00:00:00.000");

            dt = bUSDatPhong.getDataDatPhong(datPhong);
            dataGridView6.DataSource = dt;

            /*            dt2 =bUSKhachHang.getKhachHang();
                        dataGridView6.DataSource = dt2;*/
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
