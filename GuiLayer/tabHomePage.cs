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
    public partial class tabHomePage : UserControl
    {
       
        public tabHomePage()
        {
            InitializeComponent();
            
            picMain.Click += picMain_Click; // Gắn sự kiện Click cho hình ảnh
            LoadImage();

        }



        private int totalImages = 4; // Tổng số ảnh
        private int currentImage = 1; // Ảnh hiện tại đang hiển thị
        
        
        private void LoadImage()
        {
            string imagePath = string.Format(@"Images\{0}.jpg", currentImage);
            picMain.ImageLocation = imagePath;
        }

        
       
        

        private void tabHomePage_Load(object sender, EventArgs e)
        {
             
            
        }

        private void picMain_Click(object sender, EventArgs e)
        {
            currentImage ++; // Chuyển đến ảnh tiếp theo mỗi khi có sự kiện click
            if (currentImage >= totalImages)
            {
                currentImage = 1; // Quay lại ảnh đầu tiên nếu đã đến ảnh cuối cùng
            }
            LoadImage(); // Hiển thị ảnh mới
        }

       
    }
}
