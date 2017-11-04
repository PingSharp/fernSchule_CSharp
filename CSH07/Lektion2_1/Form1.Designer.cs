namespace Lektion2_1
{
    partial class MySqlAbfrage
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAbfrage = new System.Windows.Forms.Button();
            this.Beenden = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(16, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(539, 20);
            this.textBox1.TabIndex = 0;
            // 
            // buttonAbfrage
            // 
            this.buttonAbfrage.Location = new System.Drawing.Point(16, 48);
            this.buttonAbfrage.Name = "buttonAbfrage";
            this.buttonAbfrage.Size = new System.Drawing.Size(170, 32);
            this.buttonAbfrage.TabIndex = 1;
            this.buttonAbfrage.Text = "Anweisung ausführen";
            this.buttonAbfrage.UseVisualStyleBackColor = true;
            this.buttonAbfrage.Click += new System.EventHandler(this.buttonAbfrage_Click);
            // 
            // Beenden
            // 
            this.Beenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Beenden.Location = new System.Drawing.Point(385, 48);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(170, 32);
            this.Beenden.TabIndex = 2;
            this.Beenden.Text = "Programm Beenden";
            this.Beenden.UseVisualStyleBackColor = true;
            this.Beenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(539, 225);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MySqlAbfrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 337);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.buttonAbfrage);
            this.Controls.Add(this.textBox1);
            this.Name = "MySqlAbfrage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MySqlAbfrage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAbfrage;
        private System.Windows.Forms.Button Beenden;
        private System.Windows.Forms.ListBox listBox1;
    }
}

