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
    public partial class gorev : Form
    {
        public gorev()
        {
            InitializeComponent();
        }
        OleDbConnection Aconnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" + Application.StartupPath + "\\UyduVeriTabanı2.mdb");
        DataTable tablo;
        private void gorev_Load(object sender, EventArgs e)
        {
            bos_uydu_grid();
            tekrarla();
        }

        private void bos_uydu_grid()
        {
            string komut = "select * from Uydu where gorevde = 'hayır'";
            bos_Uydu(modeltxt, komut);
        }

        private void tekrarla()
        {
            string komut3 = "SELECT * from gorev";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = listele(adtr2, komut3);
        }

        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            
            tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, Aconnection);
            adtr.Fill(tablo);
            Aconnection.Close();
            return tablo;
        }
        public void bos_Uydu(ComboBox combo, string komut)
        {
            Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut,Aconnection);
            OleDbDataReader oku = AccessCommand.ExecuteReader();
            while (oku.Read())
            {
                combo.Items.Add(oku["modeli"].ToString());
            }
            Aconnection.Close();
        }
        public void istasyon_bul(TextBox adi, TextBox konumu, string komut)
        {
            Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut,Aconnection);
            OleDbDataReader oku = AccessCommand.ExecuteReader();
            while (oku.Read())
            {
                konumu.Text = oku["istasyon_yeri"].ToString();
            }
            Aconnection.Close();
        }
        public void uydu_modelcombo(ComboBox model, TextBox marka, TextBox menzil, TextBox hiz, string komut)
        {
            Aconnection.Open();
            OleDbCommand AccessCommand = new OleDbCommand(komut, Aconnection);
            OleDbDataReader oku = AccessCommand.ExecuteReader();
            while (oku.Read())
            {
                markatxt.Text = oku["markasi"].ToString();
                menziltxt.Text = oku["kullanım_menzili"].ToString();
                hiztxt.Text = oku["maks_Hizi"].ToString();
            }
            Aconnection.Close();
        }

        private void istasyon_adtxt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       

      
        private void istasyon_adtxt_TextChanged_1(object sender, EventArgs e)
        {
            string komut2 = "select * from Istasyon where istasyon_adi like '" + istasyon_adtxt.Text + "'";
            istasyon_bul(istasyon_adtxt, istasyon_kontxt, komut2);
        }
        private void modeltxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string komut2 = "select * from Uydu where modeli like '" + modeltxt.SelectedItem + "'";
            uydu_modelcombo(modeltxt, markatxt, menziltxt, hiztxt, komut2);
        }

        private void guntxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gorevbittxt_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = gorevbastxt.Value.Date;
            DateTime end = gorevbittxt.Value.Date;
            int gun1 = (int)(end-start).TotalDays;
            guntxt.Text = gun1.ToString();
        }

        private void gorevbastxt_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = gorevbastxt.Value.Date;
            DateTime end = gorevbittxt.Value.Date;
            int gun = (int)(end - start).TotalDays;
            guntxt.Text = gun.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command1 = new OleDbCommand();
            string komut = "insert into gorev(istayon_adi,istasyon_yer,marka,modeli,bas_tarih,bit_tarih,gun) values('" + istasyon_adtxt.Text.ToString() + "','" + istasyon_kontxt.Text.ToString() + "','" + markatxt.Text.ToString() + "','" + modeltxt.Text.ToString() + "','" + gorevbastxt.Text.ToString() + "','" + gorevbittxt.Text.ToString() + "','" + guntxt.Text.ToString() + "')";
            islem(command1, komut);
            string komut3 = "update Uydu set gorevde = 'evet' where modeli='"+modeltxt.Text+"'";
            modeltxt.Items.Clear();
            OleDbCommand command3 = new OleDbCommand();
            islem(command3, komut3);
            istasyon_kontxt.Clear();
            markatxt.Clear();
            modeltxt.Text = " ";
            gorevbastxt.Text = DateTime.Now.ToString();
            gorevbittxt.Text = DateTime.Now.ToString();
            bos_uydu_grid();
            tekrarla();
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
            DataGridViewRow secilen = dataGridView1.CurrentRow;
            string komut = "delete from gorev where modeli = '" + secilen.Cells["modeli"].Value.ToString() + "'";
            OleDbCommand command = new OleDbCommand();
            islem(command, komut);
            string komut2 = "update Uydu set gorevde = 'hayır' where modeli='" + secilen.Cells["modeli"].Value.ToString() + "'";
            OleDbCommand command2 = new OleDbCommand();
            islem(command2, komut2);
            modeltxt.Items.Clear();
            bos_uydu_grid();
            tekrarla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
