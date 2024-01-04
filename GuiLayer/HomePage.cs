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
        private string loggedInUser;
        public HomePage(string username)
        {
            InitializeComponent();
            loggedInUser = username;
            lbUser.Text = loggedInUser;
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
            timerDateAndTime.Start();
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = true;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = false;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelMove(btnHome);
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = true;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            PanelMove(btnRoom);
            tabBill1.Visible = false;
            tabRoom1.Visible = true;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = false;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            PanelMove(btnBooking);
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = true;
            tabService1.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PanelMove(btnClient);
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = true;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            PanelMove(btnBill);
            tabBill1.Visible = true;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = false;
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            PanelMove(btnService);
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking1.Visible = false;
            tabService1.Visible = true;
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            PanelMove(btnStatistic);
            tabBill1.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible =true;
            tabBooking1.Visible = false;
            tabService1.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to log out the account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                timerDateAndTime.Stop();
                this.Hide();
                frmLogIn login = new frmLogIn();
                login.ShowDialog();
                this.Close();


            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lbDateAndTime.Text = DateTime.Now.ToString("dd-MMM-yyyy       hh:mm:ss tt ");
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabClient1_Load(object sender, EventArgs e)
        {

        }


        private void tabStatistic1_Load(object sender, EventArgs e)
        {

        }

        private void tabBooking1_Load(object sender, EventArgs e)
        {

        }
    }
}
