using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lek2
{
    class StichpunkteForm : Form
    {
        public StichpunkteForm()
        {
            
        }
        private Button buttonÜbernehmen;
        private Button buttonBeeden;
        private TextBox textBoxStichpunkt;
        private ListBox listBoxStichpunkt;

        private void InitializeComponent()
        {
            textBoxStichpunkt = new TextBox();
            textBoxStichpunkt.Location = new Point(12,12);
            textBoxStichpunkt.Size = new Size(304, 20);
            textBoxStichpunkt.TabIndex = 0;

            this.ClientSize = new Size(427, 233);
            this.Text = "Stichpunktsammlung";
            this.Controls.Add(textBoxStichpunkt);

            //buttonÜbernehmen.Click += new EventHandler();
        }
    }
}
