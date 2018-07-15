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

namespace Lektion4_2
{
    public partial class Form1 : Form
    {
        private OdbcDataReader datareader;
        private string kundenvorname;
        private string kundennachname;
        private int kundenID;
        private string tableName = "Artikel";
        private bool update = false;
        private int verkaeuferID = 184;
        int bestellID = 0;
        string newcol = "Bestellmenge";
        private string message = "";
        string datestring = DateTime.Now.ToString("yyyy-MM-dd");

        private void ArtikelLaden()
        {
            DataTable thistable = dataSet1.Tables[tableName];
            if(thistable != null)
            {
                thistable.Clear();

            }
            string sqlcmd = "SELECT a.id,a.name,a.beschreibung,a.groesse,a.farbe,a.preis,a.menge FROM personen p,kunden k,artikel a,bestellpositionen bp,bestellungen b WHERE k.id=" 
                + kundenID.ToString() + " AND k.personID=p.id AND b.kundenID=k.id AND b.id=bp.bestellID AND bp.artikelID=a.id GROUP BY a.id ORDER BY a.id";
            odbcSelectCommand1.Connection = odbcConnection1;
            odbcSelectCommand1 = new OdbcCommand(sqlcmd, odbcConnection1);
            odbcDataAdapter1.SelectCommand = odbcSelectCommand1;
           
            odbcDataAdapter1.Fill(dataSet1,tableName);
            dataGrid.SetDataBinding(dataSet1, tableName);
            StatusLabel1.Text = "Dataset gefüllt";
            if(!update)
            {
                dataSet1.Tables[tableName].Columns.Add(newcol);
                DataGridTableStyle dgtabstyle = new DataGridTableStyle();
                dgtabstyle.MappingName = tableName;

                DataGridTextBoxColumn dgtcol1 = new DataGridTextBoxColumn();
                dgtcol1.MappingName = "id";
                dgtcol1.ReadOnly = true;
                dgtcol1.HeaderText = "Artikel-ID";
                DataGridTextBoxColumn dgtcol2 = new DataGridTextBoxColumn();
                dgtcol2.MappingName = "name";
                dgtcol2.ReadOnly = true;
                dgtcol2.HeaderText = "Artikel";
                DataGridTextBoxColumn dgtcol3 = new DataGridTextBoxColumn();
                dgtcol3.MappingName = "beschreibung";
                dgtcol3.ReadOnly = true;
                dgtcol3.HeaderText = "Beschreibung";
                DataGridTextBoxColumn dgtcol4 = new DataGridTextBoxColumn();
                dgtcol4.MappingName = "groesse";
                dgtcol4.ReadOnly = true;
                dgtcol4.HeaderText = "Größe";
                DataGridTextBoxColumn dgtcol5 = new DataGridTextBoxColumn();
                dgtcol5.MappingName = "farbe";
                dgtcol5.ReadOnly = true;
                dgtcol5.HeaderText = "Farbe";
                DataGridTextBoxColumn dgtcol6 = new DataGridTextBoxColumn();
                dgtcol6.MappingName = "preis";
                dgtcol6.Format = "c";
                dgtcol6.Alignment = HorizontalAlignment.Right;
                dgtcol6.ReadOnly = true;
                dgtcol6.HeaderText = "Preis";
                DataGridTextBoxColumn dgtcol7 = new DataGridTextBoxColumn();
                dgtcol7.MappingName = "menge";
                dgtcol7.Alignment = HorizontalAlignment.Right;
                dgtcol7.ReadOnly = true;
                dgtcol7.HeaderText = "lieferbar";
                DataGridTextBoxColumn dgtcol8 = new DataGridTextBoxColumn();
                dgtcol8.MappingName = "Bestellmenge";
                dgtcol8.NullText = "";
                dgtcol8.Alignment = HorizontalAlignment.Right;
                dgtcol8.HeaderText = "Bestellmenge";



                dgtabstyle.GridColumnStyles.Add(dgtcol1);
                dgtabstyle.GridColumnStyles.Add(dgtcol2);
                dgtabstyle.GridColumnStyles.Add(dgtcol3);
                dgtabstyle.GridColumnStyles.Add(dgtcol4);
                dgtabstyle.GridColumnStyles.Add(dgtcol5);
                dgtabstyle.GridColumnStyles.Add(dgtcol6);
                dgtabstyle.GridColumnStyles.Add(dgtcol7);
                dgtabstyle.GridColumnStyles.Add(dgtcol8);
                dataGrid.TableStyles.Add(dgtabstyle);
                update = true;
                this.AcceptButton = this.buttonBestellen;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnmelden_Click(object sender, EventArgs e)
        {
            dataSet1.Clear();
            if(textBoxID.Text.Equals(""))
            {
                StatusLabel1.Text = "Bitte zur Anmeldung eine gültige Kunden-ID eingeben!";
                return;
            }
            try
            {
                kundenID = Int32.Parse(textBoxID.Text);
                textBoxVorname.Text = "";
                textBoxNachname.Text = "";
            }
            catch(Exception ex)
            {
                kundenID = 0;
                textBoxID.Text = "0";
                StatusLabel1.Text = "Kunden-ID-Wert ist keine Zahl";
                return;
            }
            odbcConnection1.Open();
            try
            {
                string sqlcmd = "SELECT p.vorname,p.nachname FROM personen p,kunden k WHERE k.id=" + kundenID.ToString() + " AND k.personID=p.id";
                odbcSelectCommand1.Connection = odbcConnection1;
                odbcSelectCommand1 = new OdbcCommand(sqlcmd,odbcConnection1);
                odbcDataAdapter1.SelectCommand = odbcSelectCommand1;
                odbcDataAdapter1.Fill(dataSet1);
                StatusLabel1.Text = "Dataset gefüllt"; ;
                datareader = odbcSelectCommand1.ExecuteReader();
                if(datareader.HasRows)
                {
                    
                    kundenvorname = datareader.GetString(0);
                    kundennachname = datareader.GetString(1);
                    textBoxVorname.Text = kundenvorname;
                    textBoxNachname.Text = kundennachname;
                    buttonBestellen.Enabled = true;
                    StatusLabel1.Text = "Anmeldung als Kunde " + kundenvorname + "" + kundennachname + "(ID=" + kundenID + ")";
                    datareader.Close();
                    dataGrid.CaptionText = "Bestellbare Artikel:";
                    ArtikelLaden();
                }
                else
                {
                    datareader.Close();
                    textBoxVorname.Text = "";
                    textBoxNachname.Text = "";
                    textBoxID.Text = "";
                    textBoxID.Focus();
                    StatusLabel1.Text = "Anmeldung ist nicht erfolgreich.";
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.GetType() + Environment.NewLine + exc.Message);
            }
            finally
            {
                odbcConnection1.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonBestellen.Enabled = false;
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            OdbcConnectionStringBuilder sbuilder = new OdbcConnectionStringBuilder();
            sbuilder.Dsn = "LocalMySQL56";
            odbcConnection1.ConnectionString = sbuilder.ConnectionString;

        }

        private void buttonBestellen_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO bestellungen VALUES(NULL," + kundenID + ",'" + datestring + "'," + verkaeuferID + ")";
            int neueID = 0;
            try
            {
                odbcConnection1.Open();
                odbcInsertCommand1 = new OdbcCommand(sqlInsert, odbcConnection1);
                odbcInsertCommand1.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType() + ex.Message);
                
            }
            finally
            {
                odbcConnection1.Close();
            }

            try
            {
                odbcConnection1.Open();

                string sqlselect = "SELECT id FROM bestellungen WHERE kundenID=" + kundenID + " AND verkaeuferID=" + verkaeuferID + " AND datum='" + datestring + "'";
                odbcSelectCommand1 = new OdbcCommand(sqlselect, odbcConnection1);
                datareader = odbcSelectCommand1.ExecuteReader();
                while(datareader.Read())
                {
                 
                    if ((neueID = datareader.GetInt32(0)) > bestellID )
                    {
                        bestellID = neueID;
                    }
                    Console.WriteLine("Die generierte BestellID:{0}", bestellID);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.GetType() + exc.Message);
            }
            finally
            {
                odbcConnection1.Close();
            }
            try
            {
                odbcConnection1.Open();

                string sqlupdatecmd = "UPDATE artikel SET menge=menge-? WHERE menge>=? AND id=?";
                odbcUpdateCommand1 = new OdbcCommand(sqlupdatecmd, odbcConnection1);
                odbcDataAdapter1.UpdateCommand = odbcUpdateCommand1;
                OdbcParameter p1 = new OdbcParameter("p1", OdbcType.Int, 11, newcol);
                OdbcParameter p2 = new OdbcParameter("p2", OdbcType.Int, 11, newcol);
                OdbcParameter p3 = new OdbcParameter("p3", OdbcType.Int, 11, "id");
                odbcUpdateCommand1.Parameters.Add(p1);
                odbcUpdateCommand1.Parameters.Add(p2);
                odbcUpdateCommand1.Parameters.Add(p3);

                

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.GetType() + Environment.NewLine + exc.Message);
            }
            try
            {
                
                odbcDataAdapter1.Update(dataSet1, tableName);
                StatusLabel1.Text = "Bestellung ausgeführt";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType() + Environment.NewLine + ex.Message);
            }
            try
            {
                BestellungLaden(bestellID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType() + Environment.NewLine + ex.Message);
            }
            odbcConnection1.Close();



        }
        private void BestellungLaden(int bestellID)
        {
                dataSet1.Clear();
                string tableName1 = "BestellArtikel";

                DataTable thistable = dataSet1.Tables[tableName1];
                this.bestellID = bestellID;
                dataGrid.CaptionText = "Diese Bestellung wurde verbucht:";
            
                string sqlcmd = "SELECT k.id,p.nachname,a.name,a.beschreibung,bp.menge,a.preis,bp.menge*a.preis FROM personen p,kunden k,bestellungen b,bestellpositionen bp,artikel a WHERE k.id=" + kundenID.ToString() + " AND k.personID=p.id AND b.kundenID=k.id AND b.id=bp.bestellID AND bp.artikelID=a.id AND b.id=" + bestellID;
                odbcSelectCommand1.Connection = odbcConnection1;
                odbcSelectCommand1 = new OdbcCommand(sqlcmd, odbcConnection1);
                odbcDataAdapter1.SelectCommand = odbcSelectCommand1;
                odbcDataAdapter1.Fill(dataSet1, tableName1);
                dataGrid.SetDataBinding(dataSet1, tableName1);
                StatusLabel1.Text = "Dataset gefüllt";
                
                    
                    DataGridTableStyle dgtabstyle = new DataGridTableStyle();
                    dgtabstyle.MappingName = tableName1;

                    DataGridTextBoxColumn dgtcol1 = new DataGridTextBoxColumn();
                    dgtcol1.MappingName = "id";
                    dgtcol1.ReadOnly = true;
                dgtcol1.HeaderText = "Kunden-ID";
                DataGridTextBoxColumn dgtcol2 = new DataGridTextBoxColumn();
                dgtcol2.MappingName = "nachname";
                dgtcol2.ReadOnly = true;
                dgtcol2.HeaderText = "Kunden";
                DataGridTextBoxColumn dgtcol3 = new DataGridTextBoxColumn();
                dgtcol3.MappingName = "name";
                dgtcol3.ReadOnly = true;
                dgtcol3.HeaderText = "Artikel";
                    DataGridTextBoxColumn dgtcol4 = new DataGridTextBoxColumn();
                dgtcol4.MappingName = "beschreibung";
                dgtcol4.ReadOnly = true;
                dgtcol4.HeaderText = "Beschreibung";
                DataGridTextBoxColumn dgtcol5 = new DataGridTextBoxColumn();
                dgtcol5.MappingName = "menge";
                dgtcol5.ReadOnly = true;
                dgtcol5.Alignment = HorizontalAlignment.Right;
                dgtcol5.HeaderText = "Menge";
                DataGridTextBoxColumn dgtcol6 = new DataGridTextBoxColumn();
                dgtcol6.MappingName = "preis";
                dgtcol6.ReadOnly = true;
                dgtcol6.Format = "c";
                dgtcol6.Alignment = HorizontalAlignment.Right;
                dgtcol6.HeaderText = "Preis";
                DataGridTextBoxColumn dgtcol7 = new DataGridTextBoxColumn();
                dgtcol7.MappingName = "bp.menge*a.preis";
                dgtcol7.ReadOnly = true;
                dgtcol7.Format = "c";
                dgtcol7.Alignment = HorizontalAlignment.Right;
                dgtcol7.HeaderText = "Gesamtpreis";

                dgtabstyle.GridColumnStyles.Add(dgtcol1);
                dgtabstyle.GridColumnStyles.Add(dgtcol2);
                dgtabstyle.GridColumnStyles.Add(dgtcol3);
                dgtabstyle.GridColumnStyles.Add(dgtcol4);
                dgtabstyle.GridColumnStyles.Add(dgtcol5);
                dgtabstyle.GridColumnStyles.Add(dgtcol6);
                dgtabstyle.GridColumnStyles.Add(dgtcol7);
                dataGrid.TableStyles.Add(dgtabstyle);



            
           
        }
        private OdbcCommand getInsertCommand(DataRow actRow)
        {
            OdbcCommand odbccmd = new OdbcCommand("INSERT INTO bestellpositionen (bestellID ,artikelID, menge, lieferdatum) VALUES(?,?,?,?)", odbcConnection1);
            OdbcParameter p1 = new OdbcParameter("p1", OdbcType.Int);
            p1.Value = bestellID;
            OdbcParameter p2 = new OdbcParameter("p2", OdbcType.Int);
            p2.Value = actRow.ItemArray[0];
            OdbcParameter p3 = new OdbcParameter("p3", OdbcType.Int);
            p3.Value = Convert.ToInt32(actRow.ItemArray[7]);
            OdbcParameter p4 = new OdbcParameter("p4", OdbcType.Date);
            p4.Value = datestring;
            odbccmd.Parameters.Add(p1);
            odbccmd.Parameters.Add(p2);
            odbccmd.Parameters.Add(p3);
            odbccmd.Parameters.Add(p4);
            return odbccmd;
        }

       
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odbcDataAdapter1_RowUpdated(object sender, OdbcRowUpdatedEventArgs e)
        {
            object[] items = e.Row.ItemArray;
            string itemString = ">" + items[7] + "x" + items[1] + "\"" + items[2] + "\"(Aritkelnummer" + items[0] + "),Größe:" + items[3] + ",Farbe:" + items[4] + ",Einzelpreis:" + items[5] + "EURO";
            if (e.Status.Equals(UpdateStatus.ErrorsOccurred))
            {
                e.Status = UpdateStatus.SkipCurrentRow;
                Console.WriteLine("Update für diese Zeile nicht ausgeführt:\n" + itemString);
                message += "\n";
                message += itemString;

            }
            else
            {
                OdbcCommand odbccmd = getInsertCommand(e.Row); //.CommandText, odbcConnection1);
                //odbccmd.ExecuteNonQuery();
                Console.WriteLine("Update für diese Zeile ausgefürt:\n" + itemString);
                Console.WriteLine("Insert-Anweisung:\n\t" + odbccmd.CommandText + "\n");
                try
                {
                    
                    var T = odbccmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType() + Environment.NewLine + ex.Message);
                }
            }
        }

        private void dataGrid_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
