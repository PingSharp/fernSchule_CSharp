using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion4_1
{
    public partial class Form1 : Form
    {
        string xmlFile = "Karteikasten.xml";
        public Form1()
        {
            InitializeComponent();
            try
            {
                this.kartei.ReadXml(xmlFile);
                //this.kartei.ReadXmlSchema("Karteikasten.xsd");
                //XmlReadMode mode =  this.kartei.ReadXml(xmlFile);
                this.Text = xmlFile;
                toolStripStatusLabel1.Text = string.Format("Datei\"{0}\" gelesen", xmlFile);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.GetType() + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void öffnen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();//vorgefertigten .NET-Dialog 
            opendialog.InitialDirectory = @".";//Property initial das aktuelle Verzeichnis.
            opendialog.Filter = "XML-Datei(*.xml,*.xsd)|*.xml;*.xsd|Alle Dateien(*.*)|*.*";//Filter eigenschaft ist als wert ein String zuzuweisen,
            
            if(opendialog.ShowDialog()==DialogResult.OK)
            {
                xmlFile = opendialog.FileName;
                try
                {
                    kartei.Clear();
                    kartei.ReadXml(xmlFile);
                    this.Text = xmlFile;
                }
                catch(Exception ex)
                {
                    toolStripStatusLabel1.Text = ex.ToString();
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Auswahl der Xml-Datei abgebrochen";
            }
        }
    }
}
