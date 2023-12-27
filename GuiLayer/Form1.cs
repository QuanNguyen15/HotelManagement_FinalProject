using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
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

            dt2 = bNDatPhong.getDatPhong();
            dataGridView3.DataSource = dt2;

         
            dataGridView1.DataSource = dt;
            dt = nhanVien.getNhanVien();
            dataGridView1.DataSource = dt;
            dt = nhanVien.getNhanVien();
            dataGridView1.DataSource = dt;
            dt = nhanVien.getNhanVien();
            dataGridView1.DataSource = dt;
            dt = nhanVien.getNhanVien();
            dataGridView1.DataSource = dt;
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
