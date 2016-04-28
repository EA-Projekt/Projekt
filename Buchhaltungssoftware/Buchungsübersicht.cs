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
    public partial class Form_Buchungsübersicht : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Form_Buchungsübersicht()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Paul\Desktop\EingabeAusgabe\EA_Datenbank.mdb;Persist Security Info=False;";
        }

        private void dataGridView_Buchungsübersicht_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Buchungsübersicht_Load(object sender, EventArgs e)
        {
            Daten_laden();
        }
        private void Daten_laden()
        {
            dataGridView_Buchungsübersicht.DataSource = übersichtList();
        }
        private DataTable übersichtList()
        {
            DataTable dt = new DataTable();
            using (con)
            {
                using (OleDbCommand command = new OleDbCommand("select * from Buchungen", con))
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
