using BusinessLogic;
using DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmReport : Form
    {
        BUSHoaDon busHoaDon = new BUSHoaDon();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            string year = cbYear.Text.Trim();
            string nam = cbMonth.Text.Trim();
            classHoaDon hoaDon= new classHoaDon();
            hoaDon.tenHoaDon = year;
            hoaDon.loaiHoaDon = nam;
            DataTable dt = new DataTable();
            dt = busHoaDon.SelectHoaDonByMonthAndYear(hoaDon);
            dataGridViewReport.DataSource = dt;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGridview();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshDataGridview();
        }

        public void refreshDataGridview()
        {
            string year = cbYear.Text.Trim();
            string nam = cbMonth.Text.Trim();
            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = year;
            hoaDon.loaiHoaDon = nam;
            DataTable dt = new DataTable();
            dt = busHoaDon.SelectHoaDonByMonthAndYear(hoaDon);
            dataGridViewReport.DataSource = dt;
      

            decimal tong = 0;

            foreach (DataGridViewRow row in dataGridViewReport.Rows)
            {
                // Kiểm tra xem dòng có được chọn hay không
                if (!row.IsNewRow)
                {
                    // Kiểm tra giá trị cột có thể được chuyển đổi thành decimal hay không
                    if (row.Cells["tongTien"].Value != null && Decimal.TryParse(row.Cells["tongTien"].Value.ToString(), out decimal giaTri))
                    {
                        // Tính tổng
                        tong += giaTri;
                    }
                }
            }

            string chuoiTong = tong.ToString();
            lbTotal.Text = chuoiTong;
        }

    }
}
