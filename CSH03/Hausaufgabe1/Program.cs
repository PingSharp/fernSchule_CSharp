using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hausaufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter write = new StreamWriter(File.Open(@"D:\Dokumente\Ping\fernstudium\Hausaufgabe2.txt", FileMode.OpenOrCreate));
            write.WriteLine("Aufgabe2");
            write.Close();

        }
    }
}
