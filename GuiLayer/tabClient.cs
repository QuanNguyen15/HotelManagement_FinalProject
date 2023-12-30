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
        public tabClient()
        {
            InitializeComponent();
        }

        private void dataGridViewCLient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Kiểm tra xem người dùng đã nhấn vào một hàng hợp lệ không
            {
                // Kiểm tra nếu người dùng nhấn vào cột "Delete"
                if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    // Hiển thị thông báo xác nhận xóa
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra xem người dùng đã chọn "Yes" hay không
                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa hàng tương ứng
                        dataGridViewCLient.Rows.RemoveAt(e.RowIndex);
                    }
                    // Nếu chọn "No" hoặc đóng thông báo, không làm gì cả
                }
                // Kiểm tra nếu người dùng nhấn vào cột "Information"
                else if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Information")
                {
                    // Hiển thị form mới
                    frmClientInformation infoForm = new frmClientInformation();
                    infoForm.ShowDialog(); // Hiển thị form thông tin
                }
            }

        }

        private void tabClient_Load(object sender, EventArgs e)
        {

        }
    }
}
