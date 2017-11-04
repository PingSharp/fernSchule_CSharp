using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lektion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Duesenflugzeug flieger1 = new Duesenflugzeug();
            Konfigurationsdialog dialog = new Konfigurationsdialog(flieger1);
            dialog.ShowDialog();
        }
    }
}
