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
                }else if(Option == "Available")
                {
                    getAvailable();
                }else if (Option == "Maintainece")
                {
                    getMaintainece();
                }
            }
        }
        private void tabRoom_Load(object sender, EventArgs e)
        {
           
            List<classPhong> phong = busPhong.getPhongToList();
            flpSingleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpSingleRoom.WrapContents = true;
            int maxButtonsPerRow = 4; // Số lượng nút tối đa trên mỗi hàng
            int buttonCount = 0;
            

            foreach (var room in phong)
            {
                if(room.idLoaiPhong == 1)
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
            flpSingleRoom.AutoScroll = true;

            flpVipRoom.WrapContents = true;
            flpVipRoom.FlowDirection = FlowDirection.LeftToRight;
            flpVipRoom.AutoSize = true;
            flpVipRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpVipRoom.AutoScroll = true;

            flpDoubleRoom.WrapContents = true;
            flpDoubleRoom.FlowDirection = FlowDirection.LeftToRight;
            flpDoubleRoom.AutoSize = true;
            flpDoubleRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpDoubleRoom.AutoScroll = true;



        }
        private Button CreateRoom( classPhong room)
        {
            bool check = true;
            Button roomButton = new Button();
            roomButton.Text = $"Room {room.id} \n {room.trangThai}";
            roomButton.Tag = room; // luu tru giu lieu 
            roomButton.Size = new Size(240, 160);
            roomButton.Margin = new Padding(5, 10, 15, 10);
            roomButton.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

            if (room.trangThai == "Available")
            {
                check = true;
            }
            else
            {
                check = false;
            }
            roomButton.BackColor = check ? Color.FromArgb(136,230,185) : Color.FromArgb(224, 115, 130) ;

            roomButton.Click += RoomButton_Click;

            return roomButton;
        }
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
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            ToolStripMenuItem menuItem1 = new ToolStripMenuItem("Chuyển phòng");
            ToolStripMenuItem menuItem2 = new ToolStripMenuItem("Đặt phòng nhanh");
            ToolStripMenuItem menuItem3 = new ToolStripMenuItem("Cập nhật sản phẩm");
            ToolStripMenuItem menuItem4 = new ToolStripMenuItem("Thanh toán");

            menuItem1.Click += (sender, e) => ChuyenPhong(room);  // bieu thuc lamda
            menuItem2.Click += (sender, e) => DatPhongNhanh(room);
            menuItem3.Click += (sender, e) => CapNhatSanPham(room);
            menuItem4.Click += (sender, e) => ThanhToan(room, control);

            contextMenuStrip.Items.Add(menuItem1);
            contextMenuStrip.Items.Add(menuItem2);
            contextMenuStrip.Items.Add(menuItem3);
            contextMenuStrip.Items.Add(menuItem4);

            contextMenuStrip.Show(control, new Point(control.Width / 2, control.Height / 2));
            // control vi tri của click 
        }

        private void ChuyenPhong(classPhong room)
        {
            MessageBox.Show($"Đặt phòng nhanh {room.id}");
        }

        private void DatPhongNhanh(classPhong room)
        {
            MessageBox.Show($"Đặt phòng nhanh {room.id}");
        }

        private void CapNhatSanPham(classPhong room)
        {
            MessageBox.Show($"Cập nhật sản phẩm cho phòng {room.id}");
        }

        private void ThanhToan(classPhong room, Control control)
        {
            control.BackColor = Color.BlueViolet;
            MessageBox.Show($"Thanh toán cho phòng {room.id}");
        }

        private void getAll()
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
                if(room.trangThai == "Available")
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
                if (room.trangThai == "Maintenance")
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
    }
}
