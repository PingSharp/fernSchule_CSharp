using System;


namespace Lektion2
{
    public enum TicTacToeSpieler
    {
        X,O
    }
    public enum Schachspieler { Black,white}
    class GenericSpiel<T>
    {
        public T Spieler1 { get; set; }
        public T Spieler2 { get; set; }
    }
    class Spiel
    {
        public string Spieler1 { get; set; }
        public string Spieler2
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Spiel spiel1 = new Spiel { Spieler1 = "Otto", Spieler2 = "Klaus" };
            //Console.WriteLine("Spieler1 = {0,-20} Spieler2 = {1}", spiel1.Spieler1,spiel1.Spieler2);
            GenericSpiel<Schachspieler> spiel2 = new GenericSpiel<Schachspieler>
            {
                Spieler1 = Schachspieler.Black,
                Spieler2 = Schachspieler.white
            };
            Console.WriteLine("Spieler1 = {0}  Spieler2 = {1}", spiel2.Spieler1, spiel2.Spieler2);
            GenericSpiel<TicTacToeSpieler> spiel3 = new GenericSpiel<TicTacToeSpieler>
            {
                Spieler1 = TicTacToeSpieler.O,
                Spieler2 = TicTacToeSpieler.X
            };
            Console.WriteLine("Spieler1 = {0}  Spieler2 = {1}", spiel3.Spieler1, spiel3.Spieler2);
            GenericSpiel<string> spiel4 = new GenericSpiel<string>
            {
                Spieler1 = "otto",
                Spieler2 = "klaus"
            };
            Console.WriteLine("Spieler1 = {0}  Spieler2 = {1}", spiel4.Spieler1, spiel4.Spieler2);
            Console.Read();
        }
    }
}
