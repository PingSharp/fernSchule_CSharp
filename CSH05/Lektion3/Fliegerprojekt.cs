using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Erg�nzungen:
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Lektion3
{
    delegate void TransponderDel(string kennung, Position pos);
    delegate void FliegerregisterDel();

    enum Airbus { A300, A310, A318, A319, A320, A321, A330, A340, A350, A380 }

    struct Position
    {
        public int x, y, h;
        public Position(int x, int y, int h)
        {
            this.x = x;
            this.y = y;
            this.h = h;
        }
        public void Position�ndern(int deltaX, int deltaY, int deltaH)
        {
            x += deltaX;
            y += deltaY;
            h += deltaH;
        }
    }

    interface ITransponder
    {
        void Transpond(string kennung, Position pos);
    }

    abstract class Luftfahrzeug
    {
        protected internal Position pos; 

        protected string kennung;
        public string Kennung
        {
            get { return kennung; }
            set { kennung = value; }
        }

        public Luftfahrzeug() { }

        public abstract void Steigen(int meter);
        public abstract void Sinken(int meter);
    }

    // Verzweigung auf "Flugzeug" und "Schwebflieger" (letzterer nicht implementiert)
    class Flugzeug : Luftfahrzeug
    {
        protected internal Position zielPos;
        protected internal int streckeProTakt;
        protected internal int flughoehe;
        protected internal int steighoeheProTakt;
        protected internal int sinkhoeheProTakt;

        protected bool steigt = false;
        protected bool sinkt = false;

        public Flugzeug() { }

        public override void Steigen(int meter)
        {
            pos.Position�ndern(0, 0, meter);
            Console.WriteLine(kennung + " steigt " + meter
                + " Meter, neue H�he=" + pos.h);
        }

        public override void Sinken(int meter)
        {
            pos.Position�ndern(0, 0, -meter);
            Console.WriteLine(kennung + " sinkt " + meter
                + " Meter, neue H�he=" + pos.h);
        }
    }

    class Starrfluegelflugzeug : Flugzeug, ITransponder
    {
        private double a, b, alpha, a1, b1;
        private bool gelandet = false;  
        // der "Flugschreiber":
        protected BinaryWriter writer;

        protected string protokollpfad;
        public string Protokollpfad
        {
            get { return protokollpfad; }
        }

        public void Transpond(string kennung, Position pos)
        {
            DateTime timestamp = DateTime.Now;
            if (kennung.Equals(this.kennung))
            {
                Console.Write("{0}:{1} ", timestamp.Minute, timestamp.Second);
                Console.Write("\t{0}: Position={1}/{2}/{3}",// (x/y/h)",
                    this.kennung, pos.x, pos.y, pos.h);
                Console.Write(", Zieldistanz={0} m\n", Zieldistanz());
                if (Fliegerprojekt.protokollieren && writer != null)
                {
                    writer.Write(pos.x);
                    writer.Write(pos.y);
                    writer.Write(pos.h);
                }
            }
            else
            {
                double abstand = Math.Sqrt(Math.Pow(this.pos.x - pos.x, 2)
                    + Math.Pow(this.pos.y - pos.y, 2));
                Console.Write("\t{0}: {1} ist {2} m entfernt.\n",
                    this.kennung, kennung, (int)abstand);

                if (Math.Abs(this.pos.h - pos.h) < 100 && abstand < 500)
                    Console.WriteLine("\t{0}-WARNUNG: {1} hat nur {2} m H�henabstand!",
                        this.kennung, kennung, Math.Abs(this.pos.h - pos.h));
            }
        }

        private bool SinkenEinleiten()
        {
            double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2)
                             - Math.Pow(sinkhoeheProTakt, 2));
            int sinkstrecke = (int)(strecke * (pos.h - zielPos.h) / sinkhoeheProTakt);
            int zieldistanz = Zieldistanz();
            if (sinkstrecke >= zieldistanz)
            {
                // optionale Konsolenausgabe zur Kontrolle
                Console.WriteLine("{0}-Sinkstrecke {1} >= Zieldistanz {2}",
                    kennung, sinkstrecke, zieldistanz);
                return true;
            }
            else
                return false;
        }

        // Beim Sinkflug ist ein negativer Wert f�r den zweiten Parameter anzugeben
        private void PositionBerechnen(double strecke, int steighoeheProTakt)
        {
            a = zielPos.x - pos.x;
            b = zielPos.y - pos.y;
            alpha = Math.Atan2(b, a);
            a1 = Math.Cos(alpha) * strecke; 
            b1 = Math.Sin(alpha) * strecke; 
            pos.Position�ndern((int)a1, (int)b1, steighoeheProTakt);
        }

        private int Zieldistanz()
        {
            return (int)Math.Sqrt(Math.Pow(zielPos.x - pos.x, 2) + Math.Pow(zielPos.y - pos.y, 2));
        }

        public void Steuern()
        {
            if (steigt)
            {
                if (this.SinkenEinleiten())
                {
                    steigt = false;
                    sinkt = true;
                }
                else if (pos.h > flughoehe)
                {
                    steigt = false;
                }
            }
            else if (sinkt)
            {
                if (pos.h <= zielPos.h + sinkhoeheProTakt)
                    gelandet = true;
            }
            else
            {            // Horizontalflug
                if (this.SinkenEinleiten())
                {
                    sinkt = true;
                }
            }
            if (!gelandet)
            {
                // Zun�chst die aktuelle Position ausgeben:
                Fliegerprojekt.transponder(kennung, pos);
                if (steigt)
                {
                    double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2)
                                     - Math.Pow(steighoeheProTakt, 2));
                    this.PositionBerechnen(strecke, steighoeheProTakt);
                }
                else if (sinkt)
                {
                    double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2)
                                     - Math.Pow(sinkhoeheProTakt, 2));
                    this.PositionBerechnen(strecke, -sinkhoeheProTakt);
                }
                else
                {
                    // im Horizontalflug ist "strecke" gleich "streckeProTakt"
                    this.PositionBerechnen(streckeProTakt, 0);
                }
            }
            else
            {
                // Flieger deregistrieren, Transponder abschalten, Abschlussmeldung ...
                Fliegerprojekt.fliegerRegister -= this.Steuern;
                Fliegerprojekt.transponder -= this.Transpond;
                Console.WriteLine("\n{0} gelandet (Zieldistanz={1}, H�hendistanz={2})",
                    kennung, Zieldistanz(), pos.h - zielPos.h);
                if (Fliegerprojekt.protokollieren && writer != null)
                {
                    writer.Write(pos.x);
                    writer.Write(pos.y);
                    writer.Write(pos.h);
                    writer.Close();
                }
            }
        }
    }


     class Duesenflugzeug : Starrfluegelflugzeug
    {
        protected internal Airbus typ;
        protected internal int sitzplaetze;

        // gepr�fte Property in Code 1.3 (CSH03)
        private int fluggaeste;
        public int Fluggaeste
        {
            set
            {
                if (sitzplaetze < (fluggaeste + value))
                    Console.WriteLine("Keine Buchung: Die Fluggastzahl w�rde "
                        + "mit der Zubuchung von {0} Pl�tzen die verf�gbaren "
                        + "Pl�tze von {1} um {2} �bersteigen!", value, sitzplaetze,
                        value + fluggaeste - sitzplaetze);
                else
                    fluggaeste += value;
            }
            get { return fluggaeste; }
        }

        public Duesenflugzeug()
        {
        }


        public void Starte()
        {
            Console.WriteLine("Flieger \"{0}\", Typ {1} ({2} Sitzpl�tze) startet", Kennung, typ, sitzplaetze);
            steigt = true;
            Fliegerprojekt.transponder += this.Transpond;
            Fliegerprojekt.fliegerRegister += this.Steuern;
        }

        public void Buchen(int pl�tze)
        {
            Fluggaeste += pl�tze;
        }

        public void FlugschreiberInitialisieren()
        {
            if (Fliegerprojekt.protokollieren)
            {
                DateTime timestamp = DateTime.Now;
                string pfad = kennung + "_"
                    + timestamp.Day + "-" + timestamp.Hour + "-"
                    + timestamp.Minute + "-" + timestamp.Second + ".bin";
                protokollpfad = pfad;

                writer = new BinaryWriter(File.Open(pfad, FileMode.Create));
                string header =
                    "Flug \"" + kennung + "\" (Typ " + this.typ
                    + ") startet an Position " + pos.x + "-" + pos.y
                    + "-" + pos.h + " mit Zielposition " + zielPos.x + "-"
                    + zielPos.y + "-" + zielPos.h;
                writer.Write(header);
            }
        }
    }

    class Fliegerprojekt
    {
        public static TransponderDel transponder; 
        public static FliegerregisterDel fliegerRegister; 

        public static bool protokollieren = true;

        public void ProgrammTakten()
        {
            Duesenflugzeug flieger = new Duesenflugzeug();
            Konfigurationsdialog config = new Konfigurationsdialog(flieger);
            DialogResult result = config.ShowDialog();
            if (result == DialogResult.OK)
            {
                flieger = config.Flieger;
                flieger.Starte();
            }
            else
            {
                Console.WriteLine(Environment.NewLine + "Konfiguration abgebrochen oder nicht" + "vollst�ndig,kein Start");

            }
            while (fliegerRegister != null)
            {
                fliegerRegister();
                Console.WriteLine();
                Thread.Sleep(1000);
            }
        }

        // Ausgabemethode f�r die Bin�rdatei einer Flugprotokollierung:
        public void AusgabeProtokoll(string protokollpfad)
        {
            BinaryReader reader = new BinaryReader(File.Open(protokollpfad, FileMode.Open));
            // Lesen des Headers 
            Console.WriteLine(reader.ReadString());
            bool goOn = true;
            while (goOn)
            {
                try
                {
                    for (int i = 0; i < 3; i++)
                        Console.Write("\t{0}", reader.ReadInt32());
                }
                catch
                {
                    goOn = false;
                }
                Console.WriteLine();
            }
        }

        //static void Main(string[] args)
        //{
        //    Fliegerprojekt program = new Fliegerprojekt();
        //    program.ProgrammTakten();
        //}
    }
}
