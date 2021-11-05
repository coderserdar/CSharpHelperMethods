using CSharpHelperMethods.YardimciSiniflar;
using System.Text;
using System.Windows.Forms;

namespace CSharpHelperMethods
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        #region Formun Yüklenmesi ve Panel Seçimi
        /// <summary>
        /// Form İlk Yüklendiği zaman ekrandaki bütün panellerin erişilemez hale getirilmesi sağlanıyor
        /// Bu metotta, çünkü hangi panelin akttifleşeceğinin
        /// Combobox üzerinden seçilmesi lazım
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAnaSayfa_Load(object sender, System.EventArgs e)
        {
            #region Sayfa İlk Yüklendiğinde Tüm Panellerin Erişime Kapanması
            pnlTarihIslemleri.Enabled = false;
            pnlSifreIslemleri.Enabled = false;
            pnlSayiIslemleri.Enabled = false;
            pnlKisiIslemleri.Enabled = false;
            pnlMetinIslemleri.Enabled = false;
            #endregion
        }

        /// <summary>
        /// İşlem Türü Combobox'ında seçilen değere göre
        /// Ekrandaki panellerden ilgili olan haricinde hepsinin erişilemez hale getirilmesi
        /// Eğer bir şey seçilmemişse, tamamının erişilemez hale getirilmesi için
        /// Gerekli işlemlerin gerçekleştirildiği metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbIslemTuru_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            #region Combobox'tan Seçilen Değere Göre İlgili Paneli Aktif Hale Getirme
            switch (cmbIslemTuru.SelectedIndex)
            {
                // Metin İşlemleri
                case 0:
                    {
                        pnlMetinIslemleri.Enabled = true;
                        pnlTarihIslemleri.Enabled = false;
                        pnlSifreIslemleri.Enabled = false;
                        pnlSayiIslemleri.Enabled = false;
                        pnlKisiIslemleri.Enabled = false;
                        break;
                    }
                // Tarih İşlemleri
                case 1:
                    {
                        pnlMetinIslemleri.Enabled = false;
                        pnlTarihIslemleri.Enabled = true;
                        pnlSifreIslemleri.Enabled = false;
                        pnlSayiIslemleri.Enabled = false;
                        pnlKisiIslemleri.Enabled = false;
                        break;
                    }
                // Sayı İşlemleri
                case 2:
                    {
                        pnlMetinIslemleri.Enabled = false;
                        pnlTarihIslemleri.Enabled = false;
                        pnlSifreIslemleri.Enabled = false;
                        pnlSayiIslemleri.Enabled = true;
                        pnlKisiIslemleri.Enabled = false;
                        break;
                    }
                // Şifre İşlemleri
                case 3:
                    {
                        pnlMetinIslemleri.Enabled = false;
                        pnlTarihIslemleri.Enabled = false;
                        pnlSifreIslemleri.Enabled = true;
                        pnlSayiIslemleri.Enabled = false;
                        pnlKisiIslemleri.Enabled = false;
                        break;
                    }
                // Kişi İşlemleri
                case 4:
                    {
                        pnlMetinIslemleri.Enabled = false;
                        pnlTarihIslemleri.Enabled = false;
                        pnlSifreIslemleri.Enabled = false;
                        pnlSayiIslemleri.Enabled = false;
                        pnlKisiIslemleri.Enabled = true;
                        break;
                    }
                // Bunlar haricinde herhangi bir şey
                default:
                    {
                        pnlMetinIslemleri.Enabled = false;
                        pnlTarihIslemleri.Enabled = false;
                        pnlSifreIslemleri.Enabled = false;
                        pnlSayiIslemleri.Enabled = false;
                        pnlKisiIslemleri.Enabled = false;
                        break;
                    }
            }
            #endregion
        }
        #endregion

        #region Tarih İşlemleri

        /// <summary>
        /// Paneldeki Başlangıç Tarihi seçili ve tarih girilmişse, o tarihten bugüne kaç yaş olduğunun hesaplandığı metottur. İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYasHesapla_Click(object sender, System.EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked)
                MessageBox.Show("Başlangıç Tarihi girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Doğum tarihi seçilen kişi ");
                sb.Append(TarihIslemleri.YasHesapla(dtpBaslangicTarihi.Value));
                sb.Append(" yaşındadır");
                lbSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki Başlangıç Tarihi seçili ve tarih girilmişse, o tarihten bugüne kaç yaş olduğunun yıl, ay ve gün olarak metinsel bir şekilde hesaplandığı metottur. 
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYasHesaplaMetinsel_Click(object sender, System.EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked)
                MessageBox.Show("Başlangıç Tarihi girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append(TarihIslemleri.YasHesaplaMetinsel(dtpBaslangicTarihi.Value));
                lbSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki Başlangıç Tarihi ve Bitiş Tarihi alanları seçili ve tarih girilmişse,
        /// Söz konusu tarihler arasında kaç yıl, kaç ay ve gün olduğunun bilgisinin hazırlandığı metottur.
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTarihAraligi_Click(object sender, System.EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked || !dtpBitisTarihi.Checked)
                MessageBox.Show("Başlangıç Tarihi veya Bitiş Tarihi girilmediği için bu işlem gerçekleştirilemez");
            else if (dtpBaslangicTarihi.Value.Date > dtpBitisTarihi.Value.Date)
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden büyük olamaz");
            else
            {
                lbSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("İki tarih arası: ");
                sb.Append(TarihIslemleri.TarihAraligiHesapla(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date));
                lbSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki Başlangıç Tarihi ve Bitiş Tarihi alanları seçili ve tarih girilmişse,
        /// Söz konusu tarihler arasında kaç ay olduğunun bilgisinin hazırlandığı metottur.
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyFarki_Click(object sender, System.EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked || !dtpBitisTarihi.Checked)
                MessageBox.Show("Başlangıç Tarihi veya Bitiş Tarihi girilmediği için bu işlem gerçekleştirilemez");
            else if (dtpBaslangicTarihi.Value.Date > dtpBitisTarihi.Value.Date)
                MessageBox.Show("Başlangıç Tarihi Bitiş Tarihinden büyük olamaz");
            else
            {
                lbSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Ay Farkı: ");
                sb.Append(TarihIslemleri.AyFarki(dtpBaslangicTarihi.Value.Date, dtpBitisTarihi.Value.Date));
                lbSonuc.Items.Add(sb.ToString());
            }
        }
        #endregion

        #region Şifre İşlemleri
        /// <summary>
        /// Paneldeki metin kutusu dolu ise
        /// Girilen metnin MD5 algoritması ile şifrelenmiş halini
        /// Listbox üzerine yazdıran metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMd5Hash_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show("Şifrelenecek metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSifreSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Metnin MD5 Karşılığı: ");
                sb.Append(SifrelemeIslemleri.HesaplaMD5(txtSifrelenecekMetin.Text.Trim()));
                lbSifreSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusu dolu ise
        /// Girilen metnin SHA 256 algoritması ile şifrelenmiş halini
        /// Listbox üzerine yazdıran metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSha256Hash_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show("Şifrelenecek metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSifreSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Metnin SHA 256 Karşılığı: ");
                sb.Append(SifrelemeIslemleri.HesaplaSHA256(txtSifrelenecekMetin.Text.Trim()));
                lbSifreSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusu dolu ise
        /// Girilen metnin SHA 512 algoritması ile şifrelenmiş halini
        /// Listbox üzerine yazdıran metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSha512Hash_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show("Şifrelenecek metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSifreSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Metnin SHA 512 Karşılığı: ");
                sb.Append(SifrelemeIslemleri.HesaplaSHA512(txtSifrelenecekMetin.Text.Trim()));
                lbSifreSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// İlgili butona tıklandığında rastgele şifre üretilmesini sağlayan metottur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRastgeleSifreUret_Click(object sender, System.EventArgs e)
        {
            lbSifreSonuc.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Rastgele Üretilen Şifre: ");
            sb.Append(SifrelemeIslemleri.RastgeleSifreUret());
            lbSifreSonuc.Items.Add(sb.ToString());
        }

        /// <summary>
        /// Paneldeki metin kutusu dolu ise
        /// Burada yazılan metnin bir şifre olarak belirli kriterlere uygun olup olmadığının
        /// Gösterilmesini sağlayan bir metottur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifreUygunMu_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show("Şifre metni girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSifreSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Şifrenin Uygunluk Durumu: ");
                sb.Append(SifrelemeIslemleri.SifreUygunMu(txtSifrelenecekMetin.Text.Trim()));
                lbSifreSonuc.Items.Add(sb.ToString());
            }
        }
        #endregion

        #region Sayı İşlemleri
        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin sayısal bir değer olup olmadığını
        /// Kontrol eden ve sonucu gösteren metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSayisalMi_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSayi.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbSayiSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Metin Sayı Mı?: ");
                sb.Append(SayiIslemleri.SayisalMi(txtSayi.Text.Trim()) ? "Evet" : "Hayır");
                lbSayiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen para birimi cinsinden rakamın
        /// Yazıya çevrilmesini sağlayan ve sonucu listbox üzerinde gösteren bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMetneDonustur_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSayi.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else if (!SayiIslemleri.SayisalMi(txtSayi.Text.Trim().Replace(",", ".").Replace(".", "")))
                MessageBox.Show("Girilen metin sayısal bir değer olmadığı için bu işlem gerçekleştirilemez");
            else
            {
                var metinSadeceSayiKismi = txtSayi.Text.Trim();
                decimal sayi = SayiIslemleri.SayiHalineCevir(metinSadeceSayiKismi);
                lbSayiSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Girilen Sayının Metin Hali (Parasal): ");
                sb.Append(SayiIslemleri.SayiyiYaziyaCevir(sayi));
                lbSayiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Rastgele olacak şekilde 6 haneli kod oluşturmayı sağlayan bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnayKoduOlustur_Click(object sender, System.EventArgs e)
        {
            lbSayiSonuc.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Oluşturulan 6 haneli onay kodu: ");
            sb.Append(SayiIslemleri.AltiHaneliOnayKoduOlustur());
            lbSayiSonuc.Items.Add(sb.ToString());
        }
        #endregion

        #region Kişi İşlemleri
        /// <summary>
        /// Paneldeki metin kutusuna girilen TC Kimlik numarasının 
        /// Standart TC Kimlik No algoritmasına uygun olup olmadığını kontrol eden bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTcKimlikDogrula_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else if (!SayiIslemleri.SayisalMi(txtKisiMetni.Text.Trim()))
                MessageBox.Show("Girilen metin sayısal bir değer olmadığı için bu işlem gerçekleştirilemez");
            else if (txtKisiMetni.Text.Trim().Length != 11)
                MessageBox.Show("Girilen metin 11 karakter olmadığı için bu işlem gerçekleştirilemez");
            else
            {
                lbKisiSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("TC Kimlik No Doğru Mu?: ");
                sb.Append(KisiIslemleri.DogrulaTcKimlikNo(txtKisiMetni.Text.Trim()) ? "Evet" : "Hayır");
                lbKisiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen IBAN Numarasının 
        /// Standart IBAN algoritmasına uygun olup olmadığını kontrol eden bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIbanDogrula_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else if (txtKisiMetni.Text.Trim().Length != 26)
                MessageBox.Show("Girilen metin 26 karakter olmadığı için bu işlem gerçekleştirilemez. Karakter sayısı: " + txtKisiMetni.Text.Trim().Length);
            else
            {
                lbKisiSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("IBAN Doğru Mu?: ");
                sb.Append(KisiIslemleri.DogrulaIBAN(txtKisiMetni.Text.Trim()) ? "Evet" : "Hayır");
                lbKisiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin
        /// Geçerli bir e-posta adresi olup olmadığını kontrol eden bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEPostaDogrula_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbKisiSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("E-Posta Doğru Mu?: ");
                sb.Append(KisiIslemleri.DogrulaEPosta(txtKisiMetni.Text.Trim()) ? "Evet" : "Hayır");
                lbKisiSonuc.Items.Add(sb.ToString());
            }
        }
        #endregion

        #region Metin İşlemleri
        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin 
        /// Kelimelerinin ilk harflerini büyük yapmaya yarayan bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIlkHarfleriBuyukYap_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbMetinSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Metnin Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.MetinIlkKarakterleriBuyukYap(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin 
        /// Sadece ilk harfini büyük yapmaya yarayan bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIlkHarfiBuyukYap_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbMetinSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Metnin Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.MetinIlkKarakterBuyukDigerleriKucukYap(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin 
        /// İçerisindeki Türkçe karakterleri İngilizee hallerine çeviren bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTurkceKarakterDuzelt_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbMetinSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Metnin Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.TurkceKarakterleriDuzelt(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// KVKK durumlarından dolayı TC Kimlik No ve Vergi No gibi alanların
        /// Matbu çıktılarda gizlenmesi gibi bir durum söz konusu olduğundan
        /// Girilen bu 10 veya 11 karakterlik metinleri şifrelemeye yarayan bir metottur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMetinSifrele_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else if (!SayiIslemleri.SayisalMi(txtMetin.Text.Trim()))
                MessageBox.Show("Girilen metin sayısal bir değer olmadığı için bu işlem gerçekleştirilemez");
            else if (txtMetin.Text.Trim().Length != 11 && txtMetin.Text.Trim().Length != 10)
                MessageBox.Show("Girilen metin 10 veya 11 karakter olmadığı için bu işlem gerçekleştirilemez");
            else
            {
                lbMetinSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("TC Kimlik No veya Vergi No'nun Şifrelenmiş Hali: ");
                sb.Append(MetinIslemleri.MetinSifrele(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Ekrandan çeşitli karakterler içeren telefon numaraları alındığı zaman
        /// Bu telefon numarasını olması gerektiği hale çevirmeye yarayan bir metottur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTelefonNoDuzenle_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show("Metin girilmediği için bu işlem gerçekleştirilemez");
            else
            {
                lbMetinSonuc.Items.Clear();
                StringBuilder sb = new StringBuilder();
                sb.Append("Telefon Numarasının Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.TelefonNoDuzenle(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }
        #endregion
    }
}
