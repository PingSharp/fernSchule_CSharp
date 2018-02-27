using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Lektion1
{
   
    class Article
    {
        public string name;
        public string description;
        public string size { private get; set; }
        private double price;
        public void SizeAusagbe()
        {
            Console.WriteLine("Artikel '{0}' mit der Größe '{1}' erzeugt",name,size);
        }
        public Double Price
        {

            set
            {
                //price = value;
                if(value <0)
                {
                    throw new ArgumentException("Der preis darf nicht negativ sein!");
                }
                else
                {
                    price = value;
                }
            }
            get
            {
                return price;
            }
            
        }
       
    }
   
class Program
    {

        Article[] articels = new Article[] 
        {
            new Article { name ="T-Shirt", description = "Tank Top",size="Small",Price=
                19.99 },
            new Article { name ="T-Shirt", description = "V-neck",size="Medium",Price=24.99 },
            new Article { name ="T-Shirt", description = "Crew Neck",size="universal",Price=29.99 },
            new Article { name ="Baseballmütze", description = "Baumwolle",size="universal",Price=9.8 },
            new Article { name ="Baseballmütze", description = "Wollmütze",size="universal",Price=10.9 },
            new Article { name ="Mützenschirm", description = "Kunststoffschirm",size="universal",Price=3.5 },
            new Article { name ="Mützenschirm", description = "Stoffschirm",size="universal",Price=4.5 },
            new Article { name ="Sweatshirt", description = "Kapuzenshirt",size="Large",Price=34.8 },
            new Article { name ="Sweatshirt", description = "normal",size="Large",Price=24.8 },
            new Article { name ="Hosen", description = "Baumwollhosen",size="Medium",Price=65.9 },

        };


        void SelectArticles(int @case)
        {

            //var result;
           switch (@case)
            {
              
                case 1:
                    var result1 = from a in articels where a.Price < 10 select   a.description ;
                    Console.WriteLine("from a in articles where a.price < 10 select a.description:");
                    foreach(string s in result1)
                    {
                        Console.WriteLine(s);
                    }
                    break;
                case 2:
                    var result2 = from a in articels where a.Price < 10 select new { description = a.description, price = a.Price };
                    for (int i = 0;i < result2.Count();i++)
                    {
                        Console.WriteLine("Beschreibung={0,-20} Preis={1}", result2.ElementAt(i).description, result2.ElementAt(i).price);
                    }
                    break;
            }
        }

        OdbcConnection odbcConnection;
        OdbcDataReader AccessDb()
        {
            string sqlString = "SELECT name,beschreibung,groesse,preis FROM artikel";
            string sqlstring1 = "SELECT * FROM artikel WHERE farbe='weiss AND groesse='universal'";
            string ConnectionString = "Dsn=LocalMySQL56;Driver=MySQL ODBC 3.51 Driver;";
            odbcConnection = new OdbcConnection(ConnectionString);
            odbcConnection.Open();
            OdbcCommand cmd = new OdbcCommand(sqlString, odbcConnection);
            return cmd.ExecuteReader();
        }
        void read()
        {
            OdbcDataReader reader = this.AccessDb();
            //for (int i = 0; i < reader.FieldCount; i++)
            //{
            //    Console.Write(reader.GetName(i) + "   ");

            //}
            //while (reader.Read())
            //{

            //    try
            //    {

            //        Console.WriteLine(Environment.NewLine);
            //        for (int j = 0; j < reader.FieldCount; j++)
            //        {
            //            Console.Write(reader.GetValue(j).ToString()+"   ");
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.GetType() + ex.Message);

            //    }

            //}
            while (reader.Read())
            {
                Console.Write("new Article {{ name =\"{0}\", ", reader.GetString(0));
                Console.Write("description = \"{0}\",", reader.GetString(1));
                Console.Write("size=\"{0}\",", reader.GetString(2));
                Console.Write("price={0} }},", reader.GetString(3));
                Console.WriteLine();
            }
            odbcConnection.Close();


        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.read();
            test.SelectArticles(2
                );
            //var person = new { Vorname = "Beth", Nachname = "Reiser", Straße = "Whippany" };
            //Console.WriteLine( person.Straße);
            var artikel = new Article { name = "T-Shirt", description = "V-neck", size = "M", Price = 19.90 };

            artikel.SizeAusagbe();

            Console.ReadLine();
        }
    }
}

        

