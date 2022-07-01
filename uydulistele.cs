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
    public partial class uydulistele : Form
    {
        public uydulistele()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\UyduVeriTabanı2.mdb");
        DataTable tablo1;

        

        private void uydulistele_Load(object sender, EventArgs e)
        {
            yenile_uydu_listele();

        }

        private void yenile_uydu_listele()
        {
            string cumle = "select  * from Uydu";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = listele(adtr2, cumle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            tablo1 = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, Aconnection);
            adtr.Fill(tablo1);
            Aconnection.Close();
            return tablo1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string sqlText = "DELETE FROM Uydu where modeli = '" + satır.Cells["modeli"].Value.ToString() + "'";
            OleDbCommand AccessCommand = new OleDbCommand();
            islem(AccessCommand, sqlText);
            yenile_uydu_listele();
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
