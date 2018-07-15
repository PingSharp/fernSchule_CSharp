using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;


namespace Lektion3
{   [Table]
    class Categories
    {   [Column(Name ="CategoryName",CanBeNull =false)]
        public string Produktgruppe { get; set; }
        [Column(Name ="Description")]
        public string Beschreibung { get; set; }
        public override string ToString()
        {
            string returnstring = "Produktgruppe "+Produktgruppe+"("+Beschreibung+")";
            return returnstring;
        }
    }
    [Table(Name ="Customers")]
    class  Customer
    {
        [Column(IsPrimaryKey =true)]
        public string CustomerID { get; set; }
        [Column(CanBeNull =false)]
        public string CompanyName { get; set; }
        [Column]
        public string ContactName { get; set; }
        [Column]
        public string ContactTitle { get; set; }
        [Column(Name ="Address")]
        public string Adress { get; set; }
        [Column]
        public string City { get; set; }
        [Column]
        public string Region { get; set; }
        [Column]
        public string PostalCode { get; set; }
        [Column]
        public string Country { get; set; }
        [Column]
        public string Phone { get; set; }
        [Column]
        public string Fax { get; set; }
    }
    class Program
    {
        List<Customer> customers = new List<Customer> { };
        
        private string connectionstring = Properties.Settings.Default.NORTHWINDConnectionString;
        void readcustomers()
        {
            
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand sqlcmd = connection.CreateCommand();
            sqlcmd.CommandText = "SELECT CustomerID,ContactName,City FROM dbo.Customers";
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while(reader.Read())
            {
                customers.Add(new Customer {CustomerID=reader.GetString(0),ContactName=reader.GetString(1),City=reader.GetString(2) });

            }
            foreach(Customer c in customers)
            {
                Console.WriteLine("CustomerID:{0} ContactName:{1} City:{2}",c.CustomerID,c.ContactName,c.City);
            }

        }
        static void readCategories()
        {

            DataContext dataContext = new DataContext(Properties.Settings.Default.NORTHWINDConnectionString);


            var results = dataContext.GetTable<Categories>().Select(x => x).ToArray();


            var results1 = dataContext.GetTable<Categories>().Select(c => new Categories { Produktgruppe = c.Produktgruppe, Beschreibung = c.Beschreibung });
            foreach(Categories c in results)
            {
                Console.WriteLine(c);
            }
        }
       void DistinctCities()
        {
            DataContext dataContext = new DataContext(connectionstring);
            //var cities = (from customer in dataContext.GetTable<Customer>() select customer.City).Distinct();

            var cities = dataContext.GetTable<Customer>().Select(c => c.City).Distinct();
            dataContext.Log = Console.Out;
            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(dataContext.CommandTimeout);
        }
        void CustomersIn(string city)
        {
            DataContext dataContext = new DataContext(connectionstring);
            dataContext.Log = Console.Out;
            //var peopleinthecity = from customer in dataContext.GetTable<Customer>() where customer.City == city select customer.ContactName;
            var peopleinthecity = dataContext.GetTable<Customer>().Where(c => c.City == city).Select(c => c.ContactName);
            Console.WriteLine(" city {0} hat :",city);
            foreach(string s in peopleinthecity)
            {
                Console.WriteLine(s);
            }
            
           
        }
        static void Main(string[] args)
        {
            Program test = new Program();
            //test.readcustomers();
            //test.DistinctCities();
            readCategories();
            //test.CustomersIn("Köln");
            Console.Read();
        }
    }
}
