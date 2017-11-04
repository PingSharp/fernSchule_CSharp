using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ESA_Projekt
{
    public abstract class Luftfahrzeug
    {
        protected string kennung;
        protected Position pos;

        public string Kennung
        {
            get
            {
                return kennung;
            }

            set
            {
                // was forbit to set 
            }
        }

        public Luftfahrzeug() { }
        public Luftfahrzeug(string kennung, Position pos)
        {
            this.kennung = kennung;
            this.pos = pos;
        }

        public abstract void steigen(int meter);

        public abstract void sinken(int meter);
    }
}