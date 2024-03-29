﻿namespace CSharpHelperMethods.UI
{
    partial class FrmAnaSayfa
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
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTarihIslemleri = new System.Windows.Forms.Panel();
            this.btnAyFarki = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTarihAraligi = new System.Windows.Forms.Button();
            this.btnYasHesaplaMetinsel = new System.Windows.Forms.Button();
            this.btnYasHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSifreIslemleri = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSifreUygunMu = new System.Windows.Forms.Button();
            this.btnRastgeleSifreUret = new System.Windows.Forms.Button();
            this.btnSha512Hash = new System.Windows.Forms.Button();
            this.btnSha256Hash = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSifreSonuc = new System.Windows.Forms.ListBox();
            this.btnMd5Hash = new System.Windows.Forms.Button();
            this.txtSifrelenecekMetin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSayiIslemleri = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOnayKoduOlustur = new System.Windows.Forms.Button();
            this.btnMetneDonustur = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSayiSonuc = new System.Windows.Forms.ListBox();
            this.btnSayisalMi = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlKisiIslemleri = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEPostaDogrula = new System.Windows.Forms.Button();
            this.btnIbanDogrula = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbKisiSonuc = new System.Windows.Forms.ListBox();
            this.btnTcKimlikDogrula = new System.Windows.Forms.Button();
            this.txtKisiMetni = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlMetinIslemleri = new System.Windows.Forms.Panel();
            this.btnTelefonNoDuzenle = new System.Windows.Forms.Button();
            this.btnMetinSifrele = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTurkceKarakterDuzelt = new System.Windows.Forms.Button();
            this.btnIlkHarfiBuyukYap = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lbMetinSonuc = new System.Windows.Forms.ListBox();
            this.btnIlkHarfleriBuyukYap = new System.Windows.Forms.Button();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnEPostaKontrol = new System.Windows.Forms.Button();
            this.pnlTarihIslemleri.SuspendLayout();
            this.pnlSifreIslemleri.SuspendLayout();
            this.pnlSayiIslemleri.SuspendLayout();
            this.pnlKisiIslemleri.SuspendLayout();
            this.pnlMetinIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {"Metin İşlemleri", "Tarih İşlemleri", "Sayı İşlemleri", "Şifre İşlemleri", "Kişi İşlemleri"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(176, 16);
            this.cmbIslemTuru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(265, 24);
            this.cmbIslemTuru.TabIndex = 0;
            this.cmbIslemTuru.SelectedIndexChanged += new System.EventHandler(this.cmbIslemTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem Türü Seçiniz";
            // 
            // pnlTarihIslemleri
            // 
            this.pnlTarihIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTarihIslemleri.Controls.Add(this.btnAyFarki);
            this.pnlTarihIslemleri.Controls.Add(this.label8);
            this.pnlTarihIslemleri.Controls.Add(this.btnTarihAraligi);
            this.pnlTarihIslemleri.Controls.Add(this.btnYasHesaplaMetinsel);
            this.pnlTarihIslemleri.Controls.Add(this.btnYasHesapla);
            this.pnlTarihIslemleri.Controls.Add(this.label4);
            this.pnlTarihIslemleri.Controls.Add(this.lbSonuc);
            this.pnlTarihIslemleri.Controls.Add(this.dtpBitisTarihi);
            this.pnlTarihIslemleri.Controls.Add(this.dtpBaslangicTarihi);
            this.pnlTarihIslemleri.Controls.Add(this.label3);
            this.pnlTarihIslemleri.Controls.Add(this.label2);
            this.pnlTarihIslemleri.Location = new System.Drawing.Point(20, 69);
            this.pnlTarihIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTarihIslemleri.Name = "pnlTarihIslemleri";
            this.pnlTarihIslemleri.Size = new System.Drawing.Size(498, 222);
            this.pnlTarihIslemleri.TabIndex = 2;
            // 
            // btnAyFarki
            // 
            this.btnAyFarki.Location = new System.Drawing.Point(381, 94);
            this.btnAyFarki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAyFarki.Name = "btnAyFarki";
            this.btnAyFarki.Size = new System.Drawing.Size(105, 28);
            this.btnAyFarki.TabIndex = 12;
            this.btnAyFarki.Text = "Ay Farkı";
            this.btnAyFarki.UseVisualStyleBackColor = true;
            this.btnAyFarki.Click += new System.EventHandler(this.btnAyFarki_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tarih İşlemleri";
            // 
            // btnTarihAraligi
            // 
            this.btnTarihAraligi.Location = new System.Drawing.Point(272, 94);
            this.btnTarihAraligi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTarihAraligi.Name = "btnTarihAraligi";
            this.btnTarihAraligi.Size = new System.Drawing.Size(101, 28);
            this.btnTarihAraligi.TabIndex = 10;
            this.btnTarihAraligi.Text = "Tarih Aralığı";
            this.btnTarihAraligi.UseVisualStyleBackColor = true;
            this.btnTarihAraligi.Click += new System.EventHandler(this.btnTarihAraligi_Click);
            // 
            // btnYasHesaplaMetinsel
            // 
            this.btnYasHesaplaMetinsel.Location = new System.Drawing.Point(112, 94);
            this.btnYasHesaplaMetinsel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYasHesaplaMetinsel.Name = "btnYasHesaplaMetinsel";
            this.btnYasHesaplaMetinsel.Size = new System.Drawing.Size(151, 28);
            this.btnYasHesaplaMetinsel.TabIndex = 9;
            this.btnYasHesaplaMetinsel.Text = "Yaş Hesapla (Metin)";
            this.btnYasHesaplaMetinsel.UseVisualStyleBackColor = true;
            this.btnYasHesaplaMetinsel.Click += new System.EventHandler(this.btnYasHesaplaMetinsel_Click);
            // 
            // btnYasHesapla
            // 
            this.btnYasHesapla.Location = new System.Drawing.Point(4, 94);
            this.btnYasHesapla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYasHesapla.Name = "btnYasHesapla";
            this.btnYasHesapla.Size = new System.Drawing.Size(100, 28);
            this.btnYasHesapla.TabIndex = 8;
            this.btnYasHesapla.Text = "Yaş Hesapla";
            this.btnYasHesapla.UseVisualStyleBackColor = true;
            this.btnYasHesapla.Click += new System.EventHandler(this.btnYasHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuç";
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.HorizontalScrollbar = true;
            this.lbSonuc.ItemHeight = 16;
            this.lbSonuc.Location = new System.Drawing.Point(83, 129);
            this.lbSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(340, 84);
            this.lbSonuc.TabIndex = 6;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(156, 53);
            this.dtpBitisTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.ShowCheckBox = true;
            this.dtpBitisTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpBitisTarihi.TabIndex = 5;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(156, 21);
            this.dtpBaslangicTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.ShowCheckBox = true;
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpBaslangicTarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // pnlSifreIslemleri
            // 
            this.pnlSifreIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSifreIslemleri.Controls.Add(this.label7);
            this.pnlSifreIslemleri.Controls.Add(this.btnSifreUygunMu);
            this.pnlSifreIslemleri.Controls.Add(this.btnRastgeleSifreUret);
            this.pnlSifreIslemleri.Controls.Add(this.btnSha512Hash);
            this.pnlSifreIslemleri.Controls.Add(this.btnSha256Hash);
            this.pnlSifreIslemleri.Controls.Add(this.label6);
            this.pnlSifreIslemleri.Controls.Add(this.lbSifreSonuc);
            this.pnlSifreIslemleri.Controls.Add(this.btnMd5Hash);
            this.pnlSifreIslemleri.Controls.Add(this.txtSifrelenecekMetin);
            this.pnlSifreIslemleri.Controls.Add(this.label5);
            this.pnlSifreIslemleri.Location = new System.Drawing.Point(548, 69);
            this.pnlSifreIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSifreIslemleri.Name = "pnlSifreIslemleri";
            this.pnlSifreIslemleri.Size = new System.Drawing.Size(502, 222);
            this.pnlSifreIslemleri.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Şifre İşlemleri";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSifreUygunMu
            // 
            this.btnSifreUygunMu.Location = new System.Drawing.Point(231, 87);
            this.btnSifreUygunMu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSifreUygunMu.Name = "btnSifreUygunMu";
            this.btnSifreUygunMu.Size = new System.Drawing.Size(193, 28);
            this.btnSifreUygunMu.TabIndex = 17;
            this.btnSifreUygunMu.Text = "Şifre Uygun Mu?";
            this.btnSifreUygunMu.UseVisualStyleBackColor = true;
            this.btnSifreUygunMu.Click += new System.EventHandler(this.btnSifreUygunMu_Click);
            // 
            // btnRastgeleSifreUret
            // 
            this.btnRastgeleSifreUret.Location = new System.Drawing.Point(28, 87);
            this.btnRastgeleSifreUret.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRastgeleSifreUret.Name = "btnRastgeleSifreUret";
            this.btnRastgeleSifreUret.Size = new System.Drawing.Size(193, 28);
            this.btnRastgeleSifreUret.TabIndex = 16;
            this.btnRastgeleSifreUret.Text = "Rastgele Şifre Üret";
            this.btnRastgeleSifreUret.UseVisualStyleBackColor = true;
            this.btnRastgeleSifreUret.Click += new System.EventHandler(this.btnRastgeleSifreUret_Click);
            // 
            // btnSha512Hash
            // 
            this.btnSha512Hash.Location = new System.Drawing.Point(324, 52);
            this.btnSha512Hash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSha512Hash.Name = "btnSha512Hash";
            this.btnSha512Hash.Size = new System.Drawing.Size(100, 28);
            this.btnSha512Hash.TabIndex = 15;
            this.btnSha512Hash.Text = "SHA 512";
            this.btnSha512Hash.UseVisualStyleBackColor = true;
            this.btnSha512Hash.Click += new System.EventHandler(this.btnSha512Hash_Click);
            // 
            // btnSha256Hash
            // 
            this.btnSha256Hash.Location = new System.Drawing.Point(175, 52);
            this.btnSha256Hash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSha256Hash.Name = "btnSha256Hash";
            this.btnSha256Hash.Size = new System.Drawing.Size(100, 28);
            this.btnSha256Hash.TabIndex = 14;
            this.btnSha256Hash.Text = "SHA 256";
            this.btnSha256Hash.UseVisualStyleBackColor = true;
            this.btnSha256Hash.Click += new System.EventHandler(this.btnSha256Hash_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sonuç";
            // 
            // lbSifreSonuc
            // 
            this.lbSifreSonuc.FormattingEnabled = true;
            this.lbSifreSonuc.HorizontalScrollbar = true;
            this.lbSifreSonuc.ItemHeight = 16;
            this.lbSifreSonuc.Location = new System.Drawing.Point(87, 123);
            this.lbSifreSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSifreSonuc.Name = "lbSifreSonuc";
            this.lbSifreSonuc.Size = new System.Drawing.Size(333, 84);
            this.lbSifreSonuc.TabIndex = 12;
            // 
            // btnMd5Hash
            // 
            this.btnMd5Hash.Location = new System.Drawing.Point(28, 52);
            this.btnMd5Hash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMd5Hash.Name = "btnMd5Hash";
            this.btnMd5Hash.Size = new System.Drawing.Size(100, 28);
            this.btnMd5Hash.TabIndex = 11;
            this.btnMd5Hash.Text = "MD5";
            this.btnMd5Hash.UseVisualStyleBackColor = true;
            this.btnMd5Hash.Click += new System.EventHandler(this.btnMd5Hash_Click);
            // 
            // txtSifrelenecekMetin
            // 
            this.txtSifrelenecekMetin.Location = new System.Drawing.Point(157, 20);
            this.txtSifrelenecekMetin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifrelenecekMetin.Name = "txtSifrelenecekMetin";
            this.txtSifrelenecekMetin.Size = new System.Drawing.Size(264, 22);
            this.txtSifrelenecekMetin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Şifrelenecek Metin";
            // 
            // pnlSayiIslemleri
            // 
            this.pnlSayiIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSayiIslemleri.Controls.Add(this.label9);
            this.pnlSayiIslemleri.Controls.Add(this.btnOnayKoduOlustur);
            this.pnlSayiIslemleri.Controls.Add(this.btnMetneDonustur);
            this.pnlSayiIslemleri.Controls.Add(this.label10);
            this.pnlSayiIslemleri.Controls.Add(this.lbSayiSonuc);
            this.pnlSayiIslemleri.Controls.Add(this.btnSayisalMi);
            this.pnlSayiIslemleri.Controls.Add(this.txtSayi);
            this.pnlSayiIslemleri.Controls.Add(this.label11);
            this.pnlSayiIslemleri.Location = new System.Drawing.Point(20, 316);
            this.pnlSayiIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSayiIslemleri.Name = "pnlSayiIslemleri";
            this.pnlSayiIslemleri.Size = new System.Drawing.Size(502, 222);
            this.pnlSayiIslemleri.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sayı İşlemleri";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOnayKoduOlustur
            // 
            this.btnOnayKoduOlustur.Location = new System.Drawing.Point(324, 52);
            this.btnOnayKoduOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnayKoduOlustur.Name = "btnOnayKoduOlustur";
            this.btnOnayKoduOlustur.Size = new System.Drawing.Size(100, 28);
            this.btnOnayKoduOlustur.TabIndex = 15;
            this.btnOnayKoduOlustur.Text = "Onay Kodu";
            this.btnOnayKoduOlustur.UseVisualStyleBackColor = true;
            this.btnOnayKoduOlustur.Click += new System.EventHandler(this.btnOnayKoduOlustur_Click);
            // 
            // btnMetneDonustur
            // 
            this.btnMetneDonustur.Location = new System.Drawing.Point(136, 52);
            this.btnMetneDonustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMetneDonustur.Name = "btnMetneDonustur";
            this.btnMetneDonustur.Size = new System.Drawing.Size(180, 28);
            this.btnMetneDonustur.TabIndex = 14;
            this.btnMetneDonustur.Text = "Para Metnine Dönüştür";
            this.btnMetneDonustur.UseVisualStyleBackColor = true;
            this.btnMetneDonustur.Click += new System.EventHandler(this.btnMetneDonustur_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sonuç";
            // 
            // lbSayiSonuc
            // 
            this.lbSayiSonuc.FormattingEnabled = true;
            this.lbSayiSonuc.HorizontalScrollbar = true;
            this.lbSayiSonuc.ItemHeight = 16;
            this.lbSayiSonuc.Location = new System.Drawing.Point(83, 96);
            this.lbSayiSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbSayiSonuc.Name = "lbSayiSonuc";
            this.lbSayiSonuc.Size = new System.Drawing.Size(337, 100);
            this.lbSayiSonuc.TabIndex = 12;
            // 
            // btnSayisalMi
            // 
            this.btnSayisalMi.Location = new System.Drawing.Point(28, 52);
            this.btnSayisalMi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSayisalMi.Name = "btnSayisalMi";
            this.btnSayisalMi.Size = new System.Drawing.Size(100, 28);
            this.btnSayisalMi.TabIndex = 11;
            this.btnSayisalMi.Text = "Sayısal Mı?";
            this.btnSayisalMi.UseVisualStyleBackColor = true;
            this.btnSayisalMi.Click += new System.EventHandler(this.btnSayisalMi_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(157, 20);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(264, 22);
            this.txtSayi.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Şifrelenecek Metin";
            // 
            // pnlKisiIslemleri
            // 
            this.pnlKisiIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKisiIslemleri.Controls.Add(this.label12);
            this.pnlKisiIslemleri.Controls.Add(this.btnEPostaDogrula);
            this.pnlKisiIslemleri.Controls.Add(this.btnIbanDogrula);
            this.pnlKisiIslemleri.Controls.Add(this.label13);
            this.pnlKisiIslemleri.Controls.Add(this.lbKisiSonuc);
            this.pnlKisiIslemleri.Controls.Add(this.btnTcKimlikDogrula);
            this.pnlKisiIslemleri.Controls.Add(this.txtKisiMetni);
            this.pnlKisiIslemleri.Controls.Add(this.label14);
            this.pnlKisiIslemleri.Location = new System.Drawing.Point(548, 316);
            this.pnlKisiIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKisiIslemleri.Name = "pnlKisiIslemleri";
            this.pnlKisiIslemleri.Size = new System.Drawing.Size(502, 222);
            this.pnlKisiIslemleri.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Kişi İşlemleri";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEPostaDogrula
            // 
            this.btnEPostaDogrula.Location = new System.Drawing.Point(297, 52);
            this.btnEPostaDogrula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEPostaDogrula.Name = "btnEPostaDogrula";
            this.btnEPostaDogrula.Size = new System.Drawing.Size(127, 28);
            this.btnEPostaDogrula.TabIndex = 15;
            this.btnEPostaDogrula.Text = "E-Posta Doğrula";
            this.btnEPostaDogrula.UseVisualStyleBackColor = true;
            this.btnEPostaDogrula.Click += new System.EventHandler(this.btnEPostaDogrula_Click);
            // 
            // btnIbanDogrula
            // 
            this.btnIbanDogrula.Location = new System.Drawing.Point(175, 52);
            this.btnIbanDogrula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIbanDogrula.Name = "btnIbanDogrula";
            this.btnIbanDogrula.Size = new System.Drawing.Size(115, 28);
            this.btnIbanDogrula.TabIndex = 14;
            this.btnIbanDogrula.Text = "IBAN Doğrula";
            this.btnIbanDogrula.UseVisualStyleBackColor = true;
            this.btnIbanDogrula.Click += new System.EventHandler(this.btnIbanDogrula_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Sonuç";
            // 
            // lbKisiSonuc
            // 
            this.lbKisiSonuc.FormattingEnabled = true;
            this.lbKisiSonuc.HorizontalScrollbar = true;
            this.lbKisiSonuc.ItemHeight = 16;
            this.lbKisiSonuc.Location = new System.Drawing.Point(83, 96);
            this.lbKisiSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbKisiSonuc.Name = "lbKisiSonuc";
            this.lbKisiSonuc.Size = new System.Drawing.Size(337, 100);
            this.lbKisiSonuc.TabIndex = 12;
            // 
            // btnTcKimlikDogrula
            // 
            this.btnTcKimlikDogrula.Location = new System.Drawing.Point(28, 52);
            this.btnTcKimlikDogrula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTcKimlikDogrula.Name = "btnTcKimlikDogrula";
            this.btnTcKimlikDogrula.Size = new System.Drawing.Size(139, 28);
            this.btnTcKimlikDogrula.TabIndex = 11;
            this.btnTcKimlikDogrula.Text = "TC Kimlik Doğrula";
            this.btnTcKimlikDogrula.UseVisualStyleBackColor = true;
            this.btnTcKimlikDogrula.Click += new System.EventHandler(this.btnTcKimlikDogrula_Click);
            // 
            // txtKisiMetni
            // 
            this.txtKisiMetni.Location = new System.Drawing.Point(157, 20);
            this.txtKisiMetni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKisiMetni.Name = "txtKisiMetni";
            this.txtKisiMetni.Size = new System.Drawing.Size(264, 22);
            this.txtKisiMetni.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 23);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Metin";
            // 
            // pnlMetinIslemleri
            // 
            this.pnlMetinIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMetinIslemleri.Controls.Add(this.btnEPostaKontrol);
            this.pnlMetinIslemleri.Controls.Add(this.btnTelefonNoDuzenle);
            this.pnlMetinIslemleri.Controls.Add(this.btnMetinSifrele);
            this.pnlMetinIslemleri.Controls.Add(this.label15);
            this.pnlMetinIslemleri.Controls.Add(this.btnTurkceKarakterDuzelt);
            this.pnlMetinIslemleri.Controls.Add(this.btnIlkHarfiBuyukYap);
            this.pnlMetinIslemleri.Controls.Add(this.label16);
            this.pnlMetinIslemleri.Controls.Add(this.lbMetinSonuc);
            this.pnlMetinIslemleri.Controls.Add(this.btnIlkHarfleriBuyukYap);
            this.pnlMetinIslemleri.Controls.Add(this.txtMetin);
            this.pnlMetinIslemleri.Controls.Add(this.label17);
            this.pnlMetinIslemleri.Location = new System.Drawing.Point(20, 564);
            this.pnlMetinIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMetinIslemleri.Name = "pnlMetinIslemleri";
            this.pnlMetinIslemleri.Size = new System.Drawing.Size(1030, 222);
            this.pnlMetinIslemleri.TabIndex = 21;
            // 
            // btnTelefonNoDuzenle
            // 
            this.btnTelefonNoDuzenle.Location = new System.Drawing.Point(671, 52);
            this.btnTelefonNoDuzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTelefonNoDuzenle.Name = "btnTelefonNoDuzenle";
            this.btnTelefonNoDuzenle.Size = new System.Drawing.Size(179, 28);
            this.btnTelefonNoDuzenle.TabIndex = 20;
            this.btnTelefonNoDuzenle.Text = "Telefon No Düzenle";
            this.btnTelefonNoDuzenle.UseVisualStyleBackColor = true;
            this.btnTelefonNoDuzenle.Click += new System.EventHandler(this.btnTelefonNoDuzenle_Click);
            // 
            // btnMetinSifrele
            // 
            this.btnMetinSifrele.Location = new System.Drawing.Point(484, 52);
            this.btnMetinSifrele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMetinSifrele.Name = "btnMetinSifrele";
            this.btnMetinSifrele.Size = new System.Drawing.Size(179, 28);
            this.btnMetinSifrele.TabIndex = 19;
            this.btnMetinSifrele.Text = "Metin Şifrele";
            this.btnMetinSifrele.UseVisualStyleBackColor = true;
            this.btnMetinSifrele.Click += new System.EventHandler(this.btnMetinSifrele_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Metin İşlemleri";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTurkceKarakterDuzelt
            // 
            this.btnTurkceKarakterDuzelt.Location = new System.Drawing.Point(297, 52);
            this.btnTurkceKarakterDuzelt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTurkceKarakterDuzelt.Name = "btnTurkceKarakterDuzelt";
            this.btnTurkceKarakterDuzelt.Size = new System.Drawing.Size(179, 28);
            this.btnTurkceKarakterDuzelt.TabIndex = 15;
            this.btnTurkceKarakterDuzelt.Text = "Türkçe Karakter Düzelt";
            this.btnTurkceKarakterDuzelt.UseVisualStyleBackColor = true;
            this.btnTurkceKarakterDuzelt.Click += new System.EventHandler(this.btnTurkceKarakterDuzelt_Click);
            // 
            // btnIlkHarfiBuyukYap
            // 
            this.btnIlkHarfiBuyukYap.Location = new System.Drawing.Point(175, 52);
            this.btnIlkHarfiBuyukYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlkHarfiBuyukYap.Name = "btnIlkHarfiBuyukYap";
            this.btnIlkHarfiBuyukYap.Size = new System.Drawing.Size(115, 28);
            this.btnIlkHarfiBuyukYap.TabIndex = 14;
            this.btnIlkHarfiBuyukYap.Text = "İlk Harf Büyük";
            this.btnIlkHarfiBuyukYap.UseVisualStyleBackColor = true;
            this.btnIlkHarfiBuyukYap.Click += new System.EventHandler(this.btnIlkHarfiBuyukYap_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "Sonuç";
            // 
            // lbMetinSonuc
            // 
            this.lbMetinSonuc.FormattingEnabled = true;
            this.lbMetinSonuc.HorizontalScrollbar = true;
            this.lbMetinSonuc.ItemHeight = 16;
            this.lbMetinSonuc.Location = new System.Drawing.Point(83, 96);
            this.lbMetinSonuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMetinSonuc.Name = "lbMetinSonuc";
            this.lbMetinSonuc.Size = new System.Drawing.Size(868, 100);
            this.lbMetinSonuc.TabIndex = 12;
            // 
            // btnIlkHarfleriBuyukYap
            // 
            this.btnIlkHarfleriBuyukYap.Location = new System.Drawing.Point(28, 52);
            this.btnIlkHarfleriBuyukYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlkHarfleriBuyukYap.Name = "btnIlkHarfleriBuyukYap";
            this.btnIlkHarfleriBuyukYap.Size = new System.Drawing.Size(139, 28);
            this.btnIlkHarfleriBuyukYap.TabIndex = 11;
            this.btnIlkHarfleriBuyukYap.Text = "İlk Harfler Büyük";
            this.btnIlkHarfleriBuyukYap.UseVisualStyleBackColor = true;
            this.btnIlkHarfleriBuyukYap.Click += new System.EventHandler(this.btnIlkHarfleriBuyukYap_Click);
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(159, 15);
            this.txtMetin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(792, 22);
            this.txtMetin.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 23);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 17);
            this.label17.TabIndex = 3;
            this.label17.Text = "Metin";
            // 
            // btnEPostaKontrol
            // 
            this.btnEPostaKontrol.Location = new System.Drawing.Point(858, 52);
            this.btnEPostaKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.btnEPostaKontrol.Name = "btnEPostaKontrol";
            this.btnEPostaKontrol.Size = new System.Drawing.Size(160, 28);
            this.btnEPostaKontrol.TabIndex = 21;
            this.btnEPostaKontrol.Text = "E-Posta Geçerli Mi?";
            this.btnEPostaKontrol.UseVisualStyleBackColor = true;
            this.btnEPostaKontrol.Click += new System.EventHandler(this.btnEPostaKontrol_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 844);
            this.Controls.Add(this.pnlMetinIslemleri);
            this.Controls.Add(this.pnlKisiIslemleri);
            this.Controls.Add(this.pnlSayiIslemleri);
            this.Controls.Add(this.pnlSifreIslemleri);
            this.Controls.Add(this.pnlTarihIslemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIslemTuru);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler Ekranı";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.pnlTarihIslemleri.ResumeLayout(false);
            this.pnlTarihIslemleri.PerformLayout();
            this.pnlSifreIslemleri.ResumeLayout(false);
            this.pnlSifreIslemleri.PerformLayout();
            this.pnlSayiIslemleri.ResumeLayout(false);
            this.pnlSayiIslemleri.PerformLayout();
            this.pnlKisiIslemleri.ResumeLayout(false);
            this.pnlKisiIslemleri.PerformLayout();
            this.pnlMetinIslemleri.ResumeLayout(false);
            this.pnlMetinIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnEPostaKontrol;

        #endregion

        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTarihIslemleri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYasHesapla;
        private System.Windows.Forms.Button btnYasHesaplaMetinsel;
        private System.Windows.Forms.Button btnTarihAraligi;
        private System.Windows.Forms.Panel pnlSifreIslemleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifrelenecekMetin;
        private System.Windows.Forms.Button btnMd5Hash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSifreSonuc;
        private System.Windows.Forms.Button btnSha256Hash;
        private System.Windows.Forms.Button btnSha512Hash;
        private System.Windows.Forms.Button btnRastgeleSifreUret;
        private System.Windows.Forms.Button btnSifreUygunMu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAyFarki;
        private System.Windows.Forms.Panel pnlSayiIslemleri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOnayKoduOlustur;
        private System.Windows.Forms.Button btnMetneDonustur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbSayiSonuc;
        private System.Windows.Forms.Button btnSayisalMi;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlKisiIslemleri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEPostaDogrula;
        private System.Windows.Forms.Button btnIbanDogrula;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbKisiSonuc;
        private System.Windows.Forms.Button btnTcKimlikDogrula;
        private System.Windows.Forms.TextBox txtKisiMetni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlMetinIslemleri;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTurkceKarakterDuzelt;
        private System.Windows.Forms.Button btnIlkHarfiBuyukYap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lbMetinSonuc;
        private System.Windows.Forms.Button btnIlkHarfleriBuyukYap;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMetinSifrele;
        private System.Windows.Forms.Button btnTelefonNoDuzenle;
    }
}

