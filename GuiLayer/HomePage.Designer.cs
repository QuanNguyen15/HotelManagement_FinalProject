namespace GuiLayer
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.pnIMove = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.tabService1 = new GuiLayer.tabService();
            this.tabBooking1 = new GuiLayer.tabBooking();
            this.tabStatistic1 = new GuiLayer.tabStatistic();
            this.tabHomePage1 = new GuiLayer.tabHomePage();
            this.tabClient1 = new GuiLayer.tabClient();
            this.tabRoom1 = new GuiLayer.tabRoom();
            this.tabBill1 = new GuiLayer.tabBill();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbDateAndTime = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.tabBill2 = new GuiLayer.tabBill();
            this.pnMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.pnMenu.Controls.Add(this.btnStatistic);
            this.pnMenu.Controls.Add(this.panel3);
            this.pnMenu.Controls.Add(this.btnService);
            this.pnMenu.Controls.Add(this.pnIMove);
            this.pnMenu.Controls.Add(this.btnBill);
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.btnClient);
            this.pnMenu.Controls.Add(this.btnBooking);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.btnRoom);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 53);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(291, 980);
            this.pnMenu.TabIndex = 1;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStatistic
            // 
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistic.Image")));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(64, 601);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(186, 53);
            this.btnStatistic.TabIndex = 16;
            this.btnStatistic.Text = "       Statistic";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 880);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 100);
            this.panel3.TabIndex = 15;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(36, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(162, 53);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "        Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnService
            // 
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(64, 521);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(186, 53);
            this.btnService.TabIndex = 14;
            this.btnService.Text = "       Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // pnIMove
            // 
            this.pnIMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(106)))), ((int)(((byte)(184)))));
            this.pnIMove.Location = new System.Drawing.Point(52, 214);
            this.pnIMove.Name = "pnIMove";
            this.pnIMove.Size = new System.Drawing.Size(6, 53);
            this.pnIMove.TabIndex = 11;
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(64, 450);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(186, 53);
            this.btnBill.TabIndex = 13;
            this.btnBill.Text = "       Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 184);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(122, 131);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(38, 24);
            this.lbUser.TabIndex = 9;
            this.lbUser.Text = "{?}";
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(64, 391);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(186, 53);
            this.btnClient.TabIndex = 12;
            this.btnClient.Text = "       Client";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Image = ((System.Drawing.Image)(resources.GetObject("btnBooking.Image")));
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(64, 332);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(186, 53);
            this.btnBooking.TabIndex = 11;
            this.btnBooking.Text = "       Booking";
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(64, 214);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 53);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "       Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(64, 273);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(186, 53);
            this.btnRoom.TabIndex = 10;
            this.btnRoom.Text = "       Room";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnCenter.Controls.Add(this.tabBill2);
            this.pnCenter.Controls.Add(this.tabService1);
            this.pnCenter.Controls.Add(this.tabBooking1);
            this.pnCenter.Controls.Add(this.tabStatistic1);
            this.pnCenter.Controls.Add(this.tabHomePage1);
            this.pnCenter.Controls.Add(this.tabClient1);
            this.pnCenter.Controls.Add(this.tabRoom1);
            this.pnCenter.Controls.Add(this.tabBill1);
            this.pnCenter.Controls.Add(this.pictureBox2);
            this.pnCenter.Controls.Add(this.pnGrid);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(291, 53);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1611, 980);
            this.pnCenter.TabIndex = 2;
            // 
            // tabService1
            // 
            this.tabService1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabService1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabService1.Location = new System.Drawing.Point(10, 0);
            this.tabService1.Name = "tabService1";
            this.tabService1.Size = new System.Drawing.Size(1601, 980);
            this.tabService1.TabIndex = 9;
            // 
            // tabBooking1
            // 
            this.tabBooking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabBooking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBooking1.Location = new System.Drawing.Point(10, 0);
            this.tabBooking1.Name = "tabBooking1";
            this.tabBooking1.Size = new System.Drawing.Size(1601, 980);
            this.tabBooking1.TabIndex = 8;
            this.tabBooking1.Load += new System.EventHandler(this.tabBooking1_Load);
            // 
            // tabStatistic1
            // 
            this.tabStatistic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabStatistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStatistic1.Location = new System.Drawing.Point(10, 0);
            this.tabStatistic1.Name = "tabStatistic1";
            this.tabStatistic1.Size = new System.Drawing.Size(1601, 980);
            this.tabStatistic1.TabIndex = 7;
            this.tabStatistic1.Load += new System.EventHandler(this.tabStatistic1_Load);
            // 
            // tabHomePage1
            // 
            this.tabHomePage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabHomePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHomePage1.Location = new System.Drawing.Point(10, 0);
            this.tabHomePage1.Name = "tabHomePage1";
            this.tabHomePage1.Size = new System.Drawing.Size(1601, 980);
            this.tabHomePage1.TabIndex = 6;
            // 
            // tabClient1
            // 
            this.tabClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabClient1.Location = new System.Drawing.Point(10, 0);
            this.tabClient1.Name = "tabClient1";
            this.tabClient1.Size = new System.Drawing.Size(1601, 980);
            this.tabClient1.TabIndex = 5;
            this.tabClient1.Load += new System.EventHandler(this.tabClient1_Load);
            // 
            // tabRoom1
            // 
            this.tabRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRoom1.Location = new System.Drawing.Point(10, 0);
            this.tabRoom1.Name = "tabRoom1";
            this.tabRoom1.Size = new System.Drawing.Size(1601, 980);
            this.tabRoom1.TabIndex = 4;
            // 
            // tabBill1
            // 
            this.tabBill1.BackColor = System.Drawing.Color.DimGray;
            this.tabBill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBill1.Location = new System.Drawing.Point(10, 0);
            this.tabBill1.Name = "tabBill1";
            this.tabBill1.Size = new System.Drawing.Size(1601, 980);
            this.tabBill1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1601, 980);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pnGrid
            // 
            this.pnGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.pnGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnGrid.Location = new System.Drawing.Point(0, 0);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(10, 980);
            this.pnGrid.TabIndex = 1;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.pnHeader.Controls.Add(this.lbDateAndTime);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1902, 53);
            this.pnHeader.TabIndex = 3;
            this.pnHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHeader_Paint);
            // 
            // lbDateAndTime
            // 
            this.lbDateAndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDateAndTime.AutoSize = true;
            this.lbDateAndTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateAndTime.ForeColor = System.Drawing.Color.White;
            this.lbDateAndTime.Location = new System.Drawing.Point(1713, 26);
            this.lbDateAndTime.Name = "lbDateAndTime";
            this.lbDateAndTime.Size = new System.Drawing.Size(38, 24);
            this.lbDateAndTime.TabIndex = 0;
            this.lbDateAndTime.Text = "{?}";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // tabBill2
            // 
            this.tabBill2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.tabBill2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBill2.Location = new System.Drawing.Point(10, 0);
            this.tabBill2.Name = "tabBill2";
            this.tabBill2.Size = new System.Drawing.Size(1601, 980);
            this.tabBill2.TabIndex = 10;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnHeader);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnIMove;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbDateAndTime;
        private System.Windows.Forms.Timer timerDateAndTime;
        private tabBill tabBill1;
        private tabRoom tabRoom1;
        private tabClient tabClient1;
        private tabHomePage tabHomePage1;
        private System.Windows.Forms.Button btnStatistic;
        private tabStatistic tabStatistic1;
        private tabBooking tabBooking1;
        private tabService tabService1;
        private tabBill tabBill2;
    }
}