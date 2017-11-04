using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lektion3._5
{
    delegate void TransponderDel(string kennung, Position pos);
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

        protected Position pos
            ;

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
        
        protected Position zielpos;
        protected int streckeProTakt;
        protected int flughöhe;
        protected int steighöheProTakt;
        protected int sinkhöheProTakt;

        protected bool steigt = false;
        protected bool sinkt = false;
        
        public  int SteigSpeed(int streckProTakt,int flughöhe)
        {
            this.streckeProTakt = streckProTakt;
            int e = flughöhe; /*Math.Sqrt(Math.Pow(Math.Abs(this.pos.x - pos.x), 2)) + Math.Pow(Math.Abs(this.pos.y - pos.y), 2);*/
            double d = Math.Sqrt(Math.Pow(flughöhe, 2) + Math.Pow(e, 2));
            double zeit = d / streckeProTakt;
            return (int)flughöhe / (int)zeit;
        }
        public void Starte(Position zielpos, int streckeProTakt, int flughöhe,int steighöheProTakt,int sinkhöheProTakt)
        {
            this.zielpos = zielpos;
            this.streckeProTakt = streckeProTakt;
            this.flughöhe = flughöhe;
            this.steighöheProTakt = steighöheProTakt;
            this.sinkhöheProTakt = sinkhöheProTakt;
            this.steigt = true;
        }
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
        protected double a;
        protected double b;
        protected double alpha;
        protected double a1;
        protected double b1;
        protected int c;
        public bool gelandet = false;
        

        private bool SinkenEinleiten()
        {
            double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2) - Math.Pow(sinkhöheProTakt, 2));
            int sinkstrecke = (int)(strecke * (pos.h - zielpos.h) / sinkhöheProTakt);
            int zieldistanz = Zieldistanz();
            if (sinkstrecke >= zieldistanz)
            { Console.WriteLine("{0} Sinkstrecke {1} >= Zieldistanz {2}",kennung,sinkstrecke,zieldistanz);
                return true;
            }
            else
            return false;
        }
        //private void PositionBerechnen(double strecke,int steighöheProtakt)
        //{

        //}
        private int Zieldistanz()
        {
            return (int) Math.Sqrt(Math.Pow(zielpos.h - pos.h,2) +Math.Pow( Math.Sqrt(Math.Pow(zielpos.x - pos.x,2) + Math.Pow(zielpos.y - pos.y, 2)),2));
        }
        

        public void Steuern()
        {
            a = this.zielpos.x - pos.x;
            b = zielpos.y - pos.y;
            alpha = Math.Atan(b / a);
            a1 = Math.Cos(alpha) * streckeProTakt;
            b1 = Math.Sin(alpha) * streckeProTakt;
            //int reststreck = Zieldistanz();
       

            pos.PositionÄndern((int)a1, (int)b1, 0);
            double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            int reststreck = Zieldistanz();
            //bool gelandet = false;

            if (pos.h < flughöhe & sinkt == false  & gelandet ==false)
            {
                steigt = true;
                sinkt = false;
                gelandet = false;
                pos.h += steighöheProTakt;
                Program.transponder(kennung,pos);

            }
            else if (pos.h <= 0 & sinkt == true)
            {
                sinkt = false;
                steigt = false;
                gelandet = true;
                Console.WriteLine("{0} ist gelandet", kennung);
            }
            else if ((int)Math.Sqrt(Math.Pow(zielpos.x-pos.x,2) + Math.Pow(zielpos.y -pos.y,2)) <= flughöhe/*reststreck/streckeProTakt == Math.Abs((zielpos.h - pos.h))/sinkhöheProTakt*/ & steigt == false & gelandet == false)
            {
                sinkt = true;
                steigt = false;
                gelandet = false;
                pos.h -= sinkhöheProTakt;
                Program.transponder(kennung, pos);


            }
            else if (pos.h >= flughöhe  & sinkt == false & gelandet == false)
            {
                steigt = false;
                sinkt = false;
                gelandet = false;
                //pos.h = flughöhe;
                Program.transponder(kennung,pos);
            }
            
           
            //if (r > streckeProTakt & gelandet == false)
            //{ Program.transponder(kennung, pos); }
            //if (r < streckeProTakt & gelandet == false)
            //{
            //    gelandet = true;
            //    Console.WriteLine("{0} an position x = {1} /y = {2} gelandet", kennung, pos.x, pos.y);
                //Program.transponder -= Transpond;
            

            //    a = zielpos.x - pos.x;
            //    b = zielpos.y - pos.y;
            //    alpha = Math.Atan(b / a);
            //    a1 = Math.Cos(alpha) * streckeProTakt;
            //    b1 = Math.Sin(alpha) * streckeProTakt;
            //    pos.PositionÄndern((int)a1, (int)b1, 0);
            //double r = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));


        }
        public void Transpond(string kennung, Position pos)
        {


            if (kennung.Equals(this.kennung))
            {
                Console.WriteLine("{0} an Position x = {1},y = {2},h = {3}", kennung, pos.x, pos.y,pos.h);
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
        public Düsenflugzeug(string kennung, Position pos, Airbus typ) : base(kennung, pos)
        {
            this.typ = typ;
            sitzplaetze = (int)typ;
            Console.WriteLine("Der Flieger vom Typ {0} hat {1} Plaetze", typ, sitzplaetze);
        }
        public void Buchen(int plaetze)
        {
            Fluggaeste = plaetze;
        }
    }
    class Program
    {
        public static void ProgrammTakten()
        {

            Starrflügelflugzeug neuflieger = new Starrflügelflugzeug("LH5000", new Position(0, 0, 0));
            int steigspeed = neuflieger.SteigSpeed(100,600);
            neuflieger.Starte(new Position(2000, 2100, 0), 100,600,steigspeed,steigspeed);
            
            //Starrflügelflugzeug neuflieger1 = new Starrflügelflugzeug("LH900", new Position(1000, 3000, 200));
            //neuflieger1.Starte(new Position(9500, 10500, 0), 90,13000,890,890);
            while (true)
            {
                neuflieger.Steuern();
                //neuflieger1.Steuern();
                Console.WriteLine();
                Thread.Sleep(1000);

                if (neuflieger.gelandet == true /*&& neuflieger1.gelandet == true*/)
                {
                    break;
                }

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
            Flugzeug flieger = new Flugzeug("LH 906", new Position(500, 300, 20));
            Console.WriteLine("Kennung = {0}", flieger.Kennung);
            flieger.Kennung = "LH331";
            Console.WriteLine("Kennung = {0}", flieger.Kennung);
        }
        static void Main(string[] args)
        {
            ProgrammTakten();
            Console.WriteLine("{0} * ({1} - {2})/ {3} = {4}",30,50,0,10,30*(50-0)/10);
            Console.ReadLine();
        }
    }
}
