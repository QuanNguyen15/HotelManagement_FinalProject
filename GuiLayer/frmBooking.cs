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

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime aDateTime = DateTime.Now;
           
            DateTime dateTime = dateTimePickerCheckin.Value;
            string time = dateTime.ToString();
            MessageBox.Show(time);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
