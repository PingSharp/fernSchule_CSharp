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
    public partial class Flugauswahldialog : Form
    {

        private string dbName = "FliegerDB";
        public Flugauswahldialog()
        {
            InitializeComponent();

            IObjectContainer db = null;
            db = Db4oFactory.OpenFile(dbName);
            IObjectSet result = db.QueryByExample(typeof(Duesenflugzeug));
            for (int i = 0; i < result.Count ; i++)
            {
                var Puffer = (Duesenflugzeug)result[i];

                var Q = Puffer.typ.ToString();

                comboBox1.Items.Add(Q);

            }

            comboBox1.Update();

            db.Close();

        }

       

       

        
    }
}
