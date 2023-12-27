namespace GuiLayer
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.phongToolStripMenuItem,
            this.khachToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.quảnLýPhòngToolStripMenuItem1});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýPhòngToolStripMenuItem1
            // 
            this.quảnLýPhòngToolStripMenuItem1.Name = "quảnLýPhòngToolStripMenuItem1";
            this.quảnLýPhòngToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.quảnLýPhòngToolStripMenuItem1.Text = "Quản lý phòng";
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.đặtPhòngToolStripMenuItem});
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.phongToolStripMenuItem.Text = "Phong";
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            this.quảnLýPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            // 
            // khachToolStripMenuItem
            // 
            this.khachToolStripMenuItem.Name = "khachToolStripMenuItem";
            this.khachToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.khachToolStripMenuItem.Text = "Khach";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.EdgeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(159, 422);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachToolStripMenuItem;
        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem1;
    }
}