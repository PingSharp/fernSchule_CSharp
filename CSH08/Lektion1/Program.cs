using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Lektion5_1;
using Lektion5;





namespace Lektion1
{
    class XmlVerarbeiten
    {
        XmlReader reader;
        XmlWriter writer;
        public XmlVerarbeiten(string url)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            reader = XmlReader.Create(url, settings);
            writer = new XmlTextWriter("Karteikasten1.xml", new UTF8Encoding());
            //reader = new XmlTextReader(url);
        }
        public void Lesen()
        {
            try
            {
                while (reader.Read())
                {
                    //if(reader.NodeType == XmlNodeType.Whitespace)
                    //{
                    //    Console.Write(reader.NodeType + ":");
                    //    for(int i = 0; i < reader.Value.Length;i++ )
                    //    {
                    //        int wsp = Convert.ToInt16(reader.Value[i]);
                    //        Console.Write("" + wsp);
                    //    }
                    //    Console.Write("\n");
                    //}
                    
                    
                        Console.WriteLine(reader.NodeType);
                    
                    //Console.WriteLine(reader.NodeType);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType() + ":" + ex.Message);
            }
        }
        public void Ausgabe()
        {
            try
            {
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.XmlDeclaration:
                            Console.Write("<?xml {0}?>", reader.Value);
                            break;
                        case XmlNodeType.Comment:
                            Console.Write("<!--{0}-->", reader.Value);
                            break;
                        case XmlNodeType.DocumentType:
                            Console.Write("<!DOCTYPE kartei[{0}]>", reader.Value);
                            break;
                        case XmlNodeType.Element:
                            Console.Write("<{0}", reader.Name);
                            if (reader.HasAttributes == true)
                            {

                                for (int i = 0; i < reader.AttributeCount; i++)
                                {
                                    reader.MoveToAttribute(i);
                                    Console.Write(" "+ reader.Name +"="+'"'+reader.Value+'"'
                                        );
                                }
                            }
                            Console.Write(">");
                            break;

                        case XmlNodeType.EndElement:
                            Console.Write("</{0}>", reader.Name);
                            break;
                        case XmlNodeType.Text:
                            Console.Write(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            Console.Write("<![CDATA[{0}]]>", reader.Value);
                            break;
                        case XmlNodeType.EntityReference:
                            Console.Write(reader.Value);
                            break;
                        case XmlNodeType.Whitespace:
                            Console.Write(reader.Value);
                            break;
                    }
                     
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
        }
        public void Eingabe()
        {
            try
            {
                while (reader.Read())
                {

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.XmlDeclaration:
                            writer.WriteStartDocument();
                            break;
                        case XmlNodeType.Comment:
                           writer.WriteComment(reader.Value);
                            break;
                        case XmlNodeType.DocumentType:
                            writer.WriteDocType("kartei", null, null, reader.Value);
                            break;
                        case XmlNodeType.Element:
                           writer.WriteStartElement(reader.Name);
                            if (reader.HasAttributes == true)
                            {

                                for (int i = 0; i < reader.AttributeCount; i++)
                                {
                                    reader.MoveToAttribute(i);
                                    writer.WriteAttributeString(reader.Name,reader.Value);
                                }
                            }
                           
                            break;

                        case XmlNodeType.EndElement:
                            writer.WriteEndElement();                               
                            break;
                        case XmlNodeType.Text:
                            writer.WriteString(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            writer.WriteCData(reader.Value);
                            break;
                        case XmlNodeType.EntityReference:
                            writer.WriteEntityRef(reader.Name);
                            break;
                        case XmlNodeType.Whitespace:
                            writer.WriteWhitespace(reader.Value);
                            break;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ":" + ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            XmlVerarbeiten xml = new XmlVerarbeiten(@"C:\Users\Kahr_Zang\source\repos\CSH08\Lektion1\Kartei.xml");
            xml.Eingabe();
            //Console.WriteLine(KommentarTests.Programmschritt);
            //KommentarTests.Main();
            //KommentarTests obj = new KommentarTests();
            //obj.Methode();

            //xml.Lesen();
            xml.Ausgabe();
            Console.ReadLine();
        }
    }
}
