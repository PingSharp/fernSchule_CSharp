namespace Lektion3
{
    partial class Konfigurationsdialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxKennung = new System.Windows.Forms.TextBox();
            this.comboBoxTypen = new System.Windows.Forms.ComboBox();
            this.textBoxStartposX = new System.Windows.Forms.TextBox();
            this.textBoxStartPosY = new System.Windows.Forms.TextBox();
            this.textBoxStartPosH = new System.Windows.Forms.TextBox();
            this.textBoxZielPosX = new System.Windows.Forms.TextBox();
            this.textBoxZielPosY = new System.Windows.Forms.TextBox();
            this.textBoxZielPosH = new System.Windows.Forms.TextBox();
            this.textBoxFlughoehe = new System.Windows.Forms.TextBox();
            this.textBoxFlugstrecke = new System.Windows.Forms.TextBox();
            this.textBoxSteighoehe = new System.Windows.Forms.TextBox();
            this.textBoxSinkhoehe = new System.Windows.Forms.TextBox();
            this.textBox1AnzahlPlaetze = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kennung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Düsenflugzeugtyp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Startposition x, y, h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zielposition x, y, h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reiseflughöhe(m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flugstrecke pro Takt(m)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Steinghöhe pro Takt(m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sinkhöhe pro Takt(m)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Anzahl Plätze";
            // 
            // textBoxKennung
            // 
            this.textBoxKennung.Location = new System.Drawing.Point(156, 7);
            this.textBoxKennung.Name = "textBoxKennung";
            this.textBoxKennung.Size = new System.Drawing.Size(100, 20);
            this.textBoxKennung.TabIndex = 9;
            this.textBoxKennung.TextChanged += new System.EventHandler(this.textBoxKennung_TextChanged);
            // 
            // comboBoxTypen
            // 
            this.comboBoxTypen.FormattingEnabled = true;
            this.comboBoxTypen.Location = new System.Drawing.Point(156, 36);
            this.comboBoxTypen.Name = "comboBoxTypen";
            this.comboBoxTypen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypen.TabIndex = 10;
            this.comboBoxTypen.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypen_SelectedIndexChanged);
            // 
            // textBoxStartposX
            // 
            this.textBoxStartposX.Location = new System.Drawing.Point(156, 67);
            this.textBoxStartposX.Name = "textBoxStartposX";
            this.textBoxStartposX.Size = new System.Drawing.Size(79, 20);
            this.textBoxStartposX.TabIndex = 11;
            // 
            // textBoxStartPosY
            // 
            this.textBoxStartPosY.Location = new System.Drawing.Point(242, 67);
            this.textBoxStartPosY.Name = "textBoxStartPosY";
            this.textBoxStartPosY.Size = new System.Drawing.Size(83, 20);
            this.textBoxStartPosY.TabIndex = 12;
            // 
            // textBoxStartPosH
            // 
            this.textBoxStartPosH.Location = new System.Drawing.Point(332, 67);
            this.textBoxStartPosH.Name = "textBoxStartPosH";
            this.textBoxStartPosH.Size = new System.Drawing.Size(78, 20);
            this.textBoxStartPosH.TabIndex = 13;
            // 
            // textBoxZielPosX
            // 
            this.textBoxZielPosX.Location = new System.Drawing.Point(156, 97);
            this.textBoxZielPosX.Name = "textBoxZielPosX";
            this.textBoxZielPosX.Size = new System.Drawing.Size(79, 20);
            this.textBoxZielPosX.TabIndex = 14;
            // 
            // textBoxZielPosY
            // 
            this.textBoxZielPosY.Location = new System.Drawing.Point(241, 98);
            this.textBoxZielPosY.Name = "textBoxZielPosY";
            this.textBoxZielPosY.Size = new System.Drawing.Size(84, 20);
            this.textBoxZielPosY.TabIndex = 15;
            // 
            // textBoxZielPosH
            // 
            this.textBoxZielPosH.Location = new System.Drawing.Point(332, 97);
            this.textBoxZielPosH.Name = "textBoxZielPosH";
            this.textBoxZielPosH.Size = new System.Drawing.Size(78, 20);
            this.textBoxZielPosH.TabIndex = 16;
            // 
            // textBoxFlughoehe
            // 
            this.textBoxFlughoehe.Location = new System.Drawing.Point(156, 127);
            this.textBoxFlughoehe.Name = "textBoxFlughoehe";
            this.textBoxFlughoehe.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlughoehe.TabIndex = 17;
            // 
            // textBoxFlugstrecke
            // 
            this.textBoxFlugstrecke.Location = new System.Drawing.Point(156, 165);
            this.textBoxFlugstrecke.Name = "textBoxFlugstrecke";
            this.textBoxFlugstrecke.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlugstrecke.TabIndex = 18;
            // 
            // textBoxSteighoehe
            // 
            this.textBoxSteighoehe.Location = new System.Drawing.Point(156, 195);
            this.textBoxSteighoehe.Name = "textBoxSteighoehe";
            this.textBoxSteighoehe.Size = new System.Drawing.Size(100, 20);
            this.textBoxSteighoehe.TabIndex = 19;
            // 
            // textBoxSinkhoehe
            // 
            this.textBoxSinkhoehe.Location = new System.Drawing.Point(156, 217);
            this.textBoxSinkhoehe.Name = "textBoxSinkhoehe";
            this.textBoxSinkhoehe.Size = new System.Drawing.Size(100, 20);
            this.textBoxSinkhoehe.TabIndex = 20;
            // 
            // textBox1AnzahlPlaetze
            // 
            this.textBox1AnzahlPlaetze.Location = new System.Drawing.Point(156, 247);
            this.textBox1AnzahlPlaetze.Name = "textBox1AnzahlPlaetze";
            this.textBox1AnzahlPlaetze.Size = new System.Drawing.Size(100, 20);
            this.textBox1AnzahlPlaetze.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Flug...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Löschen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Location = new System.Drawing.Point(370, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Starten";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(156, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Konfigurationsdialog beenden";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Konfigurationsdialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1AnzahlPlaetze);
            this.Controls.Add(this.textBoxSinkhoehe);
            this.Controls.Add(this.textBoxSteighoehe);
            this.Controls.Add(this.textBoxFlugstrecke);
            this.Controls.Add(this.textBoxFlughoehe);
            this.Controls.Add(this.textBoxZielPosH);
            this.Controls.Add(this.textBoxZielPosY);
            this.Controls.Add(this.textBoxZielPosX);
            this.Controls.Add(this.textBoxStartPosH);
            this.Controls.Add(this.textBoxStartPosY);
            this.Controls.Add(this.textBoxStartposX);
            this.Controls.Add(this.comboBoxTypen);
            this.Controls.Add(this.textBoxKennung);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Konfigurationsdialog";
            this.Text = "Konfigurationsdialog";
            this.Load += new System.EventHandler(this.Konfigurationsdialog_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxKennung;
        private System.Windows.Forms.ComboBox comboBoxTypen;
        private System.Windows.Forms.TextBox textBoxStartposX;
        private System.Windows.Forms.TextBox textBoxStartPosY;
        private System.Windows.Forms.TextBox textBoxStartPosH;
        private System.Windows.Forms.TextBox textBoxZielPosX;
        private System.Windows.Forms.TextBox textBoxZielPosY;
        private System.Windows.Forms.TextBox textBoxZielPosH;
        private System.Windows.Forms.TextBox textBoxFlughoehe;
        private System.Windows.Forms.TextBox textBoxFlugstrecke;
        private System.Windows.Forms.TextBox textBoxSteighoehe;
        private System.Windows.Forms.TextBox textBoxSinkhoehe;
        private System.Windows.Forms.TextBox textBox1AnzahlPlaetze;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}