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

            string formattedTong = tong.ToString("#,##0.000");
            lbTotal.Text = formattedTong;
            totalRevenue();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Would you like to export the data to an Excel file?", "Question", MessageBoxButtons.YesNo);
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
            Microsoft.Office.Interop.Excel.Application excel = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Create a new workbook
                workbook = excel.Workbooks.Add(Type.Missing);

                // Assuming the first sheet is named "Sheet1"
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                // Clear existing data in the worksheet
                worksheet.Cells.Clear();
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Merge();
                worksheet.Cells[1, 1] = "Financial Report";
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 2]].Font.Size = 30;

                System.Drawing.Color myColor = System.Drawing.Color.FromArgb(34,84,54);

                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Interior.Color = System.Drawing.ColorTranslator.ToOle(myColor);

                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[2, 4]].Font.Bold = true;


                // Set the width of the merged cell to 20
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 2]].ColumnWidth = 20;
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 3]].ColumnWidth = 20;
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 4]].ColumnWidth = 20;
                // Center the text horizontally and vertically in the merged cell
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 2]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[1, 2], worksheet.Cells[1, 2]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 1]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 1]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                worksheet.Cells[2, 1] = "Bill_ID";

                worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 2]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 2]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[2, 2]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                worksheet.Cells[2, 2] = "Date Generate";

                worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 3]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 3]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[2, 3]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                worksheet.Cells[2, 3] = "Employee Name";

                worksheet.Range[worksheet.Cells[2, 4], worksheet.Cells[2, 4]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[2, 4], worksheet.Cells[2, 4]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                worksheet.Range[worksheet.Cells[2, 4], worksheet.Cells[2, 4]].Font.Bold = true;
                worksheet.Cells[2, 4] = "Reveration ID";

                worksheet.Range[worksheet.Cells[2, 5], worksheet.Cells[2, 1]].Font.Bold = true;
                worksheet.Cells[2, 5] = "Total";

                for(int i =1; i<6; i++)
                {
                    worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                }
                

                // Write data from DataTable to Excel starting from the second row
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        worksheet.Cells[i + 3, j + 1] = dt.Rows[i][j].ToString();
                    }
                }


                int lastRowIndex = dt.Rows.Count + 5;

                int totalIndex = dt.Rows.Count + 2;
                worksheet.Cells[totalIndex, 4] = "Total";

                worksheet.Range[worksheet.Cells[totalIndex, 5], worksheet.Cells[totalIndex, 5]].Font.Bold = true;

                // Make "Total" bold and center it in columns 4
                worksheet.Range[worksheet.Cells[totalIndex, 4], worksheet.Cells[totalIndex, 4]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[totalIndex, 4], worksheet.Cells[totalIndex, 4]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                worksheet.Range[worksheet.Cells[lastRowIndex, 4], worksheet.Cells[lastRowIndex, 5]].Merge();
                //worksheet.Range[worksheet.Cells[lastRowIndex, 5], worksheet.Cells[lastRowIndex, 6]].Merge();


                DateTime currentTime = DateTime.Now;
                string formattedDate = currentTime.ToString("dddd, dd MMMM yyyy");

                // Merge 4 dòng phía dưới "Signal"
                worksheet.Range[worksheet.Cells[lastRowIndex + 1, 4], worksheet.Cells[lastRowIndex + 4, 5]].Merge();

                worksheet.Cells[lastRowIndex - 1 , 4] = formattedDate;
                worksheet.Range[worksheet.Cells[lastRowIndex - 1, 4], worksheet.Cells[lastRowIndex - 1, 4]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[lastRowIndex - 1, 4], worksheet.Cells[lastRowIndex -1, 4]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                worksheet.Range[worksheet.Cells[lastRowIndex - 1, 4], worksheet.Cells[lastRowIndex - 1, 5]].Merge();
                worksheet.Range[worksheet.Cells[lastRowIndex - 1, 4], worksheet.Cells[lastRowIndex - 1, 5]].Merge();


                // Gán giá trị cho ô "Signal"
                worksheet.Cells[lastRowIndex, 4] = "Signal";

                // Make "Signal" bold and center it in columns 4
                worksheet.Range[worksheet.Cells[lastRowIndex, 4], worksheet.Cells[lastRowIndex, 4]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[lastRowIndex, 4], worksheet.Cells[lastRowIndex, 4]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Clear the content of column 5 (optional)
                worksheet.Cells[lastRowIndex, 5] = "";

                // Add borders to the merged cell (Financial Report)
                worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 5]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

                // Add borders to the header cells (Bill_ID, Date Generate, Employee Name, Reveration ID, Total)
                for (int i = 1; i < 6; i++)
                {
                    worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                    worksheet.Range[worksheet.Cells[2, i], worksheet.Cells[2, i]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                }

                // Add borders to the data cells
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                        worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        worksheet.Range[worksheet.Cells[i + 3, j + 1], worksheet.Cells[i + 3, j + 1]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                }

             /*   // Add borders to the "Total" cell
                worksheet.Range[worksheet.Cells[totalIndex, 4], worksheet.Cells[totalIndex, 4]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                worksheet.Range[worksheet.Cells[totalIndex, 4], worksheet.Cells[totalIndex, 4]].Font.Bold = true;
                worksheet.Range[worksheet.Cells[totalIndex, 4], worksheet.Cells[totalIndex, 4]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;*/

                // Prompt user to choose file name and location
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save changes and close with the chosen file name
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Exported data to Excel successfully!");
                }
                else
                {
                    // User canceled the operation
                    MessageBox.Show("Operation canceled by the user.");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
            finally
            {
                // Release COM objects
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excel);
            }

        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error releasing object: {ex.Message}");
            }
            finally
            {
                obj = null;
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
            totalRow["tienPhong"] = total;
            dt.Rows.Add(totalRow);
/*            DataRow signalRow = dt.NewRow();
            signalRow["tenNhanVien"] = "Signal";
            dt.Rows.Add(signalRow);*/




        }


    }
}
