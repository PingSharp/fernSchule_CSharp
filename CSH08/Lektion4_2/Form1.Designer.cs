namespace Lektion4_2
{
    partial class XmlDatenForm
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
            this.dataSet = new System.Data.DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMenuItemdatei = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemsave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemclose = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGrid = new System.Windows.Forms.DataGrid();
            this.toolStripMenuItemopen = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemdatei});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(807, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMenuItemdatei
            // 
            this.toolStripMenuItemdatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemsave,
            this.toolStripMenuItemclose,
            this.toolStripMenuItemopen});
            this.toolStripMenuItemdatei.Name = "toolStripMenuItemdatei";
            this.toolStripMenuItemdatei.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemdatei.Text = "Datei";
            // 
            // toolStripMenuItemsave
            // 
            this.toolStripMenuItemsave.Name = "toolStripMenuItemsave";
            this.toolStripMenuItemsave.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemsave.Text = "Speichern unter";
            this.toolStripMenuItemsave.Click += new System.EventHandler(this.toolStripMenuItemsave_Click);
            // 
            // toolStripMenuItemclose
            // 
            this.toolStripMenuItemclose.Name = "toolStripMenuItemclose";
            this.toolStripMenuItemclose.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemclose.Text = "Beenden";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGrid
            // 
            this.dataGrid.DataMember = "";
            this.dataGrid.DataSource = this.dataSet;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(807, 485);
            this.dataGrid.TabIndex = 2;
            // 
            // toolStripMenuItemopen
            // 
            this.toolStripMenuItemopen.Name = "toolStripMenuItemopen";
            this.toolStripMenuItemopen.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemopen.Text = "Öffnen";
            this.toolStripMenuItemopen.Click += new System.EventHandler(this.toolStripMenuItemopen_Click);
            // 
            // XmlDatenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 531);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XmlDatenForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.XmlDatenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet dataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemdatei;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemsave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemclose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.DataGrid dataGrid;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemopen;
    }
}

