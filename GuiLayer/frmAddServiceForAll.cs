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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GuiLayer
{
    public partial class frmAddServiceForAll : Form
    {
        BUSDichVu busDichVu = new BUSDichVu();
        public tabService TabService; 
        public frmAddServiceForAll(tabService service)
        {
            TabService = service;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string name =txtName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string loaiSanPham = cbLoaiDichVu.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(loaiSanPham) )
            {
                MessageBox.Show("Please fill in all information");
            }else if (! IsNumeric(price))
            {
                MessageBox.Show("Please fill price is number");
            }
            else
            {
                decimal isPrice = Convert.ToDecimal(price);
                classDichVu dichVu = new classDichVu();
                dichVu.tenDichVu = name;
                dichVu.donGia = isPrice;
                dichVu.loaiDichVu = loaiSanPham;
                busDichVu.addDichVu(dichVu);
                MessageBox.Show("Add successfully");
                TabService.refeshService();
                this.Close();

            }

        }

        static bool IsNumeric(string input)
        {
            // \d+ một hoặc nhiều chữ số, (\.\d+)? kiểm tra thập phân 

            string pattern = @"^\d+(\.\d+)?$";

            return Regex.IsMatch(input, pattern);
        }
        private void frmAddServiceForAll_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
