using BusinessLogic;
using DataAccess;
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
    public partial class tabStatistic : UserControl
    {
        BUSHoaDon busHoaDon =new BUSHoaDon();
        public tabStatistic()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport(); 
            report.ShowDialog();
        }

        private void tabStatistic_Load(object sender, EventArgs e)
        {
            // Lấy thời gian thực
            DateTime thoiGianThuc = DateTime.Now;

            // Lấy ngày, tháng và năm từ thời gian thực
            int month = thoiGianThuc.Month;
            string chuoiMonth= month.ToString();
            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = chuoiMonth;

            
            string tongTienDV= busHoaDon.SelectTongTienDichVuPhongByMonth(hoaDon);
            string tongTienPhong = busHoaDon.SelectTongTienPhongByMonth(hoaDon);
            string tongSoDatPhong = busHoaDon.SelectSoPhongByMonth(hoaDon);

            label5.Text = tongTienDV;
            label6.Text = tongSoDatPhong;
            label4.Text = tongTienPhong;

            decimal tongTienPhongTrongThanh = decimal.Parse(tongTienDV) + decimal.Parse(tongTienPhong);

            
            chartRevenue.Series["RevenueMonth"].Points.AddXY("January", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("February", tongTienPhong);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("March", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("April", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("May", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("June", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("Junly", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("August", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("September", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("October", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("November", tongTienPhongTrongThanh);
            chartRevenue.Series["RevenueMonth"].Points.AddXY("December", tongTienPhongTrongThanh);

            
        }
    }
}
