namespace Lektion2_2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSQL = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.buttonAbfrage = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataSet1 = new System.Data.DataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.odbcConnection = new System.Data.Odbc.OdbcConnection();
            this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
            this.odbcSelectCommand2 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand2 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand2 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand2 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter2 = new System.Data.Odbc.OdbcDataAdapter();
            this.odbcSelectCommand3 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand3 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand3 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand3 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter = new System.Data.Odbc.OdbcDataAdapter();
            this.odbcSelectCommand4 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand4 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand4 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand4 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter3 = new System.Data.Odbc.OdbcDataAdapter();
            this.odbcSelectCommand5 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand5 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand5 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand5 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter4 = new System.Data.Odbc.OdbcDataAdapter();
            this.buttonBestellungen = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelsuch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonsuche = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSQL
            // 
            this.labelSQL.AutoSize = true;
            this.labelSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSQL.Location = new System.Drawing.Point(13, 9);
            this.labelSQL.Name = "labelSQL";
            this.labelSQL.Size = new System.Drawing.Size(126, 17);
            this.labelSQL.TabIndex = 0;
            this.labelSQL.Text = "Table in der Datenbank";
            this.labelSQL.UseCompatibleTextRendering = true;
            // 
            // labelTable
            // 
            this.labelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(157, 9);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(105, 13);
            this.labelTable.TabIndex = 1;
            this.labelTable.Text = "Table im DataSet";
            this.labelTable.Click += new System.EventHandler(this.labelTable_Click);
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(160, 29);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(123, 20);
            this.textBoxTable.TabIndex = 3;
            // 
            // buttonAbfrage
            // 
            this.buttonAbfrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbfrage.Location = new System.Drawing.Point(16, 59);
            this.buttonAbfrage.Name = "buttonAbfrage";
            this.buttonAbfrage.Size = new System.Drawing.Size(151, 28);
            this.buttonAbfrage.TabIndex = 4;
            this.buttonAbfrage.Text = "Select Anweisung";
            this.buttonAbfrage.UseVisualStyleBackColor = true;
            this.buttonAbfrage.Click += new System.EventHandler(this.buttonAbfrage_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeenden.Location = new System.Drawing.Point(330, 59);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(151, 28);
            this.buttonBeenden.TabIndex = 5;
            this.buttonBeenden.Text = "Programm beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.DataMember = "";
            this.dataGrid.DataSource = this.dataSet1;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(16, 124);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(640, 267);
            this.dataGrid.TabIndex = 8;
            this.dataGrid.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid_Navigate);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // odbcConnection
            // 
            this.odbcConnection.ConnectionString = "DSN = LocalMySQL56";
            // 
            // odbcInsertCommand1
            // 
            this.odbcInsertCommand1.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("P1", System.Data.Odbc.OdbcType.Int, 10, "personID"),
            new System.Data.Odbc.OdbcParameter("P2", System.Data.Odbc.OdbcType.VarChar, 45, "firma")});
            // 
            // odbcDataAdapter1
            // 
            this.odbcDataAdapter1.DeleteCommand = this.odbcDeleteCommand1;
            this.odbcDataAdapter1.InsertCommand = this.odbcInsertCommand1;
            this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
            this.odbcDataAdapter1.UpdateCommand = this.odbcUpdateCommand1;
            this.odbcDataAdapter1.RowUpdated += new System.Data.Odbc.OdbcRowUpdatedEventHandler(this.odbcDataAdapter1_RowUpdated);
            // 
            // odbcInsertCommand2
            // 
            this.odbcInsertCommand2.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("P1", System.Data.Odbc.OdbcType.VarChar, 0, "vorname"),
            new System.Data.Odbc.OdbcParameter("P2", System.Data.Odbc.OdbcType.VarChar, 0, "nachname"),
            new System.Data.Odbc.OdbcParameter("P3", System.Data.Odbc.OdbcType.VarChar, 0, "strasse"),
            new System.Data.Odbc.OdbcParameter("P4", System.Data.Odbc.OdbcType.VarChar, 0, "hausnummer"),
            new System.Data.Odbc.OdbcParameter("P5", System.Data.Odbc.OdbcType.VarChar, 0, "ort"),
            new System.Data.Odbc.OdbcParameter("P6", System.Data.Odbc.OdbcType.Char, 0, "land"),
            new System.Data.Odbc.OdbcParameter("P7", System.Data.Odbc.OdbcType.VarChar, 0, "plz"),
            new System.Data.Odbc.OdbcParameter("P8", System.Data.Odbc.OdbcType.VarChar, 0, "telefon")});
            // 
            // odbcUpdateCommand2
            // 
            this.odbcUpdateCommand2.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("P1", System.Data.Odbc.OdbcType.VarChar, 0, "vorname"),
            new System.Data.Odbc.OdbcParameter("P2", System.Data.Odbc.OdbcType.VarChar, 0, "nachname"),
            new System.Data.Odbc.OdbcParameter("P3", System.Data.Odbc.OdbcType.VarChar, 0, "strasse"),
            new System.Data.Odbc.OdbcParameter("P4", System.Data.Odbc.OdbcType.VarChar, 0, "hausnummer"),
            new System.Data.Odbc.OdbcParameter("P5", System.Data.Odbc.OdbcType.VarChar, 0, "ort"),
            new System.Data.Odbc.OdbcParameter("P6", System.Data.Odbc.OdbcType.Char, 0, "land"),
            new System.Data.Odbc.OdbcParameter("P7", System.Data.Odbc.OdbcType.VarChar, 0, "plz"),
            new System.Data.Odbc.OdbcParameter("P8", System.Data.Odbc.OdbcType.VarChar, 0, "telefon"),
            new System.Data.Odbc.OdbcParameter("P9", System.Data.Odbc.OdbcType.Int, 0, "id")});
            // 
            // odbcDeleteCommand2
            // 
            this.odbcDeleteCommand2.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("P1", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null)});
            // 
            // odbcDataAdapter2
            // 
            this.odbcDataAdapter2.DeleteCommand = this.odbcDeleteCommand2;
            this.odbcDataAdapter2.InsertCommand = this.odbcInsertCommand2;
            this.odbcDataAdapter2.SelectCommand = this.odbcSelectCommand2;
            this.odbcDataAdapter2.UpdateCommand = this.odbcUpdateCommand2;
            // 
            // odbcDataAdapter
            // 
            this.odbcDataAdapter.DeleteCommand = this.odbcDeleteCommand3;
            this.odbcDataAdapter.InsertCommand = this.odbcInsertCommand3;
            this.odbcDataAdapter.SelectCommand = this.odbcSelectCommand3;
            this.odbcDataAdapter.UpdateCommand = this.odbcUpdateCommand3;
            // 
            // odbcSelectCommand4
            // 
            this.odbcSelectCommand4.Connection = this.odbcConnection;
            // 
            // odbcDataAdapter3
            // 
            this.odbcDataAdapter3.DeleteCommand = this.odbcDeleteCommand4;
            this.odbcDataAdapter3.InsertCommand = this.odbcInsertCommand4;
            this.odbcDataAdapter3.SelectCommand = this.odbcSelectCommand4;
            this.odbcDataAdapter3.UpdateCommand = this.odbcUpdateCommand4;
            // 
            // odbcSelectCommand5
            // 
            this.odbcSelectCommand5.Connection = this.odbcConnection;
            // 
            // odbcDataAdapter4
            // 
            this.odbcDataAdapter4.DeleteCommand = this.odbcDeleteCommand5;
            this.odbcDataAdapter4.InsertCommand = this.odbcInsertCommand5;
            this.odbcDataAdapter4.SelectCommand = this.odbcSelectCommand5;
            this.odbcDataAdapter4.UpdateCommand = this.odbcUpdateCommand5;
            // 
            // buttonBestellungen
            // 
            this.buttonBestellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestellungen.Location = new System.Drawing.Point(173, 59);
            this.buttonBestellungen.Name = "buttonBestellungen";
            this.buttonBestellungen.Size = new System.Drawing.Size(151, 28);
            this.buttonBestellungen.TabIndex = 10;
            this.buttonBestellungen.Text = "Kundenbestellungen";
            this.buttonBestellungen.UseVisualStyleBackColor = true;
            this.buttonBestellungen.Click += new System.EventHandler(this.buttonBestellungen_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonupdate.Location = new System.Drawing.Point(487, 59);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(151, 28);
            this.buttonupdate.TabIndex = 11;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // labelsuch
            // 
            this.labelsuch.AutoSize = true;
            this.labelsuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsuch.Location = new System.Drawing.Point(305, 9);
            this.labelsuch.Name = "labelsuch";
            this.labelsuch.Size = new System.Drawing.Size(215, 13);
            this.labelsuch.TabIndex = 13;
            this.labelsuch.Text = "Such nach Nachname in der Kunden";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 14;
            // 
            // buttonsuche
            // 
            this.buttonsuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsuche.Location = new System.Drawing.Point(16, 94);
            this.buttonsuche.Name = "buttonsuche";
            this.buttonsuche.Size = new System.Drawing.Size(151, 23);
            this.buttonsuche.TabIndex = 15;
            this.buttonsuche.Text = "Suchen";
            this.buttonsuche.UseVisualStyleBackColor = true;
            this.buttonsuche.Click += new System.EventHandler(this.buttonsuche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 415);
            this.Controls.Add(this.buttonsuche);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelsuch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonBestellungen);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonAbfrage);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.labelSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSQL;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Button buttonAbfrage;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Data.DataSet dataSet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Data.Odbc.OdbcConnection odbcConnection;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand1;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand1;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand2;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand2;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand2;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand2;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter2;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand3;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand3;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand3;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand3;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand4;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand4;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand4;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand4;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter3;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand5;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand5;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand5;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand5;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter4;
        private System.Windows.Forms.Button buttonBestellungen;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelsuch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonsuche;
    }
}

