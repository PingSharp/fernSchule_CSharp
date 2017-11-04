using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lektion1
{
    delegate void TransponderDel(string kennung,Position pos);
    interface ITransponder
    {
        void Transpond(string kennung, Position pos);
        //{
        //    Console.WriteLine();
        //}
    }
    enum Airbus : short
    {
        A300 = 280, A310 = 240, A318 = 260, A319 = 250, A320 = 290, A321 = 320, A330 = 350, A340 = 310, A350 = 253, A380 = 550
    }
    struct Position
    {
        public int x, y, h;
        public Position(int x, int y, int h)
        {
            this.x = x;
            this.y = y;
            this.h = h;
        }
        public void PositionÄndern(int deltaX, int deltaY, int deltaH)
        {
            x = x + deltaX;
            y = y + deltaY;
            h = h + deltaH;
        }
    }
    abstract class Luftfahrzeug
    {
        protected string kennung;

        public string Kennung
        {
            set { kennung = value; }
            get { return kennung; }
        }

        protected Position pos;

        public Luftfahrzeug() { }
        public Luftfahrzeug(string kennung, Position pos)
        {
            this.kennung = kennung;
            this.pos = pos;
        }
        public abstract void steigen(int meter);
        //{
        //    //pos.PositionÄndern(0, 0, meter);
        //    //Console.WriteLine(kennung + "steigt" + meter + "Meter,neue Hoehe =" + pos.h);
        //}
        public abstract void sinken(int meter);
        //{
        //    pos.PositionÄndern(0, 0, -meter);
        //    Console.WriteLine(kennung + "sinkt" + meter + "Meter,neue Hoehe =" + pos.h);
        //}
    }
    class Flugzeug : Luftfahrzeug
    {
        public override void steigen(int meter)
        {
            pos.PositionÄndern(0, 0, meter);
            Console.WriteLine(kennung + "steigt" + meter + "Meter,neue Hoehe =" + pos.h);
        }
        public override void sinken(int meter)
        {
            pos.PositionÄndern(0, 0, -meter);
            Console.WriteLine(kennung + "sinkt" + meter + "Meter,neue Hoehe =" + pos.h);
        }

        public Flugzeug(string kennung, Position pos) : base(kennung, pos) { }
    }
    class Starrflügelflugzeug : Flugzeug, ITransponder
    {

       
        public void Steuern()
        {
            Program.transponder(kennung,pos);
        }
        public void Transpond(string kennung, Position pos)
        {
           
            
                if (kennung.Equals(this.kennung))
                {
                    Console.WriteLine("{0} erkennt Eingang eigenes Signal.", this.kennung);
                }


                else if (this.pos.h - pos.h < 100 & this.pos.h - pos.h > 0)
                {
                    Console.WriteLine("Warnung:{0} fliegt nur {1} Meter tiefer als {2}!", kennung, this.pos.h - pos.h, this.kennung);
                    
                    
                }
                else if (this.pos.h - pos.h < 100 & this.pos.h - pos.h > 0)
                {
                    Console.WriteLine("Warnung:{0} fliegt nur {1} Meter hoeher als {2}!", this.kennung, this.pos.h - pos.h, kennung);
                    
                    //Console.WriteLine("{0} empfaengt Position von {1} : x = {2},y = {3}, h = {4}",this.kennung,kennung,pos.x,pos.x,pos.h);
                
            }
            
    
          //Console.WriteLine("Flieger funkt Kennung\"" + kennung + "\" und Position " + pos.x + "/" + pos.y + "/" + pos.h);
        }

        public Starrflügelflugzeug(string kenngung, Position pos) : base(kenngung, pos)
        {
            Program.transponder += new TransponderDel(Transpond);
        }
    }
    class Düsenflugzeug : Starrflügelflugzeug
    {
        public Airbus typ;
        
        private int sitzplaetze;
        private int fluggaeste;
        public int Fluggaeste
        {
            set
            {
                if (sitzplaetze < (fluggaeste + value))
                    Console.WriteLine("Keine Buchung:Die Fluggastzahl wuerde mit der Zubuchung von {0} Plaetzen die verfuegbaren Plaetze von {1} um {2} uebersteigen!", value, sitzplaetze, value + fluggaeste - sitzplaetze);
                else
                    fluggaeste += value;
            }
            get
             { return fluggaeste; }
        }
        public Düsenflugzeug(string kennung, Position pos,Airbus typ) : base(kennung, pos)
        {
            this.typ = typ;
            sitzplaetze = (int)typ;
            Console.WriteLine("Der Flieger vom Typ {0} hat {1} Plaetze",typ,sitzplaetze);
        }
        public void Buchen(int plaetze)
        {
            Fluggaeste = plaetze;
        }
    }
    class Program
    {
        public void ProgrammTakten()
        {
            Starrflügelflugzeug neuflieger = new Starrflügelflugzeug("LH5000",new Position(500,900,8090));
            Starrflügelflugzeug neuflieger1 = new Starrflügelflugzeug("LH900",new Position(900,730,8000));
            while (true)
            {
                neuflieger.Steuern();
                neuflieger1.Steuern();
                Console.WriteLine();
                Thread.Sleep(1000);
            }

        }
        public static TransponderDel transponder;
        public void TransponderTest()
        {
            Starrflügelflugzeug flieger1 = new Starrflügelflugzeug("LH 3000", new Position(3000, 2000, 100));
            flieger1.Steuern();
            Console.WriteLine();
            Starrflügelflugzeug flieger2 = new Starrflügelflugzeug("LH 500", new Position(3500, 1500, 180));
            flieger1.Steuern();
            flieger2.Steuern();
            Console.WriteLine();
            Starrflügelflugzeug flieger3 = new Starrflügelflugzeug("LH445", new Position(17300, 23400, 780));
            flieger1.Steuern();
            flieger2.Steuern();
            flieger3.Steuern();
            Console.WriteLine();
            transponder -= flieger2.Transpond;
            flieger1.Steuern();
            flieger3.Steuern();
            Console.WriteLine();
        }
        public void Kennung()
        {
            Flugzeug flieger = new Flugzeug("LH 906",new Position(500,300,20));
            Console.WriteLine("Kennung = {0}",flieger.Kennung);
            flieger.Kennung = "LH331";
            Console.WriteLine("Kennung = {0}", flieger.Kennung);
        }
        static void Main(string[] args)
        {
            //Düsenflugzeug df = new Düsenflugzeug("LH9532",new Position(800,950,5000),Airbus.A350);
            //df.Buchen(533);
            //Console.WriteLine("Das Ergebniss lautet: {0}",df.Fluggaeste);
            Program lh = new Program();
            //lh.TransponderTest();
            lh.ProgrammTakten();
            Console.ReadLine();
        }
    }
}
