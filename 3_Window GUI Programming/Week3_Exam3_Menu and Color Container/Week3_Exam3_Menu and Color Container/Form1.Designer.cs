namespace Week3_Exam3_Menu_and_Color_Container
{
    partial class Form1
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
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawOvalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawLineToolStripMenuItem,
            this.drawOvalToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // drawLineToolStripMenuItem
            // 
            this.drawLineToolStripMenuItem.Name = "drawLineToolStripMenuItem";
            this.drawLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawLineToolStripMenuItem.Text = "Draw Line";
            this.drawLineToolStripMenuItem.Click += new System.EventHandler(this.drawLineToolStripMenuItem_Click);
            // 
            // drawOvalToolStripMenuItem
            // 
            this.drawOvalToolStripMenuItem.Name = "drawOvalToolStripMenuItem";
            this.drawOvalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawOvalToolStripMenuItem.Text = "Draw Oval";
            this.drawOvalToolStripMenuItem.Click += new System.EventHandler(this.drawOvalToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // selectToolStripMenuItem1
            // 
            this.selectToolStripMenuItem1.Name = "selectToolStripMenuItem1";
            this.selectToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.selectToolStripMenuItem1.Text = "Select";
            this.selectToolStripMenuItem1.Click += new System.EventHandler(this.selectToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawOvalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

