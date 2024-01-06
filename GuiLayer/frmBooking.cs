using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
using DataAccess.DTO;
using Google.Protobuf.WellKnownTypes;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuiLayer
{
    public partial class frmBooking : Form
    {
        BUSKhachHang busKhachHang = new BUSKhachHang();
        BUSPhong busPhong = new BUSPhong();
        BUSHoaDon busHoaDon = new BUSHoaDon();
        BUSDatPhong busDatPhong = new BUSDatPhong();
        BUSHoaDonPhong busHoaDonPhong = new BUSHoaDonPhong();
        tabBooking book;
        public frmBooking(tabBooking booking)
        {
            book = booking;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = busPhong.getRoomAvailable();
            dataGridViewRoomAvail.DataSource = dt;

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime aDateTime = DateTime.Now;

            DateTime dateTime = dateTimePickerCheckin.Value;
            string time = dateTime.ToString();
            MessageBox.Show(time);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

            private void dataGridViewRoomAvail_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dataGridViewRoomAvail.Rows[e.RowIndex];
                    string tenPhong = selectedRow.Cells["tenPhong"].Value.ToString();

                    if (!string.IsNullOrEmpty(tenPhong) && e.ColumnIndex >= 0 && dataGridViewRoomAvail.Columns[e.ColumnIndex].HeaderText == "Add")
                    {
                        themCottrongGrid2();

                        // Add a row 
                        DataGridViewRow newRow = dataGridViewRoomSelect.Rows[dataGridViewRoomSelect.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray())];


                        newRow.Cells["Person"].Value = "1";
                        newRow.Cells["NameRoom"].Value = tenPhong;
                        // Xóa dòng
                        dataGridViewRoomAvail.Rows.Remove(selectedRow);

                        // Tự động chọn ô "Số Người" trong dataGridViewRoomSelect
                        dataGridViewRoomSelect.CurrentCell = newRow.Cells["Person"];


                    }
                }
            }
            private void themCottrongGrid2()
            {

                // Kiểm tra xem các cột đã được thêm chưa
                if (dataGridViewRoomSelect.Columns.Count == 0)
                {

                    // Thêm các cột cần thiết động từ dataGridViewRoomAvail
                    foreach (DataGridViewColumn column in dataGridViewRoomAvail.Columns)
                    {

                        dataGridViewRoomSelect.Columns.Add(column.Clone() as DataGridViewColumn);
                    }
                }
                if (dataGridViewRoomSelect.Columns["Person"] == null)
                {

                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                    newColumn.HeaderText = "Person";
                    newColumn.Name = "Person";
                    dataGridViewRoomSelect.Columns.Add(newColumn);
                }
                if (dataGridViewRoomSelect.Columns["NameRoom"] == null)
                {

                    DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                    newColumn.HeaderText = "Name Room";
                    newColumn.Name = "NameRoom";
                    dataGridViewRoomSelect.Columns.Add(newColumn);
                }
            }

        private void xoaCotTrongGrid2()
        {

            // Kiểm tra xem các cột đã được thêm chưa
            if (dataGridViewRoomSelect.Columns.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewRoomSelect.SelectedRows[0];

                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();

                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = selectedRow.Cells[i].Value;
                }

                dataGridViewRoomAvail.Rows.Add(newRow);
            }
          
        }

        static bool IsNumeric(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        public bool soCCCDmax(string input)
        {
            string pattern = @"^\d{12}$";

            return Regex.IsMatch(input, pattern);
        }

        public bool dienThoaiMax(string input)
        {
            string pattern = @"^\d{10}$";

            return Regex.IsMatch(input, pattern);
        }

        private void dataGridViewRoomSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            
            // Kiểm tra xem có ô nào được chọn trong DataGridViewRoomSelect hay không
                if (dataGridViewRoomSelect.SelectedCells.Count > 0)
                {
                    // Lấy ô được chọn từ DataGridViewRoomSelect
                    DataGridViewCell selectedCell = dataGridViewRoomSelect.SelectedCells[0];

                    // Lấy dòng và cột của ô được chọn
                    int rowIndex = selectedCell.RowIndex;
                    string columnName = "NameRoom";

                    object cellValue = dataGridViewRoomSelect.Rows[rowIndex].Cells[columnName].Value;
    
                    string nameRoom = cellValue?.ToString();



                // Kiểm tra xem dòng và cột có hợp lệ hay không
                if (rowIndex >= 0 && !string.IsNullOrEmpty(nameRoom))
                {

                    // Lấy DataTable từ busPhong
                    DataTable dataTable = busPhong.getPhongbyName(nameRoom);
                    //datagridview là một datasource
                    DataTable dataSource = (DataTable)dataGridViewRoomAvail.DataSource;

                    if (dataSource != null)
                    {

                         foreach (DataRow row in dataTable.Rows)
                        {
                            // Tạo một dòng mới
                            DataRow newRow = dataSource.NewRow();

                            // Duyệt qua từng cột trong dòng của DataTable và gán giá trị cho dòng mới
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                // Gán giá trị cho từng cột tương ứng trong dòng mới
                                newRow[column.ColumnName] = row[column.ColumnName];
                            }

                            // Thêm dòng mới vào DataTable
                            dataSource.Rows.Add(newRow);
                        }

                        // Cập nhật nguồn dữ liệu của DataGridViewRoomAvail
                        dataGridViewRoomAvail.DataSource = dataSource;
                        dataGridViewRoomSelect.Rows.RemoveAt(rowIndex);

                    }
                }
            }
            }
        

        private void btnSave_Click_2(object sender, EventArgs e)
        {

            DateTime timeCheckIn = dateTimePickerCheckin.Value;
            DateTime timeCheckOut = dateTimePickerCheckoout.Value;
            DateTime currentTime = DateTime.Now;
            string hoTen = txtClientName.Text.Trim();
            string gioiTinh = null;
            string soCDCD = txtIdNumber.Text.Trim();
            string dienThoai = txtPhoneNum.Text.Trim();
            string email = txtEmailClient.Text.Trim();
            string diachi = txtAddressClient.Text.Trim();
            int idTaiKhoan = staticTaiKhoan.idTaiKhoanStatic;
            DateTime timeIn = DateTime.MinValue;
            DateTime timeOut = DateTime.MinValue;
            bool check = true;
            bool checkTime = true;
            if (timeCheckIn > currentTime && timeCheckOut.Date > timeCheckIn.Date)
            {
                checkTime = true;
                timeIn = timeCheckIn;
                timeOut = timeCheckOut;

            }
            else
            {
                checkTime = false;

            }

            List<classKhachHang> khachHangList = busKhachHang.getlistKhachHang();
            classKhachHang KhachHangCu = null;
            foreach (classKhachHang khachHangitem in khachHangList)
            {
                if (khachHangitem.soCCCD == soCDCD)
                {
                    KhachHangCu = khachHangitem;
                    check = false;
                }

            }


            foreach (Control control in panel1.Controls)
            {
                if (control is RadioButton radioButton)
                {

                    if (radioButton != null && radioButton.Checked)
                    {
                        string Option = radioButton.Text;
                        if (Option == "Male")
                        {
                            gioiTinh = "Male";
                        }
                        else if (Option == "Female")
                        {
                            gioiTinh = "Female";
                        }
                        else if (Option == "Other")
                        {
                            gioiTinh = "Other";
                        }

                    }
                }
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soCDCD) || string.IsNullOrEmpty(dienThoai) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Please fill in all information");
            }
            else if (!IsNumeric(soCDCD) || !IsNumeric(dienThoai))
            {
                MessageBox.Show("ID card number and phone must be numeric");
            }
            else if (!soCCCDmax(soCDCD) && !dienThoaiMax(dienThoai))
            {

                MessageBox.Show($"The ID card number must be 12 numbers and the phone number must be 10 numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!soCCCDmax(soCDCD) || !dienThoaiMax(dienThoai))
            {
                if (!soCCCDmax(soCDCD))
                {
                    MessageBox.Show($"The ID card number must be 12 ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!dienThoaiMax(dienThoai))
                {
                    MessageBox.Show($"The phone number must be 10 numbers", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (!checkTime)
            {
/*                DataGridView dataGridView = dataGridViewRoomSelect;
                bool checkdataGridView = true;
                DataTable dtPhong = new DataTable();
                List<string> createDatPhongByid = new List<string>();
                if (dataGridView != null)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        object valueCot1 = row.Cells["Person"].Value;
                        object valueCot2 = row.Cells["NameRoom"].Value;

                        if (valueCot1 != null && valueCot2 != null)
                        {
                            string Room = valueCot2.ToString();
                            dtPhong = busPhong.getIdPhong(Room);

                            string idAsString = dtPhong.Rows[0]["idPhong"].ToString();
                            createDatPhongByid.Add(idAsString);


                        }
                    }
                }*/

                MessageBox.Show($"Choose time greater than the present", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!check)
            {
                bool checkPhong = false;
                DataGridView dataGridView = dataGridViewRoomSelect;
                bool checkdataGridView = true;
                int numberCreateHoaDonPhong = 0;
                DataTable dtPhong = new DataTable();
                List<string> idPhongList = new List<string>();
                List<string> soLuongNGuoilist = new List<string>();

                if (dataGridView != null)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            object valueCot1 = row.Cells["Person"].Value;
                            object valueCot2 = row.Cells["NameRoom"].Value;

                            if (valueCot1 != null && valueCot2 != null)
                            {
                                checkPhong = true;
                                string nameRoom = valueCot2.ToString();
                                dtPhong = busPhong.getIdPhong(nameRoom);
                                string idAsString = dtPhong.Rows[0][0].ToString();


                                classPhong phongIsBooked = new classPhong();
                                phongIsBooked.idPhong = int.Parse(idAsString);
                                bool checkTrangThaiPhong = busPhong.updateBookedPhong(phongIsBooked);


                                idPhongList.Add(idAsString);
                                soLuongNGuoilist.Add(valueCot1.ToString());
                                numberCreateHoaDonPhong += 1;

                            }


                        }


                    }

                    if (checkPhong)
                    {
                        int idKhachHang = KhachHangCu.idKhachHang;
                        // creat hoa don
                        classHoaDon hoaDon = new classHoaDon();
                        hoaDon.idKhachHang = idKhachHang;
                        bool checkCreateHoaDon = busHoaDon.creatHoaDon(hoaDon);

                        int idMaxHoaDon = int.Parse(busHoaDon.maxHoaDon());
                        if (checkCreateHoaDon)
                        {
                            for (int i = 0; i < numberCreateHoaDonPhong; i++)
                            {
                                int idPhong = int.Parse(idPhongList[i]);
                                int soNguoi = int.Parse(soLuongNGuoilist[i]);
                                classDatPhong datPhong = new classDatPhong(idKhachHang, idPhong, timeIn, timeOut, idTaiKhoan, soNguoi);
                                bool checkCreateDatPhong = busDatPhong.creatDatPhong(datPhong);

                                int idMaxDatPhong = int.Parse(busDatPhong.getDatPhongMax());

                                classHoaDonPhong createHoaDonPhong = new classHoaDonPhong();
                                createHoaDonPhong.idHoaDon = idMaxHoaDon;
                                createHoaDonPhong.idDatPhong = idMaxDatPhong;
                                busHoaDonPhong.creatHoaDonPhong(createHoaDonPhong);
                            }
                            MessageBox.Show($"Booking room successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        MessageBox.Show("Please choose your room", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }



            }
            else
            {
                classKhachHang khachHang = new classKhachHang(hoTen, gioiTinh, soCDCD, dienThoai, email, diachi);

                bool save = busKhachHang.addKhachHang(khachHang);
                bool checkPhong = false;
                DataGridView dataGridView = dataGridViewRoomSelect;
                bool checkdataGridView = true;
                int numberCreateHoaDonPhong = 0;
                DataTable dtPhong = new DataTable();
                List<string> idPhongList = new List<string>();
                List<string> soLuongNGuoilist = new List<string>();

                if (dataGridView != null)
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            object valueCot1 = row.Cells["Person"].Value;
                            object valueCot2 = row.Cells["NameRoom"].Value;

                            if (valueCot1 != null && valueCot2 != null)
                            {
                                checkPhong = true;
                                string nameRoom = valueCot2.ToString();
                                dtPhong = busPhong.getIdPhong(nameRoom);
                                string idAsString = dtPhong.Rows[0][0].ToString();
                               

                                classPhong phongIsBooked = new classPhong();
                                phongIsBooked.idPhong = int.Parse(idAsString);
                                bool checkTrangThaiPhong = busPhong.updateBookedPhong(phongIsBooked);
                                idPhongList.Add(idAsString);

                                soLuongNGuoilist.Add(valueCot1.ToString());
                                numberCreateHoaDonPhong += 1;

                            }
                        }

                    }

                    if (checkPhong)
                    {
                        int idKhachHang = busKhachHang.maxKhachHang();
                        // creat hoa don
                        classHoaDon hoaDon = new classHoaDon();
                        hoaDon.idKhachHang = idKhachHang;
                        bool checkCreateHoaDon = busHoaDon.creatHoaDon(hoaDon);

                        int idMaxHoaDon = int.Parse(busHoaDon.maxHoaDon());
                        if (checkCreateHoaDon)
                        {
                            for (int i = 0; i < numberCreateHoaDonPhong; i++)
                            {
                                int idPhong = int.Parse(idPhongList[i]);
                                int soNguoi = int.Parse(soLuongNGuoilist[i]);
                                classDatPhong datPhong = new classDatPhong(idKhachHang, idPhong, timeIn, timeOut, idTaiKhoan, soNguoi);
                                bool checkCreateDatPhong = busDatPhong.creatDatPhong(datPhong);

                                int idMaxDatPhong = int.Parse(busDatPhong.getDatPhongMax());

                                classHoaDonPhong createHoaDonPhong = new classHoaDonPhong();
                                createHoaDonPhong.idHoaDon = idMaxHoaDon;
                                createHoaDonPhong.idDatPhong = idMaxDatPhong;
                                busHoaDonPhong.creatHoaDonPhong(createHoaDonPhong);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please choose your room", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                        if (save && checkPhong)
                        {
                            MessageBox.Show($"Add new client and booking room successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }


                }
               
            }
            book.refreshdataGridview();
            this.Close();
        }
    }
}
