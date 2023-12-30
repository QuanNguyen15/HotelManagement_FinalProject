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
    public partial class frmClientInformation : Form
    {
        public frmClientInformation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void frmClientInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to log out the account?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void pnFather_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
