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
        public frmRoomInformation()
        {
            InitializeComponent();
        }

        private void frmRoomInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOTELSDataSet1.SanPham' table. You can move, or remove it, as needed.
            /* this.sanPhamTableAdapter.Fill(this.hOTELSDataSet1.SanPham);*/
            DataTable dt = new DataTable();
            dt = busSanPham.getDichVu();
            btnAddService.Visible = false;
            dataGridView1.DataSource = dt;

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            btnBook.Text = "Pay";
            btnAddService.Visible = true;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
           frmAddSevice addSevice = new frmAddSevice();
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

                    DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                        string id = selectedRow.Cells["idSanPham"].Value.ToString();
                        int idAsInt = int.Parse(id);
                        classDichVu SanPham = new classDichVu();
                        SanPham.idDichVu = idAsInt;
                        MessageBox.Show(id);

                        BUSDichVu busSanPham = new BUSDichVu();
                        busSanPham.deleteDichVu(SanPham);
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
