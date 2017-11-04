using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileBeispiele
{
    class Program
    {
        public void BinaryWrite(string path,int[] content)
        {

            BinaryWriter writer = new BinaryWriter(File.Open(path,FileMode.Create));
            for (int i = 0; i < content.Length; i++)
            {
                writer.Write(content[i]);
            }
            writer.Close();
        }
        public void BinaryRead(string path)
        {
            BinaryReader reader = new BinaryReader(File.Open(path,FileMode.Open));
            bool goOn = true;
            while (goOn)
            {
                try
                {
                    Console.WriteLine("{0}", reader.ReadInt16());
                }
                catch (EndOfStreamException e)
                {
                    goOn = false;
                }
            }           
            //for(int i = 0;i < 3;i++)
            //{
            //    Console.WriteLine(reader.ReadInt32());
            //}
            
            //Console.WriteLine(reader.ReadInt16());
            reader.Close();
            Console.WriteLine();
        }
        public void WriterNutzen(string pfad,string content)
        {
            StreamWriter writer = new StreamWriter(File.Open(pfad,FileMode.Create));
            writer.WriteLine(content);
            writer.Close();
        }
        public void ReaderNutzen(string pfad)
        {
            StreamReader reader = new StreamReader(File.Open(pfad, FileMode.Open));
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();

            //Console.WriteLine(reader.ReadLine());
            reader.Close();
        }
        public void DateiLesen(string pfad)
        {
            FileStream stream = File.Open(pfad, FileMode.Open);
         
            byte[] array = new byte[stream.Length];
             int result = stream.Read(array,0,(int)stream.Length);
            Console.Write("rueckgabewerte:{0}",result);
            //for (int i = 0;i < array.Length;i++)
            //{
            //    Console.Write((Char) array[i]);
            //}
            Console.WriteLine();
            stream.Close();
        }
        public void DateiErstellen(string pfad,byte[] array)
        {
            FileStream stream = File.Open(pfad,FileMode.Create);
            stream.Write(array,0,array.Length);
            stream.Close();
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            string pfad = @"D:\Dokumente\Ping\fernstudium\betreuen1.txt";
            int[] pos = {1500,3300,2600 };
            test.BinaryWrite(pfad,pos);
            //test.ReaderNutzen(pfad);
            test.BinaryRead(pfad);
            //string content = @"Dieser Text wird Inhalt der Datei.Er enthält Zeilenumbrüche und eine Pfadangabe:E:\CSH-Lehrgang\CSH03\Musterdatei.txt";
            //test.WriterNutzen(pfad, content);
            //test.ReaderNutzen(pfad);
            //byte[] array = { 69, 98, 117, 102, 106 };
            //test.DateiErstellen(pfad,array);
            //FileStream a = File.Open(@"D:\Dokumente\Ping\fernstudium\betreu.txt", FileMode.Create);
            // Console.WriteLine("{0}",a);
            //test.DateiLesen(pfad);
            Console.ReadLine();
        }
    }
}
