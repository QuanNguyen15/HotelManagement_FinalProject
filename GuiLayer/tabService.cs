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
using System.Xml.Linq;

namespace GuiLayer
{
    public partial class tabService : UserControl
    {
        BUSDichVu busDichVu =new BUSDichVu();
        BUSThietBi busThietBi = new BUSThietBi();

        public tabService()
        {
            InitializeComponent();
/*            foreach (Control control in panel3.Controls)
            {
                if (control is RadioButton radioButton)
                {

                    radioButton.CheckedChanged += RadioButton;
                }
            }*/
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmAddServiceForAll addServiceForAll = new frmAddServiceForAll(this);
            addServiceForAll.ShowDialog();
        }

        private void btnAddfacilities_Click(object sender, EventArgs e)
        {
            frmAddFacilities addFacilities = new frmAddFacilities(this); 
            addFacilities.ShowDialog();
        }

        private void tabService_Load(object sender, EventArgs e)
        {
            DataTable dtService = new DataTable();
            dtService = busDichVu.getDichVu();
            dataGridView1.DataSource = dtService;
            
            DataTable dtThietBi = new DataTable();
            dtThietBi = busThietBi.getThietBi();
            dataGridView2.DataSource = dtThietBi;
        }

        public void refeshService()
        {
            DataTable dtService = new DataTable();
            dtService = busDichVu.getDichVu();
            dataGridView1.DataSource = dtService;
        }

        public void refeshThietBi()
        {
            DataTable dtThietBi = new DataTable();
            dtThietBi = busThietBi.getThietBi();
            dataGridView2.DataSource = dtThietBi;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string id = selectedRow.Cells["idDichVu"].Value.ToString();
                if (!string.IsNullOrEmpty(id))
                {
                    if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                    {

                        DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (result == DialogResult.Yes)
                        {

                            int idAsInt = int.Parse(id);
                            classDichVu dichVu = new classDichVu();
                            dichVu.idDichVu = idAsInt;
                            busDichVu.deleteDichVu(dichVu);
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Delete successfull");
                        }

                    }
                    else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
                    {



                        /*                  // Tạo form mới và truyền thông tin vào
                                          frmClientInformation infoForm = new frmClientInformation(this);
                                          infoForm.SetClientInformation(id, name, idCard, phone, email, address, gender);
                                          infoForm.SetClientInformation(id);
                                          infoForm.ShowDialog();*/
                    }
                }
                else
                {
                    MessageBox.Show("Empty");
                }

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
