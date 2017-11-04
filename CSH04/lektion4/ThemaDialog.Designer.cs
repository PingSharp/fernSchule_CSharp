namespace lektion4
{
    partial class ThemaDialog
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
            this.button2 = new System.Windows.Forms.Button();
            this.thematexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Übernehmen
            // 
            this.Übernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Übernehmen.Location = new System.Drawing.Point(69, 120);
            this.Übernehmen.Name = "Übernehmen";
            this.Übernehmen.Size = new System.Drawing.Size(75, 23);
            this.Übernehmen.TabIndex = 0;
            this.Übernehmen.Text = "Übernehmen";
            this.Übernehmen.UseVisualStyleBackColor = true;
            this.Übernehmen.Click += new System.EventHandler(this.Übernehmen_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(424, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abbrechen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thematexbox
            // 
            this.thematexbox.Location = new System.Drawing.Point(69, 70);
            this.thematexbox.Name = "thematexbox";
            this.thematexbox.Size = new System.Drawing.Size(430, 20);
            this.thematexbox.TabIndex = 2;
            this.thematexbox.TextChanged += new System.EventHandler(this.thematexbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geben Sie bitte das Thema der Stichpunktesammlung an:";
            // 
            // ThemaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 215);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thematexbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Übernehmen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemaDialog";
            this.Text = "Thema der Stichpunktesammlung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Übernehmen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox thematexbox;
        private System.Windows.Forms.Label label1;
    }
}