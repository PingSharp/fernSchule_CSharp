using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESA_Projekt
{
    public class Flugzeug : Luftfahrzeug
    {
        protected int streckeProTakt;
        protected Position zielpos;
        protected int flughöhe;
        protected int steighöheProTakt;
        protected int sinkhöheProTakt;

        protected bool steigt = false;
        protected bool sinkt = false;

        public Flugzeug(string kennung, Position pos) : base(kennung, pos)
        {

        }

        public override void sinken(int meter)
        {
            pos.PositionÄndern(0, 0, -meter);
            Console.WriteLine(kennung + "sinkt" + meter + "Meter,neue Hoehe =" + pos.h);
        }

        public override void steigen(int meter)
        {
            pos.PositionÄndern(0, 0, meter);
            Console.WriteLine(kennung + "steigt" + meter + "Meter,neue Hoehe =" + pos.h);
        }

        public virtual void Starte(Position zielpos, int streckeProTakt, int flughöhe, int steighöheProTakt, int sinkhöheProTakt)
        {
            this.zielpos = zielpos;
            this.streckeProTakt = streckeProTakt;
            this.flughöhe = flughöhe;
            this.steighöheProTakt = steighöheProTakt;
            this.sinkhöheProTakt = sinkhöheProTakt;
            this.steigt = true;
        }

        public void Starte(Position zielpos, int streckeProTakt)
        {
            this.zielpos = zielpos;
            this.streckeProTakt = streckeProTakt;
 
        }
    }
}