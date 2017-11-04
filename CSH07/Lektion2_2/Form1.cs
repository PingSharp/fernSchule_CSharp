using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Lektion2_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonAbfrage_Click(object sender, EventArgs e)
        {
            
            //textBoxSQL.Enabled = false;
            
            //textBoxTable.Enabled = false;
            string sqlcmd = "Select * FROM " + comboBox1.SelectedItem.ToString() ;
            tableName = textBoxTable.Text;
            string tabellename = textBoxTable.Text.Trim();
            //odbcDataAdapter1 = new OdbcDataAdapter(sqlcmd, odbcConnection);
            //OdbcCommandBuilder cmdbuilder = new OdbcCommandBuilder(odbcDataAdapter1);

            //Console.WriteLine("CommandBuilder InsertCommand:" + cmdbuilder.GetInsertCommand().CommandText);
            //Console.WriteLine("CommandBuilder DeleteCommand:" + cmdbuilder.GetDeleteCommand().CommandText);
            //Console.WriteLine("CommandBuilder UpdateCommand:" + cmdbuilder.GetUpdateCommand().CommandText);
            //Console.ReadLine();

            if (sqlcmd.Equals(""))
            {
                toolStripStatusLabel1.Text = "Bitte eine SQL-Anweisung eingeben";
            }
            else
            {
                //dataSet1.Clear();
                DataTableCollection tablecollection = dataSet1.Tables;
                DataTable table = tablecollection[tabellename];
                if(table != null)
                {
                    table.Clear();
                }
                
                odbcSelectCommand2.CommandText = sqlcmd;

                try
                {
                    if(tabellename == "")
                    {
                        odbcConnection.Open();



                        odbcSelectCommand2.Connection = odbcConnection;

                        odbcDataAdapter1.SelectCommand = odbcSelectCommand2;


                        odbcDataAdapter1.Fill(dataSet1);
                        toolStripStatusLabel1.Text = "Dataset gefüllt";

                    }
                    else
                    {
                        odbcConnection.Open();



                        odbcSelectCommand2.Connection = odbcConnection;

                        odbcDataAdapter1.SelectCommand = odbcSelectCommand2;


                        odbcDataAdapter1.Fill(dataSet1,tabellename);
                        toolStripStatusLabel1.Text = "Tabelle gefüllt";
                    }
                    
                    
                    
                    

                }
                catch(Exception ex)
                {
                    toolStripStatusLabel1.Text = "Datenbankfehler";
                    MessageBox.Show(ex.GetType() +Environment.NewLine+  ex.Message,"Datenbakfehler");
                }
                finally
                {
                    odbcConnection.Close();
                }
            }
        }

        private void dataGrid_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.odbcConnection = new OdbcConnection();

            OdbcConnectionStringBuilder A = new OdbcConnectionStringBuilder();

            A.Dsn = "LocalMySQL56";

            odbcConnection.ConnectionString = A.ConnectionString;


            comboBox1.Items.Clear();
            comboBox1.Items.Add("abteilungen");
            comboBox1.Items.Add("angestellte");
            comboBox1.Items.Add("artikel");
            comboBox1.Items.Add("bestellpositionen");
            comboBox1.Items.Add("bestellungen");
            comboBox1.Items.Add("kontakte");
            comboBox1.Items.Add("kunden");
            comboBox1.Items.Add("lieferanten");
            comboBox1.Items.Add("personen");
            
        }
        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void odbcDataAdapter1_RowUpdated(object sender, OdbcRowUpdatedEventArgs e)
        {
            Console.WriteLine("SQL-Anweisung = " + e.Command.CommandText);
            Console.WriteLine("Statementtyp = " + e.StatementType);

            Console.WriteLine("Updating-Status = " + e.Status);
            //Console.WriteLine(e.Row.Table);

            //Console.WriteLine(e.Errors.HelpLink);
            //Console.WriteLine(e.Errors.HResult);
            //Console.WriteLine(e.Errors.InnerException);
            //Console.WriteLine(e.Errors.Message);
            //Console.WriteLine(e.Errors.Source);
            //Console.WriteLine(e.Errors.StackTrace);
            //Console.WriteLine(e.Errors.TargetSite);
            object[] items = e.Row.ItemArray;
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < items.Length;i++)
            {
                sb.Append(items[i]);
                sb.Append("");
            }
            if(e.Status.Equals(UpdateStatus.ErrorsOccurred))
            {
                e.Status = UpdateStatus.SkipCurrentRow;
                //Console.WriteLine("Update für diese Zeile nicht ausgeführt:\n\t" + sb.ToString());

            }
            else
            {
                //Console.WriteLine("Update für diese Zeile ausgeführt:\n\t" + sb.ToString());
            }
       }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        //private void datasetdump_Click(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Tabelleninhalt aus Datenbank" + "(dataSet):");
        //    this.Datenausgabe(dataSet1);
        //    DataSet dataSetChanges = dataSet1.GetChanges();
        //    if(dataSetChanges != null)
        //    {
        //        Console.WriteLine("Änderungen in den Tabellen" + "(datasetChanges):");
        //        this.Datenausgabe(dataSetChanges);
        //    }
            
        //}

        //private void Datenausgabe(DataSet dataset)
        //{
        //    Console.WriteLine("DataSet:" + dataSet1.DataSetName);
        //    foreach(DataTable thistable in dataSet1.Tables)
        //    {
        //        Console.WriteLine("TableName:" + thistable.TableName);
        //        foreach(DataRow thisrow in thistable.Rows)
        //        {
        //            foreach(DataColumn thiscolumn in thistable.Columns)
        //            {
        //                try
        //                {
        //                    Console.Write(thisrow[thiscolumn] + "\t");
        //                }
        //                catch(DeletedRowInaccessibleException drie)
        //                {
        //                    Console.Write("Zeile gelöscht");
        //                    break;
        //                }
        //            }
        //            Console.Write("[" + thisrow.RowState + "]\n");
        //        }
        //    }
        //}

        private void buttonBestellungen_Click(object sender, EventArgs e)
        {
            //textBoxSQL.Enabled = false;
            
            textBoxTable.Enabled = false;
            dataSet1.Reset();
            string tableKunden = "Kunden";
            string tableBestellungen = "Bestellungen";
            string tableArtikel = "Artikel";
        

            string sqlcmdkunden = "SELECT k.id, p.vorname,"
                +" p.nachname, p.plz, p.ort FROM kunden k,"
                +"personen p WHERE k.personID = p.id "
                +"ORDER BY p.nachname";
            string sqlcmdBestellungen = "SELECT b.id,"
                +"b.kundenID,b.datum,b.verkaeuferID,p.nachname FROM "
                + "bestellungen b,personen p,angestellte a WHERE b.verkaeuferID=a.id AND a.personID=p.id ORDER BY b.id";
            string sqlcmdartikel = "SELECT bp.bestellID,"
                +"bp.artikelID,a.name,a.groesse,a.farbe,"
                +"bp.menge FROM artikel a,bestellpositionen bp "
                +"WHERE a.id = bp.artikelID";
           
            try
            {
                

                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdkunden, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableKunden);
                //dataGrid.SetDataBinding(dataSet1, tableKunden);
                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdBestellungen, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableBestellungen);
                
                
                //dataGrid.SetDataBinding(dataSet1, tableBestellungen);
                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdartikel, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableArtikel);
                DataGridTableStyle dgtabstyle = new DataGridTableStyle();
                dgtabstyle.MappingName = tableBestellungen;
                DataGridTextBoxColumn dgtcol1 = new DataGridTextBoxColumn();
                dgtcol1.MappingName = "nachname";
                dgtcol1.ReadOnly = true;
                dgtcol1.HeaderText = "Verkäufer";
                DataGridTextBoxColumn dgtcol2 = new DataGridTextBoxColumn();
                dgtcol2.MappingName = "VerkaeuferID";
                dgtcol2.ReadOnly = true;
                dgtcol2.HeaderText = "VerkäuferID";
                dgtabstyle.GridColumnStyles.Add(dgtcol1);
                dgtabstyle.GridColumnStyles.Add(dgtcol2);
                dataGrid.TableStyles.Add(dgtabstyle);


                
                
                odbcConnection.Close();
            }
            catch(Exception ex)
            {
                toolStripStatusLabel1.Text = "Datenbankfehler!";
                MessageBox.Show(ex.GetType() + Environment.NewLine + ex.Message, "Datenbankfehler");


            }

            DataColumn column1 = dataSet1.Tables[tableKunden].Columns["id"];
            DataColumn column2 = dataSet1.Tables[tableBestellungen].Columns["kundenID"];
            DataRelation relation1 = new DataRelation("Bestellungen zum Kunden",column1,column2
                
                );
            DataColumn column3 = dataSet1.Tables[tableBestellungen].Columns["id"];
            DataColumn column4 = dataSet1.Tables[tableArtikel].Columns["bestellID"];
            DataRelation relation2 = new DataRelation("Artikel zum bestellungen", column3, column4);

            DataColumn column5 = dataSet1.Tables[tableArtikel].Columns["artikelID"];
            DataColumn column6 = dataSet1.Tables[tableArtikel].Columns["bestellID"];
            DataRelation relation3 = new DataRelation("Bestellungen zum Artikel", column5, column6);

            dataSet1.Relations.Add(relation1);
            dataSet1.Relations.Add(relation2);
            //dataSet1.Relations.Add(relation3);
            

        }
        private string tableName;
        private void buttonupdate_Click(object sender, EventArgs e)
        {
            this.odbcUpdateCommand2.Connection = odbcConnection;
            this.odbcDeleteCommand2.Connection = odbcConnection;
            this.odbcInsertCommand2.Connection = odbcConnection;
            odbcConnection.Open();

            this.odbcUpdateCommand2.CommandText = "UPDATE personen SET vorname=?,nachname=?,strasse=?,hausnummer=?,ort=?,land=?,plz=?,telefon=? WHERE id=?";
            this.odbcInsertCommand2.CommandText = "INSERT INTO personen (id,vorname,nachname,strasse,hausnummer,ort,land,plz,telefon) VALUES (NULL,?,?,?,?,?,?,?,?)";
            this.odbcDeleteCommand2.CommandText = "DELETE FROM personen WHERE id=?";
            this.odbcDeleteCommand2.Parameters.Add(new OdbcParameter("P1", OdbcType.Int, 0, "id"));
            this.odbcUpdateCommand2.Parameters.AddRange(new OdbcParameter[] {new OdbcParameter("P1", OdbcType.VarChar, 0, "vorname"), new OdbcParameter("P2", OdbcType.VarChar, 0, "nachname"),new OdbcParameter("P3",OdbcType.VarChar,0,"strasse"),
            new OdbcParameter("P4",OdbcType.VarChar,0,"hausnummer"),new OdbcParameter("P5",OdbcType.VarChar,0,"ort"),new OdbcParameter("P6",OdbcType.Char,0,"land"),new OdbcParameter("P7",OdbcType.VarChar,0,"plz"),new OdbcParameter("P8",OdbcType.VarChar,0,"telefon"),new OdbcParameter("P9",OdbcType.Int,0,"id") });
            this.odbcInsertCommand2.Parameters.AddRange(new OdbcParameter[] { new OdbcParameter("P1", OdbcType.VarChar, 0, "vorname"), new OdbcParameter("P2", OdbcType.VarChar, 0, "nachname"),new OdbcParameter("P3",OdbcType.VarChar,0,"strasse"),
            new OdbcParameter("P4",OdbcType.VarChar,0,"hausnummer"),new OdbcParameter("P5",OdbcType.VarChar,0,"ort"),new OdbcParameter("P6",OdbcType.Char,0,"land"),new OdbcParameter("P7",OdbcType.VarChar,0,"plz"),new OdbcParameter("P8",OdbcType.VarChar,0,"telefon")});
            odbcDataAdapter1.InsertCommand = odbcInsertCommand2;
            odbcDataAdapter1.UpdateCommand = odbcUpdateCommand2;
            odbcDataAdapter1.DeleteCommand = odbcDeleteCommand2;
            try
            {
                
                if(tableName.Equals(""))
                {
                    odbcDataAdapter1.Update(this.dataSet1);
                    toolStripStatusLabel1.Text = "DataSet Komplett-Update";
                }
                else
                {
                    odbcDataAdapter1.Update(this.dataSet1, tableName);
                    toolStripStatusLabel1.Text = "Update DataSet-Tabelle \"" + tableName + "\"";

                }
            }
            catch(Exception exc)
            {
                toolStripStatusLabel1.Text = "Datenbankfehler!";
                MessageBox.Show(exc.GetType() + Environment.NewLine + exc.Message, "Datenbankfehler");

            }
            finally
            {
                this.odbcConnection.Close();

            }
        }

        private void labelTable_Click(object sender, EventArgs e)
        {

        }

        private void buttonsuche_Click(object sender, EventArgs e)
        {
            string nachname = textBox1.Text.Trim();
            textBoxTable.Enabled = false;
            dataSet1.Reset();
            string tableKunden = "Kunden";
            string tableBestellungen = "Bestellungen";
            string tableArtikel = "Artikel";


            string sqlcmdkunden = "SELECT k.id, p.vorname,"
                + " p.nachname, p.plz, p.ort FROM kunden k,"
                + "personen p WHERE k.personID = p.id AND p.nachname = " +"'"+nachname +"'" ;
            string sqlcmdBestellungen = "SELECT k.personID, k.id,p.id,p.nachname,b.id,"
                + "b.kundenID,b.datum,b.verkaeuferID FROM personen p,kunden k,"
                + "bestellungen b WHERE b.kundenID = k.id AND p.nachname = "+"'" +nachname+"'" +"AND p.id = k.personID";
            string sqlcmdartikel = "SELECT bp.bestellID,"
                + "bp.artikelID,a.name,a.groesse,a.farbe,"
                + "bp.menge FROM artikel a,bestellpositionen bp "
                + "WHERE a.id = bp.artikelID";

            try
            {
                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdkunden, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableKunden);
                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdBestellungen, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableBestellungen);
                odbcDataAdapter1.SelectCommand = new OdbcCommand(sqlcmdartikel, odbcConnection);
                odbcDataAdapter1.Fill(dataSet1, tableArtikel);

                odbcConnection.Close();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Datenbankfehler!";
                MessageBox.Show(ex.GetType() + Environment.NewLine + ex.Message, "Datenbankfehler");


            }

            DataColumn column1 = dataSet1.Tables[tableKunden].Columns["id"];
            DataColumn column2 = dataSet1.Tables[tableBestellungen].Columns["kundenID"];
            DataRelation relation1 = new DataRelation("Bestellungen zum Kunden", column1, column2

                );
            DataColumn column3 = dataSet1.Tables[tableBestellungen].Columns["id"];
            DataColumn column4 = dataSet1.Tables[tableArtikel].Columns["bestellID"];
            DataRelation relation2 = new DataRelation("Artikel zum bestellungen", column3, column4);

            DataColumn column5 = dataSet1.Tables[tableArtikel].Columns["artikelID"];
            DataColumn column6 = dataSet1.Tables[tableArtikel].Columns["bestellID"];
            DataRelation relation3 = new DataRelation("Bestellungen zum Artikel", column5, column6);

            dataSet1.Relations.Add(relation1);
            dataSet1.Relations.Add(relation2);
        }
    }
}
