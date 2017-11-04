using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ESA_Projekt
{
    class Düsenflugzeug : Starrflügelflugzeug
    {

        public Airbus typ;
       
        private int sitzplaetze;
        private int fluggaeste;

        private BinaryWriter LocalWriter;
        
        string datetime = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();


        //public int Fluggaeste
        //{
        //    set
        //    {
        //        if (sitzplaetze < (fluggaeste + value))
        //            Console.WriteLine("Keine Buchung:Die Fluggastzahl wuerde mit der Zubuchung von {0} Plaetzen die verfuegbaren Plaetze von {1} um {2} uebersteigen!", value, sitzplaetze, value + fluggaeste - sitzplaetze);
        //        else
        //            fluggaeste += value;
        //    }
        //    get
        //    { return fluggaeste; }
        //}

        public BinaryWriter FlugSchreiber
        {
            get
            {
                return this.LocalWriter;
            }

            set
            {
                // nicht wechselbar  
            }
        }

        public  Düsenflugzeug(string kennung, Position pos, Airbus typ, Boolean SchreiberAn = true) : base(kennung, pos)
        {

            this.typ = typ;
            this.pos = pos;
            sitzplaetze = (int)typ;

            if (SchreiberAn)
            {
                string FileLocation = this.Pfad;

                this.LocalWriter = new BinaryWriter(File.Open(FileLocation, FileMode.Create)); //FlugSchreiber(kennung, typ, FileLocation);
                                                                                               //LocalWriter.Close();

                //Console.WriteLine("Flugschreiber von " + this.typ.ToString() + " mit der Kennung " + this.kennung.ToString() + " ist angeschaltet. ");
                //}
                //else
                //{
                //    Console.WriteLine("Flugschreiber von " + this.typ.ToString() + " mit der Kennung " + this.kennung.ToString() + " ist ausgeschaltet.");
            }

            //Console.WriteLine("Der Flieger vom Typ {0} hat {1} Plaetze", typ, sitzplaetze);

        }
        public string Pfad
        {

            get
            {
                return @".\" + kennung.ToString() + "-" + datetime + ".bin";
            }
        }

        public override void Transpond(string kennung, Position pos)
        {
            base.Transpond(kennung, pos);
            
            if (LocalWriter != null)
            {
                this.LocalWriter.Write(pos.x.ToString() + "  " + pos.y.ToString() + "  " + pos.h.ToString());
            }
        }

        public override void Steuern()
        {
            base.Steuern();

            if (this.gelandet)
            {
                if (LocalWriter != null)
                {
                    LocalWriter.Close();
                }
            }

        }

        public override void Starte(Position zielpos, int streckeProTakt, int flughöhe, int steighöheProTakt, int sinkhöheProTakt)
        {
            base.Starte(zielpos, streckeProTakt, flughöhe, steighöheProTakt, sinkhöheProTakt);
            //string FileLocation = @"C:\Users\Kahr_Zang\Documents\Visual Studio 2015\Projects\CSH03HA\ESA_Projekt\bin\Debug\" + kennung.ToString() + "-" + datetime+ ".bin";

            if (LocalWriter != null)
            {
                LocalWriter.Write("Flug" + '"' + kennung + '"' + "(Typ " + typ.ToString() + ")" + "startet an position  " + pos.x.ToString() + "-" + pos.y.ToString() + "-" + pos.h.ToString() + "mit Zielposition " + zielpos.x.ToString() + "-" + zielpos.y.ToString() + "-" + zielpos.h.ToString() + ".");
               
            }
            
        }
        

        //public void Buchen(int plaetze)
        //{
        //    Fluggaeste = plaetze;
        //}
    }
}