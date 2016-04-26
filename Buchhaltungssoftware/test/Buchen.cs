using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;



namespace test
{
   
    public partial class Form_Buchung_tätigen : Form
    {
        public Form_Buchung_tätigen()
        {
            CultureInfo cultureInfo = new CultureInfo("en-US",true);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            InitializeComponent();
        }

        private void Buchen_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Note_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void TextBox_Turnover_tax_TextChanged(object sender, EventArgs e)
        {
            
            TextBox_Umsatzsteuer.SelectAll();
            //This SelectAll()-Method is necessary, because Selection.Length doesn't work until there is something selected
            //TextBox_Turnover_tax.SelectionStart=0; - would also work 

            if (TextBox_Umsatzsteuer.SelectionLength > 0)
            {
                TextBox_Vorsteuer.Enabled = false;
            }
            else
            {
                TextBox_Vorsteuer.Enabled = true;
            }

            TextBox_Umsatzsteuer.SelectionStart = TextBox_Umsatzsteuer.SelectionLength;

        }

        private void TextBox_Input_tax_TextChanged(object sender, EventArgs e)
        {
            
            TextBox_Vorsteuer.SelectAll();
            //This SelectAll()-Method is necessary, because Selection.Length doesn't work until there is something selected
            //TextBox_Input_tax.SelectionStart=0; - would also work 

            if (TextBox_Vorsteuer.SelectionLength > 0)
            {
                TextBox_Umsatzsteuer.Enabled = false;
            }
            else
            {
                TextBox_Umsatzsteuer.Enabled = true; 
            }

            TextBox_Vorsteuer.SelectionStart=TextBox_Vorsteuer.SelectionLength;
        }

        private void DateTimePicker_RE_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUCHUNG WURDE GETÄTIGT!");
            
        }
    }
}
