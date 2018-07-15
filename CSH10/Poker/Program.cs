using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void WhoistheWinner(string player1,string player2)
        {
            char[] char1 = player1.ToArray<char>();
            char[] char2 = player2.ToArray<char>();
            if(char1.Reverse().SequenceEqual(char1) && char2.Reverse().SequenceEqual(char2))
            {
                if(char1[0] > char2[0])
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("-1");
                }
             
            }
        }
        static void Main(string[] args)
        {
            bool a = 'A' > 'K';
            Console.WriteLine(a);
            //Console.WriteLine("Please enter 3numbers or letters in (2,3,4,5,6,7,8,9,10,J,Q,K,A):");
            //string player1 = Console.ReadLine();
            //Console.WriteLine("Please enter again for player2:");
            //string player2 = Console.ReadLine();
            //WhoistheWinner(player1, player2);
            Console.Read();
        }
    }
}
