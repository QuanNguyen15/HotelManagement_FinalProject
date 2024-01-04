using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmAddClient : Form
    {
        BUSKhachHang busKhachHang = new BUSKhachHang();
        bool save;
        private tabClient TabClient ;

        public frmAddClient(tabClient tabClient)
        {
            TabClient = tabClient;
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
            bool check = true;
            List<classKhachHang> khachHangList = busKhachHang.getlistKhachHang();
            foreach (classKhachHang khachHangitem in khachHangList)
            {
                if (khachHangitem.soCCCD == soCDCD)
                {
                    MessageBox.Show("soCCCD was exist" + soCDCD);
                    check = false;
                }
                if (khachHangitem.dienThoai == dienThoai)
                {
                    check = false;
                    MessageBox.Show("Phone was exist" + dienThoai);
                }

            }



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

                    }
                }
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soCDCD) || string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Please fill in all information");
            }
            else if (!IsNumeric(soCDCD) || !IsNumeric(dienThoai))
            {
                MessageBox.Show("ID card number and phone must be numeric");
            }else if (!check)
            {

            }        
            else
            {
                classKhachHang khachHang = new classKhachHang(hoTen, gioiTinh, soCDCD, dienThoai, email, diachi);

                bool save = busKhachHang.addKhachHang(khachHang);
                if (save)
                {
                    TabClient.RefreshDataGridView();
                    MessageBox.Show("Add successfully");
                    this.Close();
                }
            }


        }


        static bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
