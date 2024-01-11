using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
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
    public partial class frmRoomInformation : Form
    {
        BUSDichVu busSanPham = new BUSDichVu();
        classPhong roomDichVu;
        BUSPhong busPhong = new BUSPhong();
        BUSDatPhong datPhong = new BUSDatPhong();
        tabRoom tabPhong;
        public frmRoomInformation(classPhong room, tabRoom ffrm1)
        {
            tabPhong = ffrm1;
            roomDichVu = room;
            InitializeComponent();
        }

        private void frmRoomInformation_Load(object sender, EventArgs e)
        {
            if (roomDichVu.trangThai == "Renting")
            {
                btnBook.Text = "Pay";
                btnAddService.Visible = true;
            }
            else
            {
                btnAddService.Visible = false;
            }



            // TODO: This line of code loads data into the 'hOTELSDataSet1.SanPham' table. You can move, or remove it, as needed.
            /* this.sanPhamTableAdapter.Fill(this.hOTELSDataSet1.SanPham);*/
            DataTable dtDichVuPhong = new DataTable();
            dtDichVuPhong = busPhong.GetDichVuDatPhong(roomDichVu);
    
            dataGridView1.DataSource = dtDichVuPhong;


            //lable

            DataTable thongTinPhongLb = new DataTable();
            thongTinPhongLb = busPhong.roomInforlb(roomDichVu);

            if (thongTinPhongLb.Rows.Count > 0)
            {
                string tenPhong = thongTinPhongLb.Rows[0]["tenPhong"].ToString();
                lbPhong.Text = tenPhong;
                string clientt = thongTinPhongLb.Rows[0]["tenKhachHang"].ToString();
                lbClient.Text = clientt;
                string ngayDat = thongTinPhongLb.Rows[0]["ngayDat"].ToString();
                lbDayRent.Text = ngayDat;
                string ngayTra = thongTinPhongLb.Rows[0]["ngayTra"].ToString();
                lbNumDay.Text = ngayTra;
                string soNguoi = thongTinPhongLb.Rows[0]["soNguoi"].ToString();
                lbPeople.Text = soNguoi;
                string trangThai = thongTinPhongLb.Rows[0]["trangThai"].ToString();
                lbRomStatus.Text = trangThai;
                string LoaiPhong = thongTinPhongLb.Rows[0]["tenLoaiPhong"].ToString();
                lbRoomType.Text = LoaiPhong;


            }




        }

        public void refreshDataGridView()
        {
            DataTable dtDichVuPhong = new DataTable();
            dtDichVuPhong = busPhong.GetDichVuDatPhong(roomDichVu);
            dataGridView1.DataSource = dtDichVuPhong;

        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (roomDichVu.trangThai == "Renting")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to pay?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    frmBillDetail bill = new frmBillDetail(roomDichVu, tabPhong);
                    bill.ShowDialog();
                    tabPhong.getAll();
                    this.Close();


                }

            }
            else
            {
                roomDichVu.trangThai = "Renting";
                busPhong.updatePhong(roomDichVu);
                btnBook.Text = "Pay";
                btnAddService.Visible = true;
                tabPhong.getAll();
            }

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
           frmAddSevice addSevice = new frmAddSevice(roomDichVu,this);
            addSevice.ShowDialog();
        }

        private void pnFatherSanPham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string tenDichVu = selectedRow.Cells["tenDichVu"].Value.ToString();
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes && !string.IsNullOrEmpty(tenDichVu))
                    {


                        classDichVu dichVu = new classDichVu();
                        dichVu.tenDichVu = tenDichVu;
                        dichVu.loaiDichVu = roomDichVu.tenPhong;

                        BUSDichVu busDichVu = new BUSDichVu();
                        busDichVu.DeleteDichVuPhongByRoomAndService(dichVu);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Delete successfull");
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                   
                }
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                    string tenDichVu = selectedRow.Cells["ten"].Value.ToString();
                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes && !string.IsNullOrEmpty(tenDichVu))
                    {


                        classDichVu dichVu = new classDichVu();
                        dichVu.tenDichVu = tenDichVu;
                        dichVu.loaiDichVu = roomDichVu.tenPhong;

                        BUSDichVu busDichVu = new BUSDichVu();
                        busDichVu.DeleteDichVuPhongByRoomAndService(dichVu);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Delete successfull");
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
                {

                }
            }

        }
    }
}
