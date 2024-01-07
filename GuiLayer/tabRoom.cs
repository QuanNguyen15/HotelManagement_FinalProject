using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiLayer
{
    public partial class tabRoom : UserControl
    {
        BUSPhong busPhong = new BUSPhong();
        DataTable dt;
        public tabRoom()
        {
            InitializeComponent();
            foreach (Control control in panel3.Controls)
            {
                if (control is RadioButton radioButton)
                {

                    radioButton.CheckedChanged += RadioButton;
                }
            }
        }
        private void RadioButton(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                string Option = radioButton.Text;
                if (Option == "All")
                {
                    getAll();
                }
                else if (Option == "Available")
                {
                    getAvailable();
                }
                else if (Option == "Maintainece")
                {
                    getMaintainece();
                }
                else if (Option == "Renting")
                {
                    getRenting();
                }
                else
                {
                    getBooked();
                }
            }
        }
        private void tabRoom_Load(object sender, EventArgs e)
        {

            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;

            foreach (var room in phong)
            {
                if (room.idLoaiPhong == 1)
                {
                    Button roomButtonForSingleRoom = CreateRoom(room);
                    flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                }

                if (room.idLoaiPhong == 2)
                {
                    Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                    flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                }

                if (room.idLoaiPhong == 3)
                {
                    Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                    flpVipRoom.Controls.Add(roomButtonForVipRoom);
                }



            }


            flpSingleRoom.WrapContents = true;
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.AutoSize = true;
            flpSingleRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            flpVipRoom.WrapContents = true;
            flpVipRoom.FlowDirection = FlowDirection.LeftToRight;
            flpVipRoom.AutoSize = true;
            flpVipRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            flpDoubleRoom.WrapContents = true;
            flpDoubleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpDoubleRoom.AutoSize = true;
            flpDoubleRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;




        }
        private Button CreateRoom(classPhong room)
        {
            bool check = true;
            Button roomButton = new Button();
            roomButton.Text = $"{room.tenPhong}\n {room.trangThai}";
            roomButton.Tag = room; // luu tru giu lieu 
            roomButton.Size = new Size(240, 160);
            roomButton.Margin = new Padding(5, 10, 15, 10);
            roomButton.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
           

            if (room.trangThai == "Available")
            {
                roomButton.BackColor = Color.FromArgb(125, 209, 10);
            }
            else if(room.trangThai == "Renting")
            {
                roomButton.BackColor = Color.FromArgb(149, 150, 148);
            }
            else if(room.trangThai == "Maintenaning") 
            {
                /*roomButton.BackColor = Color.FromArgb(255, 51, 51);*/
                roomButton.BackColor = Color.FromArgb(226, 51, 51);
            }
            else if(room.trangThai == "Booked")
            {
                roomButton.BackColor = Color.FromArgb(76, 132, 197);
                
            }
           
            roomButton.Click += RoomButton_Click;

            return roomButton;
        }

/*        private void RoundButton(Button button, int cornerRadius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(button.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(button.Width - cornerRadius * 2, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, button.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            button.Region = new System.Drawing.Region(path);
        }*/
        private void RoomButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // sender la su kien , send duoc ep kieu 
            if (clickedButton != null) // neu sender k phai button thi se null 
            {
                // lay du lieu trong luu tru tag va ep kieu phong
                classPhong room = clickedButton.Tag as classPhong;

                // Hiển thị ContextMenuStrip khi click vào nút
                ShowRoomOptions(clickedButton, room);
            }
        }
        private void ShowRoomOptions(Control control, classPhong room)
        {
            string ttPhong = "";
            if(room.trangThai == "Available")
            {
                ttPhong = "Update Maintenance";
            }else if (room.trangThai == "Maintenaning")
            {
                ttPhong = "Complete Repair";
            }else if(room.trangThai == "Renting")
            {
                ttPhong = "Payment";
            }else if (room.trangThai == "Booked")
            {
                ttPhong = "Check In";
            }



            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

/*            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Change Room");*/

            ToolStripMenuItem menuItem3 = new ToolStripMenuItem(ttPhong);
            /*            ToolStripMenuItem menuItem4 = new ToolStripMenuItem("Thanh toán");*/

            if (room.trangThai == "Booked" || room.trangThai == "Renting")
            {
                ToolStripMenuItem menuItem5 = new ToolStripMenuItem("Room Information");
                menuItem5.Click += (sender, e) => getThongTinPhong(room, control);
                contextMenuStrip.Items.Add(menuItem5);
            }


/*
            menuItem1.Click += (sender, e) => ChuyenPhong(room, control);  */// bieu thuc lam da

            menuItem3.Click += (sender, e) => CapNhatSanPham(room, control);
/*            menuItem4.Click += (sender, e) => ThanhToan(room, control);*/


/*            contextMenuStrip.Items.Add(menuItem1);*/
            contextMenuStrip.Items.Add(menuItem3);
/*            contextMenuStrip.Items.Add(menuItem4);*/


            contextMenuStrip.Show(control, new Point(control.Width / 2, control.Height / 2));
            // control vi tri của click 
        }
        private void getThongTinPhong(classPhong room, Control control)
        {
            frmRoomInformation roomInformation = new frmRoomInformation(room,this);
            roomInformation.ShowDialog();
        }
        private void ChuyenPhong(classPhong room, Control control)
        {
            MessageBox.Show($"Đặt phòng nhanh {room.idPhong}");
        }

       

        private void CapNhatSanPham(classPhong room, Control control)
        {
            string ttRoom = room.trangThai;
            switch (ttRoom)
            {
                case "Available":
                    room.trangThai = "Maintenaning";
                    busPhong.updatePhong(room);
                    control.Text = $"{room.tenPhong}\n {room.trangThai}";
                    control.BackColor = Color.FromArgb(226, 51, 51);
                    MessageBox.Show($"{room.tenPhong} Has Been Updated Successfuly", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Maintenaning":
                    room.trangThai = "Available";
                    busPhong.updatePhong(room);
                    control.Text = $"{room.tenPhong}\n {room.trangThai}";
                    control.BackColor = Color.FromArgb(125, 209, 10);
                    MessageBox.Show($"{room.tenPhong} Has Been Available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Booked":
                    room.trangThai = "Renting";
                    busPhong.updatePhong(room);
                    control.Text = $"{room.tenPhong}\n {room.trangThai}";
                    control.BackColor = Color.FromArgb(149, 150, 148);
                    MessageBox.Show($"{room.tenPhong} Has Been Renting", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Renting":
                    DialogResult result = MessageBox.Show("Are you sure you want to pay?", "Comfirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (result == DialogResult.Yes )
                    {

                        frmBillDetail bill = new frmBillDetail(room, this);
                        bill.ShowDialog();

                        control.Text = $"{room.tenPhong}\n {room.trangThai}";
                        control.BackColor = Color.FromArgb(226, 51, 51);
                        MessageBox.Show($"{room.tenPhong} Has Been Payment", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }




                   /* room.trangThai = "Maintenaning";
                    busPhong.updatePhong(room);
                    control.Text = $"{room.tenPhong}\n {room.trangThai}";
                    control.BackColor = Color.FromArgb(226, 51, 51);
                    MessageBox.Show($"{room.tenPhong} Has Been Payment", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    break;
            }

           /* if (room.trangThai == "Available")
            {
                room.trangThai = "Maintenance";
                busPhong.updatePhong(room);
                control.Text = $"{room.tenPhong}\n {room.trangThai}";
                control.BackColor = Color.FromArgb(119, 136, 153);
                MessageBox.Show($"{room.tenPhong} has been updated successfuly", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (room.trangThai == "Maintenance")
            {
                room.trangThai = "Available";
                busPhong.updatePhong(room);
                control.Text = $"{room.tenPhong}\n {room.trangThai}";
                control.BackColor = Color.FromArgb(136, 230, 185);
                MessageBox.Show($"{room.tenPhong} has been Available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{room.tenPhong} is in use ", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
/*
        private void ThanhToan(classPhong room, Control control)
        {
            if(room.trangThai == "Renting")
            {
                room.trangThai = "Available";
                busPhong.updatePhong(room);
                control.Text = $"{room.tenPhong}\n {room.trangThai}";
                control.BackColor = Color.FromArgb(136, 230, 185);
                MessageBox.Show($"{room.tenPhong} has been booked", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
    
            else if(room.trangThai == "Maintenance")
            {
                MessageBox.Show($"{room.tenPhong} is under maintainance", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{room.tenPhong} has not been booked yet", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }*/

        public void getAll()
        {
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                //control.Dispose(); 
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                //control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                //control.Dispose();
            }

            /*            DataTable dt = new DataTable();
                        dt = busPhong.getPhong();*/

            List<classPhong> phong = busPhong.getPhongToList();

            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;

            foreach (var room in phong)
            {
                if (room.idLoaiPhong == 1)
                {
                    Button roomButtonForSingleRoom = CreateRoom(room);
                    flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                }

                if (room.idLoaiPhong == 2)
                {
                    Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                    flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                }

                if (room.idLoaiPhong == 3)
                {
                    Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                    flpVipRoom.Controls.Add(roomButtonForVipRoom);
                }
            }
        }

        public void getAvailable()
        {
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                control.Dispose();
            }

            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;
            int maxButtonsPerRow = 4; // Số lượng nút tối đa trên mỗi hàng
            int buttonCount = 0;


            foreach (var room in phong)
            {
                if (room.trangThai == "Available")
                {
                    if (room.idLoaiPhong == 1)
                    {
                        Button roomButtonForSingleRoom = CreateRoom(room);
                        flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                    }

                    if (room.idLoaiPhong == 2)
                    {
                        Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                        flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                    }

                    if (room.idLoaiPhong == 3)
                    {
                        Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                        flpVipRoom.Controls.Add(roomButtonForVipRoom);
                    }
                }
            }
        }

        public void getMaintainece()
        {
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                control.Dispose();
            }

            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;
            int maxButtonsPerRow = 4; // Số lượng nút tối đa trên mỗi hàng
            int buttonCount = 0;


            foreach (var room in phong)
            {
                if (room.trangThai == "Maintenaning")
                {
                    if (room.idLoaiPhong == 1)
                    {
                        Button roomButtonForSingleRoom = CreateRoom(room);
                        flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                    }

                    if (room.idLoaiPhong == 2)
                    {
                        Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                        flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                    }

                    if (room.idLoaiPhong == 3)
                    {
                        Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                        flpVipRoom.Controls.Add(roomButtonForVipRoom);
                    }
                }
            }
        }
        public void getRenting()
        {
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                control.Dispose();
            }

            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;



            foreach (var room in phong)
            {
                if (room.trangThai == "Renting")
                {
                    if (room.idLoaiPhong == 1)
                    {
                        Button roomButtonForSingleRoom = CreateRoom(room);
                        flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                    }

                    if (room.idLoaiPhong == 2)
                    {
                        Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                        flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                    }

                    if (room.idLoaiPhong == 3)
                    {
                        Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                        flpVipRoom.Controls.Add(roomButtonForVipRoom);
                    }
                }
            }
        }


        public void getBooked()
        {
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                control.Dispose();
            }

            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;



            foreach (var room in phong)
            {
                if (room.trangThai == "Booked")
                {
                    if (room.idLoaiPhong == 1)
                    {
                        Button roomButtonForSingleRoom = CreateRoom(room);
                        flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                    }

                    if (room.idLoaiPhong == 2)
                    {
                        Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                        flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                    }

                    if (room.idLoaiPhong == 3)
                    {
                        Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                        flpVipRoom.Controls.Add(roomButtonForVipRoom);
                    }
                }
            }
        }



        private void flpSingleRoom_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpSingleRoom_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpSingleRoom_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void flpVipRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpDbRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Single_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void RefreshRoom()
        {
            dt = busPhong.getPhong();
            //thuc hien load lai du lieu sau khi save du lieu moi


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddRoom addRoom = new frmAddRoom(this);
            addRoom.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTermRoom = txtSearch.Text.Trim();
            classPhong phong = new classPhong();
            phong.tenPhong = searchTermRoom;
            List<classPhong> listPhong = busPhong.searchPhong(phong);
            foreach (Control control in flpSingleRoom.Controls.OfType<Button>().ToList())
            {
                flpSingleRoom.Controls.Remove(control);
                //control.Dispose(); 
            }

            foreach (Control control in flpDoubleRoom.Controls.OfType<Button>().ToList())
            {
                flpDoubleRoom.Controls.Remove(control);
                //control.Dispose();
            }

            foreach (Control control in flpVipRoom.Controls.OfType<Button>().ToList())
            {
                flpVipRoom.Controls.Remove(control);
                //control.Dispose();
            }



            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;

            foreach (var room in listPhong)
            {
                if (room.idLoaiPhong == 1)
                {
                    Button roomButtonForSingleRoom = CreateRoom(room);
                    flpSingleRoom.Controls.Add(roomButtonForSingleRoom);
                }

                if (room.idLoaiPhong == 2)
                {
                    Button roomButtonForDbRoom = CreateRoom(room); // Tạo một Button mới
                    flpDoubleRoom.Controls.Add(roomButtonForDbRoom);

                }

                if (room.idLoaiPhong == 3)
                {
                    Button roomButtonForVipRoom = CreateRoom(room); // Tạo một Button mới
                    flpVipRoom.Controls.Add(roomButtonForVipRoom);
                }
            }
        }
    }
}
