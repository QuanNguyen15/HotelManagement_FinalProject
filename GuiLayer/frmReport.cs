using BusinessLogic;
using DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuiLayer
{
    public partial class frmReport : Form
    {
        BUSHoaDon busHoaDon = new BUSHoaDon();
        DataTable dt = new DataTable();
        double total;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            string year = cbYear.Text.Trim();
            string thang = cbMonth.Text.Trim();
            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = year;
            hoaDon.loaiHoaDon = thang;
            dt = busHoaDon.SelectHoaDonByMonthAndYear(hoaDon);
            dataGridViewReport.DataSource = dt;


            dataGridViewReport.AllowUserToAddRows = false;




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
            string thang = cbMonth.Text.Trim(); ;
            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = year;
            hoaDon.loaiHoaDon = thang;
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
            totalRevenue();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon xuat file excel khong", "Hoi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                toExcel(dt, "RevenueReportNews");
            }
            else
            {
                return;
            }
        }

       public static void toExcel(DataTable dt, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;

                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                workbook = excel.Workbooks.Open("C:\\Users\\nguye\\Downloads\\RevenueReport.xlsx");
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //worksheet.Name = "RevenueReport";

                for (int i = 0; (i < dt.Rows.Count); i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 4, j + 1] = dt.Rows[i][j].ToString();

                    }
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuat du lieu thanh cong ra Excel!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }


        public void totalRevenue()
        {
            decimal total = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dt.Rows[i]["tienPhong"]);
            }

            // Add a new row to the DataTable
            DataRow totalRow = dt.NewRow();
            totalRow["tenNhanVien"] = "Total";  // Replace "columnName3" with the actual column name
            totalRow["tienPhong"] = total;
            dt.Rows.Add(totalRow);
            DataRow signalRow = dt.NewRow();
            signalRow["tenNhanVien"] = "Signal";
            dt.Rows.Add(signalRow);


            // Set the font style to bold for the "Total" row
            if (dataGridViewReport.Rows.Count > 0)
            {
                int totalRowIndex = dataGridViewReport.Rows.Count - 2; // Assuming "Total" is the second last row
                dataGridViewReport.Rows[totalRowIndex].DefaultCellStyle.Font = new Font(dataGridViewReport.DefaultCellStyle.Font, FontStyle.Bold);
            }

            // Set the font style to bold for the "Signal" row
            if (dataGridViewReport.Rows.Count > 0)
            {
                int signalRowIndex = dataGridViewReport.Rows.Count - 1; // Assuming "Signal" is the last row
                dataGridViewReport.Rows[signalRowIndex].DefaultCellStyle.Font = new Font(dataGridViewReport.DefaultCellStyle.Font, FontStyle.Bold);
            }

        }


    }
}
