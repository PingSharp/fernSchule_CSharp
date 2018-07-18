using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net.Http;

namespace Lektion3
{
    public partial class NavigationForm : Form
    {
        private string newLine = Environment.NewLine;
        private char tab = '\x0009';
        private XmlNode kontextNode;//aktuellen Knoten
        private XmlNode tempNode;//XMLNode-Objekt;
        XmlDocument xmlDoc = new XmlDocument();//Die Klasse XmlDocument erbt von XmlNode Klasse,ein XmlDocument Objekt initialisieren.
        
        


        public NavigationForm()
        {
            InitializeComponent();
            //try
            //{
            //    xmlDoc.Load("Kartei.xml");//Durch die Load Methode wird eine XML-Datei geladen. Die XML-Datei liegt im Verzeichnis"Debug".
            //    kontextNode = xmlDoc;//kontextNode wird auf das Dokument initialisiert.
            //    tbAusgabetextBox.Text = AusgabeString(kontextNode);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("{0}:{1}", ex.GetType(), ex.Message);
            //    StatusLabel.Text = ex.GetType().ToString();
            //}
            
        }
        private void Ausgabe(string node)//Die Methode ist für die Prüfung zuständig,ob der Knoten"tempNode" beim Navigieren initialisiert werden konnte.
        {//Wenn ein Button(parent,child,next,pre) gedrückt wird,wird diese Methode aufgerufen.
            if(tempNode == null)//Wenn es kein kind,keine Eltern,keine geschwister gibt,wird diese Anweisung durchgefürt.
            {
                tbAusgabetextBox.Text = "Es gibt kein" + node + "zu" + kontextNode.NodeType +
                    "\"" + kontextNode.Name + "\"";
            }
            else//Wenn es etwas gibt,wird das Objekt kontextNode wieder zugewiesen,dann wird die Methode AusgabeString aufgerufen.
            {
                kontextNode = tempNode;
                tbAusgabetextBox.Text = AusgabeString(kontextNode);
            }
        }
        private string AusgabeString(XmlNode kontextNode)
        {
            //Die Methode initialisiert eine string-Variable"retString" mit den werten von NodeType und Name,
            //alle Knotentypen haben einen Name.
            string retString = "NodeType:" + kontextNode.NodeType + newLine + "Name:   "
                + kontextNode.Name + newLine;
            switch(kontextNode.NodeType)//eine Switch-Struktur
            {
                case XmlNodeType.Document://kein Value,Der Ausgabe-String wird um die Angabe des Pfads auf die eingelesene
                    //XML-Datei ergänzt.
                    retString += "URL:     " + xmlDoc.BaseURI;//XmlDocument-Eigenschaft.
                    break;
                case XmlNodeType.DocumentType://kein Value,eine DTD kann intern im XML-Dokument erfolgen,eine solche
                    //Definition wird von der Eigenschaft"InternalSubset" zurückgegeben.dieser Eigenschaft wird von
                    //"XmlDocumentType" Klasse definiert.Dieser Typ steckt auch hinter der DocumentType-eigenschaft von"XmlDocument".

                    XmlDocumentType docType = xmlDoc.DocumentType;
                    //retString += "InternalSubset:" + docType.InternalSubset.Trim();
                    retString += "InternalSubset:" + newLine + "publicID:" + docType.PublicId + newLine + "systemID:" + docType.SystemId;
                    break;
                case XmlNodeType.Element://Kein Value
                    for(int i = 0;i <kontextNode.Attributes.Count;i++)
                    {
                        if(i==0)
                        {
                            retString += "Attribut(e):";

                        }
                        else
                        {
                            retString += tab;
                            retString += tab;
                        }
                        retString += kontextNode.Attributes.Item(i).Name;//Methode Item gehört zu der Klasse XmlAttributeCollection.
                        //Mit deren Hilfe lässt sich eine Auflistung aller Attribute aufbauen.
                        retString += "=" + kontextNode.Attributes.Item(i).Value + newLine;
                    }
                    break;
                case XmlNodeType.EntityReference://Kein Value
                    break;
                default:
                    retString += "Value:     ";
                    retString += kontextNode.Value;
                    break;
            }
            return retString;
        }

