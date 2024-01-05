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
    public partial class tabBooking : UserControl
    {
        BUSDatPhong busDatPhong = new BUSDatPhong();
        BUSHoaDon busHoaDon = new BUSHoaDon();

        public tabBooking()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmBooking booking = new frmBooking(this);
            booking.ShowDialog();
            
        }

        private void tabBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busDatPhong.getDatPhongChiTiet();
            dataGridViewBooking.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            if (search != "")
            {
                classHoaDon hoaDon = new classHoaDon();

                DataTable dataTable = new DataTable();

                hoaDon.tenHoaDon = search;
                dataTable = busHoaDon.serchBooking(hoaDon);
                dataGridViewBooking.DataSource = dataTable;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = busDatPhong.getDatPhongChiTiet();
                dataGridViewBooking.DataSource = dt;
            }


        }

        public void refreshdataGridview()
        {
            DataTable dt = new DataTable();
            dt = busDatPhong.getDatPhongChiTiet();
            dataGridViewBooking.DataSource = dt;
        }
        private void dataGridViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewBooking.Rows[e.RowIndex];
                string id = selectedRow.Cells["idHoaDon"].Value.ToString();
                MessageBox.Show(id);
                if (!string.IsNullOrEmpty(id))
                {
                    frmBookingDetail bookingDetail = new frmBookingDetail(id);
                    bookingDetail.ShowDialog();
                }
                

                
            }
        }
    }
}
