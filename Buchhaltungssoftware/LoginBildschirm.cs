using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace test
{
    public partial class LoginBildschirm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        Form_Buchhaltung Buchhaltung;
        public LoginBildschirm()
        {
            InitializeComponent();
            Buchhaltung = new Form_Buchhaltung();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
        }

        private void LoginBildschirm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                Label_Connection_Status.Text = "Connection Successful";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            command.CommandText = "select * from Login where Benutzername='" + TextBox_Benutzername.Text + "' and Passwort='" + TextBox_Passwort.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Benutzername und Passwort waren korrekt");

                Buchhaltung.ShowDialog();
                Close();

            }
            else
            if (count > 1)
            {
                MessageBox.Show("Benutzername und Passwort sind mehr als einmal vorhanden. Somit ist keine eindeutige Zuweisung möglich");
            }
            else
            {
                MessageBox.Show("Benutzername bzw. Passwort ist inkorrekt");
            }
            con.Close();

        }
        private void Button_Verlassen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
