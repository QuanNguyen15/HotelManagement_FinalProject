using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GuiLayer
{
    public partial class billDetail2 : Form
    {
        DataTable dtGridDichVu;
        int id;
        BUSHoaDon BUShoaDon = new BUSHoaDon();
        public billDetail2(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void billDetail2_Load(object sender, EventArgs e)
        {
            classHoaDon cHoaDon = new classHoaDon();
            cHoaDon.soHoaDon = id;
            DataTable datalabel = new DataTable();
            datalabel = BUShoaDon.getBillDetail(cHoaDon);


                string clientt = datalabel.Rows[0]["KhachHang"].ToString();
                lbClientFullname.Text = clientt;
                string soHoaDon = datalabel.Rows[0]["soHoaDonNew"].ToString();
                lbIdBill.Text = soHoaDon;
                string staff = datalabel.Rows[0]["tenNhanVien"].ToString();
                lbStaffFullname.Text = staff;
                string idPhong = datalabel.Rows[0]["idPhong"].ToString();
                lbIdRoom.Text = idPhong;
                string soLuong = datalabel.Rows[0]["soNguoi"].ToString();
                lbNumpeople.Text = soLuong;
                string ngayThuc = datalabel.Rows[0]["soNgayThuc"].ToString();
                lbNumday.Text = ngayThuc;
                string ngayThanhToan = datalabel.Rows[0]["ngayTra"].ToString();
                lbDateBill.Text = ngayThanhToan;
                string tongTien = datalabel.Rows[0]["tienPhong"].ToString();
                decimal parsedTongTien;

                string tenPhong = datalabel.Rows[0]["tenPhong"].ToString();
                string giaPhong = datalabel.Rows[0]["donGia"].ToString();
                if (decimal.TryParse(tongTien, out parsedTongTien))
                {             
                    string tongTienFormat = parsedTongTien.ToString("#,##0.000");

                    // Hiển thị kết quả trong lbTotal
                    lbTotal.Text = tongTienFormat;
                }
                else
                {
                   
                    lbTotal.Text = "Không hợp lệ";
                }


            

            dtGridDichVu = BUShoaDon.getBillDichVuDetail(cHoaDon);
            dataGridView1.DataSource = dtGridDichVu;
            billDetail(tenPhong, giaPhong, ngayThuc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNumday_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);

                // Hiển thị hộp thoại nhập tên file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn đầy đủ cho tệp PDF từ hộp thoại nhập tên file
                    string outputPath = saveFileDialog.FileName;

                    // Kiểm tra xem thư mục tồn tại chưa, nếu chưa thì tạo mới
                    string directory = Path.GetDirectoryName(outputPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    // Thiết lập máy in để in ra tệp PDF
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = pd;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        pd.PrinterSettings.PrintToFile = true;
                        pd.PrinterSettings.PrintFileName = outputPath;
                        pd.Print();

                        // Hiển thị địa chỉ in sau khi in và lưu thành công
                        MessageBox.Show("Đã in PDF và lưu thành công!\nĐịa chỉ in: " + outputPath);
                    }
                }
            }
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {

            // Lưu trạng thái ban đầu của FormBorderStyle
            FormBorderStyle originalFormBorderStyle = this.FormBorderStyle;

            // Tạm thời vô hiệu hóa việc vẽ khung control
            this.FormBorderStyle = FormBorderStyle.None;

            // Chuyển đổi cửa sổ Windows Form thành hình ảnh và vẽ nó ở giữa trang in
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

            float x = (e.PageBounds.Width - bitmap.Width) / 2;
            float y = (e.PageBounds.Height - bitmap.Height) / 2;

            e.Graphics.DrawImage(bitmap, x, y);

            // Khôi phục lại FormBorderStyle
            this.FormBorderStyle = originalFormBorderStyle;
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
        public void billDetail(string tenPhong, string giaPhong,string ngayThuc)
        {
            decimal total = 0;



            DataRow totalRow =dtGridDichVu.NewRow();
            totalRow["tenDichVu"] = tenPhong;  // Replace "columnName3" with the actual column name
            totalRow["donGia"] = decimal.Parse(giaPhong);
            totalRow["TongSoLuong"] = int.Parse(ngayThuc);

            totalRow["TongDonGia"] = decimal.Parse(ngayThuc) * decimal.Parse(giaPhong);
            dtGridDichVu.Rows.Add(totalRow);





        }

    }
}
