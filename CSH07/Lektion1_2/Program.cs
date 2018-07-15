using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.Odbc;

namespace Lektion1_2
{
    class Program
    {
        public class OleDbConnectionTest
        {
            private OleDbConnection oleDBconnection;
            public OleDbConnectionTest()
            {
                oleDBconnection = new OleDbConnection(@"Data Source=AccessDemo.mdb;" + "Provider=Microsoft.Jet.OLEDB.4.0;");

                //List<string> MYTries = new List<string>();

                //OdbcConnectionStringBuilder A = new OdbcConnectionStringBuilder();

                //A.Driver = "MySQL ODBC 5.2 ANSI Driver";
                //A.Dsn = "LocalMySQL56";

                ////A.Driver = "DRIVER={MySQL ODBC 5.2w Driver};";
                ////A.


        //        MYTries.Add("Provider=MSDASQL;Driver={MySQL ODBC 5.2 ANSI Driver};Server=localhost;PORT = 3306" + "DATABASE = dbdemo2;UID = demo-user");
                //MYTries.Add("Driver=MySQL ODBC 5.2 ANSI Driver;Server=localhost;PORT = 3306;Database = dbdemo2; UID = demo-user ");

                //var odbcconnection = new OdbcConnection();

                //for (int idx = 0; idx < MYTries.Count; idx++)
                //{
                //    odbcconnection.ConnectionString = MYTries[idx];

                //    odbcconnection.Open();
                //}

                //odbcconnection.ConnectionString = A.ConnectionString;

                string newLine = Environment.NewLine;

                try
                {
                    oleDBconnection.Open();
                    MessageBox.Show("Die Verbindung wurde" + "erfolgreich hergestellt" + newLine + "Datenbank:" + oleDBconnection.Database + newLine + "Datenquelle:" + oleDBconnection.DataSource + newLine + "Provider:" + oleDBconnection.Provider + newLine + "Status:" + oleDBconnection.State,"Info");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + newLine + "Bitte ConnectionString-Parameter überprüfen");

                }
                finally
                {
                    oleDBconnection.Close();
                    Console.WriteLine("Verbindung geschlossen");
                }
            }
            static void Main(string[] args)
            {
                new OleDbConnectionTest();
            }

        }
    }
}
