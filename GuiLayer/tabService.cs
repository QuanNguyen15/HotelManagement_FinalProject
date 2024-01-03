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
    public partial class tabService : UserControl
    {
        public tabService()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddServiceForAll addServiceForAll = new frmAddServiceForAll();
            addServiceForAll.ShowDialog();
        }

        private void btnAddfacilities_Click(object sender, EventArgs e)
        {
            frmAddFacilities addFacilities = new frmAddFacilities(); 
            addFacilities.ShowDialog();
        }
    }
}
