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
    public partial class frmAddFacilities : Form
    {
        BUSThietBi busThietbi = new BUSThietBi();
        public tabService TabService;
        public frmAddFacilities(tabService service)
        {
        
            InitializeComponent();
            TabService = service;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string price =txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill in all information");
            }
            else if (!IsNumeric(price))
            {
                MessageBox.Show("Please fill price is number");
            }
            else
            {
                decimal isPrice = Convert.ToDecimal(price);
                classDichVu dichVu = new classDichVu();
                classThietBi thietbi = new classThietBi();
                thietbi.tenThietBi = name;
                thietbi.donGia = isPrice;
                busThietbi.addThietBi(thietbi);
                MessageBox.Show("Add successfully");
                TabService.refeshThietBi();
                this.Close();
            }

        }
        static bool IsNumeric(string input)
        {
            // \d+ một hoặc nhiều chữ số, (\.\d+)? kiểm tra thập phân 

            string pattern = @"^\d+(\.\d+)?$";

            return Regex.IsMatch(input, pattern);
        }

        private void frmAddFacilities_Load(object sender, EventArgs e)
        {

        }
    }
}
