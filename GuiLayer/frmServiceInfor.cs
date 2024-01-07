using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace GuiLayer
{
    public partial class frmServiceInfor : Form
    {
        BUSDichVu busDichVu = new BUSDichVu();
        public tabService Tabservice;
        public frmServiceInfor(tabService Tservice)
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
            if (lbServiceName.Text != null && txtName.Text != null && txtPrice.Text != null && cbLoaiDichVu.Text != null)
            {

                int id = Convert.ToInt32(lbServiceName.Text);
                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                string loaiSanPham = cbLoaiDichVu.Text;

                classDichVu dichVu = new classDichVu(id,name,loaiSanPham,price);
                bool Update = busDichVu.UpdateDichVu(dichVu);
                if (Update)
                {
                    MessageBox.Show("Update successfull");
                    Tabservice.refeshService();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill full field: ");
            }


        }


        public void setServiceInformation(string Name, string Price, string LoaiDichVu)
        {
            txtName.Text = Name;
            txtPrice.Text = Price;
            cbLoaiDichVu.Text = LoaiDichVu;
        }

        public void setServiceId(string id)
        {
            lbServiceName.Text = id;

        }

        private void cbLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}