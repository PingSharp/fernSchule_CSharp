using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung
{
    class Hausaufgabe5
    {
        public bool BitMusterPruefen(int zahl,int operand)
        {
            bool ergebnis = ((zahl & operand) == operand);
            Console.WriteLine("{0} enthalten {1} :{2} ", zahl, operand, ergebnis);
            return ergebnis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hausaufgabe5 aufgabe = new Hausaufgabe5();
            int zahl = 1234;
            int operand = 1024;
            aufgabe.BitMusterPruefen(zahl,operand);
            Console.ReadLine();
        }
    }
}
