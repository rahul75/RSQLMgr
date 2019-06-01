namespace sqlconnectionmanager
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSQLVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConnectionToolStripMenuItem,
            this.addNewConnectionToolStripMenuItem,
            this.addNewSQLVersionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showConnectionToolStripMenuItem
            // 
            this.showConnectionToolStripMenuItem.Name = "showConnectionToolStripMenuItem";
            this.showConnectionToolStripMenuItem.ShowShortcutKeys = false;
            this.showConnectionToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.showConnectionToolStripMenuItem.Text = "Show Connection";
            this.showConnectionToolStripMenuItem.Click += new System.EventHandler(this.showConnectionToolStripMenuItem_Click);
            // 
            // addNewConnectionToolStripMenuItem
            // 
            this.addNewConnectionToolStripMenuItem.Name = "addNewConnectionToolStripMenuItem";
            this.addNewConnectionToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.addNewConnectionToolStripMenuItem.Text = "Add New Connection";
            this.addNewConnectionToolStripMenuItem.Click += new System.EventHandler(this.addNewConnectionToolStripMenuItem_Click);
            // 
            // addNewSQLVersionToolStripMenuItem
            // 
            this.addNewSQLVersionToolStripMenuItem.Name = "addNewSQLVersionToolStripMenuItem";
            this.addNewSQLVersionToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.addNewSQLVersionToolStripMenuItem.Text = "Add New SQL Version";
            this.addNewSQLVersionToolStripMenuItem.Click += new System.EventHandler(this.addNewSQLVersionToolStripMenuItem_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 471);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "home";
            this.Text = "R SQL Server Connection Manager(*Beta)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSQLVersionToolStripMenuItem;
    }
}