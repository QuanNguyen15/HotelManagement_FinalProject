namespace GuiLayer
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new ReaLTaiizor.Controls.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnMyroom = new ReaLTaiizor.Controls.Panel();
            this.btnMyroom = new System.Windows.Forms.Button();
            this.pnBookingroom = new ReaLTaiizor.Controls.Panel();
            this.btnBookingroom = new System.Windows.Forms.Button();
            this.pnBill = new ReaLTaiizor.Controls.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.pnClient = new ReaLTaiizor.Controls.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.pnAbout = new ReaLTaiizor.Controls.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnMyroom.SuspendLayout();
            this.pnBookingroom.SuspendLayout();
            this.pnBill.SuspendLayout();
            this.pnClient.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(63, 51);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 2;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(993, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "THIS IS HOME";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnHome);
            this.sidebar.Controls.Add(this.pnMyroom);
            this.sidebar.Controls.Add(this.pnBookingroom);
            this.sidebar.Controls.Add(this.pnBill);
            this.sidebar.Controls.Add(this.pnClient);
            this.sidebar.Controls.Add(this.pnAbout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 57);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(284, 666);
            this.sidebar.TabIndex = 1;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.SystemColors.Control;
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnHome.Size = new System.Drawing.Size(277, 52);
            this.pnHome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnHome.TabIndex = 3;
            this.pnHome.Text = "panel2";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-22, -21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(323, 98);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "              Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnMyroom
            // 
            this.pnMyroom.BackColor = System.Drawing.SystemColors.Control;
            this.pnMyroom.Controls.Add(this.btnMyroom);
            this.pnMyroom.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnMyroom.Location = new System.Drawing.Point(3, 61);
            this.pnMyroom.Name = "pnMyroom";
            this.pnMyroom.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnMyroom.Size = new System.Drawing.Size(277, 54);
            this.pnMyroom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnMyroom.TabIndex = 4;
            this.pnMyroom.Text = "panel3";
            // 
            // btnMyroom
            // 
            this.btnMyroom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyroom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyroom.Image = ((System.Drawing.Image)(resources.GetObject("btnMyroom.Image")));
            this.btnMyroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyroom.Location = new System.Drawing.Point(-22, -21);
            this.btnMyroom.Name = "btnMyroom";
            this.btnMyroom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMyroom.Size = new System.Drawing.Size(323, 98);
            this.btnMyroom.TabIndex = 2;
            this.btnMyroom.Text = "              My Room";
            this.btnMyroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyroom.UseVisualStyleBackColor = false;
            // 
            // pnBookingroom
            // 
            this.pnBookingroom.BackColor = System.Drawing.SystemColors.Control;
            this.pnBookingroom.Controls.Add(this.btnBookingroom);
            this.pnBookingroom.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnBookingroom.Location = new System.Drawing.Point(3, 121);
            this.pnBookingroom.Name = "pnBookingroom";
            this.pnBookingroom.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnBookingroom.Size = new System.Drawing.Size(277, 54);
            this.pnBookingroom.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnBookingroom.TabIndex = 5;
            this.pnBookingroom.Text = "panel4";
            // 
            // btnBookingroom
            // 
            this.btnBookingroom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBookingroom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingroom.Image = ((System.Drawing.Image)(resources.GetObject("btnBookingroom.Image")));
            this.btnBookingroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingroom.Location = new System.Drawing.Point(-22, -21);
            this.btnBookingroom.Name = "btnBookingroom";
            this.btnBookingroom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBookingroom.Size = new System.Drawing.Size(323, 98);
            this.btnBookingroom.TabIndex = 2;
            this.btnBookingroom.Text = "              Booking Room";
            this.btnBookingroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingroom.UseVisualStyleBackColor = false;
            // 
            // pnBill
            // 
            this.pnBill.BackColor = System.Drawing.SystemColors.Control;
            this.pnBill.Controls.Add(this.btnBill);
            this.pnBill.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnBill.Location = new System.Drawing.Point(3, 181);
            this.pnBill.Name = "pnBill";
            this.pnBill.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnBill.Size = new System.Drawing.Size(277, 54);
            this.pnBill.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnBill.TabIndex = 6;
            this.pnBill.Text = "panel5";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(-22, -21);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(323, 98);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "              Bill";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = false;
            // 
            // pnClient
            // 
            this.pnClient.BackColor = System.Drawing.SystemColors.Control;
            this.pnClient.Controls.Add(this.btnClient);
            this.pnClient.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnClient.Location = new System.Drawing.Point(3, 241);
            this.pnClient.Name = "pnClient";
            this.pnClient.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnClient.Size = new System.Drawing.Size(277, 54);
            this.pnClient.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnClient.TabIndex = 7;
            this.pnClient.Text = "panel6";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(-22, -21);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(323, 98);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "              My Client";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.UseVisualStyleBackColor = false;
            // 
            // pnAbout
            // 
            this.pnAbout.BackColor = System.Drawing.SystemColors.Control;
            this.pnAbout.Controls.Add(this.btnAbout);
            this.pnAbout.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnAbout.Location = new System.Drawing.Point(3, 301);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.pnAbout.Size = new System.Drawing.Size(277, 54);
            this.pnAbout.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnAbout.TabIndex = 8;
            this.pnAbout.Text = "panel7";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-22, -21);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(323, 98);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "              About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 723);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnMyroom.ResumeLayout(false);
            this.pnBookingroom.ResumeLayout(false);
            this.pnBill.ResumeLayout(false);
            this.pnClient.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnHome;
        private ReaLTaiizor.Controls.Panel pnHome;
        private ReaLTaiizor.Controls.Panel pnMyroom;
        private System.Windows.Forms.Button btnMyroom;
        private ReaLTaiizor.Controls.Panel pnBookingroom;
        private System.Windows.Forms.Button btnBookingroom;
        private ReaLTaiizor.Controls.Panel pnBill;
        private System.Windows.Forms.Button btnBill;
        private ReaLTaiizor.Controls.Panel pnClient;
        private System.Windows.Forms.Button btnClient;
        private ReaLTaiizor.Controls.Panel pnAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btnHam;
    }
}