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

        private void FrmAnaSayfa_Load(object sender, System.EventArgs e)
        {
            pnlTarihIslemleri.Enabled = false;
            pnlSifreIslemleri.Enabled = false;
            pnlSayiIslemleri.Enabled = false;
        }

        private void cmbIslemTuru_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbIslemTuru.SelectedIndex == 1)
            {
                pnlTarihIslemleri.Enabled = true;
                pnlSifreIslemleri.Enabled = false;
                pnlSayiIslemleri.Enabled = false;
            }
            else if (cmbIslemTuru.SelectedIndex == 2)
            {
                pnlTarihIslemleri.Enabled = false;
                pnlSifreIslemleri.Enabled = false;
                pnlSayiIslemleri.Enabled = true;
            }
            else if (cmbIslemTuru.SelectedIndex == 3)
            {
                pnlTarihIslemleri.Enabled = false;
                pnlSifreIslemleri.Enabled = true;
                pnlSayiIslemleri.Enabled = false;
            }
            else
            {
                pnlTarihIslemleri.Enabled = false;
                pnlSifreIslemleri.Enabled = false;
                pnlSayiIslemleri.Enabled = false;
            }
        }

        #region Tarih İşlemleri
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

        private void btnRastgeleSifreUret_Click(object sender, System.EventArgs e)
        {
            lbSifreSonuc.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Rastgele Üretilen Şifre: ");
            sb.Append(SifrelemeIslemleri.RastgeleSifreUret());
            lbSifreSonuc.Items.Add(sb.ToString());
        }

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

        private void btnOnayKoduOlustur_Click(object sender, System.EventArgs e)
        {
            lbSayiSonuc.Items.Clear();
            StringBuilder sb = new StringBuilder();
            sb.Append("Oluşturulan 6 haneli onay kodu: ");
            sb.Append(SayiIslemleri.AltiHaneliOnayKoduOlustur());
            lbSayiSonuc.Items.Add(sb.ToString());
        }
        #endregion
    }
}
