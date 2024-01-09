using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            DateTime thoiGianThuc = DateTime.Now;
            int currentMonth = thoiGianThuc.Month;

            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = currentMonth.ToString();
            string tongTienDV = busHoaDon.SelectTongTienDichVuPhongByMonth(hoaDon);
            string tongTienPhong = busHoaDon.SelectTongTienPhongByMonth(hoaDon);

     
            decimal tongTienDVDecimal, tongTienPhongDecimal;

            if (decimal.TryParse(tongTienDV, out tongTienDVDecimal) &&
                decimal.TryParse(tongTienPhong, out tongTienPhongDecimal))
            {
    
                string tongTienDVFormat = tongTienDVDecimal.ToString("#,##0.000");
                string tongTienPhongFormat = tongTienPhongDecimal.ToString("#,##0.000");
                label5.Text = tongTienDVFormat;
                label4.Text = tongTienPhongFormat;

            }

            string tongSoDatPhong = busHoaDon.SelectSoPhongByMonth(hoaDon);
            decimal tongTienPhongTrongThanh = decimal.Parse(tongTienDV) + decimal.Parse(tongTienPhong);

            label6.Text = tongSoDatPhong;
     

            chartRevenue.Series["RevenueMonth"].Points.Clear(); // Clear existing points

            for (int i = 1; i <= 12; i++)
            {
                hoaDon.tenHoaDon = i.ToString();

                string tongTienDVCurrentMonth = busHoaDon.SelectTongTienDichVuPhongByMonth(hoaDon);
                string tongTienPhongCurrentMonth = busHoaDon.SelectTongTienPhongByMonth(hoaDon);

                decimal tienDV = string.IsNullOrEmpty(tongTienDVCurrentMonth) ? 0 : decimal.Parse(tongTienDVCurrentMonth);
                decimal tienPhong = string.IsNullOrEmpty(tongTienPhongCurrentMonth) ? 0 : decimal.Parse(tongTienPhongCurrentMonth);

                decimal tongTienPhongTrongThang = tienDV + tienPhong;

                chartRevenue.Series["RevenueMonth"].Points.AddXY(GetMonthName(i), tongTienPhongTrongThang);
            }


        }
        private string GetMonthName(int monthNumber)
        {
            // Convert month number to month name
            return DateTimeFormatInfo.CurrentInfo.GetMonthName(monthNumber);
        }
        private void btnReport_Click_1(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       public void refresh() {
            DateTime thoiGianThuc = DateTime.Now;
            int currentMonth = thoiGianThuc.Month;

            classHoaDon hoaDon = new classHoaDon();
            hoaDon.tenHoaDon = currentMonth.ToString();
            string tongTienDV = busHoaDon.SelectTongTienDichVuPhongByMonth(hoaDon);
            string tongTienPhong = busHoaDon.SelectTongTienPhongByMonth(hoaDon);


            decimal tongTienDVDecimal, tongTienPhongDecimal;

            if (decimal.TryParse(tongTienDV, out tongTienDVDecimal) &&
                decimal.TryParse(tongTienPhong, out tongTienPhongDecimal))
            {

                string tongTienDVFormat = tongTienDVDecimal.ToString("#,##0.000");
                string tongTienPhongFormat = tongTienPhongDecimal.ToString("#,##0.000");
                label5.Text = tongTienDVFormat;
                label4.Text = tongTienPhongFormat;

            }

            string tongSoDatPhong = busHoaDon.SelectSoPhongByMonth(hoaDon);
            decimal tongTienPhongTrongThanh = decimal.Parse(tongTienDV) + decimal.Parse(tongTienPhong);

            label6.Text = tongSoDatPhong;


            chartRevenue.Series["RevenueMonth"].Points.Clear(); // Clear existing points

            for (int i = 1; i <= 12; i++)
            {
                hoaDon.tenHoaDon = i.ToString();

                string tongTienDVCurrentMonth = busHoaDon.SelectTongTienDichVuPhongByMonth(hoaDon);
                string tongTienPhongCurrentMonth = busHoaDon.SelectTongTienPhongByMonth(hoaDon);

                decimal tienDV = string.IsNullOrEmpty(tongTienDVCurrentMonth) ? 0 : decimal.Parse(tongTienDVCurrentMonth);
                decimal tienPhong = string.IsNullOrEmpty(tongTienPhongCurrentMonth) ? 0 : decimal.Parse(tongTienPhongCurrentMonth);

                decimal tongTienPhongTrongThang = tienDV + tienPhong;

                chartRevenue.Series["RevenueMonth"].Points.AddXY(GetMonthName(i), tongTienPhongTrongThang);
            }

        }

    }
}
