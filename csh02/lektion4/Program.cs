using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion4
{
    class Uebungen
    {
        public int Multiplizieren(int kaufpreis,int muenzen,int hoelzchen)
        {
            if (hoelzchen == 1)
            {
                return kaufpreis += muenzen;
            }
            else if (hoelzchen % 2 == 0)
            {
                return Multiplizieren(kaufpreis, muenzen << 1, hoelzchen >> 1);
            }
            else
            {
                kaufpreis += muenzen;
                return Multiplizieren(kaufpreis,muenzen << 1,hoelzchen >> 1);
            }
            
        }
        public void ForEach(string[]values)
        {
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }
        public void ForStattForEach(string[]values)
        {
            for (int i = 0;i < values.Length;i++)
            {
                Console.WriteLine(values[i]);
            }
        }
        public int Fakultaet(int zaehler1)
        {
            int ergebnis = 1;
            int zaehler = 1;
            for (int i = 1; i<= zaehler1; i++)
            {
                ergebnis *= i;

            }
            //while (zaehler <= zaehler1)
            //{
            //    //ergebnis *= ++zaehler;
            //    ergebnis *= zaehler++;
            //    //zaehler = zaehler + 1;
            //    //ergebnis = ergebnis * zaehler;
            //}

            Console.WriteLine("{0}!={1}",zaehler1,ergebnis);
            return ergebnis;
        }
        public void Fahrstuhl(uint stockwerk)
        {
            switch (stockwerk)
            {
                case 0:
                    Console.WriteLine("Erdgeschoss erreicht");
                    break;
                case 1:
                    Console.WriteLine("1.Obergeschoss erreicht");
                    break;
                case 2:
                    Console.WriteLine("2.Obergeschoss erreicht");
                    break;
                case 3:
                    Console.WriteLine("Dachgeschoss erreicht");
                    break;
                default:
                    Console.WriteLine("Das Stockwerk {0} gibt es nicht.Bitte geben Sie eine Nummer <= 3",stockwerk);
                    break;
            }
        }
        public void Sequenz(int a,int b,int c,int d,int e)
        {
            int ergebnis1, ergebnis2, ergebnis3;
            ergebnis1 = b * c;
            Console.WriteLine("{0} = {1} * {2}", ergebnis1, b, c);
            ergebnis2 = a + ergebnis1;
            ergebnis3 = d - e;
            ergebnis1 = ergebnis2 * ergebnis3;
            Console.WriteLine("({0}+{1}*{2})*({3}-{4})={5}", a,b,c,d,e,ergebnis1);
            //int r1, r2, r3;
            //r1 = b * c;
            //Console.WriteLine("{0} = {1} * {2}", r1, b, c);
            //r2 = a + r1;
            //Console.WriteLine("{0} = {1} + {2}", r2, a, r1);
            //r3 = d - e;
            //Console.WriteLine("{0} = {1} - {2}", r3, d, e);
            //r1 = r2 * r3;
            //Console.WriteLine("{0} = {1} * {2}", r1, r2, r3);
            //Console.WriteLine("Kontrolle: {0}",
            //(a + b * c) * (d - e));
        }
        public void EinfacheAuswahl(int alter,string name)
        {
            const int VOLLJAEHRIG = 18;
            if (alter >= VOLLJAEHRIG)
            
                Console.WriteLine("{0} ist volljaehrig.", name);
            
            else
            
                Console.WriteLine("{0} ist nicht volljaehrig.",name);
            
        }
        public void AlternativeAuswahl(bool CSHinteressiert,bool VBinteressiert)
        {
            if (CSHinteressiert == true && VBinteressiert == true)
            {
                Console.WriteLine("Du kannst C# und VB.Net-Lehrgaenge buchen");
            }

            else if (CSHinteressiert == true)
            {
                Console.WriteLine("Du bist an C# interessiert,du kannst einen C#-Lehrgang buchen");
            }
            else if (VBinteressiert == true)
            {
                Console.WriteLine("Du bist an VB.NET interessiert,du kannst einen VB.NET-Lehrgang buchen ");

            }
            
            else
            {
                Console.WriteLine("Du kannst den Studienfuehrer durchsehen,um dich ueber andere Lehrgangsangebote zu informieren");
            }
        }
        public int Dekrement()
        {
            int ergebnis =100;
            for (int i = 100;i >= 1;i--)
            {
                ergebnis = i;
            }
            Console.WriteLine("ergebnis:{0}",ergebnis);
            return ergebnis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uebungen ue = new Uebungen();
            int kaufpreis = 0;
            int muenzen = 7;
            int hoelzchen = 53;
            kaufpreis = ue.Multiplizieren(kaufpreis, muenzen, hoelzchen);

            ue.Sequenz(5, 9, 6, 10, 38);
            ue.EinfacheAuswahl(27, "ping");
            ue.AlternativeAuswahl(true, true);
            ue.Fahrstuhl(5);
            ue.Fakultaet(5);
            string[] values = { "eins","zwei","drei","vier"};
            ue.ForEach(values);
            ue.ForStattForEach(values);
            ue.Dekrement();
            ue.Multiplizieren(kaufpreis,muenzen,hoelzchen);
            Console.WriteLine("{0}*{1} ={2}",muenzen,hoelzchen,kaufpreis);
            Console.ReadLine();
        }
    }
}
