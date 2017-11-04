using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Einsendeaufgabe_3
{
    public partial class Einsendeaufgabe_3Form : Form
    {
        public Einsendeaufgabe_3Form()
        {
            InitializeComponent();
        }
        private void beenden_click(object sender,EventArgs e)
        {
            Application.Exit();
        }
    }
   partial class Einsendeaufgabe_3Form
        {
       
        private MenuStrip Testmenü;
        private ToolStripMenuItem testmenü;
        private ToolStripMenuItem Beenden;

        private void InitializeComponent()
        {
            //Menüleiste hinzufügen (Oberste Ebene)
            Testmenü = new MenuStrip();
            Testmenü.Location = new Point(0, 0);
            Testmenü.Size = new Size(450, 24);
            //Eintrag vom Typ "ToolStripMenuItem" "Testmenü" wird hinzufügt.(2.Ebene)
            testmenü = new ToolStripMenuItem();
            testmenü.Size = new Size(46, 20);
            testmenü.Visible = true;
            testmenü.Text = "&Testmenü";
            //Eintrag vom Typ "ToolStripMenuItem" "Beenden" wird durch Eingenschaft "DropDownItems" hinzufügt.(3. Ebene)
            Beenden = new ToolStripMenuItem();
            Beenden.Size = new Size(45, 20);
            Beenden.Text = "&Beenden";
            this.Beenden.Click += new EventHandler(this.beenden_click);

            //Eigenschaften des Form-Objekts werden festgelegt.
            this.ClientSize = new Size(500, 260);   //Die Gröse des Bereichs ohne Fensterrahmen und titelleiste.
            this.Text = "Einsendeaufgabe_3"; 
            this.Controls.Add(Testmenü);  // Die eingenschaft Controls (Items,DropDownItems) nimmt alle Steuerelemente auf,die auf der Benutzeroberfläche eingebaut werden.
            //Die Add Methode kann Objekte aller Klassen zur Verfügung stellen,die über die Eingenschaften "Control"verfügen.
            Testmenü.Items.Add(testmenü);
            testmenü.DropDownItems.Add(Beenden);
            
            

            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Application.Run(new Einsendeaufgabe_3Form());
        }
    }
}
