using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESA_Projekt
{
    public class Starrflügelflugzeug : Flugzeug, ITranspond
    {
        protected double a;
        protected double a1;
        protected double b;
        protected double b1;
        protected double alpha;
        protected bool gelandet = false;

        public Starrflügelflugzeug(string kenngung, Position pos) : base(kenngung, pos)
        {
            Program.transponder += new TransponderDel(this.Transpond);
        }

        public virtual void Steuern()
        {
            // entscheide über den Flugzeugzustand - sinken, steigen oder 
            // nichts von beiden
            if (this.steigt)
            {
                // aufhören zu steigen und gleich sinken
                if (this.SinkenEinleiten())
                {
                    this.steigt = false;
                    this.sinkt = true;
                }
                // noch nicht sinken, aber aufhören zu steigen
                // konstante Flughöhe 
                else if (pos.h > this.flughöhe)
                {
                    steigt = false;
                }
            }
            else if (this.sinkt)
            {
                if (pos.h <= zielpos.h + sinkhöheProTakt)
                {
                    this.gelandet = true;
                }
            }
            // konstante Höhe
            else
            {
                if (this.SinkenEinleiten())
                {
                    this.sinkt = true;
                }
            }

            // Positionsberechnung
            if (!this.gelandet)
            {
                Program.transponder(this.kennung, this.pos);

                if (this.steigt)
                {
                    // berechne wie viel von der strecke geht in die horizontale
                    double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2) -    Math.Pow(this.steighöheProTakt,2));

                    this.PositionBerechnen(strecke, steighöheProTakt);

                }
                else if (this.sinkt)
                {
                    // berechne wie viel von der strecke geht in die horizontale
                    double strecke = Math.Sqrt(Math.Pow(streckeProTakt, 2) - Math.Pow(this.sinkhöheProTakt, 2));

                    this.PositionBerechnen(strecke, -sinkhöheProTakt);
                }
                else
                {
                    // flugzeug ist horizontal 
                    this.PositionBerechnen(streckeProTakt, 0);
                }
            }
            else
            {
                // bin am Boden - abmelden von steuern und Transpond 
                Program.fliegerRegister -= this.Steuern;
                Program.transponder -= this.Transpond;

                //Console.WriteLine("\n{0} gelandet (Zieldistanz = {1}, Höhendistanz = {2}", kennung,ZielDistanz(),pos.h - zielpos.h );
            }

        }

        public virtual void Transpond(string kennung, Position pos)
        {
            double abstand = Math.Sqrt(Math.Pow(this.pos.x - pos.x,2) + Math.Pow(this.pos.y - pos.y,2)); 

            DateTime timestamp = DateTime.Now;

            if (kennung.Equals(this.kennung))
            {
                //Console.Write("{0}:{1} ", timestamp.Minute, timestamp.Second);
                //Console.Write("\t{0}-Position: {1}-{2}-{3} ", this.kennung, pos.x, pos.y, pos.h);
                //Console.Write("Zieldistanz: {0} m\n", this.ZielDistanz());
            }
            else
            {
                //Console.Write("\t{0} ist {1} m von {2} entfernt. \n", this.kennung, (int)abstand, kennung);
            }
    }

        private bool SinkenEinleiten()
        {
            
            double strecke = Math.Sqrt(Math.Pow(this.streckeProTakt, 2) - Math.Pow(this.sinkhöheProTakt, 2));

            int sinkstrecke = (int)(strecke * (pos.h - zielpos.h) / sinkhöheProTakt);

            int zieldistanz = this.ZielDistanz();

            if (sinkstrecke >= zieldistanz)
            {
                //Console.WriteLine("{0} Sinkstrecke {1} >= Zieldistanz {2}", this.kennung, sinkstrecke, zieldistanz);
                return true;
            }
            else
            {
                return false;
            }


        }

        public void PositionBerechnen(double strecke, int steighöheProTakt)
        {
            this.a = zielpos.x - pos.x;
            this.b = zielpos.y - pos.y;

            alpha = Math.Atan2(this.b, this.a);

            this.a1 = Math.Cos(alpha) * strecke;
            this.b1 = Math.Sin(alpha) * strecke;

            pos.PositionÄndern((int)a1, (int)b1, steighöheProTakt);

        }

        public int ZielDistanz()
        {
            return (int) Math.Sqrt(Math.Pow(zielpos.x - pos.x,2) + Math.Pow(zielpos.y - pos.y,2));
        }
    }
}