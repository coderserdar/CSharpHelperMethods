﻿using System;
using System.Drawing;
using System.Linq;
using CSharpHelperMethods.Library;
using System.Text;
using System.Windows.Forms;

namespace CSharpHelperMethods.UI
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        #region Formun Yüklenmesi, Panel Seçimi ve ListBox Düzenlemeleri
        /// <summary>
        /// Form İlk Yüklendiği zaman ekrandaki bütün panellerin erişilemez hale getirilmesi
        /// sağlanıyor Bu metotta, çünkü hangi panelin aktifleşeceğinin
        /// Combobox üzerinden seçilmesi lazım
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            cmbIslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            PaneliErisilebilirKil("Hicbiri");
            ListBoxlariCokluSatirliYap();
        }

        /// <summary>
        /// İşlem Türü Combobox'ında seçilen değere göre
        /// Ekrandaki panellerden ilgili olan haricinde hepsinin erişilemez hale getirilmesi
        /// Eğer bir şey seçilmemişse, tamamının erişilemez hale getirilmesi için
        /// Gerekli işlemlerin gerçekleştirildiği metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void cmbIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            var panelAdi = "Hicbiri";
            if (OnemliBilgiler.PanelListesi.Any(j => j.Key == cmbIslemTuru.SelectedIndex))
                panelAdi = OnemliBilgiler.PanelListesi.First(j => j.Key == cmbIslemTuru.SelectedIndex).Value;
            PaneliErisilebilirKil(panelAdi);
        }

        /// <summary>
        /// Parametre olarak verilen panelin aktif hale getirilmesi
        /// Diğer panellerin deaktif edilmesi için hazırlanmış metottur
        /// </summary>
        /// <param name="panelAdi">Panel Adı Bilgisi</param>
        private void PaneliErisilebilirKil(string panelAdi)
        {
            foreach (Control formElement in Controls)
            {
                if (formElement.Name == panelAdi)
                    formElement.Enabled = true;
                else if (formElement.Name.StartsWith("pnl"))
                    formElement.Enabled = false;
            }
        }

        /// <summary>
        /// Tüm Panelleri gezerek panellerin içerisindeki listboxların
        /// Multiline özelliğine kavuşması için
        /// Gerekli işlemlerin düzenlendiği metottur.
        /// </summary>
        private void ListBoxlariCokluSatirliYap()
        {
            foreach (Control formElement in Controls)
            {
                if (formElement.GetType() != typeof(Panel)) continue;
                var listBoxList = formElement.Controls.OfType<ListBox>().ToList();
                foreach (var listBox in listBoxList)
                {
                    listBox.DrawMode = DrawMode.OwnerDrawVariable;
                    listBox.MeasureItem += listBox_MeasureItem;
                    listBox.DrawItem += listBox_DrawItem;
                }
            }
        }
        
        /// <summary>
        /// This method is used to meaure the length of the item in listbox and make it multi line
        /// without using scrollbar and let the user see more efficiently
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private static void listBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (!(sender is ListBox listBox)) return;
            if (listBox.Items.Count > 0)
                e.ItemHeight = (int) e.Graphics.MeasureString(listBox.Items[e.Index].ToString(), listBox.Font, listBox.Width).Height;
        }

        /// <summary>
        /// This method is used to meaure the length of the item in listbox and make it multi line
        /// without using scrollbar and let the user see more efficiently
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private static void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (!(sender is ListBox listBox)) return;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (listBox.Items.Count > 0)
                e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
        
        #endregion

        #region Tarih İşlemleri

        /// <summary>
        /// Paneldeki Başlangıç Tarihi seçili ve tarih girilmişse,
        /// o tarihten bugüne kaç yaş olduğunun hesaplandığı metottur.
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnYasHesapla_Click(object sender, EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked)
                MessageBox.Show(Sabitler.BaslangicTarihiGirilmedi);
            else
            {
                lbSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Doğum tarihi seçilen kişi ");
                sb.Append(TarihIslemleri.YasHesapla(dtpBaslangicTarihi.Value));
                sb.Append(" yaşının içindedir");
                lbSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki Başlangıç Tarihi seçili ve tarih girilmişse,
        /// o tarihten bugüne kaç yaş olduğunun yıl, ay ve gün
        /// olarak metinsel bir şekilde hesaplandığı metottur. 
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnYasHesaplaMetinsel_Click(object sender, EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked)
                MessageBox.Show(Sabitler.BaslangicTarihiGirilmedi);
            else
            {
                lbSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append(TarihIslemleri.YasHesaplaMetinsel(dtpBaslangicTarihi.Value));
                lbSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki Başlangıç Tarihi ve Bitiş Tarihi alanları seçili ve tarih girilmişse,
        /// Söz konusu tarihler arasında kaç yıl, kaç ay ve gün olduğunun bilgisinin hazırlandığı metottur.
        /// İlgili butona tıklandığı zaman çalışır
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnTarihAraligi_Click(object sender, EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked || !dtpBitisTarihi.Checked)
                MessageBox.Show(Sabitler.BaslangicVeyaBitisTarihiGirilmedi);
            else if (dtpBaslangicTarihi.Value.Date > dtpBitisTarihi.Value.Date)
                MessageBox.Show(Sabitler.BaslangicTarihiBuyuk);
            else
            {
                lbSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnAyFarki_Click(object sender, EventArgs e)
        {
            if (!dtpBaslangicTarihi.Checked || !dtpBitisTarihi.Checked)
                MessageBox.Show(Sabitler.BaslangicVeyaBitisTarihiGirilmedi);
            else if (dtpBaslangicTarihi.Value.Date > dtpBitisTarihi.Value.Date)
                MessageBox.Show(Sabitler.BaslangicTarihiBuyuk);
            else
            {
                lbSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnMd5Hash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show(Sabitler.SifrelenecekMetinGirilmedi);
            else
            {
                lbSifreSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnSha256Hash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show(Sabitler.SifrelenecekMetinGirilmedi);
            else
            {
                lbSifreSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnSha512Hash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show(Sabitler.SifrelenecekMetinGirilmedi);
            else
            {
                lbSifreSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Girilen Metnin SHA 512 Karşılığı: ");
                sb.Append(SifrelemeIslemleri.HesaplaSHA512(txtSifrelenecekMetin.Text.Trim()));
                lbSifreSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// İlgili butona tıklandığında rastgele şifre üretilmesini sağlayan metottur
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnRastgeleSifreUret_Click(object sender, EventArgs e)
        {
            lbSifreSonuc.Items.Clear();
            var sb = new StringBuilder();
            sb.Append("Rastgele Üretilen Şifre: ");
            sb.Append(SifrelemeIslemleri.RastgeleSifreUret());
            lbSifreSonuc.Items.Add(sb.ToString());
        }

        /// <summary>
        /// Paneldeki metin kutusu dolu ise
        /// Burada yazılan metnin bir şifre olarak belirli kriterlere uygun olup olmadığının
        /// Gösterilmesini sağlayan bir metottur
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnSifreUygunMu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifrelenecekMetin.Text.Trim()))
                MessageBox.Show(Sabitler.SifreMetniGirilmedi);
            else
            {
                lbSifreSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnSayisalMi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSayi.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbSayiSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Girilen Metin Sayı Mı?: ");
                sb.Append(SayiIslemleri.SayisalMi(txtSayi.Text.Trim()) ? "Evet" : "Hayır");
                lbSayiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen para birimi cinsinden rakamın
        /// Yazıya çevrilmesini sağlayan ve sonucu listbox üzerinde gösteren bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnMetneDonustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSayi.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else if (!SayiIslemleri.SayisalMi(txtSayi.Text.Trim().Replace(",", ".").Replace(".", "")))
                MessageBox.Show(Sabitler.MetinSayisalDegil);
            else
            {
                var metinSadeceSayiKismi = txtSayi.Text.Trim();
                var sayi = SayiIslemleri.SayiHalineCevir(metinSadeceSayiKismi);
                lbSayiSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Girilen Sayının Metin Hali (Parasal): ");
                sb.Append(SayiIslemleri.SayiyiYaziyaCevir(sayi));
                lbSayiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Rastgele olacak şekilde 6 haneli kod oluşturmayı sağlayan bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnOnayKoduOlustur_Click(object sender, EventArgs e)
        {
            lbSayiSonuc.Items.Clear();
            var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnTcKimlikDogrula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else if (!SayiIslemleri.SayisalMi(txtKisiMetni.Text.Trim()))
                MessageBox.Show(Sabitler.MetinSayisalDegil);
            else if (txtKisiMetni.Text.Trim().Length != 11)
                MessageBox.Show(Sabitler.MetinTcKimlikNoDegil);
            else
            {
                lbKisiSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("TC Kimlik No Doğru Mu?: ");
                sb.Append(KisiIslemleri.DogrulaTcKimlikNo(txtKisiMetni.Text.Trim()) ? "Evet" : "Hayır");
                lbKisiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen IBAN Numarasının 
        /// Standart IBAN algoritmasına uygun olup olmadığını kontrol eden bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnIbanDogrula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else if (txtKisiMetni.Text.Trim().Length != 26)
                MessageBox.Show(Sabitler.MetinIbanNoDegil + txtKisiMetni.Text.Trim().Length);
            else
            {
                lbKisiSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("IBAN Doğru Mu?: ");
                sb.Append(KisiIslemleri.DogrulaIBAN(txtKisiMetni.Text.Trim()) ? "Evet" : "Hayır");
                lbKisiSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin
        /// Geçerli bir e-posta adresi olup olmadığını kontrol eden bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnEPostaDogrula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisiMetni.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbKisiSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnIlkHarfleriBuyukYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbMetinSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Metnin Düzenlenmiş Hali: ");
                sb.Append(txtMetin.Text.Trim().MetinIlkKarakterleriBuyukYap());
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin 
        /// Sadece ilk harfini büyük yapmaya yarayan bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnIlkHarfiBuyukYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbMetinSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Metnin Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.MetinIlkKarakterBuyukDigerleriKucukYap(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Paneldeki metin kutusuna girilen metnin 
        /// İçerisindeki Türkçe karakterleri İngilizee hallerine çeviren bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnTurkceKarakterDuzelt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbMetinSonuc.Items.Clear();
                var sb = new StringBuilder();
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
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnMetinSifrele_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else if (!SayiIslemleri.SayisalMi(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinSayisalDegil);
            else if (txtMetin.Text.Trim().Length != 11 && txtMetin.Text.Trim().Length != 10)
                MessageBox.Show(Sabitler.MetinTcKimlikNoVeyaVergiNoDegil);
            else
            {
                lbMetinSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("TC Kimlik No veya Vergi No'nun Şifrelenmiş Hali: ");
                sb.Append(MetinIslemleri.MetinSifrele(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }

        /// <summary>
        /// Ekrandan çeşitli karakterler içeren telefon numaraları alındığı zaman
        /// Bu telefon numarasını olması gerektiği hale çevirmeye yarayan bir metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnTelefonNoDuzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbMetinSonuc.Items.Clear();
                var sb = new StringBuilder();
                sb.Append("Telefon Numarasının Düzenlenmiş Hali: ");
                sb.Append(MetinIslemleri.TelefonNoDuzenle(txtMetin.Text.Trim()));
                lbMetinSonuc.Items.Add(sb.ToString());
            }
        }
        
        /// <summary>
        /// Ekrandan girilen metnin geçerli bir e-posta adresi olup olmadığını kontrol eden
        /// Sonucu listbox'a yazdıran metottur.
        /// </summary>
        /// <param name="sender">The sender info (For example Main Form)</param>
        /// <param name="e">Event Arguments</param>
        private void btnEPostaKontrol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMetin.Text.Trim()))
                MessageBox.Show(Sabitler.MetinGirilmedi);
            else
            {
                lbMetinSonuc.Items.Clear();
                var gecerliMi = MetinIslemleri.MailAdresiGecerliMi(txtMetin.Text.Trim());
                lbMetinSonuc.Items.Add(txtMetin.Text.Trim());
                lbMetinSonuc.Items.Add(gecerliMi ? Sabitler.EPostaAdresiGecerli : Sabitler.EPostaAdresiGecerliDegil);
            }
        }
        #endregion
    }
}