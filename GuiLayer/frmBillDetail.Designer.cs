namespace GuiLayer
{
    partial class frmBillDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDetail));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumday = new System.Windows.Forms.Label();
            this.lbNumpeople = new System.Windows.Forms.Label();
            this.lbIdRoom = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStaffFullname = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.lbDateBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClientFullname = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(725, 798);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Contact us: 095466456";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNumday);
            this.panel1.Controls.Add(this.lbNumpeople);
            this.panel1.Controls.Add(this.lbIdRoom);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbStaffFullname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbIdBill);
            this.panel1.Controls.Add(this.lbDateBill);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbClientFullname);
            this.panel1.Location = new System.Drawing.Point(37, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 624);
            this.panel1.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDichVu,
            this.donGia,
            this.TongSoLuong,
            this.TongDonGia});
            this.dataGridView1.Location = new System.Drawing.Point(51, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 331);
            this.dataGridView1.TabIndex = 68;
            // 
            // tenDichVu
            // 
            this.tenDichVu.DataPropertyName = "tenDichVu";
            this.tenDichVu.HeaderText = "Service";
            this.tenDichVu.MinimumWidth = 6;
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.Width = 200;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Price";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.Width = 150;
            // 
            // TongSoLuong
            // 
            this.TongSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongSoLuong.DataPropertyName = "TongSoLuong";
            this.TongSoLuong.HeaderText = "Amount";
            this.TongSoLuong.MinimumWidth = 6;
            this.TongSoLuong.Name = "TongSoLuong";
            // 
            // TongDonGia
            // 
            this.TongDonGia.DataPropertyName = "TongDonGia";
            this.TongDonGia.HeaderText = "Sum";
            this.TongDonGia.MinimumWidth = 6;
            this.TongDonGia.Name = "TongDonGia";
            this.TongDonGia.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mr/Mrs:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(52)))), ((int)(((byte)(108)))));
            this.lbTotal.Location = new System.Drawing.Point(549, 569);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(54, 33);
            this.lbTotal.TabIndex = 66;
            this.lbTotal.Text = "{?}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 65;
            this.label1.Text = "Total:";
            // 
            // lbNumday
            // 
            this.lbNumday.AutoSize = true;
            this.lbNumday.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumday.Location = new System.Drawing.Point(724, 144);
            this.lbNumday.Name = "lbNumday";
            this.lbNumday.Size = new System.Drawing.Size(33, 19);
            this.lbNumday.TabIndex = 64;
            this.lbNumday.Text = "{?}";
            // 
            // lbNumpeople
            // 
            this.lbNumpeople.AutoSize = true;
            this.lbNumpeople.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumpeople.Location = new System.Drawing.Point(742, 109);
            this.lbNumpeople.Name = "lbNumpeople";
            this.lbNumpeople.Size = new System.Drawing.Size(33, 19);
            this.lbNumpeople.TabIndex = 63;
            this.lbNumpeople.Text = "{?}";
            // 
            // lbIdRoom
            // 
            this.lbIdRoom.AutoSize = true;
            this.lbIdRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdRoom.Location = new System.Drawing.Point(654, 77);
            this.lbIdRoom.Name = "lbIdRoom";
            this.lbIdRoom.Size = new System.Drawing.Size(33, 19);
            this.lbIdRoom.TabIndex = 62;
            this.lbIdRoom.Text = "{?}";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(551, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 61;
            this.label11.Text = "Number of days:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(551, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Number of people:";
            // 
            // lbStaffFullname
            // 
            this.lbStaffFullname.AutoSize = true;
            this.lbStaffFullname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStaffFullname.Location = new System.Drawing.Point(115, 145);
            this.lbStaffFullname.Name = "lbStaffFullname";
            this.lbStaffFullname.Size = new System.Drawing.Size(33, 19);
            this.lbStaffFullname.TabIndex = 59;
            this.lbStaffFullname.Text = "{?}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "ID Room:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Staff:";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.Location = new System.Drawing.Point(119, 109);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(33, 19);
            this.lbIdBill.TabIndex = 56;
            this.lbIdBill.Text = "{?}";
            // 
            // lbDateBill
            // 
            this.lbDateBill.AutoSize = true;
            this.lbDateBill.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBill.Location = new System.Drawing.Point(229, 83);
            this.lbDateBill.Name = "lbDateBill";
            this.lbDateBill.Size = new System.Drawing.Size(33, 19);
            this.lbDateBill.TabIndex = 55;
            this.lbDateBill.Text = "{?}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Bill creation date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "ID Bill:";
            // 
            // lbClientFullname
            // 
            this.lbClientFullname.AutoSize = true;
            this.lbClientFullname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientFullname.Location = new System.Drawing.Point(135, 45);
            this.lbClientFullname.Name = "lbClientFullname";
            this.lbClientFullname.Size = new System.Drawing.Size(38, 24);
            this.lbClientFullname.TabIndex = 52;
            this.lbClientFullname.Text = "{?}";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(855, 725);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 50);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPrint.TabIndex = 59;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 768);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 54);
            this.label4.TabIndex = 57;
            this.label4.Text = "\r\nSee you again in the future!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(52)))), ((int)(((byte)(108)))));
            this.label7.Location = new System.Drawing.Point(393, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 51);
            this.label7.TabIndex = 56;
            this.label7.Text = "Bill";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 966);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.MaximumSize = new System.Drawing.Size(958, 1013);
            this.MinimumSize = new System.Drawing.Size(958, 1013);
            this.Name = "frmBillDetail";
            this.Text = "frmBillDetail";
            this.Load += new System.EventHandler(this.frmBillDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumday;
        private System.Windows.Forms.Label lbNumpeople;
        private System.Windows.Forms.Label lbIdRoom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbStaffFullname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label lbDateBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClientFullname;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongDonGia;
    }
}