using System;

namespace Lektion5
{
    /// <summary>
    /// Dokumentationskommentar vor einer 
    /// Klassendeklaration
    /// </summary>
    public class KommentarTests
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
        public KommentarTests()
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
        public static void Main()
        {
            Console.WriteLine(++programmschritt + ".Ausgabe aus Main-Methode");
            KommentarTests obj = new KommentarTests();
            obj.Methode();
            
        }
    }
    
}
