using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;


namespace ESA_Projekt
{
    class Program
    {
        // just for try 
        //float gleitkommazahl = 0.8f;
        //double nummer = 0.8;
        //decimal nummber = 0.38282m;
        public static bool protokollieren = true;
        public static TransponderDel transponder;

        public static FliegerRegisterDel fliegerRegister;
        public BinaryReader LokalReader;

        static void Main(string[] args)
        {
            
            Program.ProgrammTakten(); 
            
            //Düsenflugzeug flieger = new Düsenflugzeug("LH3000", new Position(3500,1500,180), Airbus.A300);


            //flieger.Starte(new Position(1000,500,200),200,300,20,10);


            //Program.fliegerRegister += flieger.Steuern;


            //while (Program.fliegerRegister != null)
            //{

            //    Program.fliegerRegister();

            //    Console.WriteLine();
            //    Thread.Sleep(1000);

            //}

            //Düsenflugzeug flieger2 = new Düsenflugzeug("LH310", new Position(10, 4, 8), Airbus.A310, false);

            Console.ReadLine();
        }

        public void Kennung()
        {
            Flugzeug flieger = new Flugzeug("LH 906", new Position(500, 300, 20));
            Console.WriteLine("Kennung = {0}", flieger.Kennung);
            flieger.Kennung = "LH331";
            Console.WriteLine("Kennung = {0}", flieger.Kennung);
        }

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

        public static void ProgrammTakten()
        {
           
            Düsenflugzeug neuflieger = new Düsenflugzeug("LH5000", new Position(3500, 1500, 180),Airbus.A300, Program.protokollieren);

            neuflieger.Starte(new Position(1000, 500, 200), 200,300,20,10);
            

            Program.fliegerRegister += neuflieger.Steuern;

            Starrflügelflugzeug neuflieger1 = new Starrflügelflugzeug("LH900", new Position(3000, 2000, 100));
            neuflieger1.Starte(new Position(1000, 500, 200), 260, 350,25,15);

            Program.fliegerRegister += neuflieger1.Steuern;


            while (Program.fliegerRegister != null) 
            {

                Program.fliegerRegister();
                
                Thread.Sleep(1000);


            }

            Program newprogramm = new Program();
            newprogramm.ESA4Out(neuflieger.Pfad);


        }
        public void ESA4Out(string protokollpfad)
        {
            if (protokollieren == true)
            {
                this.LokalReader = new BinaryReader(File.Open(protokollpfad, FileMode.Open));

                var Puffer = LokalReader.ReadString();
                Console.Write((Puffer + "\n").PadRight(10));
                Console.Write("\n");

                bool goon = true;
                while (goon)
                {
                    try
                    {
                        Puffer = LokalReader.ReadString();

                        var Positions = Puffer.Split(' ');
                        
                        Console.Write("".PadRight(5));
                        Console.Write(Positions[0].PadRight(10));
                        Console.Write(Positions[2].PadRight(10));
                        Console.Write(Positions[4].PadRight(10) + "\n");
                    }
                    catch (EndOfStreamException e)
                    {
                        goon = false;
                    }
                }
                LokalReader.Close();
            }
            else
            {
                //Console.WriteLine("Ich bin fertig!");
            }
        }
    }
}
