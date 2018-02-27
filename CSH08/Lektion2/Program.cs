using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Lektion2
{
    class DocumentHandling
    {
        public XmlDocument CreatDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();//Ein XMLdokument-objekt wird in der regel mit dem parameterlosen Konstruktor erstellt.
            //xmlDoc.LoadXml("<kartei><karte sachgebiet=\"XML\">" + "<stichwort>CDATA</stichwort>" + "</karte></kartei>");
            //xmlDoc.LoadXml("<person paNr='4007541799'><name>müller</name><vorname>David</vorname></person>");
            //Die Methode"LoadXml" laedt XML-Daten direkt aus einer Zeichenkette.
            //XmlElement xmlelement= xmlDoc.GetElementById("4007541799");
            xmlDoc.Load("Kartei.xml");
            return xmlDoc;
        }
        public XmlDocument ExtendDocument(XmlDocument xmlDoc)
        {
            XmlElement element = xmlDoc.CreateElement("karte");//Die Methode"CreatElement" wird der Name des gewünschten Elements als Parameter angegeben.
            XmlText text = xmlDoc.CreateTextNode("CDATA");//Die Methode wird der gewünschten Text als Parameter übergeben.
            /*XmlNode aktnode = xmlDoc.DocumentElement.FirstChild.AppendChild(element);*///Die Eigenschaft"DocumentElement" ist eine Konotenreferenz,sie gibt das wurzelement des Dokuments zurück.
            //FirstChild Eigenschaft gibt das kind des wurzelments zurück
            //AppendChild Methode fügt neuer Knoten ans  Ende der Liste der untergeordneten Knoten.
            XmlElement elemnet1 = xmlDoc.CreateElement("stichwort");
            XmlNode aktnode = xmlDoc.DocumentElement.AppendChild(element);
            
            aktnode.AppendChild(elemnet1);
            aktnode.FirstChild.AppendChild(text);

            return xmlDoc;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            DocumentHandling obj = new DocumentHandling();
            XmlDocument xmlDoc = obj.CreatDocument();
            

            Console.WriteLine("Das XML-Dokument:");
            xmlDoc.Save(Console.Out);//Die Save Methode arbeitet ähnlich der Load-Methode und kann mit einem string,einem stream,oder einem Writer-Objekt als parameter aufgerufen werden.
            //Das Out-Objekt ist ein solches Writer-Objekt,das in die Konsole schreibt.

            Console.WriteLine(xmlDoc);
            //Console.ReadLine();

            obj.ExtendDocument(xmlDoc);
            Console.WriteLine("Das ergaenzte XML-Dokument:");
            xmlDoc.Save(Console.Out);
            
            Console.WriteLine();
            XmlNodeList list = xmlDoc.GetElementsByTagName("autor");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
            }
            Console.ReadLine();
        }
    }
}
