using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
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
    public partial class billDetail2 : Form
    {
        
        int id;
        BUSHoaDon BUShoaDon = new BUSHoaDon();
        public billDetail2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void billDetail2_Load(object sender, EventArgs e)
        {
            classHoaDon cHoaDon = new classHoaDon();
            cHoaDon.soHoaDon = id;
            DataTable datalabel = new DataTable();
            datalabel = BUShoaDon.getBillDetail(cHoaDon);


            if (datalabel.Columns.Contains("KhachHang"))
            {
                string clientt = datalabel.Rows[0]["KhachHang"].ToString();
                lbClientFullname.Text = clientt;
                string soHoaDon = datalabel.Rows[0]["soHoaDonNew"].ToString();
                lbIdBill.Text = soHoaDon;
                string staff = datalabel.Rows[0]["tenNhanVien"].ToString();
                lbStaffFullname.Text = staff;
                string idPhong = datalabel.Rows[0]["idPhong"].ToString();
                lbIdRoom.Text = idPhong;
                string soLuong = datalabel.Rows[0]["soNguoi"].ToString();
                lbNumpeople.Text = soLuong;
                string ngayThuc = datalabel.Rows[0]["soNgayThuc"].ToString();
                lbNumday.Text = ngayThuc;
                string ngayThanhToan = datalabel.Rows[0]["ngayTra"].ToString();
                lbDateBill.Text = ngayThanhToan;
                string tongTien = datalabel.Rows[0]["tienPhong"].ToString();
                lbTotal.Text = tongTien;
            }

            DataTable dtGridDichVu = BUShoaDon.getBillDichVuDetail(cHoaDon);
            dataGridView1.DataSource = dtGridDichVu;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNumday_Click(object sender, EventArgs e)
        {

        }
    }
}
