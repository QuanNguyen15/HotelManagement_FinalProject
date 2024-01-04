using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmLogIn : Form
    {
        BUSTaiKhoan busTaiKhoan = new BUSTaiKhoan();
        public frmLogIn()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            List<classTaiKhoan> listTaiKhoan = busTaiKhoan.getTaiKhoanList();
            bool isLoggedIn = false;
            foreach (classTaiKhoan taikhoan in listTaiKhoan)
            {
             
                if (username == taikhoan.userName && password == taikhoan.password)
                {
                    isLoggedIn = true;
                    break; // Thoát vòng lặp khi đã tìm thấy kết quả khớp
                }
            }

            if (isLoggedIn)
            {
                this.Hide();
                HomePage home = new HomePage(txtUserName.Text);
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowpass.Checked)
            {

                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {

                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lbContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://web.facebook.com/profile.php?id=100039986584807");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10; // Độ cong muốn áp dụng
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            Rectangle bounds = panel1.ClientRectangle;
            bounds.Inflate(-borderRadius, -borderRadius);
            path.AddArc(bounds.X, bounds.Y, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius * 2, bounds.Y, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(bounds.X + bounds.Width - borderRadius * 2, bounds.Y + bounds.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            panel1.Region = new Region(path);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
