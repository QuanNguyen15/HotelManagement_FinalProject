using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
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
    public partial class frmAddSevice : Form
    {
        BUSDichVu bUSSanPham = new BUSDichVu(); 
        public frmAddSevice()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void frmAddSevice_Load(object sender, EventArgs e)
        {
            BUSDichVu bUSSanPham = new BUSDichVu();
            DataTable dt =bUSSanPham.getDichVu();
            foreach (DataRow row in dt.Rows)
            {                
                string tenSanPham = row["TenSanPham"].ToString();
                comboBox1.Items.Add(tenSanPham);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            comboBox1.Items.Clear();
            classDichVu sanPham = new classDichVu();
            sanPham.tenDichVu = searchText;
            BUSDichVu bUSSanPham = new BUSDichVu();
            DataTable dt = bUSSanPham.searchSanPham(sanPham);
            foreach (DataRow row in dt.Rows)
            {
                string tenSanPham = row["TenSanPham"].ToString();
                comboBox1.Items.Add(tenSanPham);
            }
        }
    }
}
