using System;
using System.Linq;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Models.NORTHWINDContext();

            var cust = t.Employees.Where(x => x.Country.Equals("UK")).OrderBy(x => x.LastName).ToList();

            // sind 4!
            int custNo = cust.Count;

            var cust0 = cust.First();

            cust0.Country = "Germany";
            t.Update(cust0);
            t.SaveChanges();

            cust = t.Employees.Where(x => x.Country.Equals("UK")).OrderBy(x => x.LastName).ToList();

            // ok nun gibt es nur noch 3!!!
            custNo = cust.Count;

            cust0 = t.Employees.Where(x => x.Country.Equals("Germany")).First();

            cust0.Country = "UK";
            t.Update(cust0);
            t.SaveChanges();

            cust = t.Employees.Where(x => x.Country.Equals("UK")).OrderBy(x => x.LastName).ToList();

            // ok nun haben wir wieder 4!!!
            custNo = cust.Count;


            Console.Read();
        }
    }
}
