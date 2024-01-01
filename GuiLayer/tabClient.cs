﻿using BusinessLogic;
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
    public partial class tabClient : UserControl
    {
        BUSKhachHang bUSKhachHang = new BUSKhachHang();
        public tabClient()
        {
            InitializeComponent();
        }

        private void dataGridViewCLient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        dataGridViewCLient.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Xóa thành công!");
                    }

                }
                else if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    // Lấy thông tin từ dòng được chọn
                    DataGridViewRow selectedRow = dataGridViewCLient.Rows[e.RowIndex];
                    string id = selectedRow.Cells["idKhachHang"].Value.ToString();
                    string name = selectedRow.Cells["hoTen"].Value.ToString();
                    string idCard = selectedRow.Cells["soCCCD"].Value.ToString();
                    string phone = selectedRow.Cells["dienThoai"].Value.ToString();
                    string email = selectedRow.Cells["email"].Value.ToString();
                    string address = selectedRow.Cells["diaChi"].Value.ToString();
                    string gender = selectedRow.Cells["gioiTinh"].Value.ToString();
                    

                    // Tạo form mới và truyền thông tin vào
                    frmClientInformation infoForm = new frmClientInformation();
                    infoForm.SetClientInformation(id, name, idCard, phone, email, address, gender);
                    infoForm.SetClientInformation(id);
                    infoForm.ShowDialog();
                }
            }

        }


        private void tabClient_Load(object sender, EventArgs e)
        {
            DataTable dt = bUSKhachHang.getKhachHang();
            dataGridViewCLient.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientInformation infoForm = new frmClientInformation();
            infoForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddClient addClient = new frmAddClient();
            addClient.ShowDialog(); 
        }
    }
}
