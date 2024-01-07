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
    public partial class tabBill : UserControl
    {
        BUSHoaDon busHoaDon =new BUSHoaDon();
        public tabBill()
        {
            InitializeComponent();
        }

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewBill.Rows[e.RowIndex];
                string idHoaDon = selectedRow.Cells["idHoaDon"].Value.ToString();

                if (dataGridViewBill.Columns[e.ColumnIndex].HeaderText == "Detail" && !string.IsNullOrEmpty(idHoaDon))
                {
                    int idHoaDonNew = int.Parse(idHoaDon);
                    billDetail2 billDetail = new billDetail2(idHoaDonNew);
                    billDetail.ShowDialog();

                }
            }
        }

        private void tabBill_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busHoaDon.getHoaDon();
            dataGridViewBill.DataSource = dt;
        }

        public void refreshDatagridview()
        {
            DataTable dt = new DataTable();
            dt = busHoaDon.getHoaDon();
            dataGridViewBill.DataSource = dt;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(search))
            {
                DataTable dt = new DataTable();
                classHoaDon hoaDon = new classHoaDon();
                hoaDon.tenHoaDon = search;
           
                dt = busHoaDon.SearchHoaDonPhongBySoHoaDonNew(hoaDon);
                dataGridViewBill.DataSource = dt;
            }

            else
            {
                DataTable dt = new DataTable();
                dt = busHoaDon.getHoaDon();
                dataGridViewBill.DataSource = dt;
            }
        }
    }
}
