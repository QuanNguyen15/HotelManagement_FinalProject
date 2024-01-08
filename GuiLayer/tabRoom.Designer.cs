namespace GuiLayer
{
    partial class tabRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabRoom));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radAvail = new System.Windows.Forms.RadioButton();
            this.radMaintenece = new System.Windows.Forms.RadioButton();
            this.flpSingleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.Single = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpVipRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDoubleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radRenting = new System.Windows.Forms.RadioButton();
            this.radBooked = new System.Windows.Forms.RadioButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpSingleRoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpVipRoom.SuspendLayout();
            this.flpDoubleRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 34);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(548, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(26, 51);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(48, 28);
            this.radAll.TabIndex = 9;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radAvail
            // 
            this.radAvail.AutoSize = true;
            this.radAvail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAvail.Location = new System.Drawing.Point(92, 51);
            this.radAvail.Name = "radAvail";
            this.radAvail.Size = new System.Drawing.Size(96, 28);
            this.radAvail.TabIndex = 10;
            this.radAvail.TabStop = true;
            this.radAvail.Text = "Available";
            this.radAvail.UseVisualStyleBackColor = true;
            // 
            // radMaintenece
            // 
            this.radMaintenece.AutoSize = true;
            this.radMaintenece.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMaintenece.Location = new System.Drawing.Point(207, 51);
            this.radMaintenece.Name = "radMaintenece";
            this.radMaintenece.Size = new System.Drawing.Size(119, 28);
            this.radMaintenece.TabIndex = 12;
            this.radMaintenece.TabStop = true;
            this.radMaintenece.Text = "Maintainece";
            this.radMaintenece.UseVisualStyleBackColor = true;
            // 
            // flpSingleRoom
            // 
            this.flpSingleRoom.BackColor = System.Drawing.Color.White;
            this.flpSingleRoom.Controls.Add(this.Single);
            this.flpSingleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSingleRoom.Location = new System.Drawing.Point(0, 0);
            this.flpSingleRoom.Name = "flpSingleRoom";
            this.flpSingleRoom.Size = new System.Drawing.Size(1600, 56);
            this.flpSingleRoom.TabIndex = 34;
            this.flpSingleRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSingleRoom_Paint_2);
            // 
            // Single
            // 
            this.Single.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single.Location = new System.Drawing.Point(3, 0);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(1549, 56);
            this.Single.TabIndex = 39;
            this.Single.Text = "Single Room";
            this.Single.Click += new System.EventHandler(this.Single_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.flpVipRoom);
            this.panel1.Controls.Add(this.flpDoubleRoom);
            this.panel1.Controls.Add(this.flpSingleRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 810);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flpVipRoom
            // 
            this.flpVipRoom.BackColor = System.Drawing.Color.White;
            this.flpVipRoom.Controls.Add(this.label1);
            this.flpVipRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpVipRoom.Location = new System.Drawing.Point(0, 115);
            this.flpVipRoom.Name = "flpVipRoom";
            this.flpVipRoom.Size = new System.Drawing.Size(1600, 56);
            this.flpVipRoom.TabIndex = 38;
            this.flpVipRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDbRoom_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1549, 53);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vip Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flpDoubleRoom
            // 
            this.flpDoubleRoom.BackColor = System.Drawing.Color.White;
            this.flpDoubleRoom.Controls.Add(this.label5);
            this.flpDoubleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDoubleRoom.Location = new System.Drawing.Point(0, 56);
            this.flpDoubleRoom.Name = "flpDoubleRoom";
            this.flpDoubleRoom.Size = new System.Drawing.Size(1600, 59);
            this.flpDoubleRoom.TabIndex = 37;
            this.flpDoubleRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.flpVipRoom_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1549, 56);
            this.label5.TabIndex = 41;
            this.label5.Text = "Double Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(58, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 810);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radRenting);
            this.panel3.Controls.Add(this.radBooked);
            this.panel3.Controls.Add(this.lbStatus);
            this.panel3.Controls.Add(this.radMaintenece);
            this.panel3.Controls.Add(this.radAll);
            this.panel3.Controls.Add(this.radAvail);
            this.panel3.Location = new System.Drawing.Point(878, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 100);
            this.panel3.TabIndex = 39;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // radRenting
            // 
            this.radRenting.AutoSize = true;
            this.radRenting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRenting.Location = new System.Drawing.Point(355, 51);
            this.radRenting.Name = "radRenting";
            this.radRenting.Size = new System.Drawing.Size(87, 28);
            this.radRenting.TabIndex = 16;
            this.radRenting.TabStop = true;
            this.radRenting.Text = "Renting";
            this.radRenting.UseVisualStyleBackColor = true;
            // 
            // radBooked
            // 
            this.radBooked.AutoSize = true;
            this.radBooked.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBooked.Location = new System.Drawing.Point(476, 51);
            this.radBooked.Name = "radBooked";
            this.radBooked.Size = new System.Drawing.Size(86, 28);
            this.radBooked.TabIndex = 15;
            this.radBooked.TabStop = true;
            this.radBooked.Text = "Booked";
            this.radBooked.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(9, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(146, 24);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "Room\'s status";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(765, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 34);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(623, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 34);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSearch);
            this.Name = "tabRoom";
            this.Size = new System.Drawing.Size(1601, 980);
            this.Load += new System.EventHandler(this.tabRoom_Load);
            this.flpSingleRoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flpVipRoom.ResumeLayout(false);
            this.flpDoubleRoom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radAvail;
        private System.Windows.Forms.RadioButton radMaintenece;
        private System.Windows.Forms.FlowLayoutPanel flpSingleRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpVipRoom;
        private System.Windows.Forms.FlowLayoutPanel flpDoubleRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Single;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radBooked;
        private System.Windows.Forms.RadioButton radRenting;
    }
}
