using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DelegateBeispiel
{
    delegate void Nachricht(string sender);
    class Program
    {
        public void GutenTag(string sender)
        {
            Console.WriteLine("{0} sagt guten tag!",sender);
        }
        public void AufWiedersehen(string sender)
        {
            Console.WriteLine("{0} sagt aufwiedersehen!",sender);
        }
        public void DelegateAnwenden()
        {
            Nachricht info = new Nachricht(GutenTag);
            info += new Nachricht(AufWiedersehen);
            info("Ihr Administrator");

        }
        static void Main(string[] args)
        {
            //FileStream stream = new FileStream(@"D:\Dokumente\Ping\fernstudium\test.txt",FileMode.Create);
            StreamWriter write = new StreamWriter(File.Open(@"D:\Dokumente\Ping\fernstudium\test.txt",FileMode.Create));
            write.WriteLine("Hello!world!");
            write.Close();
            StreamReader read = new StreamReader(File.Open(@"D:\Dokumente\Ping\fernstudium\test.txt", FileMode.OpenOrCreate));
            StreamReader read1 = new StreamReader(File.Open(@"D:\Dokumente\Ping\fernstudium\test1.txt", FileMode.OpenOrCreate));
            read.Close();
            //Program test = new Program();
            //test.DelegateAnwenden();
            //Console.ReadLine();
        }
    }
}
