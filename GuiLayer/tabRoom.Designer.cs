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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radAvail = new System.Windows.Forms.RadioButton();
            this.radMaintenece = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flpSingleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpVipRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDoubleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Single = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpSingleRoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpVipRoom.SuspendLayout();
            this.flpDoubleRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(548, 43);
            this.textBox1.TabIndex = 1;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(15, 17);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(43, 20);
            this.radAll.TabIndex = 9;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // radAvail
            // 
            this.radAvail.AutoSize = true;
            this.radAvail.Location = new System.Drawing.Point(101, 19);
            this.radAvail.Name = "radAvail";
            this.radAvail.Size = new System.Drawing.Size(85, 20);
            this.radAvail.TabIndex = 10;
            this.radAvail.TabStop = true;
            this.radAvail.Text = "Available";
            this.radAvail.UseVisualStyleBackColor = true;
            // 
            // radMaintenece
            // 
            this.radMaintenece.AutoSize = true;
            this.radMaintenece.Location = new System.Drawing.Point(216, 19);
            this.radMaintenece.Name = "radMaintenece";
            this.radMaintenece.Size = new System.Drawing.Size(101, 20);
            this.radMaintenece.TabIndex = 12;
            this.radMaintenece.TabStop = true;
            this.radMaintenece.Text = "Maintainece";
            this.radMaintenece.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Location = new System.Drawing.Point(581, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 44);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(26, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 810);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radMaintenece);
            this.panel3.Controls.Add(this.radAll);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.radAvail);
            this.panel3.Location = new System.Drawing.Point(846, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 100);
            this.panel3.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1549, 56);
            this.label5.TabIndex = 41;
            this.label5.Text = "Double Room";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Single
            // 
            this.Single.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Single.Location = new System.Drawing.Point(3, 0);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(1549, 56);
            this.Single.TabIndex = 39;
            this.Single.Text = "Single Room";
            this.Single.Click += new System.EventHandler(this.Single_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1549, 53);
            this.label1.TabIndex = 40;
            this.label1.Text = "Vip Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radAvail;
        private System.Windows.Forms.RadioButton radMaintenece;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flpSingleRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpVipRoom;
        private System.Windows.Forms.FlowLayoutPanel flpDoubleRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Single;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