        private void parentbutton_Click(object sender, EventArgs e)
        {
            tempNode = kontextNode.ParentNode;
            Ausgabe("ParentNode");


        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            tempNode = kontextNode.PreviousSibling;
            Ausgabe("PreviousSibling");
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            tempNode = kontextNode.NextSibling;
            Ausgabe("NextSibling");
        }

        private void childbutton_Click(object sender, EventArgs e)
        {
            tempNode = kontextNode.FirstChild;
            Ausgabe("FirstChild");
        }

        private void Xbutton_Click(object sender, EventArgs e)
        {
            tbAusgabetextBox.Text = AusgabeString(kontextNode);
        }

        private void buttonchilds_Click(object sender, EventArgs e)
        {
            //XmlNodeList nodelist = kontextNode.ChildNodes;
            //if (nodelist == null)
            //{
            //    StatusLabel.Text = "Diese Knote hat keine kinder!";
            //}
            //else
            //{
            //    for (int i = 0; i < nodelist.Count; i++)
            //    {
            //        tbAusgabetextBox.Text = AusgabeString(nodelist[i]);
            //    }
            //}
            string ausgabe = "";
            if(kontextNode.HasChildNodes)
            {
                for(int i = 0;i < kontextNode.ChildNodes.Count;i++)
                {
                    ausgabe += kontextNode.ChildNodes[i].OuterXml + newLine;
                    //Gibt das Markup aller Kindelemente des aktuellen Knotens sowie des aktuellen Knotens selbst zurück!
                }
                tbAusgabetextBox.Text = ausgabe;
            }
            else
            {
                tbAusgabetextBox.Text = kontextNode.Name + "hat keine ChildNodes";
            }
        }

        private void buttonbyTagName_Click(object sender, EventArgs e)
        {
            //string eingabe = textBoxByTagName.Text;
            //string ausgabe = "";
            //XmlNodeList listofxmlnode = xmlDoc.GetElementsByTagName(eingabe);
            //if (eingabe == "")
            //{
            //    StatusLabel.Text = "Bitte geben Sie TagName ein!";
            //}
            //else
            //{
            //    for (int i = 0; i < listofxmlnode.Count; i++)
            //    {
            //        ausgabe += listofxmlnode[i].InnerText + newLine;

            //    }
            //}
            //tbAusgabetextBox.Text = ausgabe;
            if (textBoxByTagName.Text.Length == 0)
            {
                StatusLabel.Text = "Bitter einen Tagnamen angeben!";
            }
            else
            {
                StatusLabel.Text = "";
                string tagName = textBoxByTagName.Text.Trim();
                string ausgabe = "Einträge zum Elementnamen \"" + tagName + "\":" + newLine + newLine;
                XmlNodeList nodelist = xmlDoc.GetElementsByTagName(tagName);
                for (int i = 0; i < nodelist.Count; i++)
                {
                    ausgabe += nodelist[i].InnerText + newLine;
                  
                }
                tbAusgabetextBox.Text = ausgabe;
                textBoxByTagName.Text = "";
            }
        }

