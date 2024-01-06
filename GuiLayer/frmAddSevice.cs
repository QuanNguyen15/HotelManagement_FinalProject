using BusinessLogic;
using DataAccess;
using DataAccess.DAL;
using DataAccess.DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class frmAddSevice : Form
    {
        BUSDichVu busDichVu= new BUSDichVu();
        classPhong room;
        frmRoomInformation Information;
        public frmAddSevice(classPhong phong,frmRoomInformation fRI)
        {
            Information = fRI;
            room = phong;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void frmAddSevice_Load(object sender, EventArgs e)
        {
            
            BUSDichVu busDichVu = new BUSDichVu();
            DataTable dtCbb = busDichVu.getLoaiDichVu();
            foreach (DataRow row in dtCbb.Rows)
            {                
                string dichVu = row["loaiDichVu"].ToString();
                comboBox1.Items.Add(dichVu);
            }
            comboBox1.SelectedItem = comboBox1.Items[0];

            DataTable dtgridview = new DataTable();
            string loaiDichVu = "Delivery";
            classDichVu dichVuGrid = new classDichVu();
            dichVuGrid.loaiDichVu = loaiDichVu;
            dtgridview = busDichVu.getDichVubyLoai(dichVuGrid);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedValue = comboBox1.SelectedItem;
            if (selectedValue != null )
            {
                DataTable dt = new DataTable();
                string loaiDichVu = selectedValue.ToString();
                classDichVu dichVu = new classDichVu();
                dichVu.loaiDichVu = loaiDichVu;
                 dt= busDichVu.getDichVubyLoai(dichVu);

                dataGridViewService.DataSource = dt;
            }  
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text.Trim();

            object selectedValue = comboBox1.SelectedItem;
            if (selectedValue != null)
            {
                DataTable dt = new DataTable();
                string loaiDichVu = selectedValue.ToString();
                classDichVu dichVu = new classDichVu();
                dichVu.loaiDichVu = loaiDichVu;
                dichVu.tenDichVu = search;
                dt = busDichVu.SearchDichVuByNameAndLoai(dichVu);

                dataGridViewService.DataSource = dt;
            }
        }

        private void dataGridViewService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewService.Rows[e.RowIndex];
                string tenDichVu = selectedRow.Cells["tenDichVu"].Value.ToString();

                if (!string.IsNullOrEmpty(tenDichVu) && e.ColumnIndex >= 0 && dataGridViewService.Columns[e.ColumnIndex].HeaderText == "Add")
                {
                    themCottrongGrid2();

                    // Add a row 
                    DataGridViewRow newRow = dataGridViewPickedService.Rows[dataGridViewPickedService.Rows.Add(selectedRow.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray())];


                    newRow.Cells["soLuong"].Value = "1";
                    newRow.Cells["tenDichVu"].Value = tenDichVu;
                    // Xóa dòng
/*                    dataGridViewService.Rows.Remove(selectedRow);*/

                    // Tự động chọn ô "Số Người" trong dataGridViewRoomSelect
                    dataGridViewPickedService.CurrentCell = newRow.Cells["soLuong"];


                }
            }
        }

        private void dataGridViewPickedService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có ô nào được chọn trong DataGridViewRoomSelect hay không
            if (dataGridViewPickedService.SelectedCells.Count > 0)
            {
                // Lấy ô được chọn từ DataGridViewRoomSelect
                DataGridViewCell selectedCell = dataGridViewPickedService.SelectedCells[0];

                // Lấy dòng và cột của ô được chọn
                int rowIndex = selectedCell.RowIndex;
                string columnName = "tenDichVu";
                object cellValue = dataGridViewPickedService.Rows[rowIndex].Cells[columnName].Value;
                string nameService = cellValue?.ToString();
                if (rowIndex >= 0 && !string.IsNullOrEmpty(nameService))
                {
                    dataGridViewPickedService.Rows.RemoveAt(rowIndex);
                }
                /*string columnName = "tenDichVu";

                object cellValue = dataGridViewPickedService.Rows[rowIndex].Cells[columnName].Value;
                string nameService = cellValue?.ToString();



                // Kiểm tra xem dòng và cột có hợp lệ hay không
                if (rowIndex >= 0 && !string.IsNullOrEmpty(nameService))
                {

                    classDichVu dichvu = new classDichVu();
                    dichvu.tenDichVu = nameService;
                    // Lấy DataTable từ busPhong
                    DataTable dataTable = busDichVu.getTenPriceDichVuByName(dichvu);

                    //datagridview là một datasource
                    DataTable dataSource = (DataTable)dataGridViewService.DataSource;

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
                        dataGridViewService.DataSource = dataSource;*/

                    }
                }
