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
            string hoTen = txtName.Text.Trim();
            string gioiTinh = null;
            string soCDCD = txtIdCard.Text.Trim();
            string dienThoai = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diachi = txtAddress.Text.Trim();
            bool check = true;
            bool checkTime = true;
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
            else if (!soCCCDmax(soCDCD) && !dienThoaiMax(dienThoai))
            {
                
                MessageBox.Show($"The ID card number must be 12 numbers and the phone number must be 10 numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (!soCCCDmax(soCDCD) || !dienThoaiMax(dienThoai))
            {
                if (!soCCCDmax(soCDCD))
                {
                    MessageBox.Show($"The ID card number must be 12 ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(!dienThoaiMax(dienThoai))
                {
                    MessageBox.Show($"The phone number must be 10 numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        public bool soCCCDmax(string input)
        {
            string pattern = @"^\d{12}$";

            return Regex.IsMatch(input, pattern);
        }

        public bool dienThoaiMax(string input)
        {           
            string pattern = @"^\d{10}$";

            return Regex.IsMatch(input, pattern);
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
