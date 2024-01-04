﻿using System;
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
        public tabBill()
        {
            InitializeComponent();
        }

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridViewBill.Columns[e.ColumnIndex].HeaderText == "Detail")
                {
                    frmBillDetail billDetail = new frmBillDetail();
                    billDetail.ShowDialog();

                }
            }
        }
    }
}
