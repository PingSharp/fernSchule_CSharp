using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace ESA
{
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
        public double price { get; set; }
        
        

    }
    public static class ExtensionMethods
    {
        public static IEnumerator<T> GetEnumerator<T>(this IEnumerable<T> enumerator)
        {
            Console.WriteLine("Methode GetEnumerator wird aufgerufen!");
            return enumerator.GetEnumerator();
        }
    }
    
    
    class Program 
    {
       
        OdbcConnection odbcConnection;
        List<Person> personlist = new List<Person> { };
        List<Article> articlepreislist = new List<Article> { };
        OdbcDataReader AccessDB(string cmd)
        {
            string ConnectionString = "Dsn=LocalMySQL56;Driver=MySQL ODBC 3.51 Driver;";
            odbcConnection = new OdbcConnection(ConnectionString);
            odbcConnection.Open();
            
            OdbcCommand odbcCommand = new OdbcCommand(cmd, odbcConnection);
            return odbcCommand.ExecuteReader();
           
        }
        void ReadPersonen()
        {
            OdbcDataReader reader =  AccessDB("SELECT id,vorname,nachname,ort,plz FROM personen");
            while(reader.Read())
            {
                personlist.Add(new Person { id = (uint)reader.GetInt32(0),vorname=reader.GetString(1),nachname=reader.GetString(2),ort=reader.GetString(3),plz=(uint)reader.GetInt32(4) });
            }
            odbcConnection.Close();


        }
        void ReadArticlePreis()
        {
            OdbcDataReader reader = AccessDB("SELECT preis FROM artikel");
            while(reader.Read())
            {
                articlepreislist.Add(new Article { price = reader.GetDouble(0) });

            }
            odbcConnection.Close();
            
        }
        void MostExpensiveArticle()
        {
            var result = articlepreislist.Max(a => a.price);
            Console.WriteLine("Der teuerste Artikel kostet {0}$", result);
        }
        void PrintPersonJohnInBurlington()
        {
            var result = from p in personlist where p.vorname == "John" && p.ort == "Burlington" orderby p.nachname select new { p.vorname, p.nachname, p.ort };
            foreach(var i in result)
            {
                Console.WriteLine("{0}  {1} in {2}", i.vorname, i.nachname, i.ort);
            }
        }
        void PrintNachnameCaraOrLull()
        {
            var result = from p in personlist where p.nachname == "Cara" || p.nachname == "Lull" orderby p.nachname select new { p.vorname, p.nachname, p.ort };
            foreach(var i in result)
            {
                Console.WriteLine("{0} {1} in {2}", i.vorname, i.nachname, i.ort);
            }
        }
        void PrintOrt()
        {
            var result = from p in personlist where p.ort == "Belmont" || p.ort == "Powell" orderby p.ort select new { p.vorname,p.nachname,p.ort };
            //var result1 = from p in personlist where p.ort.Contains("Belmont") || p.ort.Contains("Powell") orderby p.ort select new { p.vorname, p.nachname, p.ort };
            //IEnumerable<string> ortlist = from p in personlist where p.ort=="Belmont"||p.ort=="Powell" select p.ort;
            //var result2 = (from p in personlist from o in ortlist where p.ort == o || p.ort == o orderby p.ort select new { p.vorname, p.nachname, p.ort }).Distinct();
            foreach(var o in result)
            {
                Console.WriteLine("{0} {1} in {2}",o.vorname,o.nachname,o.ort);
            }
        }
        Dictionary<string, int> bankleitzahlendictionary = new Dictionary<string, int> { };
        void StoreBankleitzahlen()
        {
            if (bankleitzahlendictionary.Count == 0)
            {
                bankleitzahlendictionary.Add("Postbank Ffm", 50010060);
                bankleitzahlendictionary.Add("Deutsche Bank Ffm", 50070010);
                bankleitzahlendictionary.Add("Sparkasse Darmstadt", 50850150);

            }
            else
            {
                bankleitzahlendictionary.Clear();
                bankleitzahlendictionary.Add("Postbank Ffm", 50010060);
                bankleitzahlendictionary.Add("Deutsche Bank Ffm", 50070010);
                bankleitzahlendictionary.Add("Sparkasse Darmstadt", 50850150);
            }
        }
        void PrintBankleitzahlen()
        {
            //foreach (var item in bankleitzahlendictionary)
            //{
            //    Console.WriteLine("[{0}]-->[{1}]", item.Key, item.Value);
            //}
            IEnumerator enumerator=  bankleitzahlendictionary.Keys.GetEnumerator();
            IEnumerator enumerator1 = bankleitzahlendictionary.Values.GetEnumerator();

            var enum2 = bankleitzahlendictionary.GetEnumerator();
            
            while(enum2.MoveNext())
            {
                var puffer = enum2.Current;
                Console.WriteLine("[{0}]-->[{1}]", puffer.Key, puffer.Value);
            }

            while(enumerator.MoveNext() && enumerator1.MoveNext())
            {

                
                Console.WriteLine("[{0}]-->[{1}]",enumerator.Current,enumerator1.Current);
            }
        }
        void ESA5(string queriedCity)
        {


           
            var result = (from p in personlist from o in (from i in personlist
                                                          group i by i.ort into g
                                                          where g.Count() >= 3
                                                          select new { g.Key })
                          where p.ort == queriedCity && p.ort == o.Key
                          orderby p.nachname
                          select new { p.vorname, p.nachname, p.ort }).Distinct();
            int sum = result.Count();
            Console.WriteLine("{0} Personen wohnen in '{1}':", sum, queriedCity);
           
            foreach (var i in result)
            {
                Console.WriteLine("{0} {1} in {2}",i.vorname,i.nachname,i.ort);
            }
        }
        
        
        
        static void Main(string[] args)
        {
            //List<string> test = new List<string> {"ab","cd","ef" };
            //test.GetEnumerator<string>();
            Program test = new Program();
            test.ReadPersonen();
            //test.PrintPersonJohnInBurlington();
            //Console.WriteLine();
            //test.PrintNachnameCaraOrLull();
            //Console.WriteLine();
            //test.PrintOrt();
            //Console.WriteLine();
            //test.ReadArticlePreis();
            //test.MostExpensiveArticle();
            //Console.WriteLine();
            test.ESA5("Bedford");
            test.StoreBankleitzahlen();
            test.PrintBankleitzahlen();
            Console.Read();
          
        }
    }
}
