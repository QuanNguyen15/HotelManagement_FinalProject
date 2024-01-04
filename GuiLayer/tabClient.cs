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
using System.Xml.Linq;

namespace GuiLayer
{
    public partial class tabClient : UserControl
    {
        BUSKhachHang bUSKhachHang = new BUSKhachHang();
        DataTable dt;
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

                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        
                        DataGridViewRow selectedRow = dataGridViewCLient.Rows[e.RowIndex];
                        string id = selectedRow.Cells["idKhachHang"].Value.ToString();
                        int idAsInt = int.Parse(id);
                        classKhachHang khachHang=new classKhachHang();
                        khachHang.idKhachHang = idAsInt;
                        bUSKhachHang.deleteKhachHang(khachHang);
                        dataGridViewCLient.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Delete successfull");
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
                    frmClientInformation infoForm = new frmClientInformation(this);
                    infoForm.SetClientInformation(id, name, idCard, phone, email, address, gender);
                    infoForm.SetClientInformation(id);
                    infoForm.ShowDialog();
                }
            }

        }


        private void tabClient_Load(object sender, EventArgs e)
        {
            dt = bUSKhachHang.getKhachHang();
            dataGridViewCLient.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmClientInformation infoForm = new frmClientInformation(this);
            infoForm.ShowDialog();
        }

        //tao mot class frmAddClient 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddClient addClient = new frmAddClient(this); //truyen doi tuong this(tabClient)
            addClient.ShowDialog(); 
        }      

        public void RefreshDataGridView()
        {
            dt = bUSKhachHang.getKhachHang();
            //thuc hien load lai du lieu sau khi save du lieu moi
            dataGridViewCLient.DataSource = dt;
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if(searchTerm.Length > 0 )
            {
                classKhachHang khachHang = new classKhachHang();
                khachHang.hoTen = searchTerm;

                dt = bUSKhachHang.searchKhachHang(khachHang);
                dataGridViewCLient.DataSource = dt;
            }
            else
            {
                dt = bUSKhachHang.getKhachHang();
                dataGridViewCLient.DataSource = dt;
            }

        }
    }
}
