namespace Lektion1
{
    partial class StichpunkteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Übernehmen = new System.Windows.Forms.Button();
            this.textBoxStichpunkt = new System.Windows.Forms.TextBox();
            this.listBoxStichpunkt = new System.Windows.Forms.ListBox();
            this.beenden = new System.Windows.Forms.Button();
            this.nachoben = new System.Windows.Forms.Button();
            this.nachunter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Übernehmen

            // 
            this.Übernehmen.Location = new System.Drawing.Point(511, 12);
            this.Übernehmen.Name = "Übernehmen";
            this.Übernehmen.Size = new System.Drawing.Size(84, 20);
            this.Übernehmen.TabIndex = 0;
            this.Übernehmen.Text = "Übernehmen";
            this.Übernehmen.UseVisualStyleBackColor = true;
            this.Übernehmen.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStichpunkt
            // 
            this.textBoxStichpunkt.Location = new System.Drawing.Point(12, 12);
            this.textBoxStichpunkt.Name = "textBoxStichpunkt";
            this.textBoxStichpunkt.Size = new System.Drawing.Size(493, 20);
            this.textBoxStichpunkt.TabIndex = 1;
            this.textBoxStichpunkt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter);


            // 
            // listBoxStichpunkt
            // 
            this.listBoxStichpunkt.FormattingEnabled = true;
            this.listBoxStichpunkt.Location = new System.Drawing.Point(12, 40);
            this.listBoxStichpunkt.Name = "listBoxStichpunkt";
            this.listBoxStichpunkt.Size = new System.Drawing.Size(493, 303);
            this.listBoxStichpunkt.TabIndex = 2;
            this.listBoxStichpunkt.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(511, 321);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(84, 19);
            this.beenden.TabIndex = 3;
            this.beenden.Text = "Beenden";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // nachoben
            // 
            this.nachoben.Location = new System.Drawing.Point(511, 155);
            this.nachoben.Name = "nachoben";
            this.nachoben.Size = new System.Drawing.Size(84, 19);
            this.nachoben.TabIndex = 4;
            this.nachoben.Text = "nach oben";
            this.nachoben.UseVisualStyleBackColor = true;
            this.nachoben.Click += new System.EventHandler(this.nachoben_Click);
            // 
            // nachunter
            // 
            this.nachunter.Location = new System.Drawing.Point(511, 180);
            this.nachunter.Name = "nachunter";
            this.nachunter.Size = new System.Drawing.Size(84, 20);
            this.nachunter.TabIndex = 5;
            this.nachunter.Text = "nach unter";
            this.nachunter.UseVisualStyleBackColor = true;
            this.nachunter.Click += new System.EventHandler(this.button2_Click);
            // 
            // StichpunkteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(647, 562);
            this.Controls.Add(this.nachunter);
            this.Controls.Add(this.nachoben);
            this.Controls.Add(this.beenden);
            this.Controls.Add(this.listBoxStichpunkt);
            this.Controls.Add(this.textBoxStichpunkt);
            this.Controls.Add(this.Übernehmen);
            this.Name = "StichpunkteForm";
            this.Text = "StichpunkteForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            this.KeyPreview = true;



        }

        #endregion

        private System.Windows.Forms.Button Übernehmen;
        private System.Windows.Forms.TextBox textBoxStichpunkt;
        private System.Windows.Forms.ListBox listBoxStichpunkt;
        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.Button nachoben;
        private System.Windows.Forms.Button nachunter;
    }
}

