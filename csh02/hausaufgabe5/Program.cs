using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hausaufgabe5
{
    class aufgabe
    {
        //public int BitMusterPruefen(int zahl,int operand)
        //{

        //}
        public void check(ArrayList list,ArrayList list1)
        {
          bool ergebnis = list.Contains(list1[0]);
            Console.WriteLine(" {0} ",ergebnis);
        }
        public ArrayList Hochzahl(int nummer)
        {
            ArrayList list = new ArrayList();
            ArrayList list3 = new ArrayList();
            while (nummer > 0)
            {

                if (nummer % 2 == 0)
                {
                    nummer = nummer / 2;
                    list.Add(0);
                }
                else
                {
                    nummer = nummer / 2;
                    list.Add(1);
                    int num = list.Count - 1;

                    list3.Add(num);

                }
            }                     
            Console.WriteLine("");
            foreach (object h in list3)
            {
                Console.Write(" {0} ", h);
            }
            return list3;

        }
        public void dez2bin(int zahl)
        {
            ArrayList list1 = new ArrayList();
            ArrayList list3 = new ArrayList();
            while (zahl > 0)
            {
                
                if (zahl % 2 == 0)
                {
                    zahl = zahl / 2;
                    list1.Add(0);
                }
                else
                {
                    zahl = zahl / 2;
                    list1.Add(1);
                    int num = list1.Count - 1;
                   
                    list3.Add(num);
             
                }
            }
            list1.Reverse();
            foreach (object listnum in list1)
            {
                Console.Write("{0}", listnum);
                
            }
            Console.WriteLine("");
            
            

        }
    }
    class Program
    {
       
        
        static void Main(string[] args)
        {
            aufgabe af = new aufgabe();
            int zahl = 1234;
            
            int operand = 1024;
            Console.WriteLine("Binaer Zahl von {0} ist :",zahl);
            af.dez2bin(zahl);
            Console.WriteLine("");
            af.Hochzahl(zahl);
            Console.WriteLine("");
            Console.WriteLine("Binaer Zahl von {0} ist :",operand);
            af.dez2bin(operand);
            Console.WriteLine("");
            af.Hochzahl(operand);
            Console.WriteLine("");
            af.check(af.Hochzahl(zahl),af.Hochzahl(operand));
            
            Console.ReadLine();
        }
    }
}
