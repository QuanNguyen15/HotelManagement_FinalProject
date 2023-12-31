﻿using BusinessLogic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GuiLayer
{
    public partial class frmAddRoom : Form
    {
        BUSPhong busPhong = new BUSPhong();
        bool save;
        private tabRoom TabRoom;
        public frmAddRoom(tabRoom tabRoom)
        {
            TabRoom = tabRoom;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tenPhong = txtRoomName.Text.Trim();

                DataTable dt = busPhong.getPhongbyName(tenPhong);


            if (string.IsNullOrEmpty(tenPhong))
            {
                MessageBox.Show("Please fill in all information");
            }else if(dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Room is exist. Please choose other room name.");
            }
            else
            {
                int idLoaiPhong = 1;

                if ("Single" == cbRoomType.Text)
                {
                    idLoaiPhong = 1;
                }
                else if ("Double" == cbRoomType.Text)
                {
                    idLoaiPhong = 2;
                }
                else
                {
                    idLoaiPhong = 3;
                }


                classPhong phong = new classPhong(tenPhong, idLoaiPhong);
                bool save = busPhong.addPhong(phong);
                if (save)
                {
                    //
                    TabRoom.getAll();
                    MessageBox.Show("Add room successfull");
                    this.Close();
                }
            }
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
