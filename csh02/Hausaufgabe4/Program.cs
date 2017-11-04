using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausaufgabe4
{
    class aufgabe
    {
        public void Ausgaben(int a,int b,string waehrung)
        {
            int price = a * b;
            Console.WriteLine("Fuer {0} Aktien a {1} {2} haben Sie {3} {2} zu zahlen", a, b, waehrung, price, waehrung);
        }
        public uint UlamVermutung(uint zahl)
        {
            Console.WriteLine("Es wurde {0} eingegeben.",zahl);

            while (zahl > 1)
            {

                if ( zahl % 2 == 1)
            {
                    zahl *= 3 ;
                    zahl =++zahl;
                    Console.WriteLine(" Die Nummer ist ungerade,das Ergebnis ist:{0} ",zahl);
                }
                else
            {

                    zahl = zahl / 2;
                    Console.WriteLine("Die Nummer ist gerade,das Ergebnis ist:{0}",zahl);
                }
            }
            Console.WriteLine("Das Ergebnis der UlamVermutung lautet:{0}",zahl);
            return zahl;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            aufgabe aufgebe1 = new aufgabe();
            Console.WriteLine("Bitte geben Sie eine nummer:");
            string zahl = Console.ReadLine();
            uint nummer = Convert.ToUInt32(zahl);
            aufgebe1.UlamVermutung(nummer);
            aufgebe1.Ausgaben(120, 6, "Euro");
            Console.ReadLine();
        }
    }
}
