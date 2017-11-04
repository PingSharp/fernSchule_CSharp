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
    public partial class tipps : Form
    {
        public tipps()
        {
            InitializeComponent();
        }

        public tipps(string ErrorText)
        {
            InitializeComponent();

            this.label1.Text = ErrorText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
