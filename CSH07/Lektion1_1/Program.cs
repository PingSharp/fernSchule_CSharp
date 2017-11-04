using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Lektion1_1
{
    public class OdbcConnectionTest
    {
        private OdbcConnection odbcconnection;
        public OdbcConnectionTest()
        {
            odbcconnection = new OdbcConnection();

            //List<string> MYTries = new List<string>();

            OdbcConnectionStringBuilder A = new OdbcConnectionStringBuilder();

            A.Driver = "MySQL ODBC 3.51 Driver;";
            A.Dsn = "LocalMySQL56";
            //odbcconnection.ConnectionTimeout = 30;

            //A.Driver = "DRIVER={MySQL ODBC 5.2 ANSI Driver};";
            ////A.


            //MYTries.Add("Provider=MSDASQL;Driver={MySQL ODBC 5.2 ANSI Driver};Server=localhost;PORT = 3306" + "DATABASE = dbdemo2;UID = demo-user");
            //MYTries.Add("Driver={MySQL ODBC 5.2 ANSI Driver};Server=localhost;PORT = 3306;Database = dbdemo2; UID = demo-user ");


            /*
            for (int idx = 0; idx < MYTries.Count; idx++)
            {
                odbcconnection.ConnectionString = MYTries[idx];
            }
            */
            odbcconnection.ConnectionString = "Dsn=LocalMySQL56;Driver=MySQL ODBC 3.51 Driver;"; // A.ConnectionString;

            string newLine = Environment.NewLine;

            try
            {
                odbcconnection.Open();
                MessageBox.Show("Die Verbindung wurde" + "erfolgreich hergestellt" + 
                    newLine + "Server Version:" + odbcconnection.ServerVersion + newLine 
                    + "Datenquelle:" + odbcconnection.DataSource + newLine + "Datenbank:"
                    + odbcconnection.Database +newLine+ 
                    "Connectiontimeout:"+ odbcconnection.ConnectionTimeout);

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + newLine + "Bitte ConnectionString-Parameter überprüfen");

            }
            finally
            {
                odbcconnection.Close();
                Console.WriteLine("Verbindung geschlossen");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new OdbcConnectionTest();
            Console.ReadLine();
        }
    }
}
