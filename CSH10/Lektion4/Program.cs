using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Lektion4
{
    class Content
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public Content()
        {

        }
        public Content(string text,string type)
        {
            this.Text = text;
            this.Type = type;
        }
    }
    class Card
    {
        public string Subject { get; set; }
        public IEnumerable<Content> Contents { get; set; }
        public IEnumerable<string> Keywords { get; set; }
        public string Abstact { get; set; }
        public string Source { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Date { get; set; }
        public Card()
        {

        }
        public Card(string subject,IEnumerable<Content>contents,IEnumerable<string>keywords,string abstact,string source,DateTime createdate,DateTime date)
        {
            this.Subject = subject;
            this.Contents = contents;
            this.Keywords = keywords;
            this.Abstact = abstact;
            this.Source = source;
            this.CreateDate = createdate;
            this.Date = date;
        }
    }
    class Program
    {
        void Achsen(int fall)
        {
            XElement root = XElement.Load(@"C:\Users\Kahr_Zang\source\repos\CSH10\Lektion4\Box.xml");
            
            switch(fall)
            {
                case 1:
                    var r1 = root.Nodes();
                    Console.WriteLine("*Die Nodes *");
                    foreach(var r in r1)
                    {
                        Console.WriteLine(r);
                    }
                    break;
                case 2:
                    var r2 = root.Descendants();
                    Console.WriteLine("*Die Descendants*");
                    foreach(var r in r2)
                    {
                        Console.WriteLine(r);
                    }
                    break;
                case 3:
                    var r3 = root.DescendantNodes();
                    Console.WriteLine("*Die DescendantNodes*");
                    foreach(var r in r3)
                    {
                        Console.WriteLine(r);                    }
                    break;
                case 7:
                    //var r7 = from r in root.Descendants("content")
                    //         where r.Attribute("type").Value.Equals("text")
                    //         select r;
                    //foreach(var r in r7)
                    //{
                    //    Console.WriteLine(r);
                    //}
                    var r7 = root.Descendants("content").Where(e => e.Attribute("type").Value.Equals("text"));
                    foreach(var r in r7)
                    {
                        Console.WriteLine(r);
                    }
                    break;
            }
            
        }
       static XDocument NewDocument(XElement element)
        {
            XNamespace xNamespace = "http://www.linq-to-xml.de";
            XName xName = xNamespace + "box";
            
            XDocument document =new XDocument(new XDeclaration("1.0","utf-8","yes"), new XElement(xName, element));
            var result = from e in document.Elements() select e;
            //string savename = DateTime.Now.ToString("ss.mm.hh.dd.MM.yyyy.") + "newbox"+".xml";
            //document.Save(savename);
            //Console.WriteLine(File.ReadAllText(savename));
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
            return document;

        }
        XElement NewCard(string subject,string keyword,string @abstact,string content,string type,string source)
        {
            XElement xElement = new XElement("card", new XAttribute("subject", subject),
                new XElement("keyword", keyword),
                new XElement("abstract", abstact),
                new XElement("content", new XAttribute("type",type), content),
                new XElement("source",source));
            return xElement;
        }
       static XElement NewCard(string subject,XElement[]keywords,string @abstract,XElement[]contents,string source,DateTime dateTime,DateTime date)
        {
            XElement xElement = new XElement("card", new XAttribute("subject", subject),
                keywords,
               new XElement("abstract", @abstract),
                contents,
               new XElement("source", source),
              new XElement("createDate", dateTime.ToString("dd.MM.yyyy"))
                ,new XElement( "date",date.ToString("dd.MM.yyyy")));
            return xElement;
        }
        void AddCardElement(XElement card,XElement toAdd)
        {
            if(!toAdd.IsEmpty&&toAdd.Name == "content")
            {
                XElement kontextelment = card.Elements("content").Last();
                kontextelment.AddAfterSelf(toAdd);
            }
            else if (!toAdd.IsEmpty&&toAdd.Name=="keyword")
            {
                XElement kontextelement = card.Elements("keyword").Last();
                kontextelement.AddAfterSelf(toAdd);
            }
        }
        IEnumerable<Card> CreateCardObjects()
        {
            List<Card> cardlist = new List<Card> { };
            List<Content> list = new List<Content> { };
            List<string> keywords = new List<string> { };
            XElement root = XElement.Load(@"C:\Users\Kahr_Zang\source\repos\CSH10\Lektion4\Box.xml");
            //var subject =from c in  root.Descendants("card") 
            var result = root.Elements();
            foreach(var r in result)
            {
               var s =  r.Elements("content");
                foreach(var c in s)
                {
                    Content content = new Content { Text = c.Value, Type = c.Attribute("type").Value };
                  
                    list.Add(content);
                }

                var keywordslist = r.Elements("keyword");
               foreach(var k in keywordslist)
                {
                    keywords.Add(k.Value);
                }
               
                Card card = new Card {Subject=r.Attribute("subject").Value,Contents=list,Keywords =keywords,
                    Abstact =r.Element("abstact").Value,Source=r.Element("source").Value,
                    CreateDate =Convert.ToDateTime(r.Element("createDate").Value),Date=Convert.ToDateTime(r.Element("date").Value) };
               
                cardlist.Add(card);
                
            }
            return cardlist;
            
        }
        static void Main(string[] args)
        {
            //Program test = new Program();
            //XElement element = new XElement("card", new XElement("keyword", "Funktionale Konstruktion"),
            //    new XElement("abstract", "Zusammenfassung"),
            //    new XElement("content", "Konstruktion im Code wie im XML-Dokument"),
            //    new XElement("createDate", DateTime.Now.ToString("dd.mm.yyyy")));
            //XElement element = test.NewCard("XML", "DTD", "Wie erstellt man eine DTD?", "Erst Struktur planen,dann umsetzen.", "title", "Web");
            //test.AddCardElement(element, new XElement("content", "nicht reicht eine Anleitung aus.", new XAttribute("type", "title")));
            //XDocument newdoc =  test.NewElement(element);
            XElement[] keywords={ new XElement("keyword","DTD"),new XElement("keyword","Wikipedia") };
            XElement[] contents = { new XElement("content", "Erst Struktur planen,dann umsetzen.",new XAttribute("type","titel")),
            new XElement("content","Nicht immer reicht eine Anleitung aus,die in Wikipedia stehr:",new XAttribute("type","text")),
            new XElement("content","Eine Dokumenttypdefinition...",new XAttribute("type","quote")),
            new XElement("content","http://de.wikipedia.org/wiki/Dokumenttypdefinition",new XAttribute("type","url"))};
            XElement element = NewCard("XML", keywords, "Wie erstellt man eine DTD", contents, "Web",DateTime.Now,DateTime.Now);
            XDocument newdoc =NewDocument(element);

            //test.Achsen(7);
            //test.Achsen(2);
            //test.Achsen(3);
            //IEnumerable<Card> card = test.CreateCardObjects();
            //foreach (Card c in card)
            //{
            //    Console.WriteLine(c.Subject);
            //    Console.WriteLine(c.Abstact);
            //    Console.WriteLine(c.Source);
            //    Console.WriteLine(c.CreateDate);
            //    Console.WriteLine(c.Date);
            //    foreach(Content co in c.Contents)
            //    {
            //        Console.WriteLine(co.Type);
            //        Console.WriteLine(co.Text);
            //        foreach (string s in c.Keywords)
            //        {
            //            Console.WriteLine(s);
            //        }
            //    }

            //}
            Console.Read();
        }
    }
}
