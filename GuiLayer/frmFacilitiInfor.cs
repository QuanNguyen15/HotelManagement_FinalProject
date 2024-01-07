using BusinessLogic;
using DataAccess;
using ServiceStack;
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
    public partial class frmFacilitiInfor : Form
    {
        BUSThietBi busThietBi=new BUSThietBi(); 
        public tabService Tabservice;
        public frmFacilitiInfor(tabService Tservice)
        {
            Tabservice = Tservice;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;    
            string price =txtPrice.Text;
            int id = Convert.ToInt32(lbFacilitiName.Text.Trim());

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(price))
            {

                decimal priceDecimal = Convert.ToDecimal(price);
                classThietBi thietBi = new classThietBi(id, name, priceDecimal);
                bool Update = busThietBi.UpdateThietBi(thietBi);
                if (Update)
                {
                    MessageBox.Show("Update successfull");
                    Tabservice.refeshThietBi();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields. ");
            }

        }

        public void setFacilitiInformation(string Name, string Price)
        {
            txtName.Text = Name;
            txtPrice.Text = Price;
        }

        public void setFacilitiID(string id)
        {
            lbFacilitiName.Text = id;

        }
    }
    }
