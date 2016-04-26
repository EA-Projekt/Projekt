namespace test
{
    partial class LoginBildschirm
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
            this.Button_Bestätigen = new System.Windows.Forms.Button();
            this.Label_Benutzename = new System.Windows.Forms.Label();
            this.Label_Passwort = new System.Windows.Forms.Label();
            this.TextBox_Benutzername = new System.Windows.Forms.TextBox();
            this.TextBox_Passwort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Bestätigen
            // 
            this.Button_Bestätigen.Location = new System.Drawing.Point(292, 164);
            this.Button_Bestätigen.Name = "Button_Bestätigen";
            this.Button_Bestätigen.Size = new System.Drawing.Size(193, 77);
            this.Button_Bestätigen.TabIndex = 0;
            this.Button_Bestätigen.Text = "Bestätigen";
            this.Button_Bestätigen.UseVisualStyleBackColor = true;
            this.Button_Bestätigen.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Benutzename
            // 
            this.Label_Benutzename.AutoSize = true;
            this.Label_Benutzename.Location = new System.Drawing.Point(12, 9);
            this.Label_Benutzename.Name = "Label_Benutzename";
            this.Label_Benutzename.Size = new System.Drawing.Size(104, 17);
            this.Label_Benutzename.TabIndex = 1;
            this.Label_Benutzename.Text = "Benutzername:";
            this.Label_Benutzename.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Passwort
            // 
            this.Label_Passwort.AutoSize = true;
            this.Label_Passwort.Location = new System.Drawing.Point(12, 38);
            this.Label_Passwort.Name = "Label_Passwort";
            this.Label_Passwort.Size = new System.Drawing.Size(69, 17);
            this.Label_Passwort.TabIndex = 2;
            this.Label_Passwort.Text = "Passwort:";
            // 
            // TextBox_Benutzername
            // 
            this.TextBox_Benutzername.Location = new System.Drawing.Point(122, 9);
            this.TextBox_Benutzername.Name = "TextBox_Benutzername";
            this.TextBox_Benutzername.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Benutzername.TabIndex = 3;
            this.TextBox_Benutzername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBox_Passwort
            // 
            this.TextBox_Passwort.Location = new System.Drawing.Point(122, 38);
            this.TextBox_Passwort.Name = "TextBox_Passwort";
            this.TextBox_Passwort.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Passwort.TabIndex = 4;
            this.TextBox_Passwort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginBildschirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 253);
            this.Controls.Add(this.TextBox_Passwort);
            this.Controls.Add(this.TextBox_Benutzername);
            this.Controls.Add(this.Label_Passwort);
            this.Controls.Add(this.Label_Benutzename);
            this.Controls.Add(this.Button_Bestätigen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginBildschirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login-Bildschirm";
            this.Load += new System.EventHandler(this.LoginBildschirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Bestätigen;
        private System.Windows.Forms.Label Label_Benutzename;
        private System.Windows.Forms.Label Label_Passwort;
        private System.Windows.Forms.TextBox TextBox_Benutzername;
        private System.Windows.Forms.TextBox TextBox_Passwort;
    }
}