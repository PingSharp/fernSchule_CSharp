namespace Lektion3
{
    partial class NavigationForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.parentbutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.childbutton = new System.Windows.Forms.Button();
            this.Xbutton = new System.Windows.Forms.Button();
            this.tbAusgabetextBox = new System.Windows.Forms.TextBox();
            this.buttonchilds = new System.Windows.Forms.Button();
            this.textBoxByTagName = new System.Windows.Forms.TextBox();
            this.buttonbyTagName = new System.Windows.Forms.Button();
            this.buttonroot = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.tbEingabe = new System.Windows.Forms.TextBox();
            this.labeleinfügen = new System.Windows.Forms.Label();
            this.labelersetzen = new System.Windows.Forms.Label();
            this.labelentfernen = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonChild = new System.Windows.Forms.Button();
            this.buttonBefore = new System.Windows.Forms.Button();
            this.buttonAfter = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonCData = new System.Windows.Forms.Button();
            this.buttonErsetzen = new System.Windows.Forms.Button();
            this.buttonAttribut = new System.Windows.Forms.Button();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelpath = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel.Text = "toolStripStatusLabel1";
            // 
            // parentbutton
            // 
            this.parentbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parentbutton.Location = new System.Drawing.Point(750, 30);
            this.parentbutton.Name = "parentbutton";
            this.parentbutton.Size = new System.Drawing.Size(75, 23);
            this.parentbutton.TabIndex = 1;
            this.parentbutton.Text = "parent";
            this.parentbutton.UseVisualStyleBackColor = true;
            this.parentbutton.Click += new System.EventHandler(this.parentbutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.previousbutton.Location = new System.Drawing.Point(632, 118);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(75, 23);
            this.previousbutton.TabIndex = 2;
            this.previousbutton.Text = "previous";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextbutton.Location = new System.Drawing.Point(867, 118);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 3;
            this.nextbutton.Text = "next";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // childbutton
            // 
            this.childbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.childbutton.Location = new System.Drawing.Point(750, 243);
            this.childbutton.Name = "childbutton";
            this.childbutton.Size = new System.Drawing.Size(75, 23);
            this.childbutton.TabIndex = 4;
            this.childbutton.Text = "child";
            this.childbutton.UseVisualStyleBackColor = true;
            this.childbutton.Click += new System.EventHandler(this.childbutton_Click);
            // 
            // Xbutton
            // 
            this.Xbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xbutton.Location = new System.Drawing.Point(750, 118);
            this.Xbutton.Name = "Xbutton";
            this.Xbutton.Size = new System.Drawing.Size(75, 23);
            this.Xbutton.TabIndex = 5;
            this.Xbutton.Text = "X";
            this.Xbutton.UseVisualStyleBackColor = true;
            this.Xbutton.Click += new System.EventHandler(this.Xbutton_Click);
            // 
            // tbAusgabetextBox
            // 
            this.tbAusgabetextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.tbAusgabetextBox.Location = new System.Drawing.Point(12, 72);
            this.tbAusgabetextBox.Multiline = true;
            this.tbAusgabetextBox.Name = "tbAusgabetextBox";
            this.tbAusgabetextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAusgabetextBox.Size = new System.Drawing.Size(393, 204);
            this.tbAusgabetextBox.TabIndex = 6;
            // 
            // buttonchilds
            // 
            this.buttonchilds.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonchilds.Location = new System.Drawing.Point(740, 297);
            this.buttonchilds.Name = "buttonchilds";
            this.buttonchilds.Size = new System.Drawing.Size(100, 23);
            this.buttonchilds.TabIndex = 7;
            this.buttonchilds.Text = "childs";
            this.buttonchilds.UseVisualStyleBackColor = true;
            this.buttonchilds.Click += new System.EventHandler(this.buttonchilds_Click);
            // 
            // textBoxByTagName
            // 
            this.textBoxByTagName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxByTagName.Location = new System.Drawing.Point(726, 345);
            this.textBoxByTagName.Name = "textBoxByTagName";
            this.textBoxByTagName.Size = new System.Drawing.Size(140, 20);
            this.textBoxByTagName.TabIndex = 8;
            // 
            // buttonbyTagName
            // 
            this.buttonbyTagName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonbyTagName.Location = new System.Drawing.Point(740, 399);
            this.buttonbyTagName.Name = "buttonbyTagName";
            this.buttonbyTagName.Size = new System.Drawing.Size(100, 23);
            this.buttonbyTagName.TabIndex = 9;
            this.buttonbyTagName.Text = "byTagName";
            this.buttonbyTagName.UseVisualStyleBackColor = true;
            this.buttonbyTagName.Click += new System.EventHandler(this.buttonbyTagName_Click);
            // 
            // buttonroot
            // 
            this.buttonroot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonroot.Location = new System.Drawing.Point(740, 491);
            this.buttonroot.Name = "buttonroot";
            this.buttonroot.Size = new System.Drawing.Size(100, 23);
            this.buttonroot.TabIndex = 10;
            this.buttonroot.Text = "root";
            this.buttonroot.UseVisualStyleBackColor = true;
            this.buttonroot.Click += new System.EventHandler(this.buttonroot_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.BackColor = System.Drawing.Color.Linen;
            this.buttonBeenden.ForeColor = System.Drawing.Color.Red;
            this.buttonBeenden.Location = new System.Drawing.Point(740, 531);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(100, 23);
            this.buttonBeenden.TabIndex = 11;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = false;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // tbEingabe
            // 
            this.tbEingabe.Location = new System.Drawing.Point(12, 297);
            this.tbEingabe.Name = "tbEingabe";
            this.tbEingabe.Size = new System.Drawing.Size(393, 20);
            this.tbEingabe.TabIndex = 12;
            // 
            // labeleinfügen
            // 
            this.labeleinfügen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeleinfügen.AutoSize = true;
            this.labeleinfügen.Location = new System.Drawing.Point(58, 348);
            this.labeleinfügen.Name = "labeleinfügen";
            this.labeleinfügen.Size = new System.Drawing.Size(89, 13);
            this.labeleinfügen.TabIndex = 13;
            this.labeleinfügen.Text = "Element einfügen";
            // 
            // labelersetzen
            // 
            this.labelersetzen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelersetzen.AutoSize = true;
            this.labelersetzen.Location = new System.Drawing.Point(-3, 388);
            this.labelersetzen.Name = "labelersetzen";
            this.labelersetzen.Size = new System.Drawing.Size(150, 13);
            this.labelersetzen.TabIndex = 14;
            this.labelersetzen.Text = "Text,CData einfügen/ersetzen";
            // 
            // labelentfernen
            // 
            this.labelentfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelentfernen.AutoSize = true;
            this.labelentfernen.Location = new System.Drawing.Point(2, 476);
            this.labelentfernen.Name = "labelentfernen";
            this.labelentfernen.Size = new System.Drawing.Size(145, 13);
            this.labelentfernen.TabIndex = 15;
            this.labelentfernen.Text = "Attribut hinzufügen/entfernen";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Location = new System.Drawing.Point(54, 534);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxValue.Location = new System.Drawing.Point(337, 534);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(158, 20);
            this.textBoxValue.TabIndex = 17;
            // 
            // buttonChild
            // 
            this.buttonChild.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonChild.Location = new System.Drawing.Point(149, 342);
            this.buttonChild.Name = "buttonChild";
            this.buttonChild.Size = new System.Drawing.Size(75, 23);
            this.buttonChild.TabIndex = 18;
            this.buttonChild.Text = "Child";
            this.buttonChild.UseVisualStyleBackColor = true;
            this.buttonChild.Click += new System.EventHandler(this.buttonChild_Click);
            // 
            // buttonBefore
            // 
            this.buttonBefore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBefore.Location = new System.Drawing.Point(244, 342);
            this.buttonBefore.Name = "buttonBefore";
            this.buttonBefore.Size = new System.Drawing.Size(75, 23);
            this.buttonBefore.TabIndex = 19;
            this.buttonBefore.Text = "Before";
            this.buttonBefore.UseVisualStyleBackColor = true;
            this.buttonBefore.Click += new System.EventHandler(this.buttonBefore_Click);
            // 
            // buttonAfter
            // 
            this.buttonAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAfter.Location = new System.Drawing.Point(339, 342);
            this.buttonAfter.Name = "buttonAfter";
            this.buttonAfter.Size = new System.Drawing.Size(75, 23);
            this.buttonAfter.TabIndex = 20;
            this.buttonAfter.Text = "After";
            this.buttonAfter.UseVisualStyleBackColor = true;
            this.buttonAfter.Click += new System.EventHandler(this.buttonAfter_Click);
            // 
            // buttonText
            // 
            this.buttonText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonText.Location = new System.Drawing.Point(149, 388);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(75, 23);
            this.buttonText.TabIndex = 21;
            this.buttonText.Text = "Text";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonCData
            // 
            this.buttonCData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCData.Location = new System.Drawing.Point(244, 388);
            this.buttonCData.Name = "buttonCData";
            this.buttonCData.Size = new System.Drawing.Size(75, 23);
            this.buttonCData.TabIndex = 22;
            this.buttonCData.Text = "CData";
            this.buttonCData.UseVisualStyleBackColor = true;
            this.buttonCData.Click += new System.EventHandler(this.buttonCData_Click);
            // 
            // buttonErsetzen
            // 
            this.buttonErsetzen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonErsetzen.Location = new System.Drawing.Point(339, 388);
            this.buttonErsetzen.Name = "buttonErsetzen";
            this.buttonErsetzen.Size = new System.Drawing.Size(75, 23);
            this.buttonErsetzen.TabIndex = 23;
            this.buttonErsetzen.Text = "Ersetzen";
            this.buttonErsetzen.UseVisualStyleBackColor = true;
            this.buttonErsetzen.Click += new System.EventHandler(this.buttonErsetzen_Click);
            // 
            // buttonAttribut
            // 
            this.buttonAttribut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAttribut.Location = new System.Drawing.Point(149, 476);
            this.buttonAttribut.Name = "buttonAttribut";
            this.buttonAttribut.Size = new System.Drawing.Size(75, 23);
            this.buttonAttribut.TabIndex = 24;
            this.buttonAttribut.Text = "Attribut";
            this.buttonAttribut.UseVisualStyleBackColor = true;
            this.buttonAttribut.Click += new System.EventHandler(this.buttonAttribut_Click);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEntfernen.Location = new System.Drawing.Point(244, 476);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(75, 23);
            this.buttonEntfernen.TabIndex = 25;
            this.buttonEntfernen.Text = "Entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(54, 32);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(320, 20);
            this.textBoxPath.TabIndex = 26;
            this.textBoxPath.Click += new System.EventHandler(this.textBoxPath_Click);
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // labelpath
            // 
            this.labelpath.AutoSize = true;
            this.labelpath.Location = new System.Drawing.Point(2, 35);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(52, 13);
            this.labelpath.TabIndex = 27;
            this.labelpath.Text = "Xml Path:";
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(380, 29);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonsubmit.TabIndex = 28;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 582);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.buttonAttribut);
            this.Controls.Add(this.buttonErsetzen);
            this.Controls.Add(this.buttonCData);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonAfter);
            this.Controls.Add(this.buttonBefore);
            this.Controls.Add(this.buttonChild);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelentfernen);
            this.Controls.Add(this.labelersetzen);
            this.Controls.Add(this.labeleinfügen);
            this.Controls.Add(this.tbEingabe);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonroot);
            this.Controls.Add(this.buttonbyTagName);
            this.Controls.Add(this.textBoxByTagName);
            this.Controls.Add(this.buttonchilds);
            this.Controls.Add(this.tbAusgabetextBox);
            this.Controls.Add(this.Xbutton);
            this.Controls.Add(this.childbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.parentbutton);
            this.Controls.Add(this.statusStrip1);
            this.Name = "NavigationForm";
            this.Text = "Navigition mit DOM";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button parentbutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button childbutton;
        private System.Windows.Forms.Button Xbutton;
        private System.Windows.Forms.TextBox tbAusgabetextBox;
        private System.Windows.Forms.Button buttonchilds;
        private System.Windows.Forms.TextBox textBoxByTagName;
        private System.Windows.Forms.Button buttonbyTagName;
        private System.Windows.Forms.Button buttonroot;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.TextBox tbEingabe;
        private System.Windows.Forms.Label labeleinfügen;
        private System.Windows.Forms.Label labelersetzen;
        private System.Windows.Forms.Label labelentfernen;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonChild;
        private System.Windows.Forms.Button buttonBefore;
        private System.Windows.Forms.Button buttonAfter;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonCData;
        private System.Windows.Forms.Button buttonErsetzen;
        private System.Windows.Forms.Button buttonAttribut;
        private System.Windows.Forms.Button buttonEntfernen;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.Button buttonsubmit;
    }
}

