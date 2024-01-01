using BusinessLogic;
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
            dt = bUSKhachHang.getKhachHang();
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

        public void getAllKhachHang(string hoten , string gioiTinh,string card, string dienThoai, string email, string diaChi)
        {
            DataTable dt = bUSKhachHang.getKhachHang();
            dataGridViewCLient.DataSource = dt;
            DataRow dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = hoten;
            dr[2] = gioiTinh;
            dr[3] = card;
            dr[4] = dienThoai;
            dr[5] = email;
            dr[6] = diaChi;
            dr[6] = diaChi;
            dr[6] = diaChi;

            dt.Rows.Add(dr);
            dataGridViewCLient.DataSource = dt;
        }


        public void RefreshDataGridView()
        {
           
            dataGridViewCLient.DataSource = bUSKhachHang.getKhachHang(); ;
            dataGridViewCLient.Refresh();
            MessageBox.Show("show");
        }



        public void callBack() { 
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
