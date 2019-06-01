using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace sqlconnectionmanager
{
    public partial class setserver : Form
    {
        public setserver()
        {
            InitializeComponent();
            fnLoadVersion();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = openFileDialog1.FileName;
            } 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!File.Exists("sqlversion.xml"))
            {
                XmlWriter xmlWriter = XmlWriter.Create("sqlversion.xml");

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("SQLVERSIONS");

                xmlWriter.WriteStartElement("SQLV");
                xmlWriter.WriteStartElement("Name");
                xmlWriter.WriteString(textBox1.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("location");
                xmlWriter.WriteString(label2.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            else
            {
                XDocument xDocument = XDocument.Load("sqlversion.xml");
                XElement root = xDocument.Element("SQLVERSIONS");
                IEnumerable<XElement> rows = root.Descendants("SQLV");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("SQLV",
                   new XElement("Name", textBox1.Text.ToString()),
                   new XElement("location", label2.Text.ToString()) 
                    
                   
                   ));
                xDocument.Save("sqlversion.xml");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                string proname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(@"sqlversion.xml");
                XmlNodeList nodes = xdoc.GetElementsByTagName("SQLV");
                foreach (XmlNode node in nodes)
                {
                    if (node["Name"].InnerText == proname)
                    {
                        node.ParentNode.RemoveChild(node);
                        break;
                    }
                }
                xdoc.Save(@"sqlversion.xml");

            }
        }


        private void fnLoadVersion()
        {
            DataSet myDataSet2 = new DataSet();
            myDataSet2.ReadXml(@"sqlversion.xml");
            dataGridView1.DataSource = myDataSet2.Tables[0].DefaultView;
            
        }


        }
    
}
