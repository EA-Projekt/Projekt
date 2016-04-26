namespace test
{
    partial class Form_Buchung_tätigen
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
            this.DateTimePicker_Date_of_receipt = new System.Windows.Forms.DateTimePicker();
            this.Label_Rechnungsdatum = new System.Windows.Forms.Label();
            this.Label_Eingangsdatum = new System.Windows.Forms.Label();
            this.DateTimePicker_Rechnungsdatum = new System.Windows.Forms.DateTimePicker();
            this.Label_Anmerkung = new System.Windows.Forms.Label();
            this.TextBox_Note = new System.Windows.Forms.TextBox();
            this.Button_Senden = new System.Windows.Forms.Button();
            this.Label_Betrag = new System.Windows.Forms.Label();
            this.TextBox_Betrag = new System.Windows.Forms.TextBox();
            this.Label_Belegnummer = new System.Windows.Forms.Label();
            this.TextBox_Belegnummer = new System.Windows.Forms.TextBox();
            this.Label_Umsatzsteuer = new System.Windows.Forms.Label();
            this.TextBox_Umsatzsteuer = new System.Windows.Forms.TextBox();
            this.Label_Vorsteuer = new System.Windows.Forms.Label();
            this.TextBox_Vorsteuer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DateTimePicker_Date_of_receipt
            // 
            this.DateTimePicker_Date_of_receipt.Location = new System.Drawing.Point(128, 110);
            this.DateTimePicker_Date_of_receipt.Name = "DateTimePicker_Date_of_receipt";
            this.DateTimePicker_Date_of_receipt.Size = new System.Drawing.Size(241, 22);
            this.DateTimePicker_Date_of_receipt.TabIndex = 2;
            // 
            // Label_Rechnungsdatum
            // 
            this.Label_Rechnungsdatum.AutoSize = true;
            this.Label_Rechnungsdatum.Location = new System.Drawing.Point(12, 58);
            this.Label_Rechnungsdatum.Name = "Label_Rechnungsdatum";
            this.Label_Rechnungsdatum.Size = new System.Drawing.Size(123, 17);
            this.Label_Rechnungsdatum.TabIndex = 3;
            this.Label_Rechnungsdatum.Text = "Rechnungsdatum:";
            this.Label_Rechnungsdatum.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Eingangsdatum
            // 
            this.Label_Eingangsdatum.AutoSize = true;
            this.Label_Eingangsdatum.Location = new System.Drawing.Point(12, 110);
            this.Label_Eingangsdatum.Name = "Label_Eingangsdatum";
            this.Label_Eingangsdatum.Size = new System.Drawing.Size(110, 17);
            this.Label_Eingangsdatum.TabIndex = 4;
            this.Label_Eingangsdatum.Text = "Eingangsdatum:";
            this.Label_Eingangsdatum.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateTimePicker_Rechnungsdatum
            // 
            this.DateTimePicker_Rechnungsdatum.Location = new System.Drawing.Point(137, 58);
            this.DateTimePicker_Rechnungsdatum.Name = "DateTimePicker_Rechnungsdatum";
            this.DateTimePicker_Rechnungsdatum.Size = new System.Drawing.Size(252, 22);
            this.DateTimePicker_Rechnungsdatum.TabIndex = 1;
            this.DateTimePicker_Rechnungsdatum.ValueChanged += new System.EventHandler(this.DateTimePicker_RE_Date_ValueChanged);
            // 
            // Label_Anmerkung
            // 
            this.Label_Anmerkung.AutoSize = true;
            this.Label_Anmerkung.Location = new System.Drawing.Point(12, 159);
            this.Label_Anmerkung.Name = "Label_Anmerkung";
            this.Label_Anmerkung.Size = new System.Drawing.Size(84, 17);
            this.Label_Anmerkung.TabIndex = 6;
            this.Label_Anmerkung.Text = "Anmerkung:";
            this.Label_Anmerkung.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBox_Note
            // 
            this.TextBox_Note.Location = new System.Drawing.Point(102, 159);
            this.TextBox_Note.Multiline = true;
            this.TextBox_Note.Name = "TextBox_Note";
            this.TextBox_Note.Size = new System.Drawing.Size(276, 56);
            this.TextBox_Note.TabIndex = 3;
            this.TextBox_Note.TextChanged += new System.EventHandler(this.TextBox_Note_TextChanged);
            // 
            // Button_Senden
            // 
            this.Button_Senden.Location = new System.Drawing.Point(562, 326);
            this.Button_Senden.Name = "Button_Senden";
            this.Button_Senden.Size = new System.Drawing.Size(117, 62);
            this.Button_Senden.TabIndex = 7;
            this.Button_Senden.Text = "Senden";
            this.Button_Senden.UseVisualStyleBackColor = true;
            this.Button_Senden.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Label_Betrag
            // 
            this.Label_Betrag.AutoSize = true;
            this.Label_Betrag.Location = new System.Drawing.Point(12, 241);
            this.Label_Betrag.Name = "Label_Betrag";
            this.Label_Betrag.Size = new System.Drawing.Size(54, 17);
            this.Label_Betrag.TabIndex = 9;
            this.Label_Betrag.Text = "Betrag:";
            // 
            // TextBox_Betrag
            // 
            this.TextBox_Betrag.Location = new System.Drawing.Point(78, 241);
            this.TextBox_Betrag.Name = "TextBox_Betrag";
            this.TextBox_Betrag.Size = new System.Drawing.Size(163, 22);
            this.TextBox_Betrag.TabIndex = 4;
            // 
            // Label_Belegnummer
            // 
            this.Label_Belegnummer.AutoSize = true;
            this.Label_Belegnummer.Location = new System.Drawing.Point(12, 9);
            this.Label_Belegnummer.Name = "Label_Belegnummer";
            this.Label_Belegnummer.Size = new System.Drawing.Size(99, 17);
            this.Label_Belegnummer.TabIndex = 11;
            this.Label_Belegnummer.Text = "Belegnummer:";
            // 
            // TextBox_Belegnummer
            // 
            this.TextBox_Belegnummer.Location = new System.Drawing.Point(117, 9);
            this.TextBox_Belegnummer.Name = "TextBox_Belegnummer";
            this.TextBox_Belegnummer.Size = new System.Drawing.Size(173, 22);
            this.TextBox_Belegnummer.TabIndex = 0;
            this.TextBox_Belegnummer.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Label_Umsatzsteuer
            // 
            this.Label_Umsatzsteuer.AutoSize = true;
            this.Label_Umsatzsteuer.Location = new System.Drawing.Point(12, 290);
            this.Label_Umsatzsteuer.Name = "Label_Umsatzsteuer";
            this.Label_Umsatzsteuer.Size = new System.Drawing.Size(99, 17);
            this.Label_Umsatzsteuer.TabIndex = 13;
            this.Label_Umsatzsteuer.Text = "Umsatzsteuer:";
            // 
            // TextBox_Umsatzsteuer
            // 
            this.TextBox_Umsatzsteuer.Location = new System.Drawing.Point(117, 290);
            this.TextBox_Umsatzsteuer.Name = "TextBox_Umsatzsteuer";
            this.TextBox_Umsatzsteuer.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Umsatzsteuer.TabIndex = 5;
            this.TextBox_Umsatzsteuer.TextChanged += new System.EventHandler(this.TextBox_Turnover_tax_TextChanged);
            // 
            // Label_Vorsteuer
            // 
            this.Label_Vorsteuer.AutoSize = true;
            this.Label_Vorsteuer.Location = new System.Drawing.Point(13, 339);
            this.Label_Vorsteuer.Name = "Label_Vorsteuer";
            this.Label_Vorsteuer.Size = new System.Drawing.Size(74, 17);
            this.Label_Vorsteuer.TabIndex = 15;
            this.Label_Vorsteuer.Text = "Vorsteuer:";
            // 
            // TextBox_Vorsteuer
            // 
            this.TextBox_Vorsteuer.Location = new System.Drawing.Point(93, 339);
            this.TextBox_Vorsteuer.Name = "TextBox_Vorsteuer";
            this.TextBox_Vorsteuer.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Vorsteuer.TabIndex = 6;
            this.TextBox_Vorsteuer.TextChanged += new System.EventHandler(this.TextBox_Input_tax_TextChanged);
            // 
            // Form_Buchung_tätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 400);
            this.Controls.Add(this.TextBox_Vorsteuer);
            this.Controls.Add(this.Label_Vorsteuer);
            this.Controls.Add(this.TextBox_Umsatzsteuer);
            this.Controls.Add(this.Label_Umsatzsteuer);
            this.Controls.Add(this.TextBox_Belegnummer);
            this.Controls.Add(this.Label_Belegnummer);
            this.Controls.Add(this.TextBox_Betrag);
            this.Controls.Add(this.Label_Betrag);
            this.Controls.Add(this.Button_Senden);
            this.Controls.Add(this.TextBox_Note);
            this.Controls.Add(this.Label_Anmerkung);
            this.Controls.Add(this.DateTimePicker_Rechnungsdatum);
            this.Controls.Add(this.Label_Eingangsdatum);
            this.Controls.Add(this.Label_Rechnungsdatum);
            this.Controls.Add(this.DateTimePicker_Date_of_receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Buchung_tätigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buchung tätigen";
            this.Load += new System.EventHandler(this.Buchen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker_Date_of_receipt;
        private System.Windows.Forms.Label Label_Rechnungsdatum;
        private System.Windows.Forms.Label Label_Eingangsdatum;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Rechnungsdatum;
        private System.Windows.Forms.Label Label_Anmerkung;
        private System.Windows.Forms.TextBox TextBox_Note;
        private System.Windows.Forms.Button Button_Senden;
        private System.Windows.Forms.Label Label_Betrag;
        private System.Windows.Forms.TextBox TextBox_Betrag;
        private System.Windows.Forms.Label Label_Belegnummer;
        private System.Windows.Forms.TextBox TextBox_Belegnummer;
        private System.Windows.Forms.Label Label_Umsatzsteuer;
        private System.Windows.Forms.TextBox TextBox_Umsatzsteuer;
        private System.Windows.Forms.Label Label_Vorsteuer;
        private System.Windows.Forms.TextBox TextBox_Vorsteuer;
    }
}