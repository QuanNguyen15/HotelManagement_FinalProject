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
using TheArtOfDev.HtmlRenderer.Adapters;

namespace GuiLayer
{
    public partial class frmClientInformation : Form
    {
        BUSKhachHang busKhachHang =new BUSKhachHang();
        tabClient client;

        public frmClientInformation(tabClient clientFrom1)
        {
            client = clientFrom1;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

       

        private void frmClientInformation_Load(object sender, EventArgs e)
        {
            
        }
        public void SetClientInformation(string id, string name, string idCard, string phone, string email, string address,string gender)
        {
            txtId.Text = id;
            txtName.Text = name;
            txtIdCard.Text = idCard;
            txtPhone.Text = phone;
            txtEmail.Text = email;
            txtAddress.Text = address;
            switch (gender)
            {
                case "Male":
                    rdMale.Checked = true;
                    break;
                case "Female":
                    rdFemale.Checked = true;
                    break;
                case "Other":
                    rdOther.Checked = true;
                    break;
                default:
                    // Xử lý trường hợp giới tính không hợp lệ
                    break;
            }
        }
        public void SetClientInformation(string id)
        {
            lbIdClient.Text = id; // Cập nhật giá trị ID lên Label
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void pnFather_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbIdClient_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idString = txtId.Text;
            int id = int.Parse(idString);

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
            }
            else
            {

                classKhachHang khachHang = new classKhachHang(id, hoTen, gioiTinh, dienThoai, email, diachi);
                bool update = busKhachHang.upDateKhachHang(khachHang);
                MessageBox.Show("Update successful");
                client.RefreshDataGridView();
                this.Close();

            }

            }
        static bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }
    }
}
