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
    public partial class uyduekleme : Form
    {
        public uyduekleme()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\UyduVeriTabanı2.mdb");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlText = "INSERT INTO Uydu (markasi, modeli, kullanım_menzili,maks_Hizi,uretim_Yili,gorevde) values('" + markatext.Text.ToString() + "', '" + modeltext.Text.ToString() + "','" + menziltext.Text.ToString() + "','" + hiztext.Text.ToString() + "','" + yiltext.Text.ToString() + "','hayır')";
            OleDbCommand AccessCommand = new OleDbCommand();
            islem(AccessCommand, sqlText);
            modeltext.Clear();
            menziltext.Clear();
            hiztext.Clear();
            yiltext.Clear();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        public void islem(OleDbCommand command, string sorgu)
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
