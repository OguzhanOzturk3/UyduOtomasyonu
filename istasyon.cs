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

namespace UyduOtomasyonu
{
    public partial class istasyon : Form
    {
        public istasyon()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\UyduVeriTabanı2.mdb");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            string sqlText = "INSERT INTO Istasyon (istasyon_adi, istasyon_yeri, istasyon_mail) values('" + istasyon_ad.Text.ToString() + "', '" + istasyon_yer.Text.ToString() + "','" + istasyon_mail.Text.ToString() + "')";
            OleDbCommand AccessCommand = new OleDbCommand();
            islem(AccessCommand, sqlText);
            istasyon_ad.Clear();
            istasyon_yer.Clear();
            istasyon_mail.Clear();

        }

        private void istasyon_ad_TextChanged(object sender, EventArgs e)
        {

        }
        public void islem(OleDbCommand command,string sorgu)
        {
            Aconnection.Open();
            command.Connection = Aconnection;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            Aconnection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
