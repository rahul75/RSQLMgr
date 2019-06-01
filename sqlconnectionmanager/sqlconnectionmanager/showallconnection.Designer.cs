namespace sqlconnectionmanager
{
    partial class showallconnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showallconnection));
            this.myDataGridView = new System.Windows.Forms.DataGridView();
            this.btnconnect = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlSQLVersion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myDataGridView
            // 
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnconnect});
            this.myDataGridView.Location = new System.Drawing.Point(12, 94);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.Size = new System.Drawing.Size(872, 237);
            this.myDataGridView.TabIndex = 0;
            this.myDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myDataGridView_CellContentClick);
            // 
            // btnconnect
            // 
            this.btnconnect.HeaderText = "Connect";
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Text = "CONNECT";
            this.btnconnect.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select SQL Server Version";
            // 
            // ddlSQLVersion
            // 
            this.ddlSQLVersion.FormattingEnabled = true;
            this.ddlSQLVersion.Location = new System.Drawing.Point(178, 26);
            this.ddlSQLVersion.Name = "ddlSQLVersion";
            this.ddlSQLVersion.Size = new System.Drawing.Size(263, 21);
            this.ddlSQLVersion.TabIndex = 2;
            // 
            // showallconnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 448);
            this.Controls.Add(this.ddlSQLVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showallconnection";
            this.Text = "showallconnection";
            this.Load += new System.EventHandler(this.showallconnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn btnconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlSQLVersion;
    }
}