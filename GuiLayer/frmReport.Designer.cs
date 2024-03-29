﻿namespace GuiLayer
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.soHoaDonNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDatPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.cbTypePrint = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cbYear.Location = new System.Drawing.Point(111, 26);
            this.cbYear.Name = "cbYear";
            this.cbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbYear.Size = new System.Drawing.Size(126, 27);
            this.cbYear.TabIndex = 0;
            this.cbYear.Text = "2024";
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(418, 30);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbMonth.Size = new System.Drawing.Size(126, 27);
            this.cbMonth.TabIndex = 1;
            this.cbMonth.Text = "1";
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Month";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.soHoaDonNew,
            this.ngayLap,
            this.idDatPhong,
            this.tenNhanVien,
            this.tongTien});
            this.dataGridViewReport.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewReport.Location = new System.Drawing.Point(53, 202);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReport.RowHeadersVisible = false;
            this.dataGridViewReport.RowHeadersWidth = 51;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.Size = new System.Drawing.Size(1035, 400);
            this.dataGridViewReport.TabIndex = 4;
            // 
            // soHoaDonNew
            // 
            this.soHoaDonNew.DataPropertyName = "soHoaDonNew";
            this.soHoaDonNew.HeaderText = "Bill ID";
            this.soHoaDonNew.MinimumWidth = 6;
            this.soHoaDonNew.Name = "soHoaDonNew";
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayDat";
            this.ngayLap.HeaderText = "Check in day";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            // 
            // idDatPhong
            // 
            this.idDatPhong.DataPropertyName = "idDatPhong";
            this.idDatPhong.HeaderText = "Booking ID";
            this.idDatPhong.MinimumWidth = 6;
            this.idDatPhong.Name = "idDatPhong";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Staff name";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tienPhong";
            this.tongTien.HeaderText = "Total";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1048, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(40, 40);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrint.TabIndex = 5;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbTypePrint
            // 
            this.cbTypePrint.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypePrint.FormattingEnabled = true;
            this.cbTypePrint.Items.AddRange(new object[] {
            "PDF",
            "EXCEL"});
            this.cbTypePrint.Location = new System.Drawing.Point(943, 30);
            this.cbTypePrint.Name = "cbTypePrint";
            this.cbTypePrint.Size = new System.Drawing.Size(88, 27);
            this.cbTypePrint.TabIndex = 6;
            this.cbTypePrint.Text = "EXCEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(370, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Revenue Report ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 650);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(719, 650);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTotal.Size = new System.Drawing.Size(46, 29);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "{?}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(986, 650);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "VND";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1147, 756);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTypePrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbYear);
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.ComboBox cbTypePrint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHoaDonNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDatPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}