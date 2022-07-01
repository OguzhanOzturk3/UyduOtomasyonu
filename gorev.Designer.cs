
namespace UyduOtomasyonu
{
    partial class gorev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.istasyon_kontxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gorevbastxt = new System.Windows.Forms.DateTimePicker();
            this.gorevbittxt = new System.Windows.Forms.DateTimePicker();
            this.modeltxt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menziltxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hiztxt = new System.Windows.Forms.TextBox();
            this.guntxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.istasyon_adtxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Bitis_Tarihi,
            this.Gun});
            this.dataGridView1.Location = new System.Drawing.Point(342, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // istasyon_kontxt
            // 
            this.istasyon_kontxt.Location = new System.Drawing.Point(147, 80);
            this.istasyon_kontxt.Name = "istasyon_kontxt";
            this.istasyon_kontxt.Size = new System.Drawing.Size(100, 22);
            this.istasyon_kontxt.TabIndex = 2;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(135, 199);
            this.markatxt.Name = "markatxt";
            this.markatxt.Size = new System.Drawing.Size(100, 22);
            this.markatxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "İstasyon Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "İstasyon Konumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Uydu Markası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uydu Modeli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Görev Başlangıcı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Görev Bitişi";
            // 
            // gorevbastxt
            // 
            this.gorevbastxt.Location = new System.Drawing.Point(136, 319);
            this.gorevbastxt.Name = "gorevbastxt";
            this.gorevbastxt.Size = new System.Drawing.Size(200, 22);
            this.gorevbastxt.TabIndex = 15;
            this.gorevbastxt.ValueChanged += new System.EventHandler(this.gorevbastxt_ValueChanged);
            // 
            // gorevbittxt
            // 
            this.gorevbittxt.Location = new System.Drawing.Point(135, 359);
            this.gorevbittxt.Name = "gorevbittxt";
            this.gorevbittxt.Size = new System.Drawing.Size(200, 22);
            this.gorevbittxt.TabIndex = 16;
            this.gorevbittxt.ValueChanged += new System.EventHandler(this.gorevbittxt_ValueChanged);
            // 
            // modeltxt
            // 
            this.modeltxt.FormattingEnabled = true;
            this.modeltxt.Location = new System.Drawing.Point(135, 157);
            this.modeltxt.Name = "modeltxt";
            this.modeltxt.Size = new System.Drawing.Size(121, 24);
            this.modeltxt.TabIndex = 17;
            this.modeltxt.SelectedIndexChanged += new System.EventHandler(this.modeltxt_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Kullanım Menzili";
            // 
            // menziltxt
            // 
            this.menziltxt.Location = new System.Drawing.Point(135, 239);
            this.menziltxt.Name = "menziltxt";
            this.menziltxt.Size = new System.Drawing.Size(100, 22);
            this.menziltxt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Maksimum Hızı";
            // 
            // hiztxt
            // 
            this.hiztxt.Location = new System.Drawing.Point(135, 279);
            this.hiztxt.Name = "hiztxt";
            this.hiztxt.Size = new System.Drawing.Size(100, 22);
            this.hiztxt.TabIndex = 21;
            // 
            // guntxt
            // 
            this.guntxt.Location = new System.Drawing.Point(135, 399);
            this.guntxt.Name = "guntxt";
            this.guntxt.Size = new System.Drawing.Size(100, 22);
            this.guntxt.TabIndex = 23;
            this.guntxt.TextChanged += new System.EventHandler(this.guntxt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(12, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Görev Süresi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Göreve Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Görevden Çağır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // istasyon_adtxt
            // 
            this.istasyon_adtxt.Location = new System.Drawing.Point(147, 40);
            this.istasyon_adtxt.Name = "istasyon_adtxt";
            this.istasyon_adtxt.Size = new System.Drawing.Size(100, 22);
            this.istasyon_adtxt.TabIndex = 27;
            this.istasyon_adtxt.TextChanged += new System.EventHandler(this.istasyon_adtxt_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 36);
            this.button3.TabIndex = 28;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UyduOtomasyonu.Properties.Resources.uydu;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Istasyon_Adi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Istasyon_Yeri";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Markasi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modeli";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Baslangic_Tarihi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Bitis_Tarihi
            // 
            this.Bitis_Tarihi.HeaderText = "Bitis_Tarihi";
            this.Bitis_Tarihi.MinimumWidth = 6;
            this.Bitis_Tarihi.Name = "Bitis_Tarihi";
            this.Bitis_Tarihi.Width = 125;
            // 
            // Gun
            // 
            this.Gun.HeaderText = "Gun";
            this.Gun.MinimumWidth = 6;
            this.Gun.Name = "Gun";
            this.Gun.Width = 125;
            // 
            // gorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1112, 467);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.istasyon_adtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guntxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hiztxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menziltxt);
            this.Controls.Add(this.modeltxt);
            this.Controls.Add(this.gorevbittxt);
            this.Controls.Add(this.gorevbastxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.istasyon_kontxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gorev";
            this.Text = "Göreve Çıkarma";
            this.Load += new System.EventHandler(this.gorev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox istasyon_kontxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker gorevbastxt;
        private System.Windows.Forms.DateTimePicker gorevbittxt;
        private System.Windows.Forms.ComboBox modeltxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox menziltxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hiztxt;
        private System.Windows.Forms.TextBox guntxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox istasyon_adtxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;
    }
}