using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion1
{
    class Luftfahrzeug
    {
        protected string kennung;
        public Luftfahrzeug(string kennung)
        {
            this.kennung = kennung;
        }
        public override string ToString()
        {

            return "Luftfahrzeug mit der Kennung" + kennung;
        }
    }
    class Uebung
     {
        public void Konsolenausgabe()
        {
            string ort = "Darmstadt";
            int Jahr = 2012;
            double Ausgabe = 223;
            string Waehrung = "Euro";
            Console.WriteLine("Die Einwohner von {0} haben {1} {2} Mio. {3} fuer Weihnachtsgeschenke ausgegeben",ort,Jahr,Ausgabe,Waehrung);
        }
            public void ObjectMethoden()
            {
                Luftfahrzeug flieger1 = new Luftfahrzeug("LH3000");
                Luftfahrzeug flieger2 = new Luftfahrzeug("LH4000");
                Luftfahrzeug flieger3 = null;
            bool ergebnis = flieger1.Equals(flieger2);
            Console.WriteLine("flieger1 gleich flieger2?{0}",ergebnis);

            bool ergebnis1 = flieger1.Equals(flieger3);
            Console.WriteLine("flieger1 gleich flieger3?{0}", ergebnis1);
            int Hashcode1 = flieger1.GetHashCode();
            int Hashcode2 = flieger2.GetHashCode();
            //int Hashcode3 = flieger3.GetHashCode();
            Console.WriteLine("flieger1-Hashcode:{0}",Hashcode1);
            Console.WriteLine("flieger2-Hashcode:{0}",Hashcode2);
            //Console.WriteLine("flieger3-Hashcode:{0}",Hashcode3);
            Console.WriteLine("flieger1.tostring:{0}",flieger1.ToString());
            Console.WriteLine("fluger3 nach null-zuweisung:{0}",flieger3);
            }
        public void ObjectZuweisungen()
        {
            object obj0 = new Object();
            object obj1 = new Luftfahrzeug("LH200");
            object obj2 = 12;
            int num = (int)obj2;
            object obj3 = "Eine Zeichenkette";
            Console.WriteLine("objo = {0}",obj0.GetType());
            Console.WriteLine("obj1 = {0}",obj1.GetType());
            Console.WriteLine("obj2 = {0}",obj2.GetType());
            Console.WriteLine("obj3 = {0}",obj3.GetType());
            
            Console.WriteLine("num = {0}",num);
        }
        }

    class Program
    {
        static void Main(string[] args)
        {
            Uebung ue = new Uebung();
            //ue.ObjectMethoden();
            ue.ObjectZuweisungen();
            //ue.Konsolenausgabe();
            Console.ReadLine();
            //A a1 = new A();
            //A a = new A();
            //bool ergebnis = a1.Equals(a);
            //Console.WriteLine("type:"+a1.GetType());
            //Console.WriteLine("bool ergebnis:"+ ergebnis);
            //Console.ReadLine();

        }
    }
}
