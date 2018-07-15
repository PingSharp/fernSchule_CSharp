using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
namespace Lektion3
{
    partial class Konfigurationsdialog : Form
    {

        private Duesenflugzeug flieger;
        public Duesenflugzeug Flieger
        {
            get { return flieger; }
        }
        private string dbName = "FliegerDB";
        internal bool isConfigurationComplete;
      

        private void SetEingabewerte()
        {
            textBoxKennung.Text = "LH500";
            textBoxStartposX.Text = "100";
            textBoxStartPosY.Text = "300";
            textBoxStartPosH.Text = "9000";
            textBoxZielPosX.Text = "900";
            textBoxZielPosY.Text = "1000";
            textBoxZielPosH.Text = "7000";
            textBoxFlughoehe.Text = "11000";
            textBoxFlugstrecke.Text = "500";
            textBoxSteighoehe.Text = "800";
            textBoxSinkhoehe.Text = "300";
            textBox1AnzahlPlaetze.Text = "190";
        }
        //Diese Methode wertet alle Eingabefelder im Konfigurationsdialog aus
        //und speichert die dort vom benutzer eingetragenen Werte im Düsenflugzeug-Objekt.
        private void initializeFlieger()
        {
            flieger.Kennung = textBoxKennung.Text;
            if (flieger.Kennung.Length == 0)
            {
                Console.WriteLine("Fliegerkennung nicht gesetzt!");
                isConfigurationComplete = false;
            }
            var Puffer = (Airbus) System.Enum.Parse(typeof(Airbus), comboBoxTypen.SelectedItem.ToString());

            flieger.typ = Puffer;

            try
            {
                flieger.pos = new Position(Int32.Parse(textBoxStartposX.Text), Int32.Parse(textBoxStartPosY.Text), Int32.Parse(textBoxStartPosH.Text));
            }
            catch (Exception)
            {
                Console.WriteLine("Startpositionsvariablen nicht gesetzt!");
                isConfigurationComplete = false;
            }
            try
            {
                flieger.zielPos = new Position(Int32.Parse(textBoxZielPosX.Text), Int32.Parse(textBoxZielPosY.Text), Int32.Parse(textBoxZielPosH.Text));

            }
            catch(Exception)
            {
                Console.WriteLine("Zielpositionsvariablen nicht gesetzt!");
                isConfigurationComplete = false;
            }
            flieger.flughoehe = Int32.Parse(textBoxFlughoehe.Text);
            if(textBoxFlughoehe.Text.Length == 0)
            {
                Console.WriteLine("Flughoehe nicht gesetzt!");
                isConfigurationComplete = false;
            }
            flieger.streckeProTakt = Int32.Parse(textBoxFlugstrecke.Text);
            if(textBoxFlugstrecke.Text.Length == 0)
            {
                Console.WriteLine("Flugstrecke nicht gesetzt!");
                isConfigurationComplete = false;
            }
            flieger.steighoeheProTakt = Int32.Parse(textBoxSteighoehe.Text);
            if(textBoxSteighoehe.Text.Length == 0)
            {
                Console.WriteLine("Flugsteighoehe nicht gesetzt!");
                isConfigurationComplete = false;
            }
            flieger.sinkhoeheProTakt = Int32.Parse(textBoxSinkhoehe.Text);
            if(textBoxSinkhoehe.Text.Length == 0)
            {
                Console.WriteLine("Flugsinkhoehe nicht gesetzt!");
                isConfigurationComplete = false;

            }
            flieger.sitzplaetze = Int32.Parse(textBox1AnzahlPlaetze.Text);
            if(textBox1AnzahlPlaetze.Text.Length == 0)
            {
                Console.WriteLine("AnzahlPlaetze nicht gesetzt!");
                isConfigurationComplete = false;

            }
        }

        public Konfigurationsdialog(Duesenflugzeug flieger)
        {
            this.flieger = flieger;
            InitializeComponent();
            
            foreach(string typ in Enum.GetNames(typeof(Airbus)))
            {
                comboBoxTypen.Items.Add(typ);
            }
            SetEingabewerte();
            this.BringToFront();
        }
        private void Konfigurationsdialog_Load(object sender,EventArgs e)
        {
            foreach (Airbus element in Enum.GetValues(typeof(Airbus))) comboBoxTypen.Items.Add(element);
            comboBoxTypen.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxTypen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Konfigurationsdialog_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IObjectContainer db = null;//Deklaration des Db-Arbeitsobjekt.
            bool updated = false;
            try
            {
                db = Db4oFactory.OpenFile("a");//Db-Arbeitsobjekt wird durch die OpenFile methode zugewiesen.
                IList<Duesenflugzeug> fluege =
                    db.Query<Duesenflugzeug>(delegate (Duesenflugzeug flieger)//Die Methode Query verwendet in mehrfacher Hinsicht eine sehr spezielle
                    //Syntax,die gibt eine Ilist mit Typ düsenflugzeug zurück,und die methode 
                    //hat einen Predicate delegate als parameter ,Diese delegate hat eine anonyme Methode gespeichert,die methode nimmt düsenflugzeug 
                    //objekt,und dann prüfen ob diese kennung schon existiert,
                    //wenn ja,wird dieses düsenflugzeug object in der IList gespeichert. 
                    {
                        return flieger.Kennung == textBoxKennung.Text;
                    }
                    );
                foreach(Duesenflugzeug flieger in fluege)
                {
                    Console.WriteLine("Fllug mit der Kennung {0} in Datenbank gefunden",flieger.Kennung);
                }
                if(fluege.Count > 0)
                {
                    flieger = fluege.First();
                    updated = true;
                }
                this.initializeFlieger();
                db.Store(flieger);
                if(updated)
                {
                    Console.WriteLine("Datenbank-Update für den Flug mit der Kennung {0}",flieger.Kennung);

                }
                else
                {
                    Console.WriteLine("Flug mit der Kennung {0} in der Datenbank gespeichert",flieger.Kennung);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType()+":"+ex.Message);

            }
            finally
            {
                if(db!=null)
                {
                    db.Close();
                }
            }
        }

        private void textBoxKennung_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flugauswahldialog flugauswahl = new Flugauswahldialog();
            flugauswahl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IObjectContainer db = null;//Deklaration des Db-Arbeitsobjekt.
            try
            {

                db = Db4oFactory.OpenFile("a");//Db-Arbeitsobjekt wird durch die OpenFile methode zugewiesen.
                IList<Duesenflugzeug> fluege =
                    db.Query<Duesenflugzeug>(delegate (Duesenflugzeug flieger)//Die Methode Query verwendet in mehrfacher Hinsicht eine sehr spezielle
                    //Syntax,die gibt eine Ilist mit Typ düsenflugzeug zurück,und die methode 
                    //hat einen Predicate delegate als parameter ,Diese delegate hat eine anonyme Methode gespeichert,die methode nimmt düsenflugzeug 
                    //objekt,und dann prüfen ob diese kennung schon existiert,
                    //wenn ja,wird dieses düsenflugzeug object in der IList gespeichert. 
                    {
                        return flieger.Kennung == textBoxKennung.Text;
                    }
                    );
                if(fluege.Count > 0)
                {
                    flieger = fluege.First();
                    db.Delete(flieger);
                    Console.WriteLine("Flug {0} gelöscht ", flieger.Kennung);

                }
                else
                {
                    Console.WriteLine("Kein Flug mit der Kennung {0} in der Datenbank", textBoxKennung.Text);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ":" + ex.Message);

            }
            finally
            {
                if (db != null)
                {
                    db.Close();
                }
            }
        }
    }
}
