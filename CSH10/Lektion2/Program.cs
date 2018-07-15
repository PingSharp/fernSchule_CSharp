using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Lektion2
{
    //class person
    //{
    //    public string ort { get; set; }
    //}
    class Program
    {

        OdbcConnection odbcConnection;
        List<string> citylist;
        OdbcDataReader AccessDB(string sqlcmd)
        {
            string connectstring = "DSN=LocalMySQL56";
            odbcConnection = new OdbcConnection(connectstring);
            odbcConnection.Open();
            OdbcCommand odbcCommand = new OdbcCommand(sqlcmd, odbcConnection);
            return odbcCommand.ExecuteReader();

        }
        
        void ReadPersonen()
        {
            string sqlcmd = "SELECT DISTINCT(ort) FROM personen ORDER BY ort";
            citylist = new List<string> { };
            OdbcDataReader reader = AccessDB(sqlcmd);
            while(reader.Read())
            {
                citylist.Add(reader.GetString(0));
            }
            //foreach (string s in citylist)
            //{
            //    Console.WriteLine(s);
            //}
        }
        bool CityNameMitLeerzeichen(string city)
        { 
            bool IsWhiteSpace=false;
           for(int i = 0;i<city.Length;i++)
            {
                if(char.IsWhiteSpace(city, i)==true)
                { IsWhiteSpace = true; }
                
                

            }
           
            return IsWhiteSpace;

           
        }
        void CityNameWithWhitespace()
        {
            var result = citylist.Where(c => c.Contains(" "));
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
        void FiveShortestCityNames()
        {
            //var result = citylist.OrderBy(c=>c.Length).ElementAt(0);
            //foreach(string s in result)
            //{
            //    Console.WriteLine(s);
            //}
            
            for (int i = 0; i < 5; i++)
            {
                var result = citylist.OrderBy(c => c.Length).ElementAt(i);
                //foreach (char s in result)
                //{
                //    Console.WriteLine(s);
                //}
            }
            

        }
        void OrderCityList(string Buchstabe)
        {

            //var orderedcitylist = from c in citylist
            //                      where c.StartsWith(Buchstabe.ToUpper())
            //                      orderby c.Length
            //                      select c;
            var orderedcitylist = citylist.Where(c => c.StartsWith(Buchstabe.ToUpper()))
                .OrderBy(c => c.Length);
            //.Select(c => c);
            var orderedcitylist3 = citylist.OrderBy(c => c.Length).Select(c=>c.StartsWith(Buchstabe.ToUpper())?c:null);
            var orderedcitylist1 = citylist.OrderBy(c => c)
                .ThenBy(c => c.Length);
            var orderedcitylist2 = citylist.OrderBy(c => c.Substring(0,1)).ThenBy(c=>c.Length);
            foreach(string s in orderedcitylist3)
            {
                if (s != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            //string[] fruits = { "apple", "banana", "mango", "orange",
            //          "passionfruit", "grape" };

            //IEnumerable<string> query =
            //    fruits.TakeWhile(fruit => String.Compare("orange", fruit, true) != 0);

            //foreach (string fruit in query)
            //{
            //    Console.WriteLine(fruit);
            //}
           
            test.ReadPersonen();
            test.CityNameWithWhitespace();
          //  List<string> list1 = new List<string> { "hello chris","hello world", "apple","hello ping" };
          //IEnumerable<string> list =  list1.TakeWhile(c => c.Contains(" ")).ToArray();
          //  foreach(string s in list)
          //  {
          //      Console.WriteLine(s);
          //  }
            //test.CityNameMitLeerzeichen("city");
            //test.FiveShortestCityNames();
            //test.OrderCityList("n");
            //int[] ungerade = { 1, 3, 5, 7, 9,10 };
            //int[] gerade = { 2, 4, 6, 8, 10 };
            //var result = ungerade.Concat<int>(gerade);
            //var result1 = ungerade.Union<int>(gerade);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //foreach(int i in result1)
            //{
            //    Console.WriteLine(i);
            //}
            //var result = gerade.Except<int>(ungerade);
            //var result1 = gerade.Intersect<int>(ungerade);
            //var result2 = gerade.Union<int>(ungerade);
            //foreach(int i in result2)
            //{
            //    Console.WriteLine(i);
            //}
            //int[] ints = { 4, 8, 8, 3, 9, 0, 7, 8, 2 };
            
            //foreach(int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
           
            //int numEven = ints.Aggregate(0, (total, next) =>
            //                                    next % 2 == 0 ? total + 1 : total);

            //Console.WriteLine("The number of even integers is: {0}", numEven);

            //object[] objects = new object[] {"string1",1,2,3,"string2" };
            //var stringresult = objects.OfType<string>();
            //var intresult = objects.OfType<int>();
            //foreach(string s in stringresult)
            //{
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine();
            //foreach(int i in intresult)
            //{
            //    Console.WriteLine(i);
            //}
            //int @case = 1;
            //switch (@case)
            //   {
            //    case 1:
            //     IEnumerator<string> citylist1 = test.citylist.GetEnumerator();
            //        IEnumerable citylist2 = (IEnumerable) citylist1; 
            //        foreach (var item in citylist2)
            //        {

            //        }
            //        //while(citylist1.MoveNext())
            //        //{
            //        //    Console.WriteLine(citylist1.Current);
            //        //}

            //        break;

            //}
            Console.Read();
        }
    }
}
