using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sqlconnectionmanager
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            showallconnection newMDIChild = new showallconnection();
            // Set the Parent Form of the Child window.
            if (!CheckForDuplicate(newMDIChild))
            {
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Dock = DockStyle.Fill;  
                newMDIChild.Show();
            }
        }

        private void showConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showallconnection newMDIChild = new showallconnection();
            // Set the Parent Form of the Child window.
            if (!CheckForDuplicate(newMDIChild))
            {
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Dock = DockStyle.Fill;  
                newMDIChild.Show();
            }
        }

        private void addNewConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            // Set the Parent Form of the Child window.
            if (!CheckForDuplicate(newMDIChild))
            {
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Dock = DockStyle.Fill;  
                newMDIChild.Show();
            }
        }

        private void addNewSQLVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setserver newMDIChild = new setserver();
            // Set the Parent Form of the Child window.
            if (!CheckForDuplicate(newMDIChild))
            {
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.Dock = DockStyle.Fill;  
                newMDIChild.Show();
            }
        }

        private bool CheckForDuplicate(Form newForm)
        {
            bool bValue = false;
            foreach (Form fm in this.MdiChildren)
            {
                if (fm.GetType() == newForm.GetType())
                {
                    fm.Activate();
                    fm.WindowState = FormWindowState.Maximized;
                    bValue = true;
                }
            }
            return bValue;
        }

        private void home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
