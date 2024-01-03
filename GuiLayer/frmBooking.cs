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
    public partial class frmBooking : Form
    {
        BUSPhong busPhong = new BUSPhong(); 
        public frmBooking()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busPhong.getRoomAvailable();
            dataGridViewRoomAvail.DataSource = dt;

        }
    }
}
