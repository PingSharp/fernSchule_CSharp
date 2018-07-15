using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromeNumber
{
    class Program
    {
        public static String DecimalToFraction(double dec)
        {
            string str = dec.ToString();
            if (str.Contains(','))
            {
                String[] parts = str.Split(',');
                long whole = long.Parse(parts[0]);
                long numerator = long.Parse(parts[1]);
                long denominator = (long)Math.Pow(10, parts[1].Length);
                long divisor = GCD(numerator, denominator);
                long num = numerator / divisor;
                long den = denominator / divisor;

                String fraction = num + "/" + den;
                if (whole > 0)
                {
                    return whole + " " + fraction;
                }
                else
                {
                    return fraction;
                }
            }
            else
            {
                return str;
            }
        }

        public static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        //static void palindrome (string num)
        //{

        //    if (num.Length == 1)
        //    {
        //        Console.Write("one digit palindrome number.");

        //    }
        //    else
        //    {
        //        List<char> char1 = new List<char> { };
        //        List<char> char2 = new List<char> { };

        //        char[] strings = num.ToCharArray(0,num.Length);
        //       if(strings.Length%2==0)
        //        {

        //            for(int i = 0;i<strings.Length/2;i++)
        //            {
        //                char1.Add(strings[i]);
        //                char2.Add(strings[strings.Length - (i + 1)]);
        //            }
        //            if(char1.SequenceEqual(char2))
        //            {
        //                Console.WriteLine("{0} is a palindrome number.", num);
        //            }
        //            else
        //            {
        //                Console.WriteLine("{0} is not a palindrome number.", num);
        //            }


        //        }
        //       else
        //        {
        //            for(int i = 0;i < (strings.Length-1)/2;i++)
        //            {
        //                char1.Add(strings[i]);
        //                char2.Add(strings[strings.Length - (i + 1)]);
        //            }
        //            if (char1.SequenceEqual(char2))
        //            {
        //                Console.WriteLine("{0} is a palindrome number.", num);
        //            }
        //            else
        //            {
        //                Console.WriteLine("{0} is not a palindrome number.", num);
        //            }
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            DecimalToFraction(0.75);
            //Console.WriteLine("Please enter a number:");
            //string num = Console.ReadLine();
            
            //if(num.Reverse<char>().SequenceEqual(num))
            //{
            //    Console.WriteLine("{0} is a palindrome number.", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a palindrome number.", num);
            //}
            Console.Read();
        }
    }
}
