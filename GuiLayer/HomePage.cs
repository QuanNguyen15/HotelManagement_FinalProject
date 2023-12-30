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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PanelMove(Control btn)
        {
            pnIMove.Top = btn.Top;
            pnIMove.Height = btn.Height;
        }
        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelMove(btnHome);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            PanelMove(btnRoom);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            PanelMove(btnBooking);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PanelMove(btnClient);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            PanelMove(btnBill);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            PanelMove(btnService);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to log out the account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PanelMove(btnLogout);
                /*timerDateAndTime.Stop();*/
                this.Close();
            }
        }
    }
}
