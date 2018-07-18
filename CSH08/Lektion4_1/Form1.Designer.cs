namespace Lektion4_1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Datei = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnen = new System.Windows.Forms.ToolStripMenuItem();
            this.Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.karteiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartei = new Lektion4_1.kartei();
            this.kartei1 = new Lektion4_1.kartei();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.karteiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.karteiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartei)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartei1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Datei});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Datei
            // 
            this.Datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnen,
            this.Speichern,
            this.Beenden});
            this.Datei.Name = "Datei";
            this.Datei.Size = new System.Drawing.Size(46, 20);
            this.Datei.Text = "Datei";
            // 
            // öffnen
            // 
            this.öffnen.Name = "öffnen";
            this.öffnen.Size = new System.Drawing.Size(157, 22);
            this.öffnen.Text = "Öffnen";
            this.öffnen.Click += new System.EventHandler(this.öffnen_Click);
            // 
            // Speichern
            // 
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(157, 22);
            this.Speichern.Text = "Speichern unter";
            // 
            // Beenden
            // 
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(157, 22);
            this.Beenden.Text = "Beenden";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(478, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // karteiBindingSource
            // 
            this.karteiBindingSource.DataSource = this.kartei;
            this.karteiBindingSource.Position = 0;
            // 
            // kartei
            // 
            this.kartei.DataSetName = "kartei";
            this.kartei.Locale = new System.Globalization.CultureInfo("en-US");
            this.kartei.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kartei1
            // 
            this.kartei1.DataSetName = "kartei";
            this.kartei1.Locale = new System.Globalization.CultureInfo("en-US");
            this.kartei1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.karteiBindingSource;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 27);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(478, 209);
            this.dataGrid1.TabIndex = 3;
            // 
            // karteiBindingSource1
            // 
            this.karteiBindingSource1.DataSource = this.kartei;
            this.karteiBindingSource1.Position = 0;
            // 
            // karteiBindingSource2
            // 
            this.karteiBindingSource2.DataSource = this.kartei;
            this.karteiBindingSource2.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 261);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "XMLDatenForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartei)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartei1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karteiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Datei;
        private System.Windows.Forms.ToolStripMenuItem öffnen;
        private System.Windows.Forms.ToolStripMenuItem Speichern;
        private System.Windows.Forms.ToolStripMenuItem Beenden;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource karteiBindingSource;
        private kartei kartei;
        private kartei kartei1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.BindingSource karteiBindingSource1;
        private System.Windows.Forms.BindingSource karteiBindingSource2;
    }
}

