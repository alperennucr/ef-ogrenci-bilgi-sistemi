namespace MiniOgrenciBilgiSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBox_ogrenciIslemleri = new GroupBox();
            btn_ogrSil = new Button();
            btn_ogrGuncelle = new Button();
            txtBox_ogrNumara = new TextBox();
            btn_ogrEkle = new Button();
            txtBox_ogrSoyad = new TextBox();
            txtBox_ogrAd = new TextBox();
            lbl_ogrNumara = new Label();
            lbl_ogrSoyad = new Label();
            lbl_ogrAd = new Label();
            grpBox_sinifIslemleri = new GroupBox();
            numUpD_sinifKontenjan = new NumericUpDown();
            btn_sinifSil = new Button();
            btn_sinifGuncelle = new Button();
            btn_sinifEkle = new Button();
            txtBox_sinifAd = new TextBox();
            lbl_sinifKontenjan = new Label();
            lbl_sinifAd = new Label();
            grpBox_dersIslemleri = new GroupBox();
            numUpD_dersAd = new NumericUpDown();
            btn_dersSil = new Button();
            btn_dersGuncelle = new Button();
            btn_dersEkle = new Button();
            txtBox_dersKod = new TextBox();
            label1 = new Label();
            lbl_dersKod = new Label();
            btn_dersSecimi = new Button();
            button2 = new Button();
            lbl_ogrSinif = new Label();
            comboBox1 = new ComboBox();
            grpBox_ogrenciIslemleri.SuspendLayout();
            grpBox_sinifIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpD_sinifKontenjan).BeginInit();
            grpBox_dersIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpD_dersAd).BeginInit();
            SuspendLayout();
            // 
            // grpBox_ogrenciIslemleri
            // 
            grpBox_ogrenciIslemleri.Controls.Add(comboBox1);
            grpBox_ogrenciIslemleri.Controls.Add(lbl_ogrSinif);
            grpBox_ogrenciIslemleri.Controls.Add(button2);
            grpBox_ogrenciIslemleri.Controls.Add(btn_dersSecimi);
            grpBox_ogrenciIslemleri.Controls.Add(btn_ogrSil);
            grpBox_ogrenciIslemleri.Controls.Add(btn_ogrGuncelle);
            grpBox_ogrenciIslemleri.Controls.Add(txtBox_ogrNumara);
            grpBox_ogrenciIslemleri.Controls.Add(btn_ogrEkle);
            grpBox_ogrenciIslemleri.Controls.Add(txtBox_ogrSoyad);
            grpBox_ogrenciIslemleri.Controls.Add(txtBox_ogrAd);
            grpBox_ogrenciIslemleri.Controls.Add(lbl_ogrNumara);
            grpBox_ogrenciIslemleri.Controls.Add(lbl_ogrSoyad);
            grpBox_ogrenciIslemleri.Controls.Add(lbl_ogrAd);
            grpBox_ogrenciIslemleri.Location = new Point(23, 29);
            grpBox_ogrenciIslemleri.Name = "grpBox_ogrenciIslemleri";
            grpBox_ogrenciIslemleri.Size = new Size(343, 372);
            grpBox_ogrenciIslemleri.TabIndex = 0;
            grpBox_ogrenciIslemleri.TabStop = false;
            grpBox_ogrenciIslemleri.Text = "Öğrenci İşlemleri";
            // 
            // btn_ogrSil
            // 
            btn_ogrSil.Location = new Point(228, 245);
            btn_ogrSil.Name = "btn_ogrSil";
            btn_ogrSil.Size = new Size(75, 23);
            btn_ogrSil.TabIndex = 8;
            btn_ogrSil.Text = "Sil";
            btn_ogrSil.UseVisualStyleBackColor = true;
            // 
            // btn_ogrGuncelle
            // 
            btn_ogrGuncelle.Location = new Point(128, 244);
            btn_ogrGuncelle.Name = "btn_ogrGuncelle";
            btn_ogrGuncelle.Size = new Size(75, 23);
            btn_ogrGuncelle.TabIndex = 7;
            btn_ogrGuncelle.Text = "Güncelle";
            btn_ogrGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtBox_ogrNumara
            // 
            txtBox_ogrNumara.Location = new Point(141, 143);
            txtBox_ogrNumara.Name = "txtBox_ogrNumara";
            txtBox_ogrNumara.Size = new Size(147, 23);
            txtBox_ogrNumara.TabIndex = 5;
            // 
            // btn_ogrEkle
            // 
            btn_ogrEkle.Location = new Point(25, 244);
            btn_ogrEkle.Name = "btn_ogrEkle";
            btn_ogrEkle.Size = new Size(75, 23);
            btn_ogrEkle.TabIndex = 6;
            btn_ogrEkle.Text = "Ekle";
            btn_ogrEkle.UseVisualStyleBackColor = true;
            // 
            // txtBox_ogrSoyad
            // 
            txtBox_ogrSoyad.Location = new Point(141, 95);
            txtBox_ogrSoyad.Name = "txtBox_ogrSoyad";
            txtBox_ogrSoyad.Size = new Size(147, 23);
            txtBox_ogrSoyad.TabIndex = 4;
            // 
            // txtBox_ogrAd
            // 
            txtBox_ogrAd.Location = new Point(141, 46);
            txtBox_ogrAd.Name = "txtBox_ogrAd";
            txtBox_ogrAd.Size = new Size(147, 23);
            txtBox_ogrAd.TabIndex = 3;
            // 
            // lbl_ogrNumara
            // 
            lbl_ogrNumara.AutoSize = true;
            lbl_ogrNumara.Location = new Point(30, 143);
            lbl_ogrNumara.Name = "lbl_ogrNumara";
            lbl_ogrNumara.Size = new Size(95, 15);
            lbl_ogrNumara.TabIndex = 2;
            lbl_ogrNumara.Text = "Öğrenci Numara";
            // 
            // lbl_ogrSoyad
            // 
            lbl_ogrSoyad.AutoSize = true;
            lbl_ogrSoyad.Location = new Point(41, 98);
            lbl_ogrSoyad.Name = "lbl_ogrSoyad";
            lbl_ogrSoyad.Size = new Size(84, 15);
            lbl_ogrSoyad.TabIndex = 1;
            lbl_ogrSoyad.Text = "Öğrenci Soyad";
            // 
            // lbl_ogrAd
            // 
            lbl_ogrAd.AutoSize = true;
            lbl_ogrAd.Location = new Point(58, 49);
            lbl_ogrAd.Name = "lbl_ogrAd";
            lbl_ogrAd.Size = new Size(67, 15);
            lbl_ogrAd.TabIndex = 0;
            lbl_ogrAd.Text = "Öğrenci Ad";
            // 
            // grpBox_sinifIslemleri
            // 
            grpBox_sinifIslemleri.Controls.Add(numUpD_sinifKontenjan);
            grpBox_sinifIslemleri.Controls.Add(btn_sinifSil);
            grpBox_sinifIslemleri.Controls.Add(btn_sinifGuncelle);
            grpBox_sinifIslemleri.Controls.Add(btn_sinifEkle);
            grpBox_sinifIslemleri.Controls.Add(txtBox_sinifAd);
            grpBox_sinifIslemleri.Controls.Add(lbl_sinifKontenjan);
            grpBox_sinifIslemleri.Controls.Add(lbl_sinifAd);
            grpBox_sinifIslemleri.Location = new Point(410, 29);
            grpBox_sinifIslemleri.Name = "grpBox_sinifIslemleri";
            grpBox_sinifIslemleri.Size = new Size(343, 173);
            grpBox_sinifIslemleri.TabIndex = 9;
            grpBox_sinifIslemleri.TabStop = false;
            grpBox_sinifIslemleri.Text = "Sınıf İşlemleri";
            // 
            // numUpD_sinifKontenjan
            // 
            numUpD_sinifKontenjan.Location = new Point(141, 84);
            numUpD_sinifKontenjan.Name = "numUpD_sinifKontenjan";
            numUpD_sinifKontenjan.Size = new Size(147, 23);
            numUpD_sinifKontenjan.TabIndex = 10;
            // 
            // btn_sinifSil
            // 
            btn_sinifSil.Location = new Point(228, 128);
            btn_sinifSil.Name = "btn_sinifSil";
            btn_sinifSil.Size = new Size(75, 23);
            btn_sinifSil.TabIndex = 8;
            btn_sinifSil.Text = "Sil";
            btn_sinifSil.UseVisualStyleBackColor = true;
            // 
            // btn_sinifGuncelle
            // 
            btn_sinifGuncelle.Location = new Point(127, 128);
            btn_sinifGuncelle.Name = "btn_sinifGuncelle";
            btn_sinifGuncelle.Size = new Size(75, 23);
            btn_sinifGuncelle.TabIndex = 7;
            btn_sinifGuncelle.Text = "Güncelle";
            btn_sinifGuncelle.UseVisualStyleBackColor = true;
            // 
            // btn_sinifEkle
            // 
            btn_sinifEkle.Location = new Point(25, 128);
            btn_sinifEkle.Name = "btn_sinifEkle";
            btn_sinifEkle.Size = new Size(75, 23);
            btn_sinifEkle.TabIndex = 6;
            btn_sinifEkle.Text = "Ekle";
            btn_sinifEkle.UseVisualStyleBackColor = true;
            // 
            // txtBox_sinifAd
            // 
            txtBox_sinifAd.Location = new Point(141, 46);
            txtBox_sinifAd.Name = "txtBox_sinifAd";
            txtBox_sinifAd.Size = new Size(147, 23);
            txtBox_sinifAd.TabIndex = 3;
            // 
            // lbl_sinifKontenjan
            // 
            lbl_sinifKontenjan.AutoSize = true;
            lbl_sinifKontenjan.Location = new Point(34, 86);
            lbl_sinifKontenjan.Name = "lbl_sinifKontenjan";
            lbl_sinifKontenjan.Size = new Size(87, 15);
            lbl_sinifKontenjan.TabIndex = 1;
            lbl_sinifKontenjan.Text = "Sınıf Kontenjan";
            // 
            // lbl_sinifAd
            // 
            lbl_sinifAd.AutoSize = true;
            lbl_sinifAd.Location = new Point(73, 49);
            lbl_sinifAd.Name = "lbl_sinifAd";
            lbl_sinifAd.Size = new Size(48, 15);
            lbl_sinifAd.TabIndex = 0;
            lbl_sinifAd.Text = "Sınıf Ad";
            // 
            // grpBox_dersIslemleri
            // 
            grpBox_dersIslemleri.Controls.Add(numUpD_dersAd);
            grpBox_dersIslemleri.Controls.Add(btn_dersSil);
            grpBox_dersIslemleri.Controls.Add(btn_dersGuncelle);
            grpBox_dersIslemleri.Controls.Add(btn_dersEkle);
            grpBox_dersIslemleri.Controls.Add(txtBox_dersKod);
            grpBox_dersIslemleri.Controls.Add(label1);
            grpBox_dersIslemleri.Controls.Add(lbl_dersKod);
            grpBox_dersIslemleri.Location = new Point(410, 228);
            grpBox_dersIslemleri.Name = "grpBox_dersIslemleri";
            grpBox_dersIslemleri.Size = new Size(343, 173);
            grpBox_dersIslemleri.TabIndex = 11;
            grpBox_dersIslemleri.TabStop = false;
            grpBox_dersIslemleri.Text = "Ders İşlemleri";
            // 
            // numUpD_dersAd
            // 
            numUpD_dersAd.Location = new Point(141, 84);
            numUpD_dersAd.Name = "numUpD_dersAd";
            numUpD_dersAd.Size = new Size(147, 23);
            numUpD_dersAd.TabIndex = 10;
            // 
            // btn_dersSil
            // 
            btn_dersSil.Location = new Point(228, 128);
            btn_dersSil.Name = "btn_dersSil";
            btn_dersSil.Size = new Size(75, 23);
            btn_dersSil.TabIndex = 8;
            btn_dersSil.Text = "Sil";
            btn_dersSil.UseVisualStyleBackColor = true;
            // 
            // btn_dersGuncelle
            // 
            btn_dersGuncelle.Location = new Point(127, 128);
            btn_dersGuncelle.Name = "btn_dersGuncelle";
            btn_dersGuncelle.Size = new Size(75, 23);
            btn_dersGuncelle.TabIndex = 7;
            btn_dersGuncelle.Text = "Güncelle";
            btn_dersGuncelle.UseVisualStyleBackColor = true;
            // 
            // btn_dersEkle
            // 
            btn_dersEkle.Location = new Point(25, 128);
            btn_dersEkle.Name = "btn_dersEkle";
            btn_dersEkle.Size = new Size(75, 23);
            btn_dersEkle.TabIndex = 6;
            btn_dersEkle.Text = "Ekle";
            btn_dersEkle.UseVisualStyleBackColor = true;
            // 
            // txtBox_dersKod
            // 
            txtBox_dersKod.Location = new Point(141, 46);
            txtBox_dersKod.Name = "txtBox_dersKod";
            txtBox_dersKod.Size = new Size(147, 23);
            txtBox_dersKod.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 49);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Ders Ad";
            // 
            // lbl_dersKod
            // 
            lbl_dersKod.AutoSize = true;
            lbl_dersKod.Location = new Point(67, 86);
            lbl_dersKod.Name = "lbl_dersKod";
            lbl_dersKod.Size = new Size(54, 15);
            lbl_dersKod.TabIndex = 0;
            lbl_dersKod.Text = "Ders Kod";
            // 
            // btn_dersSecimi
            // 
            btn_dersSecimi.Location = new Point(183, 304);
            btn_dersSecimi.Name = "btn_dersSecimi";
            btn_dersSecimi.Size = new Size(120, 46);
            btn_dersSecimi.TabIndex = 9;
            btn_dersSecimi.Text = "Ders Seçimi";
            btn_dersSecimi.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(25, 304);
            button2.Name = "button2";
            button2.Size = new Size(120, 46);
            button2.TabIndex = 10;
            button2.Text = "Numaraya göre bul";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbl_ogrSinif
            // 
            lbl_ogrSinif.AutoSize = true;
            lbl_ogrSinif.Location = new Point(50, 188);
            lbl_ogrSinif.Name = "lbl_ogrSinif";
            lbl_ogrSinif.Size = new Size(75, 15);
            lbl_ogrSinif.TabIndex = 11;
            lbl_ogrSinif.Text = "Öğrenci Sınıf";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBox_dersIslemleri);
            Controls.Add(grpBox_sinifIslemleri);
            Controls.Add(grpBox_ogrenciIslemleri);
            Name = "Form1";
            Text = "Form1";
            grpBox_ogrenciIslemleri.ResumeLayout(false);
            grpBox_ogrenciIslemleri.PerformLayout();
            grpBox_sinifIslemleri.ResumeLayout(false);
            grpBox_sinifIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpD_sinifKontenjan).EndInit();
            grpBox_dersIslemleri.ResumeLayout(false);
            grpBox_dersIslemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpD_dersAd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBox_ogrenciIslemleri;
        private Label lbl_ogrAd;
        private Label lbl_ogrNumara;
        private Label lbl_ogrSoyad;
        private Button btn_ogrGuncelle;
        private Button btn_ogrEkle;
        private TextBox txtBox_ogrSoyad;
        private TextBox txtBox_ogrAd;
        private Button btn_ogrSil;
        private TextBox txtBox_ogrNumara;
        private GroupBox grpBox_sinifIslemleri;
        private Button btn_sinifSil;
        private Button btn_sinifGuncelle;
        private Button btn_sinifEkle;
        private TextBox txtBox_sinifAd;
        private Label lbl_sinifKontenjan;
        private Label lbl_sinifAd;
        private NumericUpDown numUpD_sinifKontenjan;
        private GroupBox grpBox_dersIslemleri;
        private NumericUpDown numUpD_dersAd;
        private Button btn_dersSil;
        private Button btn_dersGuncelle;
        private Button btn_dersEkle;
        private TextBox txtBox_dersKod;
        private Label label1;
        private Label lbl_dersKod;
        private Button btn_dersSecimi;
        private Button button2;
        private ComboBox comboBox1;
        private Label lbl_ogrSinif;
    }
}
