using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace Lektion2_1
{
    public partial class MySqlAbfrage : Form

    {
        private OdbcConnection odbcconnection;
        private OdbcCommand odbcommand;
        private OdbcDataReader odbcreader;
        public MySqlAbfrage()
        {
            InitializeComponent();

            this.odbcconnection = new OdbcConnection();
            
            OdbcConnectionStringBuilder A = new OdbcConnectionStringBuilder();
            
            A.Dsn = "LocalMySQL56";
            
            odbcconnection.ConnectionString = A.ConnectionString;

        }

        private void buttonAbfrage_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// vorhandenen Einträge in der listbox entfernen.
            string sqlcommand = textBox1.Text.Trim();
            odbcommand = new OdbcCommand(sqlcommand, odbcconnection);//initialisierung des command-objekts.

            odbcconnection.Open();//connection Öffnen
            if (sqlcommand.ToUpper().StartsWith("SELECT"))
            {
                try//zu viele Ausnahmen!!!!!!!!
                {

                    this.odbcreader = odbcommand.ExecuteReader();
                    int spalten = odbcreader.FieldCount;//fieldcount Eigenschaft:Infors ,wie viel Spalten mit Daten bei Ausführung der SQL-Anweisung zurückgeben.
                    string spaltenname = "";
                    for (int i = 0; i < spalten; i++)
                    {
                        spaltenname += odbcreader.GetName(i) + "\t";//Getname Methode liefert die Spaltenüberschriften.
                    }
                    listBox1.Items.Add(spaltenname);
                    listBox1.Items.Add("");
                    while (odbcreader.Read())//read-methode liefert true ,solange noch weitere Zeilen vorhanden sind.anderenfalls false.
                    {
                        string zeile = "";
                        for (int j = 0; j < spalten; j++)
                        {
                            zeile += odbcreader.GetValue(j).ToString() + "\t";

                        }
                        listBox1.Items.Add(zeile);
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add(ex.GetType() + ":" + ex.Message);//Ausnahmetyp und die von der Ausnahme generierte Meldung.
                }


                finally
                {
                    this.odbcconnection.Close();
                   
                }
            }
            else
            {
                try
                {
                    int rows = odbcommand.ExecuteNonQuery();
                    listBox1.Items.Add(rows + "betroffene Datensätze");
                }
                catch(Exception exc)
                {
                    listBox1.Items.Add(exc.GetType() + exc.Message);
                }
                finally
                {
                    this.odbcconnection.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MySqlAbfrage_Load(object sender, EventArgs e)
        {

        }
    }
}
