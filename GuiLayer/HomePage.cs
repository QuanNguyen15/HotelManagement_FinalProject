using DataAccess.DAL;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
        tabClient client = null;
        int idTaiKhoan =1;
        int Role = 0;
        public HomePage(string username ,int idRole)
        {
            InitializeComponent();
            loggedInUser = username;
            lbUser.Text = loggedInUser;
            Role = idRole;
            if(Role == 1)
            {
                btnStatistic.Visible = true;
            }else
            {
                btnStatistic.Visible = false;
            }
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
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = true;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = false;
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelMove(btnHome);
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = true;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            PanelMove(btnRoom);
            tabBill2.Visible = false;
            tabRoom1.Visible = true;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = false;
            tabRoom1.getAll();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            PanelMove(btnBooking);
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking.Visible = true;
            tabService1.Visible = false;



        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PanelMove(btnClient);
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = true;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = false;
            tabClient1.RefreshDataGridView();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            PanelMove(btnBill);
            tabBill2.Visible = true;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = false;
            tabBill2.refreshDatagridview();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            PanelMove(btnService);
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible = false;
            tabBooking.Visible = false;
            tabService1.Visible = true;
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            PanelMove(btnStatistic);
            tabBill2.Visible = false;
            tabRoom1.Visible = false;
            tabClient1.Visible = false;
            tabHomePage1.Visible = false;
            tabStatistic1.Visible =true;
            tabBooking.Visible = false;
            tabService1.Visible = false;

            tabStatistic1.refresh();
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
