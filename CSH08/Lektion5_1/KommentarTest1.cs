using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion5_1
{
    /// <summary>
    /// Dokumentationskommentar vor einer 
    /// Klassendeklaration
    /// </summary>
    public class KommentarTest1
    {
        ///<summary>
        ///Kommentar vor einem Klassenfeld
        ///</summary>
        private static int programmschritt = 1;

        ///<summary>
        ///Event vom Typ "System.EventHandler"
        ///</summary>
        public event EventHandler AnyEvent;

        ///<summary>
        ///Property,Zugriff auf "get"eingeschränkt
        ///</summary>
        public static int Programmschritt
        {
            get { return programmschritt; }
        }

        ///<summary>
        ///Der Parameterlose Konstruktor hat eine
        ///Implementierung(Konsolenausgabe).
        ///</summary>
        public KommentarTest1()
        {
            ///<summary>
            ///commentar
            ///</summary>
            Console.WriteLine(++programmschritt + ".Ausgabe aus Konstruktor");
        }

        ///<summary>
        ///Die Instanzmethode bewirkt eine Konsoleausgabe
        ///</summary>
        public void Methode()
        {
            Console.WriteLine(++programmschritt + ".Ausgabe aus Instanzmethode");
        }
        ///<summary>
        ///Der Compiler erwartet einen Einstiegspunkt
        ///(Main-Methode). Fehlt die Main-Methode,wird
        ///die Klasse nicht kompiliert.
        ///</summary>
        static void Main()
        {
            Console.WriteLine(++programmschritt + ".Ausgabe aus Main-Methode");
            KommentarTest1 obj = new KommentarTest1();
            obj.Methode();

        }
    }
}
