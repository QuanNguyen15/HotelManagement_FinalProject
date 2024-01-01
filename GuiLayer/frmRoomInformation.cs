using BusinessLogic;
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
    public partial class frmRoomInformation : Form
    {
        BUSSanPham busSanPham = new BUSSanPham();
        public frmRoomInformation()
        {
            InitializeComponent();
        }

        private void frmRoomInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOTELSDataSet1.SanPham' table. You can move, or remove it, as needed.
            /* this.sanPhamTableAdapter.Fill(this.hOTELSDataSet1.SanPham);*/
            DataTable dt = new DataTable();
            dt = busSanPham.getSanPham();
            btnAddService.Visible = false;
            dataGridView1.DataSource = dt;

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            btnBook.Text = "Pay";
            btnAddService.Visible = true;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
           frmAddSevice addSevice = new frmAddSevice();
            addSevice.ShowDialog();
        }

        private void pnFatherSanPham_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
