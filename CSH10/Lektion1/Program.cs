using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Lektion1
{
    class Program
    {
       
        void Message_2(Action<string> action)
        {
            action("nachricht");
        }
        void Message_1(Action action)
        {
            action();
        }
        void message()
        {
            Console.WriteLine("Nachricht von der parameterlosen Message-Methode");
        }
        void Message(string nachricht)
        {
            Console.WriteLine(nachricht);
        }
        delegate void MessageDelegate(string nachricht);
        void MessagePerDelegate(string message)
        {
            MessageDelegate newsdelegate = new MessageDelegate(this.Message);
            newsdelegate(message);
            
        }
        OdbcConnection odbcConnection;
        List<string> ortlist;
        OdbcDataReader AccessDB()
        {
            string connectionstring = "DSN=LocalMySQL56";
            odbcConnection = new OdbcConnection(connectionstring);
            odbcConnection.Open();
            string cmd = "SELECT DISTINCT(ort) FROM personen";
            OdbcCommand odbcCommand = new OdbcCommand(cmd, odbcConnection);
            return odbcCommand.ExecuteReader();

        }
        void ReadOrt()
        {
            OdbcDataReader reader = AccessDB();
            ortlist = new List<string> { };
            while (reader.Read())
            {
                ortlist.Add(reader.GetString(0));
            }
            odbcConnection.Close();
           
            
            
        }
        void minlinq()
        {
            var result = from o in ortlist where o.Length == ortlist.Min(name => name.Length) select o;
            foreach (string s in result)
            {
                Console.WriteLine("{0} hat die Länge {1} (linq)", s, s.Length);
            }
        }
        void Min(Func<string,int> func)
        {
            List<int> ortlength = new List<int> { };
           foreach(string s in ortlist)
            {
                ortlength.Add(func(s));
                
            }
            int retunrnint =  ortlength.Min();
            foreach(string s in ortlist)
            {
                if(s.Length == retunrnint)
                {
                    Console.WriteLine("{0} hat die Länge {1} ",s,retunrnint);
                }
            }
           
            
        }
        List<string> CityFilter_1(Func<string,bool> filter)
        {
            List<string> returnlist = new List<string> { };
            if (ortlist != null)
            {
                foreach (string city in ortlist)
                {
                    if (filter(city))
                    {
                        returnlist.Add(city);
                    }
                }
            }
            else
                Console.WriteLine("Fehler:Die cityliste wurde nicht erzeugt!");
            foreach(string s in returnlist)
            {
                Console.WriteLine(s);
            }
            return returnlist;
        }
       
        List<string> CityFilter(Predicate<string> filter )
        {
            List<string> returnlist = new List<string> { };
            if (ortlist != null)
            {
                ortlist.Min(name => name.Length);
                foreach (string city in ortlist)
                {
                    if (filter(city))
                        returnlist.Add(city);
                }
            }
            else
                Console.WriteLine("FEHLER:Die Cityliste wurde nicht erzeugt.");

            foreach(string s in returnlist)
            {
                Console.WriteLine(s);
            }
            return returnlist;
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.ReadOrt();
            IEnumerable<string> result = from o in test.ortlist where o.Length == test.ortlist.Min(name => name.Length) select o;
            foreach(string s in result)
            {
                Console.WriteLine("{0} hat die länge {1} (linq in main )", s, s.Length);
            }
            
            test.Min(s => s.Length);
            test.minlinq();
            
            //Console.WriteLine("Bitte Geben Sie (von A bis Z) ein!");

            //string eingabe = Console.ReadLine().ToUpper();
            //test.CityFilter_1(s => s.StartsWith(eingabe));

            //Predicate<string> filter = a => a.StartsWith(eingabe); 
            //Predicate<string> filterB = delegate (string s)
            //{
            //    return s.StartsWith("B");
            //};

            //test.CityFilter(s => s.StartsWith(eingabe));

            //test.Message_2(a => { Console.WriteLine(a); });
            //int @case = 3;
            //switch (@case)
            //{
            //    case 1:
            //        test.MessagePerDelegate("Konsoleausgabe über MessageDelegate!");
            //        break;
            //    case 2:
            //        MessageDelegate newsdelegate = delegate (string s) { Console.WriteLine(s); };
            //        newsdelegate("Konsoleausgabe über anonyme Methode!");
            //        break;
            //    case 3:
            //        //Action action = test.message;
            //        test.Message_1(delegate () { Console.WriteLine("Nachricht von der anonymen Methode im Action-Delegate-Objekt" +
            //            ""); });
            //        break;
            //}

            Console.Read();
        }
    }
}
