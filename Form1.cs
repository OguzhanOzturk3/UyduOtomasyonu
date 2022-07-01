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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            istasyon istasyon1 = new istasyon();
            istasyon1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istasyon_liste istasyon_liste1 = new istasyon_liste();
            istasyon_liste1.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            uyduekleme uyduekleme1 = new uyduekleme();
            uyduekleme1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uydulistele uydulistele1 = new uydulistele();
            uydulistele1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gorev gorev1 = new gorev();
            gorev1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
