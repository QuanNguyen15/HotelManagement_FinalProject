using BusinessLogic;
using DataAccess;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmBillDetail : Form
    {
        BUSPhong busPhong = new BUSPhong();
        BUSHoaDon busHoaDon=new BUSHoaDon();
        BUSHoaDonPhong busHoaDonPhong = new BUSHoaDonPhong();
        BUSDatPhong busDatPhong = new BUSDatPhong();

        classPhong room;
        tabRoom roomTab;
        DataTable dtGridDichVu;
        public frmBillDetail(classPhong cPhong , tabRoom tRoom)
        {
            room = cPhong;
            roomTab = tRoom;    
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            string tenRoom = room.tenPhong;
            classHoaDon hoaDon=new classHoaDon();
            hoaDon.tenHoaDon = tenRoom;
            DataTable dtBill= busHoaDon.getBill(hoaDon);


            if (dtBill.Columns.Contains("KhachHang"))
            {
                string clientt = dtBill.Rows[0]["KhachHang"].ToString();
                lbClientFullname.Text = clientt;
                string soHoaDon = dtBill.Rows[0]["soHoaDonNew"].ToString();
                lbIdBill.Text = soHoaDon;
                string staff = dtBill.Rows[0]["tenNhanVien"].ToString();
                lbStaffFullname.Text = staff;
                string idPhong = dtBill.Rows[0]["idPhong"].ToString();
                lbIdRoom.Text = idPhong;
                string soLuong = dtBill.Rows[0]["soNguoi"].ToString();
                lbNumpeople.Text = soLuong;

            }
            string ngayThuc = dtBill.Rows[0]["SoNgayThuc"].ToString();
            lbNumday.Text = ngayThuc;
            // Lấy thời gian thực
            DateTime thoiGianThuc = DateTime.Now;
            string chuoiThoiGian = thoiGianThuc.ToString("yyyy /MM/dd HH:mm:ss");

            lbDateBill.Text = chuoiThoiGian;

            dtGridDichVu = busHoaDon.getBillDichVu(hoaDon);
            dataGridView1.DataSource = dtGridDichVu;

            DataTable dtDonGiaPhong = busPhong.GetDonGiaByIdPhong(room);
            decimal donGiaPhong = Convert.ToDecimal(dtDonGiaPhong.Rows[0][0]);
            decimal tongTienDichVu = 0;
            decimal TongNgayThuc = decimal.Parse(lbNumday.Text);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra xem dòng có được chọn hay không
                if (!row.IsNewRow)
                {
                    // Kiểm tra giá trị cột có thể được chuyển đổi thành decimal hay không
                    if (row.Cells["TongDonGia"].Value != null && Decimal.TryParse(row.Cells["TongDonGia"].Value.ToString(), out decimal giaTri))
                    {
                        // Tính tổng
                        tongTienDichVu += giaTri;
                    }
                }
            }

            decimal tongHoaDon = (TongNgayThuc * donGiaPhong) + tongTienDichVu;
            string tongHoaDonFormat = tongHoaDon.ToString("#,##0.000");
            billDetail(TongNgayThuc, donGiaPhong);
            lbTotal.Text = tongHoaDonFormat;






            string idHoaDon = dtBill.Rows[0]["idHoaDon"].ToString();
            string idDatPhong = dtBill.Rows[0]["idDatPhong"].ToString();

            int parsedIdHoaDon = int.Parse(idHoaDon);
            int parsedIdDatPhong = int.Parse(idDatPhong);

            int soNgayThuc = int.Parse(ngayThuc);

            /*   DateTime thoiGianChuyenDoi;
               thoiGianChuyenDoi = DateTime.ParseExact(chuoiThoiGian, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);*/
            classDatPhong classDatPhong = new classDatPhong();
            classDatPhong.idDatPhong = parsedIdDatPhong;
            classDatPhong.ngayThuc = soNgayThuc;
            busDatPhong.UpdateSoNgayThuc(classDatPhong);

            classHoaDonPhong hoaDonPhong = new classHoaDonPhong(parsedIdHoaDon, parsedIdDatPhong, tongHoaDon, thoiGianThuc);
            busHoaDonPhong.UpdateHoaDonPhong(hoaDonPhong);


            room.trangThai = "Maintenaning";
            busPhong.updatePhong(room);


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

        public void billDetail(decimal TongNgayThuc, decimal dongiaPhong)
        {
            decimal total = 0;


            // Add a new row to the DataTable
            DataRow totalRow = dtGridDichVu.NewRow();
            totalRow["tenDichVu"] = room.tenPhong;  // Replace "columnName3" with the actual column name
            totalRow["donGia"] = dongiaPhong;
            totalRow["TongSoLuong"] = TongNgayThuc; 
            totalRow["TongDonGia"] = TongNgayThuc* dongiaPhong;
            dtGridDichVu.Rows.Add(totalRow);


        }
    }
    }
