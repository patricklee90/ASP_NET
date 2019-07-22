namespace Week3_Tutorial8_Drawing_Program
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
            this.pictureFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MI5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MI10 = new System.Windows.Forms.ToolStripMenuItem();
            this.lineStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MISolid = new System.Windows.Forms.ToolStripMenuItem();
            this.MIDotted = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureFileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.lineWidthToolStripMenuItem,
            this.lineStyleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureFileToolStripMenuItem
            // 
            this.pictureFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pictureFileToolStripMenuItem.Name = "pictureFileToolStripMenuItem";
            this.pictureFileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.pictureFileToolStripMenuItem.Text = "Picture File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectColorToolStripMenuItem.Text = "Select Color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.selectColorToolStripMenuItem_Click);
            // 
            // lineWidthToolStripMenuItem
            // 
            this.lineWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI2,
            this.MI5,
            this.MI10});
            this.lineWidthToolStripMenuItem.Name = "lineWidthToolStripMenuItem";
            this.lineWidthToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.lineWidthToolStripMenuItem.Text = "Line Width";
            // 
            // MI2
            // 
            this.MI2.Checked = true;
            this.MI2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MI2.Name = "MI2";
            this.MI2.Size = new System.Drawing.Size(86, 22);
            this.MI2.Text = "2";
            this.MI2.Click += new System.EventHandler(this.MI2_Click);
            // 
            // MI5
            // 
            this.MI5.Name = "MI5";
            this.MI5.Size = new System.Drawing.Size(86, 22);
            this.MI5.Text = "5";
            this.MI5.Click += new System.EventHandler(this.MI5_Click);
            // 
            // MI10
            // 
            this.MI10.Name = "MI10";
            this.MI10.Size = new System.Drawing.Size(86, 22);
            this.MI10.Text = "10";
            this.MI10.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // lineStyleToolStripMenuItem
            // 
            this.lineStyleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MISolid,
            this.MIDotted});
            this.lineStyleToolStripMenuItem.Name = "lineStyleToolStripMenuItem";
            this.lineStyleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.lineStyleToolStripMenuItem.Text = "Line Style";
            // 
            // MISolid
            // 
            this.MISolid.Checked = true;
            this.MISolid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MISolid.Name = "MISolid";
            this.MISolid.Size = new System.Drawing.Size(135, 22);
            this.MISolid.Text = "Solid Line";
            this.MISolid.Click += new System.EventHandler(this.MISolid_Click);
            // 
            // MIDotted
            // 
            this.MIDotted.Name = "MIDotted";
            this.MIDotted.Size = new System.Drawing.Size(135, 22);
            this.MIDotted.Text = "Dotted Line";
            this.MIDotted.Click += new System.EventHandler(this.MIDotted_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 391);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pictureFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI2;
        private System.Windows.Forms.ToolStripMenuItem MI5;
        private System.Windows.Forms.ToolStripMenuItem MI10;
        private System.Windows.Forms.ToolStripMenuItem lineStyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MISolid;
        private System.Windows.Forms.ToolStripMenuItem MIDotted;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

