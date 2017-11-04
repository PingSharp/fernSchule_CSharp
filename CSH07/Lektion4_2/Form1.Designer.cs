namespace Lektion4_2
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
            this.labelvorname = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxVorname = new System.Windows.Forms.TextBox();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonAnmelden = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonBestellen = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.dataSet1 = new System.Data.DataSet();
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcInsertCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcUpdateCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDeleteCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelvorname
            // 
            this.labelvorname.AutoSize = true;
            this.labelvorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvorname.Location = new System.Drawing.Point(13, 13);
            this.labelvorname.Name = "labelvorname";
            this.labelvorname.Size = new System.Drawing.Size(56, 13);
            this.labelvorname.TabIndex = 0;
            this.labelvorname.Text = "Vorname";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNachname.Location = new System.Drawing.Point(164, 13);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(67, 13);
            this.labelNachname.TabIndex = 1;
            this.labelNachname.Text = "Nachname";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(319, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(67, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Kunden-ID";
            // 
            // textBoxVorname
            // 
            this.textBoxVorname.Location = new System.Drawing.Point(16, 30);
            this.textBoxVorname.Name = "textBoxVorname";
            this.textBoxVorname.Size = new System.Drawing.Size(142, 20);
            this.textBoxVorname.TabIndex = 3;
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Location = new System.Drawing.Point(167, 30);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(142, 20);
            this.textBoxNachname.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(322, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(96, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // buttonAnmelden
            // 
            this.buttonAnmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnmelden.Location = new System.Drawing.Point(472, 29);
            this.buttonAnmelden.Name = "buttonAnmelden";
            this.buttonAnmelden.Size = new System.Drawing.Size(75, 23);
            this.buttonAnmelden.TabIndex = 6;
            this.buttonAnmelden.Text = "Anmelden";
            this.buttonAnmelden.UseVisualStyleBackColor = true;
            this.buttonAnmelden.Click += new System.EventHandler(this.buttonAnmelden_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeenden.Location = new System.Drawing.Point(472, 59);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 7;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonBestellen
            // 
            this.buttonBestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBestellen.Location = new System.Drawing.Point(16, 58);
            this.buttonBestellen.Name = "buttonBestellen";
            this.buttonBestellen.Size = new System.Drawing.Size(75, 23);
            this.buttonBestellen.TabIndex = 8;
            this.buttonBestellen.Text = "Bestellen";
            this.buttonBestellen.UseVisualStyleBackColor = true;
            this.buttonBestellen.Click += new System.EventHandler(this.buttonBestellen_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 262);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.DataMember = "";
            this.dataGrid.DataSource = this.dataSet1;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(16, 88);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(531, 171);
            this.dataGrid.TabIndex = 10;
            this.dataGrid.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid_Navigate);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // odbcUpdateCommand1
            // 
            this.odbcUpdateCommand1.Connection = this.odbcConnection1;
            this.odbcUpdateCommand1.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("P1", System.Data.Odbc.OdbcType.Int, 11, "Bestellmenge"),
            new System.Data.Odbc.OdbcParameter("P2", System.Data.Odbc.OdbcType.Int, 11, "Bestellmenge"),
            new System.Data.Odbc.OdbcParameter("P3", System.Data.Odbc.OdbcType.Int, 11, "id")});
            // 
            // odbcDataAdapter1
            // 
            this.odbcDataAdapter1.DeleteCommand = this.odbcDeleteCommand1;
            this.odbcDataAdapter1.InsertCommand = this.odbcInsertCommand1;
            this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
            this.odbcDataAdapter1.UpdateCommand = this.odbcUpdateCommand1;
            this.odbcDataAdapter1.RowUpdated += new System.Data.Odbc.OdbcRowUpdatedEventHandler(this.odbcDataAdapter1_RowUpdated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 284);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonBestellen);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonAnmelden);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxNachname);
            this.Controls.Add(this.textBoxVorname);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.labelvorname);
            this.Name = "Form1";
            this.Text = "Benutzeranmeldung und Ausführung von Bestellungen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelvorname;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxVorname;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonAnmelden;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonBestellen;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Data.DataSet dataSet1;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
        private System.Data.Odbc.OdbcCommand odbcInsertCommand1;
        private System.Data.Odbc.OdbcCommand odbcUpdateCommand1;
        private System.Data.Odbc.OdbcCommand odbcDeleteCommand1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
    }
}

