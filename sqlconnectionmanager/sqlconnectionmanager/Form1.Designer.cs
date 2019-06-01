namespace sqlconnectionmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProjName = new System.Windows.Forms.TextBox();
            this.tbxservername = new System.Windows.Forms.TextBox();
            this.Servername = new System.Windows.Forms.Label();
            this.tbxusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxdatabase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // tbxProjName
            // 
            this.tbxProjName.Location = new System.Drawing.Point(90, 32);
            this.tbxProjName.Name = "tbxProjName";
            this.tbxProjName.Size = new System.Drawing.Size(293, 20);
            this.tbxProjName.TabIndex = 1;
            // 
            // tbxservername
            // 
            this.tbxservername.Location = new System.Drawing.Point(90, 72);
            this.tbxservername.Name = "tbxservername";
            this.tbxservername.Size = new System.Drawing.Size(293, 20);
            this.tbxservername.TabIndex = 3;
            // 
            // Servername
            // 
            this.Servername.AutoSize = true;
            this.Servername.Location = new System.Drawing.Point(13, 72);
            this.Servername.Name = "Servername";
            this.Servername.Size = new System.Drawing.Size(67, 13);
            this.Servername.TabIndex = 2;
            this.Servername.Text = "Server name";
            // 
            // tbxusername
            // 
            this.tbxusername.Location = new System.Drawing.Point(89, 108);
            this.tbxusername.Name = "tbxusername";
            this.tbxusername.Size = new System.Drawing.Size(293, 20);
            this.tbxusername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // tbxpassword
            // 
            this.tbxpassword.Location = new System.Drawing.Point(90, 150);
            this.tbxpassword.Name = "tbxpassword";
            this.tbxpassword.Size = new System.Drawing.Size(293, 20);
            this.tbxpassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "password";
            // 
            // tbxdatabase
            // 
            this.tbxdatabase.Location = new System.Drawing.Point(90, 189);
            this.tbxdatabase.Name = "tbxdatabase";
            this.tbxdatabase.Size = new System.Drawing.Size(293, 20);
            this.tbxdatabase.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Database";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.Location = new System.Drawing.Point(89, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(292, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(447, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(460, 266);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 310);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxdatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxservername);
            this.Controls.Add(this.Servername);
            this.Controls.Add(this.tbxProjName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProjName;
        private System.Windows.Forms.TextBox tbxservername;
        private System.Windows.Forms.Label Servername;
        private System.Windows.Forms.TextBox tbxusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxdatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}

