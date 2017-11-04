using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion1
{
    public partial class StichpunkteForm : Form
    {
        private void enter(object s, KeyEventArgs a)
        {
            if (a.KeyData == Keys.Enter)
            {
                listBoxStichpunkt.Items.Add(textBoxStichpunkt.Text);
                textBoxStichpunkt.Text = "";
                textBoxStichpunkt.Select();
            }
            

        }
        //protected override void OnEnter(EventArgs e)
        //{
        //    Enter += new EventHandler(enter);
        //}

        public StichpunkteForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxStichpunkt.Items.Add(textBoxStichpunkt.Text);
            textBoxStichpunkt.Text = "";
            textBoxStichpunkt.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object select = listBoxStichpunkt.SelectedItem;
            int index = listBoxStichpunkt.SelectedIndex;
            int menge = listBoxStichpunkt.Items.Count;
            if (index < menge-1)
            {
                listBoxStichpunkt.Items.Remove(select);
                listBoxStichpunkt.Items.
                    Insert(index + 1, select);
            }
        }

        private void nachoben_Click(object sender, EventArgs e)
        {
            
                

                    object select = listBoxStichpunkt.SelectedItem;
                    int index = listBoxStichpunkt.SelectedIndex;
                    if (index > 0)
                    {
                        listBoxStichpunkt.Items.Remove(select);
                        listBoxStichpunkt.Items.Insert(index - 1, select);
                    }
                
               
                

            
        }
    }
}
