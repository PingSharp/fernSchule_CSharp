using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lektion4
{
    public partial class ThemaDialog : Form
    {
        public string Thema()
        {
            
            string thema = thematexbox.Text;
            thematexbox.Select();
            return thema;
        }
        public ThemaDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Übernehmen_Click(object sender, EventArgs e)
        {

        }

        private void thematexbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
