using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lektion2_2
{
    class Person
    {
        public string name { get; set; }
        public string vorname { get; set; }
        public override string ToString()
        {
            return "Person{ name=\""+name+"\",vorname = \""+vorname+"\"}";
        }
    }
    class Konto
    {
        public int kontonummer { get; set; }
        public int blz
        {
            get;
            set;
        }
        public override string ToString()
        {
            return "Konto{ kontonummer=" + kontonummer + ",blz = " + blz + "}";
        }
    }
    class Lernheft
    {
        public string bezeichner { get; set; }
        public string title { get; set; }

    }
    class urlaubsreise
    {
        public string land { get; set; }
        public string hotel
        {
            get;
            set;
        }
    }
    class Program
    {
        Hashtable bankleitzahlen = new Hashtable();
        public  Hashtable StoreBankleitzahlen(string bankname)
        {

            
            bankleitzahlen.Add(bankname.GetHashCode(), bankname);
            return bankleitzahlen;

        }
        public static void ArrayListBuntGemischt()
        {
            ArrayList list1 = new ArrayList();
            list1.Add(new Person {name="iuhrf",vorname="jfiejf" });
            list1.Add(new Konto {kontonummer=7389,blz=378 });
            //for (int i = 0; i < list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //foreach (object i in list1)
            //{
            //    Console.WriteLine(i);
            //}
            IEnumerator enumerator = list1.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
        public  void PrintBankleitzahl()
        {
            foreach(DictionaryEntry d in bankleitzahlen)
            {
                Console.WriteLine("{0}:{1}", d.Key.ToString(),d.Value.ToString());
            };

          
        }
        public static void ListTypisiert()
        {
            List<Person> list2 = new List<Person> {};
            list2.Add(new Person { name = "a", vorname = "b" });
            //list2.Add(new Konto {blz="ji",kontonummer=213});
            foreach(Person j in list2)
            {
                Console.WriteLine(j.name);
            }
        }
        static void Main(string[] args)
        {
            //ArrayListBuntGemischt();

            //ListTypisiert();
            Program test = new Program();
            test.StoreBankleitzahlen("postbank");
            test.PrintBankleitzahl();
            // chris : 
            //var listle = new List<Person>();
            //listle.Add(new Person() {name = "Christian Kahr", vorname = "Christian" });

            //Console.WriteLine(listle[0].vorname);
            Console.Read();

        }
    }
}
