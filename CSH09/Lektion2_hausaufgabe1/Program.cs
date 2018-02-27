using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Lektion2_hausaufgabe1
{
    class Article
    {
        public UInt32 id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string size {get; set; }
        public string color { get; set; }
        public UInt32 menge { get; set; }
        private double price;
        public double Price
        { get { return price; }
            set { if (value >= 0)
                { price = value; }
            else
                {
                    throw new ArgumentException("Der Preis darf nicht negativ sein!");
                }
            } }
        public override string ToString()
        {
            return name + "(" + description + ")" + size + ":" + Price + "$";

        }

    }
    class Program
    {
        List<Article> artikellist = new List<Article> { };
        OdbcConnection odbcConnection;
        OdbcDataReader AccessDb()
        {
            string sqlString = "SELECT name,beschreibung,groesse,preis FROM artikel";
            string sqlstring1 = "SELECT * FROM artikel";
            string ConnectionString = "Dsn=LocalMySQL56;Driver=MySQL ODBC 3.51 Driver;";
            odbcConnection = new OdbcConnection(ConnectionString);
            odbcConnection.Open();
            OdbcCommand cmd = new OdbcCommand(sqlstring1, odbcConnection);
            return cmd.ExecuteReader();
        }
        void read()
        {
            OdbcDataReader reader = this.AccessDb();
            while (reader.Read())
            {

                artikellist.Add(new Article
                {
                    id = (uint)reader.GetInt32(0),
                    name = reader.GetString(1),
                    description = reader.GetString(2),
                    size = reader.GetString(3),
                    color = reader.GetString(4),
                    menge = (uint)reader.GetInt32(5),
                    Price = reader.GetDouble(6)
                })
                ;
                ReadArticles();

            }
            foreach (Article a in artikellist)
            {
                Console.WriteLine(a);
            }
            odbcConnection.Close();


        }
        public void ReadArticles()
        {
            int index = artikellist.Count()-1;
            Console.WriteLine( "artikellist.Add(new Article{ id= "+artikellist[index].id+
                ", name =\" "+artikellist[index].name
                +"\",description = \""+artikellist[index].description+"\",size = \""
                +artikellist[index].size+"\",color = \""+artikellist[index].color+"\", menge = "
                +artikellist[index].menge+", Price = "+artikellist[index].Price+"})");
            
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            test.read();
           
            Console.Read();
        }
    }
}
