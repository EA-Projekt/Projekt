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
    public partial class Form_Fahrtenbuch : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form_Fahrtenbuch()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
        }

        private void Form_Fahrtenbuch_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
        private void Daten_laden()
        {
            dataGridView_Fahrtenbuch.DataSource = fahrtenbuch();
        }
        private DataTable fahrtenbuch()
        {
            DataTable dt = new DataTable();
            using (con)
            {
                using (OleDbCommand command = new OleDbCommand("select * from Fahrtenbuch", con))
                {
                    con.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
                }
            }
            return dt;
        }
    }
}
