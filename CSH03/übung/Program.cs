using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace übung
{
    class Program
    
    {
        private static void English(string name)
        {
            Console.WriteLine("Hello,{0}",name);

        }
        private static void Chinese(string name)
        {
            Console.WriteLine("ni hao,{0}",name);
        }
        public delegate void Hello(string name);
        private static void GreetPeople(string name,Hello language)
        {
            language(name);
        }
        static void Main(string[] args)
        {
            Program.GreetPeople("Lucy",Chinese);
            Console.ReadLine();
        }
    }
}
