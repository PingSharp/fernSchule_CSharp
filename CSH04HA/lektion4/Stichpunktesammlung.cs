using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lektion4
{
    public partial class Stichpunktesammlung : Form
    {

        Optionen_zum_Öffnen_der_Stichpunktesammlung optionen;
     
        public Stichpunktesammlung()
        {

            this.InitializeComponent();

           


        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox2.Text;
            listBox1.Items.Add(item);
            textBox2.Text = "";
            textBox2.Select();
        }

        private void löschen_Click(object sender, EventArgs e)
        {
            object select = listBox1.SelectedItem;
            if (select != null)
            {
                listBox1.Items.Remove(select);
                toolStripStatusLabel1.Text = "Eintrag wird gelöscht!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Sie haben noch keinen Eintrag ausgewählt!";
            }
        }

        private void nachoben_Click(object sender, EventArgs e)
        {
            //bool isArgumentOutofRange = false;
            object selectnachoben = listBox1.SelectedItem;
            int index = listBox1.SelectedIndex;
            try
            {
                //if (isArgumentOutofRange == false) 
                //{
                    listBox1.Items.Insert(index - 1, selectnachoben);
                    listBox1.Items.RemoveAt(index + 1);
                    toolStripStatusLabel1.Text = "Der Eintrag ist nach oben geschoben.";
                //}
            }
            catch (ArgumentOutOfRangeException a)
            {
                //isArgumentOutofRange = true;
                if (index < 0)
                {
                    Fehlermeldung fehlermeldung = new Fehlermeldung();
                    fehlermeldung.ShowDialog();
                    toolStripStatusLabel1.Text = "Der Eintrag ist nicht nach oben geschoben.";
                }
                else
                {
                    tipps tip = new tipps();
                    tip.ShowDialog();
                    toolStripStatusLabel1.Text = "Der Eintrag ist nicht nach oben geschoben.";
                }

            }
        }

        private void nachuntern_Click(object sender, EventArgs e)
        {
            bool isArgumentNull = false;
            object selectnachunter = listBox1.SelectedItem;
            int index = listBox1.SelectedIndex;
            int count = listBox1.Items.Count;
            try
            {
                if (index < count - 1 && isArgumentNull == false)
                {
                    listBox1.Items.Remove(selectnachunter);
                    listBox1.Items.Insert(++index, selectnachunter);
                    toolStripStatusLabel1.Text = "Der Eintrag ist nach untern geschoben.";

                }
                else if (index == count - 1)
                {
                    tipps tip = new tipps("Der Eintrag ist schon ganz untern,Bitte wählen Sie einen neuen Eintrag aus!");

                    tip.ShowDialog();

                    toolStripStatusLabel1.Text = "Der Eintrag ist nicht nach untern geschoben.";
                }
            }
            catch (ArgumentNullException)
            {

                isArgumentNull = true;
                Fehlermeldung fehlermeldung = new Fehlermeldung();
                fehlermeldung.ShowDialog();
                toolStripStatusLabel1.Text = "Der Eintrag ist nicht nach untern geschoben.";
            }
        }

        private void Stichpunktesammlung_Load(object sender, EventArgs e)
        {
            //Der Optionwn_zum_Öffnen_der_Stichpunktesammlung-Dialog wird als  eine Klasse  hinzufügt.Die Klasse bietet einen parameterlosen Konstruktor,mit dem das Dialog-Fenster erstellt werden kann.
            Optionen_zum_Öffnen_der_Stichpunktesammlung optionen = new Optionen_zum_Öffnen_der_Stichpunktesammlung();
            var optionenresult = optionen.ShowDialog();
            if (optionenresult == DialogResult.OK)
            {
                
            
            }
            else if (optionenresult == DialogResult.Yes)
            {
                //Das Themadialog-Fenster wird angezeigt.
                ThemaDialog themadialog = new ThemaDialog();
                DialogResult themaresult = themadialog.ShowDialog();
                if (themaresult == DialogResult.OK)
                {
                    textBox1.Text = themadialog.Thema();
                    listBox1.Items.Clear();
                    textBox2.Select();

                    toolStripStatusLabel1.Text = "Neues Thema : " + themadialog.Thema();

                }
                else
                {
                    toolStripStatusLabel1.Text = "Thema-Dialog abgebrochen";
                }
            }
            else
            {
               //Das OpenFileDialog-Fenster wird angezeigt.
                OpenFileDialog opendialog = new OpenFileDialog();
                opendialog.Title = "Stichpunkteliste öffnen";
                opendialog.Filter = "Textdateien (*.txt) | *.txt|Alle Dateien (*.*) | *.*";
                opendialog.CheckFileExists = true;
                opendialog.CheckPathExists = true;
                if (opendialog.ShowDialog() == DialogResult.OK)
                {

                    listBox1.Items.Clear();

                    StreamReader read = new StreamReader(opendialog.FileName, System.Text.Encoding.Default);

                    string thema = read.ReadLine();
                    textBox1.Text = thema;
                    while (!read.EndOfStream)
                    {
                        object inhalt = read.ReadLine();
                        listBox1.Items.Add(inhalt);
                    }
                    read.Close();
                    this.toolStripStatusLabel1.Text = "Datei \"" + opendialog.FileName + "\"geöffnet.";

                }

                else
                {
                    this.toolStripStatusLabel1.Text = "Öffnen abgebrochen";
                }
            }
        }
        private string fileName;
        private void Speichern(string fileName)
        {
            string path = fileName;
            FileStream newfs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter write = new StreamWriter(newfs);
            string thema = textBox1.Text;
            write.WriteLine(thema);
            for (int i = 0; i < listBox1.Items.Count; i++)
            { 
                string selected = listBox1.Items[i].ToString();
                
                write.WriteLine(selected);

                
                
            }
            write.Close();

            


        }
        private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog speicherndialog = new SaveFileDialog();
            speicherndialog. Title = "Stichpunkteliste";
            speicherndialog.Filter = "Textdateien (*.txt) | *.txt|Alle Dateien (*.*) | *.*";
            DateTime time = DateTime.Now;
            if (fileName == null)
            {
                speicherndialog.FileName = time.ToString("yyyy-MM-dd") + textBox1.Text.Trim() + ".txt";
            }

            else
            {
                speicherndialog.FileName = fileName;
                
               
            }
            DialogResult result = speicherndialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Speichern(speicherndialog.FileName);
                fileName = speicherndialog.FileName;
                this.toolStripStatusLabel1.Text = "Daten gespeichert!";

            }
            else
            { this.toolStripStatusLabel1.Text = "Speichern abgebrochen!"; }
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Title = "Stichpunkteliste öffnen";
            opendialog.Filter = "Textdateien (*.txt) | *.txt|Alle Dateien (*.*) | *.*";
            opendialog.CheckFileExists = true;
            opendialog.CheckPathExists = true;
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                StreamReader read = new StreamReader(opendialog.FileName, System.Text.Encoding.Default);
               
                string thema = read.ReadLine();
                textBox1.Text = thema;
                while (!read.EndOfStream)
                {
                    object inhalt = read.ReadLine();
                    listBox1.Items.Add(inhalt);
                }
                read.Close();
                this.toolStripStatusLabel1.Text = "Datei \"" +opendialog.FileName + "\"geöffnet.";
                
            }
            else
            {
                this.toolStripStatusLabel1.Text = "Öffnen abgebrochen";
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void öffnenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();

            //this.toolStripContainer1.TopToolStripPanel.Controls

            //this.toolStripContainer1.LeftToolStripPanel.Controls
                
            opendialog.Title = "Stichpunkteliste öffnen";
            opendialog.Filter = "Textdateien (*.txt) | *.txt|Alle Dateien (*.*) | *.*";
            opendialog.CheckFileExists = true;
            opendialog.CheckPathExists = true;
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                StreamReader read = new StreamReader(opendialog.FileName, System.Text.Encoding.Default);
                string thema = read.ReadLine();
                textBox1.Text = thema;

                while (!read.EndOfStream)
                {
                    object inhalt = read.ReadLine();
                    listBox1.Items.Add(inhalt);
                }
                read.Close();
                this.toolStripStatusLabel1.Text = "Datei \"" + opendialog.FileName + "\"geöffnet.";

            }
            else
            {
                this.toolStripStatusLabel1.Text = "Öffnen abgebrochen";
            }

        }

        private void speichernToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog speicherndialog = new SaveFileDialog();
            speicherndialog.Title = "Stichpunkteliste";
            speicherndialog.Filter = "Textdateien (*.txt) | *.txt|Alle Dateien (*.*) | *.*";
            DateTime time = DateTime.Now;
            if (fileName == null)
            {
                speicherndialog.FileName = time.ToString("yyyy-MM-dd") + textBox1.Text.Trim() + ".txt";
            }

            else
            {
                speicherndialog.FileName = Path.GetFileName(fileName);

                speicherndialog.RestoreDirectory = true;

                speicherndialog.InitialDirectory = Path.GetDirectoryName(fileName);


            }
            DialogResult result = speicherndialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Speichern(speicherndialog.FileName);
                fileName = speicherndialog.FileName;
                this.toolStripStatusLabel1.Text = "Daten gespeichert!";

            }
            else
            { this.toolStripStatusLabel1.Text = "Speichern abgebrochen!"; }
        }

        private void neuToolStripButton_Click(object sender, EventArgs e)
        {
            ThemaDialog themadialog = new ThemaDialog();
            DialogResult themaresult = themadialog.ShowDialog();
            if (themaresult == DialogResult.OK)
            {
                textBox1.Text = themadialog.Thema();
                listBox1.Items.Clear();
                textBox2.Select();

                toolStripStatusLabel1.Text = "Neues Thema : " + themadialog.Thema();

            }
            else
            {
                toolStripStatusLabel1.Text = "Thema-Dialog abgebrochen";
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.neuToolStripButton_Click(sender,e);
        }

        private void hilfeToolStripButton_Click(object sender, EventArgs e)
        {
            HilfeDialog hilfdialog = new HilfeDialog();
            
            toolStripStatusLabel1.Text = " Hilfedialog wird angezeigt! ";

            hilfdialog.Show();
        }

       

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 
