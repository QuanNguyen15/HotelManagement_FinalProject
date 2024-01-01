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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpDbRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpSingleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpVipRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.radAll.Location = new System.Drawing.Point(774, 17);
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
            this.radAvail.Location = new System.Drawing.Point(860, 19);
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
            this.radMaintenece.Location = new System.Drawing.Point(975, 17);
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
            this.comboBox1.Location = new System.Drawing.Point(860, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(26, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 807);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.flpVipRoom);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1503, 40);
            this.panel4.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "VIP Room";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.flpDbRoom);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1503, 50);
            this.panel3.TabIndex = 31;
            // 
            // flpDbRoom
            // 
            this.flpDbRoom.AutoScroll = true;
            this.flpDbRoom.AutoSize = true;
            this.flpDbRoom.BackColor = System.Drawing.Color.White;
            this.flpDbRoom.Location = new System.Drawing.Point(25, 37);
            this.flpDbRoom.Name = "flpDbRoom";
            this.flpDbRoom.Size = new System.Drawing.Size(1400, 10);
            this.flpDbRoom.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Double Room";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.flpSingleRoom);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 800);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1503, 50);
            this.panel2.TabIndex = 29;
            // 
            // flpSingleRoom
            // 
            this.flpSingleRoom.AutoScroll = true;
            this.flpSingleRoom.AutoSize = true;
            this.flpSingleRoom.BackColor = System.Drawing.Color.White;
            this.flpSingleRoom.Location = new System.Drawing.Point(25, 37);
            this.flpSingleRoom.MinimumSize = new System.Drawing.Size(1400, 0);
            this.flpSingleRoom.Name = "flpSingleRoom";
            this.flpSingleRoom.Size = new System.Drawing.Size(1400, 10);
            this.flpSingleRoom.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Single Room";
            // 
            // flpVipRoom
            // 
            this.flpVipRoom.BackColor = System.Drawing.Color.White;
            this.flpVipRoom.Location = new System.Drawing.Point(25, 27);
            this.flpVipRoom.MaximumSize = new System.Drawing.Size(1400, 0);
            this.flpVipRoom.Name = "flpVipRoom";
            this.flpVipRoom.Size = new System.Drawing.Size(277, 10);
            this.flpVipRoom.TabIndex = 23;
            // 
            // tabRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.radMaintenece);
            this.Controls.Add(this.radAvail);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.textBox1);
            this.Name = "tabRoom";
            this.Size = new System.Drawing.Size(1601, 980);
            this.Load += new System.EventHandler(this.tabRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpSingleRoom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpDbRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpVipRoom;
    }
}
