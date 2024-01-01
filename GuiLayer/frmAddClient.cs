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

namespace GuiLayer
{
    public partial class frmAddClient : Form
    {
        BUSKhachHang busKhachHang = new BUSKhachHang();
        bool save;
        private tabClient tabClient = new tabClient() ;

        public frmAddClient()
        {
            InitializeComponent();
            
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
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
            string hoTen = txtName.Text;
            string gioiTinh = null;
            string soCDCD = txtIdCard.Text;
            string dienThoai = txtPhone.Text;
            string email = txtEmail.Text;
            string diachi = txtAddress.Text;


            foreach (Control control in pnRadio.Controls)
            {
                if (control is RadioButton radioButton)
                {

                    if (radioButton != null && radioButton.Checked)
                    {
                        string Option = radioButton.Text;
                        if (Option == "Male")
                        {
                            gioiTinh = "Male";
                        }
                        else if (Option == "Female")
                        {
                            gioiTinh = "Female";
                        }
                        else if (Option == "Other")
                        {
                            gioiTinh = "Other";
                        }
                        else
                        {
                            MessageBox.Show("Please fill full information");
                        }

                    }
                }
            }

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soCDCD) || string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Please fill full information");
            }
            else
            {
                MessageBox.Show(hoTen + gioiTinh + soCDCD + dienThoai + email + diachi);
                classKhachHang khachHang;
                khachHang = new classKhachHang(hoTen, gioiTinh, soCDCD, dienThoai, email, diachi);


                save = busKhachHang.addKhachHang(khachHang);
                if (save)
                {
                    MessageBox.Show("add thanh cong");
                    tabClient.RefreshDataGridView(); 
                    this.Close();

                }
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
