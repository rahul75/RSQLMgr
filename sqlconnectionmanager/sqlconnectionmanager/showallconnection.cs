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
    public partial class showallconnection : Form
    {
        public showallconnection()
        {
            InitializeComponent();
        }

        private void showallconnection_Load(object sender, EventArgs e)
        {
            fnLoadConnections();

            fnLoadVersion();

        }

        private void fnLoadVersion()
        {
            DataSet myDataSet2 = new DataSet();
            myDataSet2.ReadXml(@"sqlversion.xml");
            ddlSQLVersion.DataSource = myDataSet2.Tables[0].DefaultView;
            ddlSQLVersion.DisplayMember = "Name";
            ddlSQLVersion.ValueMember = "Location";
        }

        private void fnLoadConnections()
        {
            DataSet myDataSet = new DataSet();
            myDataSet.ReadXml(@"sercon.xml");
            myDataGridView.DataSource = myDataSet.Tables[0].DefaultView;
            myDataGridView.AllowUserToAddRows = false;
        }

        private void myDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                StringBuilder str = new StringBuilder();
                str.AppendFormat(@"-S {0} -U {1} -P {2} -d {3} ",myDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
                    ,myDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()
                      , myDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString()
                        , myDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()
                    );
                string path = ddlSQLVersion.SelectedValue.ToString(); //@"C:\Program Files\Microsoft SQL Server\120\Tools\Binn\ManagementStudio\ssms.exe";
                System.Diagnostics.Process.Start(path, str.ToString());
            }
        }
    }
}
