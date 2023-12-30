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
                
                if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                    
                        dataGridViewCLient.Rows.RemoveAt(e.RowIndex);
                    }
                    
                }
                
                else if (dataGridViewCLient.Columns[e.ColumnIndex].HeaderText == "Information")
                {
                    
                    frmClientInformation infoForm = new frmClientInformation();
                    infoForm.ShowDialog(); 
                }
            }

        }

        private void tabClient_Load(object sender, EventArgs e)
        {

        }
    }
}
