using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion3
{
    class Operatoren
    {
        public void UnaereOperatoren()
        {
            int var1 = +1234;
            int var2 = -1234;
            string auswertung = var1 == var2 ? "Gleich" : "Ungleich";
            Console.WriteLine("die Auswertung:{0}",auswertung);
        }
        public void Modulo()
        {
            int intVar1 = 1234;
            int intVar2 = 13;
            Console.WriteLine("intVar1 % intVar2 = {0}",intVar1 %intVar2);
            double doubleVar1 = 22.33;
            double doubleVar2 = 6.6;
            Console.WriteLine("doubleVar1 % doubleVar2 = {0}",doubleVar1 % doubleVar2);
        }
        public void Vergleiche()
        {
            int Var1 = -1234;
            int Var2 = 1234;
            int Var3 = 1234;
            bool a = Var1 < Var2;
            bool b = Var3 >= Var2;
            bool c = a = b;
            Console.WriteLine("Var1 < Var2 und Var3 >= Var2 haben die gleiche boolesche Wert:{0}", Var1 < Var2 == Var3 >= Var2);
            string s1 = "string";
            string s2 = s1;
            Console.WriteLine("s1 == s2:{0}", s1 == s2);
        }
        public void LogischeOps()
        {
            bool volljaehrig = true;
            bool buerge = false;
            double verdienst = 1950;
            bool kreditwuerdig = volljaehrig & (verdienst > 2000 | buerge);
            Console.WriteLine("kreditwuerdig:{0}", kreditwuerdig);
            int zahl = 12345;
            Console.WriteLine("~12345:{0}", ~zahl);
        }
        public void shift()
        {
            int value = 9;
            int ergebnis1 = value << 2;
            int ergebnis2 = value >> 2;
            Console.WriteLine("9<<2:{0},9>>2:{1}", ergebnis1, ergebnis2);

        }
        public void InkrementUndDekrement()
        {
            int var = 1;
            Console.WriteLine("var++ = {0}", var++);
            Console.WriteLine("var   = {0}", var);
            Console.WriteLine("var-- = {0}", var--);
            Console.WriteLine("var   = {0}", var);
            var = 1;
            Console.WriteLine("++var = {0}", ++var);
            Console.WriteLine("var   = {0}", var);
            Console.WriteLine("--var = {0}", --var);
            Console.WriteLine("var   = {0}", var);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Operatoren ternaerenOperator = new Operatoren();
            ternaerenOperator.UnaereOperatoren();
            ternaerenOperator.Modulo();
            ternaerenOperator.Vergleiche();
            ternaerenOperator.LogischeOps();
            ternaerenOperator.shift();
            ternaerenOperator.InkrementUndDekrement();
            Console.ReadLine();
        }
    }
}