        private void buttonroot_Click(object sender, EventArgs e)
        {
            //string ausgabe = "Das Wurzelelment dieses dokument läutet: "+newLine + xmlDoc.DocumentElement.OuterXml;
            kontextNode = xmlDoc.DocumentElement;

            tbAusgabetextBox.Text = AusgabeString(kontextNode);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonChild_Click(object sender, EventArgs e)
        {
            XmlElement element = xmlDoc.CreateElement(tbEingabe.Text);
            try
            {
                kontextNode = kontextNode.AppendChild(element);
                tbAusgabetextBox.Text = AusgabeString(kontextNode);
                StatusLabel.Text = "Kind-Element zu \"" + kontextNode.Name + "\"eingefügt";

            }
            catch(Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }
            
        }

        private void buttonBefore_Click(object sender, EventArgs e)
        {
            XmlElement element = xmlDoc.CreateElement(tbEingabe.Text);
            try
            {
                kontextNode = kontextNode.ParentNode.InsertBefore(element, kontextNode);
                tbAusgabetextBox.Text = AusgabeString(kontextNode);
                StatusLabel.Text = "Element vor \"" + kontextNode.Name + "\"eingefügt";

            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }

        }

        private void buttonAfter_Click(object sender, EventArgs e)
        {
            XmlElement element = xmlDoc.CreateElement(tbEingabe.Text);
            try
            {
                kontextNode = kontextNode.ParentNode.InsertAfter(element, kontextNode);
                tbAusgabetextBox.Text = AusgabeString(kontextNode);
                StatusLabel.Text = "Element nach \"" + kontextNode.Name + "\"eingefügt";

            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }

        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            XmlText textnode = xmlDoc.CreateTextNode(tbEingabe.Text);
            try
            {
                kontextNode.AppendChild(textnode);
                StatusLabel.Text = "Text zu \"" + kontextNode.Name + "\"hinzufügt";

            }
            catch(Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }
        }

        private void buttonCData_Click(object sender, EventArgs e)
        {
            XmlCDataSection cdata = xmlDoc.CreateCDataSection(tbEingabe.Text);
            try
            {
                kontextNode.AppendChild(cdata);
                StatusLabel.Text = "CData zu \"" + kontextNode.Name + "\"hinzufügt";
            }
            catch(Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }
        }

        private void buttonErsetzen_Click(object sender, EventArgs e)
        {
            if (kontextNode.FirstChild.NodeType == XmlNodeType.CDATA)
            {

                XmlCDataSection cdata = xmlDoc.CreateCDataSection(tbEingabe.Text);
                try
                {
                    kontextNode.ReplaceChild(cdata, kontextNode.FirstChild);
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = ex.GetType() + ex.Message;
                }
            }
            else
            {
                XmlText text = xmlDoc.CreateTextNode(tbEingabe.Text);
                try
                {
                    kontextNode.ReplaceChild(text, kontextNode.FirstChild);

                }
                catch (Exception ex)
                {
                    StatusLabel.Text = ex.GetType() + ex.Message;
                }
            }
            
            
        }

        private void buttonAttribut_Click(object sender, EventArgs e)
        {
            XmlAttribute newatt = xmlDoc.CreateAttribute(textBoxName.Text);
            newatt.Value = textBoxValue.Text;
            try
            {
                ((XmlElement)kontextNode).SetAttributeNode(newatt);
                tbAusgabetextBox.Text = "Attribut \"" + textBoxName.Text + "=\"" + textBoxValue.Text + "\"für \"" + kontextNode.Name + "\"gesetzt";

             
            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.GetType() + ex.Message;
            }


        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (name == "")
            {
                StatusLabel.Text = "Bitte Geben Sie Name ein!";
            }
            else
            {
                if (((XmlElement)kontextNode).HasAttributes)
                {
                    try
                    {
                        ((XmlElement)kontextNode).RemoveAttribute(name);
                        StatusLabel.Text = "Attribut \"" + textBoxName.Text + "=\"" + "\"für \"" + kontextNode.Name + "\"entfernt.";
                    }
                    catch (Exception ex)
                    {
                        StatusLabel.Text = ex.GetType() + ex.Message;
                    }
                }
                
            }
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            

            string path = textBoxPath.Text;
            textBoxPath.Text= "";
            XmlUrlResolver resolver = new XmlUrlResolver();
            resolver.Credentials = System.Net.CredentialCache.DefaultCredentials;
            xmlDoc.XmlResolver = resolver;

            try
            {
                xmlDoc.Load(path);//Durch die Load Methode wird eine XML-Datei geladen. Die XML-Datei liegt im Verzeichnis"Debug".
                kontextNode = xmlDoc;//kontextNode wird auf das Dokument initialisiert.
                tbAusgabetextBox.Text = AusgabeString(kontextNode);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}:{1}", ex.GetType(), ex.Message);
                StatusLabel.Text = ex.GetType().ToString();
            }

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openpathdialog = new OpenFileDialog();
            openpathdialog.InitialDirectory = @".";
            openpathdialog.Filter= "XML-Datei(*.xml,*.xsd)|*.xml;*.xsd|Alle Dateien(*.*)|*.*";
            if(openpathdialog.ShowDialog()==DialogResult.OK)
            {
                textBoxPath.Text = openpathdialog.FileName;

            }
            else
            {
                StatusLabel.Text = "DialogOpen wird abgebrochen!";
            }
          
        }
    }
}
