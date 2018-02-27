using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namensraum für Hausaufgabe
/// </summary>
namespace Lektion4_2
{
    /// <summary>
    /// Die Klasse zur Beschreibung der XML GUI
    /// </summary>
    public partial class XmlDatenForm : Form
    {
        string xmlFile = "Karteikasten.xml";

        string xsdFile = "Karteikasten.xsd";
        string autor = "";
        /// <summary>
        /// Das ist der Konstruktor der XMLDatenform.
        /// Hier werden die Komponenten initialisiert.
        /// </summary>
        public XmlDatenForm()
        {
            InitializeComponent();



        }

        private void XmlDatenForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();//vorgefertigten .NET-Dialog 
            opendialog.InitialDirectory = @".";//Property initial das aktuelle Verzeichnis.
            opendialog.Filter = "XML-Datei(*.xml,*.xsd)|*.xml;*.xsd|Alle Dateien(*.*)|*.*";//Filter eigenschaft ist als wert ein String zuzuweisen,

            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                xmlFile = opendialog.FileName;
                try
                {
                    dataSet.Clear();
                    dataSet.ReadXml(xmlFile);
                    this.dataSet.AcceptChanges();
                    FormatTables();
                    FormatTable2();
                    //dataSet.ReadXmlSchema(xsdFile);
                    //XmlReadMode mode = dataSet.ReadXml(xmlFile);
                    this.Text = xmlFile;
                    //AddDefaultAttributes();
                }
                catch (Exception ex)
                {
                    StatusLabel.Text = ex.ToString();
                }
            }
            else
            {
                StatusLabel.Text = "Auswahl der Xml-Datei abgebrochen";
            }
        }
        /// <summary>
        /// Diese Methode dient der Formatierung der Tabelle im Zentrum der GUI, welche die Zeilen in den Tabellen des Datensatzes anzeigt. 
        /// Dabei werden Spaltennamen der GUI-Tabelle, Weite und ihren korrespondierenen Columnnames, im table object des XML dataset objects, berücksichtigt.
        /// </summary>
        /// <example>
        /// Die Formatierung / Style der Tabelle wird über 
        /// <code>
        /// DataGridTableStyle tabstylekarte = new DataGridTableStyle();
        /// </code>
        /// erzeugt.
        /// Spalte 1 bekommt die Standardwerte :
        /// <code>
        /// DataGridTextBoxColumn dgtcol1 = new DataGridTextBoxColumn();
        /// dgtcol1.MappingName = "stichwort";
        /// dgtcol1.HeaderText = "Stichwort";
        /// dgtcol1.Width = 160;
        /// </code>
        /// und wird über 
        /// <code>
        /// tabstylekarte.GridColumnStyles.Add(dgtcol1);
        /// </code>
        /// mit dem Style verküpft.
        /// Das Binding zwischen GUI Tabelle und Datensatztabelle passiert über
        /// <code>
        /// string datamember = dataSet.Tables[0].TableName;
        /// DataGridTableStyle tabstylekarte = new DataGridTableStyle();
        /// tabstylekarte.MappingName = datamember;
        /// </code>
        /// </example>
        protected void FormatTables()
        {


            string datamember = dataSet.Tables[0].TableName;
            dataGrid.SetDataBinding(dataSet, datamember);

            DataGridTableStyle tabstylekarte = new DataGridTableStyle();
            tabstylekarte.MappingName = datamember;

            DataGridTextBoxColumn dgtcol1 = new DataGridTextBoxColumn();
            dgtcol1.MappingName = "stichwort";
            dgtcol1.HeaderText = "Stichwort";
            dgtcol1.Width = 160;
            DataGridTextBoxColumn dgtcol2 = new DataGridTextBoxColumn();
            dgtcol2.MappingName = "sachgebiet";
            dgtcol2.HeaderText = "Sachgebiet";
            dgtcol2.Width = 100;
            DataGridTextBoxColumn dgtcol3 = new DataGridTextBoxColumn();
            dgtcol3.MappingName = "referenz";
            dgtcol3.HeaderText = "Referenz";
            dgtcol3.Width = 300;
            DataGridTextBoxColumn dgtcol4 = new DataGridTextBoxColumn();
            dgtcol4.MappingName = "autor";
            dgtcol4.HeaderText = "Autor";
            dgtcol4.Width = 100;
            DataGridTextBoxColumn dgtcol5 = new DataGridTextBoxColumn();
            dgtcol5.MappingName = "erstelldatum";
            dgtcol5.HeaderText = "Erstelldatum";
            dgtcol5.Width = 100;
            DataGridTextBoxColumn dgtcol6 = new DataGridTextBoxColumn();
            dgtcol6.MappingName = "aenderungsdatum";
            dgtcol6.HeaderText = "Änderungsdatum";
            dgtcol6.Width = 100;
            tabstylekarte.GridColumnStyles.Add(dgtcol1);
            tabstylekarte.GridColumnStyles.Add(dgtcol2);
            tabstylekarte.GridColumnStyles.Add(dgtcol3);
            tabstylekarte.GridColumnStyles.Add(dgtcol4);
            tabstylekarte.GridColumnStyles.Add(dgtcol5);
            tabstylekarte.GridColumnStyles.Add(dgtcol6);



            dataGrid.TableStyles.Add(tabstylekarte);



        }
        private void FormatTable2()
        {

            DataGridTableStyle tabstyleliste = new DataGridTableStyle();
            tabstyleliste.MappingName = "liste";
            DataGridTextBoxColumn dgtcolliste = new DataGridTextBoxColumn();
            dgtcolliste.MappingName = "liste_Text";
            dgtcolliste.HeaderText = "Liste-Text";
            dgtcolliste.Width = 200;


            DataGridTableStyle tabstylebeschreibung = new DataGridTableStyle();
            tabstylebeschreibung.MappingName = "beschreibung";
            DataGridTextBoxColumn dgtcolbeschreibung = new DataGridTextBoxColumn();
            dgtcolbeschreibung.MappingName = "beschreibung_Text";
            dgtcolbeschreibung.HeaderText = "Beschreibung-Text";
            dgtcolbeschreibung.Width = 300;
            tabstyleliste.GridColumnStyles.Add(dgtcolliste);
            tabstylebeschreibung.GridColumnStyles.Add(dgtcolbeschreibung);
            dataGrid.TableStyles.Add(tabstyleliste);
            dataGrid.TableStyles.Add(tabstylebeschreibung);
        }

        private void toolStripMenuItemsave_Click(object sender, EventArgs e)
        {
            if (this.AddDefaultAttributes())
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Filter = "XML-Datei(*.xml,*.xsd)|*.xml;*.xsd|Alle Dateien(*.*)|*.*";
                if (savedialog.FileName == null)
                {
                    savedialog.FileName = DateTime.Now.ToString("yyyy-MM-dd") + ".xml";
                    DialogResult result1 = savedialog.ShowDialog();
                    if (result1 == DialogResult.OK)
                    {
                        dataSet.WriteXml(savedialog.FileName);
                    }

                }
                else
                {
                    DialogResult result = savedialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dataSet.WriteXml(savedialog.FileName);
                    }
                }
            }
            else
            {
                StatusLabel.Text = "Keine Änderungen im Dataset!";
            }
        }
        /// <summary>
        /// In dieser Methode werden die Änderungen des XML Dokumentes geprüft und je nach dem die Attribute aenderungsdatum bzw. erstelldatum hinzugefügt.
        /// Zu erst wird über <code>dataSet.HasChanges(DataRowState.Added)</code> und <code>dataSet.HasChanges(DataRowState.Modified)</code> bestimmt, ob 
        /// was geändert wurde und über die Konsole ausgegeben. 
        /// Anschließend wird über <code>dataSet.GetChanges()</code> ein Objekt erzeugt, welches die Änderungen beinhaltet. 
        /// <para >
        /// Über 
        /// <code>
        ///     if(dschanged != null)
        /// </code>
        /// wird abgefragt, ob Änderungen vorhanden sind. Falls keine vorhanden sind, wird hier bereits ein false zurückgegeben und nichts weiter gemacht.
        /// Sowas kann beispielsweise folgendermaßen passieren : 
        /// <code>
        /// DataTable table = new DataTable();
        /// table.Columns.Add("column_1");
        /// table.Columns.Add("column_2");
        /// table.Rows.Add("1",1);
        /// table.Rows.Add("2",2);
        /// DataSet a = new DataSet();
        /// a.Tables.Add(table);
        /// a.AcceptChanges();
        /// DataSet diff_a = a.GetChanges();
        /// </code>
        /// </para>
        /// Falls Änderungen existieren, wird über alle geänderten Zeilen mittels <code>foreach (DataRow row in karteTable.Rows)</code> iteriert. 
        /// Jede Zeile wird dabei auf ihre Version geprüft. 
        /// <para>
        /// Ein true bei 
        /// <code>
        /// if(row.HasVersion(DataRowVersion.Original))
        /// </code>
        /// zeigt an, dass eine Originalversion vorhanden ist, also eine Änderung am Original gemacht wurde. 
        /// Ein false könnte bei folgendem Fall auftreten : 
        /// <code>
        /// DataTable table = new DataTable("table_1");
        /// table.Columns.Add("column_1");
        /// table.Columns.Add("column_2");
        /// table.Rows.Add("1",1);
        /// DataSet a = new DataSet();
        /// a.Tables.Add(table);
        /// a.AcceptChanges();
        /// table.Rows.Add("2",2);
        /// DataSet diff_a = a.GetChanges();
        /// bool willBeFalse = diff_a.Tables["table_1"].Rows[0].HasVersion(DataRowVersion.Original);
        ///</code>
        /// Nach der Versionsabfrage wird nun über 
        /// <code>
        /// if (row.RowState == DataRowState.Deleted)
        /// </code>
        /// geprüft, ob das Original gelöscht oder geändert wurde. Falls nicht gelöscht, muss es geändert worden sein. 
        /// Ein Beispiel hierfür : 
        /// <code>
        /// DataTable table = new DataTable("table_1");
        /// table.Columns.Add("column_1");
        /// table.Columns.Add("column_2");
        /// table.Rows.Add("1",1);
        /// DataSet a = new DataSet();
        /// a.Tables.Add(table);
        /// a.AcceptChanges();
        /// a.Tables["table_1"].Select("column_1 = '1'").First()["column_2"] = 2;
        /// DataSet diff_a = a.GetChanges();
        /// var firstChangedRow = diff_a.Tables["table_1"].Rows[0];
        /// var stateIsModified = firstChangedRow.RowState;
        /// a.Tables["table_1"].Select("column_1 = '1'").First().Delete();
        /// diff_a = a.GetChanges();
        /// firstChangedRow = diff_a.Tables["table_1"].Rows[0];
        /// var stateIsDeleted = firstChangedRow.RowState;
        /// </code>
        /// </para>
        /// Bei einer aenderung wird der row noch mittels <code> row["aenderungsdatum"] = DateTime.Now.ToString("yyyy-MM-dd");</code> ein Zeitstempel hinzugefügt
        /// Bei einem Hinzufügen passiert das mittels <code>row["erstelldatum"] = DateTime.Now.ToString("yyyy-MM-dd");</code>
        /// </summary>
        /// <returns>Erfolgreich oder nicht</returns>
        protected bool AddDefaultAttributes()
        {

            bool isAdded = dataSet.HasChanges(DataRowState.Added);
            Console.WriteLine("DataSet Added= " + isAdded);
            bool isModified = dataSet.HasChanges(DataRowState.Modified);
            Console.WriteLine("DataSet Modified= " + isModified);
            DataSet dschanged = dataSet.GetChanges();
            if(dschanged != null)
            {
                dschanged.Tables["liste"].Clear();
                dschanged.Tables["beschreibung"].Clear();
                DataTable karteTable = dschanged.Tables["karte"];

                foreach (DataRow row in karteTable.Rows)
                {
                    //Console.WriteLine(Ausgabehilfen.DataRowAusgabe(row));
                    if(row.HasVersion(DataRowVersion.Original))
                    {
                        if (row.RowState == DataRowState.Deleted)
                        {
                            StatusLabel.Text = "Diese Zeile wird gelöscht.";

                        }
                        else
                        {
                            row["aenderungsdatum"] = DateTime.Now.ToString("yyyy-MM-dd");
                            Console.WriteLine("Es gibt ein Original zur Karte" + "mit dem Stichwort = " + row["stichwort"]);
                        }
                    }
                    else
                    {
                        //row["autor"] = autor;
                        row["erstelldatum"] = DateTime.Now.ToString("yyyy-MM-dd");
                        Console.WriteLine("Es gibt kein Original zur Karte mit dem Stichwort = " + row["stichwort"]);

                    }

                }
                dataSet.Merge(dschanged);
                dataSet.AcceptChanges();
                
                return true;
            }
            else
            {
                return false;
            }
            
        }
        /// <summary>
        /// Eine Klasse zur Unterstützung der Zeilenausgaben in einem Set.
        /// </summary>
        public class Ausgabehilfen
        {
            /// <summary>
            /// der Default Konstruktor
            /// </summary>
            public Ausgabehilfen() { }
            private static char tab = '\x009';
            /// <summary>
            /// baut einen string der alle Spaltennamen  und dazugehörigen Werte einer spezifischen Zeile / row in der Tabelle eines Datensatzes enthält  
            /// <para> Wird u.a. in der Methode 
            /// <see cref="DataSetAusgabe" />
            /// genutzt, in der ein Datensatz in seine Tabellen und Zeilen aufgesplittet wird. Die Methode DatenRowAusgabe wird für jede Zeile in jeder Tabelle eines Datensatzes gerufen.
            /// </para>
            /// </summary>
            /// <param name="row">Zeile einer Datensatztabelle</param>
            /// <returns>String der alle Spaltennamen und Werte einer Zeile enthält</returns>
            protected static string DataRowAusgabe(DataRow row )
            {
                string ausgabe = "";
                ausgabe += tab;
                for (int i = 0;i < row.ItemArray.Length;i++ )
                {
                    ausgabe += row.Table.Columns[i].ColumnName + "=\"" + row.ItemArray[i] + "\"|";
                }
                return ausgabe;
            }
            /// <summary>
            /// Gibt alle Spaltennamen und Werte einer jeden Zeile einer jeden Tabelle eines Datensatzes auf der Konsole aus. 
            /// <para>DataSetAusgabe nutzt dabei die Methode
            /// <see cref="DataRowAusgabe" />
            /// in welcher die Spaltennamen und Werte einer Zeile erfasst werden und aus ihnen ein string konstruiert wird, der ausgegeben wird. 
            /// </para>
            /// </summary>
            /// <param name="ds">ein spezifischer Datensatz, dessen Zeilen über Spalten ausgegeben werden soll</param>
            protected static void DataSetAusgabe(DataSet ds)
            {
                if(ds != null)
                {
                    foreach(DataTable table in ds.Tables)
                    {
                        Console.WriteLine("Tabelle \"" + table.TableName + "\"");
                        foreach(DataRow row in table.Rows)
                        {
                            Console.WriteLine(DataRowAusgabe(row));
                            
                        }
                    }
                   
                }
            }
        }
    }
}
