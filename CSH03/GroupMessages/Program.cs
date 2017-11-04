using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace GroupMessages
{
    
    class Program
    {
        static Random random = new Random();
        static void SendMessage(object user)
        {
            Console.WriteLine("schick {0} eine Sms:Guten Tag! ",user);
            Thread.Sleep(random.Next(10));
            Console.WriteLine("{0} hat die sms empfangen!",user);
        }
        static void Main(string[] args)
        {
            Console.Title = "SMS Sender";
            for (int i = 0;i < 10;i++)
            {
                int nummer = random.Next(100000000);
                Thread thread = new Thread(new ParameterizedThreadStart(SendMessage));
                thread.Start("152"+ nummer);
            }
            Console.ReadLine();
        }
    }
}
