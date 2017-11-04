using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3
{
    class hausaufgabe3
    {
        public int Fakultaet(int zahl)
        {
            int ergebnis = 1;
            
            for (int i = 1; i <= zahl; i++)
            {
                ergebnis *= i;

            }            

            Console.WriteLine("{0}!= {1} ", zahl, ergebnis);
            return ergebnis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            hausaufgabe3 aufgabe = new hausaufgabe3();
            Console.WriteLine("Bitte geben Sie eine Nummer:");
            int number = int.Parse(Console.ReadLine());
            aufgabe.Fakultaet(number);
            Console.ReadLine();
        }
    }
}