/*            }
        }
*/
        private void themCottrongGrid2()
        {

            // Kiểm tra xem các cột đã được thêm chưa
            if (dataGridViewPickedService.Columns.Count == 0)
            {

                // Thêm các cột cần thiết động từ dataGridViewRoomAvail
                foreach (DataGridViewColumn column in dataGridViewService.Columns)
                {
                    // Kiểm tra xem tên cột có phải là "Add" hay không
                    if (column.Name != "Add")
                    {
                        // Nếu không phải cột "Add", thì sao chép cột vào dataGridViewPickedService
                        dataGridViewPickedService.Columns.Add(column.Clone() as DataGridViewColumn);
                    }
                }
            }
            if (dataGridViewPickedService.Columns["soLuong"] == null)
            {

                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                newColumn.HeaderText = "Amount";
                newColumn.Name = "soLuong";
            
                dataGridViewPickedService.Columns.Add(newColumn);
            }
            if (dataGridViewPickedService.Columns["tenDichVu"] == null)
            {

                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                newColumn.HeaderText = "Service";
                newColumn.Name = "tenDichVu";
               
                dataGridViewPickedService.Columns.Add(newColumn);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool checkPhong = false;
            DataGridView dataGridView = dataGridViewPickedService;
            bool checkdataGridView = true;
            int numberCreateService = 0;
            DataTable dtPhong = new DataTable();

            string tenPhong = room.tenPhong;

            List<int> soLuongDichVuList = new List<int>();
            List<string> tenDichVuList = new List<string>();

            if (dataGridView != null)
            {

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        object soLuong = row.Cells["soLuong"].Value;
                        object tenDichVu = row.Cells["tenDichVu"].Value;

                        if (soLuong != null && tenDichVu != null)
                        {
                          
                            checkPhong = true;
                            int soluongDichVu = int.Parse(soLuong.ToString());
                            string nameDichVU = tenDichVu.ToString();
/*                            cDichVu.idDichVu = soluongDichVu;
                            cDichVu.tenDichVu = nameDichVU;
                            cDichVu.loaiDichVu = tenPhong;

                            busDichVu.AddDichVuPhongByRoomAndService(cDichVu);
*/



                            soLuongDichVuList.Add(soluongDichVu);
                            tenDichVuList.Add(nameDichVU);
                            numberCreateService += 1;

                        }


                    }


                }
                classDichVu cDichVu = new classDichVu();
                if (checkPhong)
                {

                    for (int i = 0; i < numberCreateService; i++)
                    {
                        int soLuongDichVu = soLuongDichVuList[i];

                        string tenDichVu = tenDichVuList[i];
                        cDichVu.idDichVu = soLuongDichVu;
                        cDichVu.tenDichVu = tenDichVu;
                        cDichVu.loaiDichVu = tenPhong;

                        busDichVu.AddDichVuPhongByRoomAndService(cDichVu);

                    }
                    MessageBox.Show($"Add service successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmRoomInformation frmRefrest = Information;
                    frmRefrest.refreshDataGridView();   
                    this.Close();

                }
                }
    }
}}
