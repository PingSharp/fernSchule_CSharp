using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ESA_2
{
    class Program
    {
        public void ESA2In(string pfad,byte[] array)
        {
           
        StreamWriter write = new StreamWriter(File.Open(pfad,FileMode.Create));
            for (int idx = 0; idx < array.Length; idx++)
            {

                if (idx > 0 && idx % 11 == 0)
                {
                    write.WriteLine();
                    write.Write(array[idx].ToString());
                    write.Write(",");
                }
                else
                {
                    write.Write(array[idx].ToString());
                    write.Write(",");
                }
            }
            write.Close();
        }
        public void ESAOut(string path)
        {
            StreamReader read = new StreamReader(File.Open(path, FileMode.Open));
            bool Continue = true;
            
            while (Continue){

                try
                {

                    string string1 = read.ReadLine();

                    byte[] Zeichen_AsASCII = string1.Split(',').Where(x => !x.Equals("")).Select(x => Convert.ToByte(x)).ToArray();

                    Console.WriteLine(System.Text.Encoding.ASCII.GetString(Zeichen_AsASCII));
                    
                    
                }
                catch (NullReferenceException e)
                {
                    Continue = false;
                }
            }
            
            read.Close();
        }
        static void Main(string[] args)
        {
            Program test = new Program();
           
            string pfad = @".\ESA2.txt";
            byte[] array = {32, 32, 67, 67, 32, 32, 32, 35, 32, 35, 32,
                32, 67, 32, 32, 67, 32, 32, 35, 32, 35, 32,
                67, 32, 32, 32, 32, 32, 35, 35, 35, 35, 35,
                67, 32, 32, 32, 32, 32, 32, 35, 32, 35, 32,
                67, 32, 32, 32, 32, 32, 35, 35, 35, 35, 35,
                32, 67, 32, 32, 67, 32, 32, 35, 32, 35, 32,
                32, 32, 67, 67, 32, 32, 32, 35, 32, 35, 32 };
            test.ESA2In(pfad, array);
            test.ESAOut(pfad);
            Console.ReadKey();
        }
    }
}
