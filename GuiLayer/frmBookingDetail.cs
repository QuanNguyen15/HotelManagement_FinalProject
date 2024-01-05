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
    public partial class frmBookingDetail : Form
    {
        BUSHoaDon busHoaDon = new BUSHoaDon();
        string idBook;
        public frmBookingDetail(string id)
        {
            idBook = id;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            classHoaDon hoaDon = new classHoaDon();
            int id = int.Parse(idBook);
            hoaDon.idHoaDon = id;

            DataTable dt = new DataTable();
            dt = busHoaDon.getBooking(hoaDon);
            dataGridViewBookingDetail.DataSource = dt;

            DataTable dtLable = new DataTable();
            dtLable = busHoaDon.getBookinglable(hoaDon);

            if (dtLable.Columns.Contains("tenKhachHang"))
            {
                string clientt = dtLable.Rows[0][1].ToString();
                lbClient.Text = clientt;
                string time = dtLable.Rows[0]["ngayDat"].ToString();
                lbDateTime.Text = time;
                string staff = dtLable.Rows[0]["hoten"].ToString();
                lbStaff.Text = staff;
                string idHoaDon = dtLable.Rows[0]["idHoaDon"].ToString();
                label1.Text = idHoaDon;
            }
            else
            {
                MessageBox.Show("");
            }

        }

        private void dataGridViewBookingDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
