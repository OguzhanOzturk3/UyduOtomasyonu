
namespace UyduOtomasyonu
{
    partial class uyduekleme
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
            this.modeltext = new System.Windows.Forms.TextBox();
            this.markatext = new System.Windows.Forms.ComboBox();
            this.menziltext = new System.Windows.Forms.TextBox();
            this.hiztext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yiltext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modeltext
            // 
            this.modeltext.Location = new System.Drawing.Point(413, 154);
            this.modeltext.Name = "modeltext";
            this.modeltext.Size = new System.Drawing.Size(144, 22);
            this.modeltext.TabIndex = 0;
            // 
            // markatext
            // 
            this.markatext.FormattingEnabled = true;
            this.markatext.Items.AddRange(new object[] {
            "SPACEX",
            "LEOLABS",
            "GHGSAT",
            "ORBITAL INSIGHT",
            "SLINGSHOT AEROSPACE",
            "ROCKET LAB",
            "PLANET",
            "RELATIVITY SPACE",
            "CAPELLA SPACE",
            "ASTROSCALE"});
            this.markatext.Location = new System.Drawing.Point(413, 111);
            this.markatext.Name = "markatext";
            this.markatext.Size = new System.Drawing.Size(144, 24);
            this.markatext.TabIndex = 1;
            // 
            // menziltext
            // 
            this.menziltext.Location = new System.Drawing.Point(413, 193);
            this.menziltext.Name = "menziltext";
            this.menziltext.Size = new System.Drawing.Size(144, 22);
            this.menziltext.TabIndex = 2;
            // 
            // hiztext
            // 
            this.hiztext.Location = new System.Drawing.Point(413, 233);
            this.hiztext.Name = "hiztext";
            this.hiztext.Size = new System.Drawing.Size(144, 22);
            this.hiztext.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(284, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Markası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(284, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modeli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(284, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanım Menzili";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(284, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maksimum Hızı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // yiltext
            // 
            this.yiltext.Location = new System.Drawing.Point(413, 273);
            this.yiltext.Name = "yiltext";
            this.yiltext.Size = new System.Drawing.Size(144, 22);
            this.yiltext.TabIndex = 8;
            this.yiltext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(284, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Üretim Yılı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "Uyduyu Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "Geri Dön";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UyduOtomasyonu.Properties.Resources.uydu;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uyduekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1112, 467);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yiltext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiztext);
            this.Controls.Add(this.menziltext);
            this.Controls.Add(this.markatext);
            this.Controls.Add(this.modeltext);
            this.Controls.Add(this.pictureBox1);
            this.Name = "uyduekleme";
            this.Text = "Uydu Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modeltext;
        private System.Windows.Forms.ComboBox markatext;
        private System.Windows.Forms.TextBox menziltext;
        private System.Windows.Forms.TextBox hiztext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yiltext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}