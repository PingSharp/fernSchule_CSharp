using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Lektion3
{
    class Employee
    {
        public Person person { get; set; }
        public uint personID;
        public UInt32 abtID { get; set; }
        public override string ToString()
        {
            string returnstring = person.vorname+"  "+person.nachname+",Abteilung :"+abtID;
            return returnstring;
        }
    }
    class Person
    {
        public uint id { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string ort { get; set; }
        public uint plz { get; set; }
    }
    class Article
    {
        public UInt32 id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public UInt32 menge { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                { price = value; }
                else
                {
                    throw new ArgumentException("Der Preis darf nicht negativ sein!");
                }
            }
        }
        public override string ToString()
        {
            return name + "(" + description + ")" + size + ":" + Price + "$";

        }

    }
    class Program
    {
        List<Employee> employeelist = new List<Employee> { };
        List<Person> personlist = new List<Person> { };
        List<Article> artikellist = new List<Article> { };
        OdbcConnection odbcConnection;
        OdbcDataReader AccessDb(string tabellename)
        {
            string ConnectionString = "Dsn=LocalMySQL56;Driver=MySQL ODBC 3.51 Driver;";
            odbcConnection = new OdbcConnection(ConnectionString);
            odbcConnection.Open();


            if (tabellename == "article")
            {
                //string sqlString = "SELECT name,beschreibung,groesse,preis FROM artikel";
                string sqlstring1 = "SELECT * FROM artikel";

                OdbcCommand cmd = new OdbcCommand(sqlstring1, odbcConnection);
                return cmd.ExecuteReader();
            }
            else if(tabellename =="person")
            {
                string sqlpersonstring = "SELECT id,vorname,nachname,ort,plz FROM personen";
                OdbcCommand cmd1 = new OdbcCommand(sqlpersonstring, odbcConnection);
                return cmd1.ExecuteReader();
            }
            else
            {
                string sqlemployee = "SELECT abtID,personID FROM angestellte";
                OdbcCommand cmd2 = new OdbcCommand(sqlemployee, odbcConnection);
                return cmd2.ExecuteReader();
            }
            //odbcConnection.Close();

            
            
        }
        public void ReadEmployees()
        {
            OdbcDataReader reader = this.AccessDb("angestellte");
            while(reader.Read())
            {
                
               Employee employee =  new Employee { abtID = (uint)reader.GetInt32(0), personID = (uint)reader.GetInt32(1) };
                if (personlist.Count == 0)
                {
                    ReadPersons();
                    IEnumerable<Person> angestellteperson = from p in personlist where employee.personID == p.id select p;

                    employee.person = angestellteperson.ElementAt(0);

                    employeelist.Add(employee);
                }
                else
                {
                    IEnumerable<Person> angestellteperson = from p in personlist where employee.personID == p.id select p;

                    employee.person = angestellteperson.ElementAt(0);

                    employeelist.Add(employee);

                }
                    
                
            }

            odbcConnection.Close();
            //foreach(Employee e in employeelist)
            //{
            //    Console.WriteLine(e);
            //}
        }
        public void ReadPersons()
        {
           
           
            OdbcDataReader reader1 = this.AccessDb("person");
            while(reader1.Read())
            {
                
                personlist.Add(new Person { id=(uint)reader1.GetInt32(0),
                    vorname =reader1.GetString(1),nachname=reader1.GetString(2),
                    ort =reader1.GetString(3),plz=(uint)reader1.GetInt32(4) });

            }
            odbcConnection.Close();
            //foreach(Person p in personlist )
            //{
            //    Console.WriteLine(p.id);
            //}
        }
        void NameEqualsTown()
        {
            ReadPersons();

            //var list1 = from p in personlist where p.nachname==p.ort select new {p.vorname,p.nachname,p.ort };
            //var list1 = from p in personlist let ort = p.ort where p.nachname == ort select new { p.vorname, p.nachname };
            var list2 = from p in personlist from o in personlist where p.nachname == o.ort group p by p.nachname into list select list.Distinct() ;

            //var list3 = list2.Distinct<>();
            foreach (var i in list2)
            {
               foreach (Person p in i)
                {
                    Console.WriteLine(p.nachname);
                }
            }
        }
        public void PrintSortedPersons()
        {
            string a = Environment.NewLine;
            var list = from p in personlist where p.ort.ToUpper().StartsWith("B") orderby p.ort,p.nachname group p by p.ort into orte select orte.Key;
            
            foreach(string key in list)
            {
                Console.WriteLine(key);

            }
            //foreach ( IGrouping<string,Person> items in list)
            //{
                
            //    Console.WriteLine("Ort:{0}",items.Key);
                
                
            //    foreach (Person subitem in items)
            //    {
            //        Console.WriteLine("nachname:{0},vorname:{1}",subitem.nachname,subitem.vorname);
            //    }
            //    Console.WriteLine(a);
            //}
        }
        public void CreateArticleList()
        {
            artikellist.Add(new Article { id = 300, name = " T-Shirt", description = "Tank Top", size = "Small", color = "weiss", menge = 9, Price = 19.99 });
            artikellist.Add(new Article { id = 301, name = " T-Shirt", description = "V-neck", size = "Medium", color = "orange", menge = 35, Price = 24.99 });
            artikellist.Add(new Article { id = 302, name = " T-Shirt", description = "Crew Neck", size = "universal", color = "grau", menge = 59, Price = 29.99 });
            artikellist.Add(new Article { id = 400, name = " Baseballmütze", description = "Baumwolle", size = "universal", color = "schwarz", menge = 79, Price = 9.8 });
            artikellist.Add(new Article { id = 401, name = " Baseballmütze", description = "Wollmütze", size = "universal", color = "weiss", menge = 9, Price = 10.9 });
            artikellist.Add(new Article { id = 500, name = " Mützenschirm", description = "Kunststoffschirm", size = "universal", color = "weiss", menge = 30, Price = 3.5 });
            artikellist.Add(new Article { id = 501, name = " Mützenschirm", description = "Stoffschirm", size = "universal", color = "grau", menge = 3, Price = 4.5 });
            artikellist.Add(new Article { id = 600, name = " Sweatshirt", description = "Kapuzenshirt", size = "Large", color = "grün", menge = 28, Price = 34.8 });
            artikellist.Add(new Article { id = 601, name = " Sweatshirt", description = "normal", size = "Large", color = "blau", menge = 32, Price = 24.8 });
            artikellist.Add(new Article { id = 700, name = " Hosen", description = "Baumwollhosen", size = "Medium", color = "grau", menge = 60, Price = 65.9 }); 

        }
        public string ReadArticles()
        {
            OdbcDataReader reader = this.AccessDb("article");
            StringBuilder newstring = new StringBuilder();
            while (reader.Read())
            {
               
                newstring.Append("artikellist.Add(new Article{ id= " + (uint)reader.GetInt32(0) +
                    ", name =\" " + reader.GetString(1)
                    + "\",description = \"" + reader.GetString(2) + "\",size = \""
                    + reader.GetString(3) + "\",color = \"" + reader.GetString(4) + "\", menge = "
                    + (uint)reader.GetInt32(5) + ", Price = " + reader.GetDouble(6) + "});");
                Console.WriteLine("artikellist.Add(new Article{ id= " + (uint)reader.GetInt32(0) +
                    ", name =\" " + reader.GetString(1)
                    + "\",description = \"" + reader.GetString(2) + "\",size = \""
                    + reader.GetString(3) + "\",color = \"" + reader.GetString(4) + "\", menge = "
                    + (uint)reader.GetInt32(5) + ", Price = " + reader.GetDouble(6) + "})");
                Console.WriteLine();
            }
            
            return newstring.ToString();
            

        }
        public void PrintArticleNames()
        {
         
            var articlenames = from a in artikellist where a.name.GetHashCode() > a.Price*a.id && a.name.Substring(0,1).CompareTo("K") < 0 select a;
            foreach (Article artikle in articlenames)
            {
                Console.WriteLine(artikle);
            }
            //foreach (string names in articlenames)
            //{
            //    Console.WriteLine(names);
            //}
        }
        public void PrintArticlePrices()
        {
            IEnumerable<double> articleprices = from a in artikellist select a.Price;
            foreach(double price in articleprices)
            {
                Console.WriteLine(price);
            }
        }
        public void PrintArticleNameSelection()
        {
            IEnumerable<string> result = from a in artikellist where a.name.Length > 10 select a.name;
            foreach(string names in result)
            {
                Console.WriteLine(names);
            }
        }
        public void PrintEmPloyees()
        {
            var result = from p in personlist join e in employeelist on p.id equals e.personID orderby p.nachname select new { p.vorname, p.nachname, e.abtID };
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
        string[] PrintEmployeesMethod =
        {
             "void PrintEmPloyees()",
        "{",
            "var result = from p in personlist join e in employeelist on p.id equals e.personID orderby p.nachname select new { p.vorname, p.nachname, e.abtID };",
            "foreach (var i in result)",
            "{",
                "Console.WriteLine(i);",
            "}"
        };
        string[] linqKeywords = { "from", "where", "orderby", "join", "let", "group", "select", "by", "in", "on", "equals" };
        public void PrintKeywords()
        {
            IEnumerable<string> keywords = from line in PrintEmployeesMethod
                           let words = line.Split(' ')
                           from word in words
                           from keyword in linqKeywords
                           where word == keyword
                           select word;
            Console.WriteLine("Alle LINQ-Schlüsselwörter in der Methode \"PrintEmployees()\":");
            foreach(string keyword in keywords)
            {
                Console.WriteLine(keyword);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Bitte Geben Sie eine Nummer ein:");
            //int @case =Convert.ToInt16( Console.ReadLine());
            //Program test = new Program();
            //test.CreateArticleList();
            //switch(@case)
            //{
            //    case 1:
            //        test.PrintArticleNames();
            //        break;
            //    case 2:
            //        test.PrintArticlePrices();
            //        break;
            //    case 3:
            //        test.PrintArticleNameSelection();
            //        break;
            //}
            Program test1 = new Program();
            //test1.ReadEmployees();
            //test1.PrintEmPloyees();
            //test1.PrintKeywords();
            //test1.PrintSortedPersons();
            test1.NameEqualsTown();

            Console.ReadLine();
        }
    }
}
