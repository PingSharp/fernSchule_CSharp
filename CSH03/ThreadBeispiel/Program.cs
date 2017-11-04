using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadBeispiel
{
    class Program
    {
        public void ProgrammTakten()
        {

        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.ProgrammTakten();
            while (true)
            {
                //Console.Write(DateTime.Now+"\r");
                Console.Write("\a");
                Console.Write("\r{0}",DateTime.Now);
                //Console.WriteLine("\a");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
