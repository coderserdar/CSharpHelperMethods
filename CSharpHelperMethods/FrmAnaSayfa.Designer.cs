namespace CSharpHelperMethods
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
            this.btnTarihAraligi = new System.Windows.Forms.Button();
            this.btnYasHesaplaMetinsel = new System.Windows.Forms.Button();
            this.btnYasHesapla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTarihIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Metin İşlemleri",
            "Tarih İşlemleri",
            "Sayı İşlemleri",
            "Şifre İşlemleri",
            "Kişi İşlemleri"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(132, 13);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbIslemTuru.TabIndex = 0;
            this.cmbIslemTuru.SelectedIndexChanged += new System.EventHandler(this.cmbIslemTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem Türü Seçiniz";
            // 
            // pnlTarihIslemleri
            // 
            this.pnlTarihIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTarihIslemleri.Controls.Add(this.btnTarihAraligi);
            this.pnlTarihIslemleri.Controls.Add(this.btnYasHesaplaMetinsel);
            this.pnlTarihIslemleri.Controls.Add(this.btnYasHesapla);
            this.pnlTarihIslemleri.Controls.Add(this.label4);
            this.pnlTarihIslemleri.Controls.Add(this.lbSonuc);
            this.pnlTarihIslemleri.Controls.Add(this.dtpBitisTarihi);
            this.pnlTarihIslemleri.Controls.Add(this.dtpBaslangicTarihi);
            this.pnlTarihIslemleri.Controls.Add(this.label3);
            this.pnlTarihIslemleri.Controls.Add(this.label2);
            this.pnlTarihIslemleri.Location = new System.Drawing.Point(15, 56);
            this.pnlTarihIslemleri.Name = "pnlTarihIslemleri";
            this.pnlTarihIslemleri.Size = new System.Drawing.Size(374, 181);
            this.pnlTarihIslemleri.TabIndex = 2;
            // 
            // btnTarihAraligi
            // 
            this.btnTarihAraligi.Location = new System.Drawing.Point(204, 76);
            this.btnTarihAraligi.Name = "btnTarihAraligi";
            this.btnTarihAraligi.Size = new System.Drawing.Size(113, 23);
            this.btnTarihAraligi.TabIndex = 10;
            this.btnTarihAraligi.Text = "Tarih Aralığı";
            this.btnTarihAraligi.UseVisualStyleBackColor = true;
            this.btnTarihAraligi.Click += new System.EventHandler(this.btnTarihAraligi_Click);
            // 
            // btnYasHesaplaMetinsel
            // 
            this.btnYasHesaplaMetinsel.Location = new System.Drawing.Point(84, 76);
            this.btnYasHesaplaMetinsel.Name = "btnYasHesaplaMetinsel";
            this.btnYasHesaplaMetinsel.Size = new System.Drawing.Size(113, 23);
            this.btnYasHesaplaMetinsel.TabIndex = 9;
            this.btnYasHesaplaMetinsel.Text = "Yaş Hesapla (Metin)";
            this.btnYasHesaplaMetinsel.UseVisualStyleBackColor = true;
            this.btnYasHesaplaMetinsel.Click += new System.EventHandler(this.btnYasHesaplaMetinsel_Click);
            // 
            // btnYasHesapla
            // 
            this.btnYasHesapla.Location = new System.Drawing.Point(3, 76);
            this.btnYasHesapla.Name = "btnYasHesapla";
            this.btnYasHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnYasHesapla.TabIndex = 8;
            this.btnYasHesapla.Text = "Yaş Hesapla";
            this.btnYasHesapla.UseVisualStyleBackColor = true;
            this.btnYasHesapla.Click += new System.EventHandler(this.btnYasHesapla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sonuç";
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.HorizontalScrollbar = true;
            this.lbSonuc.Location = new System.Drawing.Point(117, 109);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(200, 69);
            this.lbSonuc.TabIndex = 6;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitisTarihi.Location = new System.Drawing.Point(117, 41);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.ShowCheckBox = true;
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBitisTarihi.TabIndex = 5;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(117, 8);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.ShowCheckBox = true;
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangicTarihi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTarihIslemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIslemTuru);
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler Ekranı";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.pnlTarihIslemleri.ResumeLayout(false);
            this.pnlTarihIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
    }
}

