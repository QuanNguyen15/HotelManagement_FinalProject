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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 59 )
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnHome.Width = sidebar.Width;
                    pnMyroom.Width = sidebar.Width;
                    pnBookingroom.Width = sidebar.Width;
                    pnBill.Width = sidebar.Width;
                    pnClient.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnHome.Width = sidebar.Width;
                    pnMyroom.Width = sidebar.Width;
                    pnBookingroom.Width = sidebar.Width;
                    pnBill.Width = sidebar.Width;
                    pnClient.Width = sidebar.Width;
                    pnAbout.Width = sidebar.Width;
                }

            }
        }

        
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
