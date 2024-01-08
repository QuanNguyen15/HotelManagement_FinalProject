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
            MessageBox.Show("year " + year + "thang" + thang);
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
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co muon xuat file excel khong", "Hoi", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                toExcel1(dt, "RevenueReport");
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
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "RevenueReport";
                /*
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                                }*/
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Rows[i].ItemArray.Length) // Kiểm tra xem cột thứ j có tồn tại không
                        {
                            worksheet.Cells[i + 3, j + 1] = dt.Rows[i][j].ToString();
                        }
                        else
                        {
                            MessageBox.Show("cot j khong ton tai");
                        }

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
        public static void toExcel1(DataTable dt, string fileName)
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

                workbook = excel.Workbooks.Open("C:\\Users\\Admin\\Downloads\\RevenueReport (1).xlsx");

                string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName, "BangLoaiHang.xlsx");

                /*                string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "BangLoaiHang.xlsx");
                                string text = System.IO.File.ReadAllText(filePath);*/

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "loaihang";

                /*for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }*/
                int fixedRow = 13; // Dòng cố định
                int currentRow = 4; // Dòng bắt đầu từ 4

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[currentRow, j + 1].Value = dt.Rows[i][j].ToString();
                    }

                    // Kiểm tra nếu đang ở dòng cố định, chèn một dòng mới
                    if (currentRow == fixedRow)
                    {
                        InsertRow(worksheet, currentRow + 1);
                        // Tăng giá trị của dòng cố định và dòng hiện tại
                        fixedRow++;
                        currentRow++;
                    }

                    // Tăng giá trị của dòng hiện tại
                    currentRow++;
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

    }
}
