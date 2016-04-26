namespace test
{
    partial class Form_Buchhaltung
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
            this.Button_Buchung_tätigen = new System.Windows.Forms.Button();
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung = new System.Windows.Forms.Button();
            this.Button_Anlagenverzeichnis_ausgeben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Buchung_tätigen
            // 
            this.Button_Buchung_tätigen.Location = new System.Drawing.Point(12, 7);
            this.Button_Buchung_tätigen.Name = "Button_Buchung_tätigen";
            this.Button_Buchung_tätigen.Size = new System.Drawing.Size(191, 131);
            this.Button_Buchung_tätigen.TabIndex = 0;
            this.Button_Buchung_tätigen.Text = "Buchung tätigen";
            this.Button_Buchung_tätigen.UseVisualStyleBackColor = true;
            this.Button_Buchung_tätigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Einnahmen_bzw_Ausgaben_Rechnung
            // 
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Location = new System.Drawing.Point(12, 144);
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Name = "Button_Einnahmen_bzw_Ausgaben_Rechnung";
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Size = new System.Drawing.Size(191, 131);
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.TabIndex = 1;
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Text = "Einnahmen bzw. Ausgaben Rechnung ";
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.UseVisualStyleBackColor = true;
            this.Button_Einnahmen_bzw_Ausgaben_Rechnung.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_Anlagenverzeichnis_ausgeben
            // 
            this.Button_Anlagenverzeichnis_ausgeben.Location = new System.Drawing.Point(12, 281);
            this.Button_Anlagenverzeichnis_ausgeben.Name = "Button_Anlagenverzeichnis_ausgeben";
            this.Button_Anlagenverzeichnis_ausgeben.Size = new System.Drawing.Size(191, 131);
            this.Button_Anlagenverzeichnis_ausgeben.TabIndex = 2;
            this.Button_Anlagenverzeichnis_ausgeben.Text = "Anlagenverzeichnis ausgeben";
            this.Button_Anlagenverzeichnis_ausgeben.UseVisualStyleBackColor = true;
            this.Button_Anlagenverzeichnis_ausgeben.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_Buchhaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 541);
            this.Controls.Add(this.Button_Anlagenverzeichnis_ausgeben);
            this.Controls.Add(this.Button_Einnahmen_bzw_Ausgaben_Rechnung);
            this.Controls.Add(this.Button_Buchung_tätigen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Buchhaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchhaltung";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Buchung_tätigen;
        private System.Windows.Forms.Button Button_Einnahmen_bzw_Ausgaben_Rechnung;
        private System.Windows.Forms.Button Button_Anlagenverzeichnis_ausgeben;
    }
}

