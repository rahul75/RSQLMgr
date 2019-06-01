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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fnLoadConnections();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!File.Exists("sercon.xml"))
            {
                XmlWriter xmlWriter = XmlWriter.Create("sercon.xml");

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("conns");

                xmlWriter.WriteStartElement("con");
                xmlWriter.WriteStartElement("Projectname");
                xmlWriter.WriteString(tbxProjName.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Servername");
                xmlWriter.WriteString(tbxservername.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("username");
                xmlWriter.WriteString(tbxusername.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("password");
                xmlWriter.WriteString(tbxpassword.Text.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("database");
                xmlWriter.WriteString(tbxdatabase.Text.ToString());
                xmlWriter.WriteEndElement();



                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }
            else
            {
                XDocument xDocument = XDocument.Load("sercon.xml");
                XElement root = xDocument.Element("conns");
                IEnumerable<XElement> rows = root.Descendants("con");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("con",
                   new XElement("Projectname", tbxProjName.Text.ToString()),
                   new XElement("Servername", tbxservername.Text.ToString()),
                   new XElement("username", tbxusername.Text.ToString()),
                   new XElement("password", tbxpassword.Text.ToString()),
                   new XElement("database", tbxdatabase.Text.ToString()) 
                   
                   ));
                xDocument.Save("sercon.xml");
            }
        }

        private void fnLoadConnections()
        {
            DataSet myDataSet = new DataSet();
            myDataSet.ReadXml(@"sercon.xml");
            dataGridView1.DataSource = myDataSet.Tables[0].DefaultView;
            dataGridView1.AllowUserToAddRows = false;
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
                xdoc.Load(@"sercon.xml");
                XmlNodeList nodes = xdoc.GetElementsByTagName("con");
                foreach (XmlNode node in nodes)
                {
                    if (node["Projectname"].InnerText == proname)
                    {
                        node.ParentNode.RemoveChild(node);
                        break;
                    }
                }
                xdoc.Save(@"sercon.xml");

            }
        }

    }
}
