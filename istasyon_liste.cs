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
using System.Data.SqlClient;
namespace UyduOtomasyonu
{
    public partial class istasyon_liste : Form
    {
        public istasyon_liste()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\UyduVeriTabanı2.mdb");
        DataTable tablo;
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string sqlText = "DELETE FROM Istasyon where istasyon_adi = '" + satır.Cells["istasyon_adi"].Value.ToString() + "'";
            OleDbCommand AccessCommand = new OleDbCommand();
            islem(AccessCommand, sqlText);
            YenileListe();
        }

        private void istasyon_liste_Load(object sender, EventArgs e)
        {
            YenileListe();

        }

        private void YenileListe()
        {
            string cumle = "select * from Istasyon";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
           

            dataGridView1.DataSource = listele(adtr2, cumle);
        }

        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, Aconnection);
            adtr.Fill(tablo);
            Aconnection.Close();
            return tablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void islem(OleDbCommand command, string sorgu)
        {
            Aconnection.Open();
            command.Connection = Aconnection;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            Aconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
