using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    /// <summary>
    /// Library kısmında Metin İşlemleri bölümünde
    /// Yer alan metotların örnek test durumları ve beklenen sonuçları ile
    /// Test edildikleri sınıftır
    /// </summary>
    [TestFixture]
    public class MetinIslemleriTest
    {
        /// <summary>
        /// Mail Adresinin geçerli olup olmadığına dair test metodurur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>E-Posta Adresinin Geçerli Olup Olmadığı Bilgisi</returns>
        [Test]
        [TestCase("serdargul@outlook.com", ExpectedResult = true)]
        [TestCase("serdar@aol.com", ExpectedResult = true)]
        [TestCase("a.b", ExpectedResult = false)]
        [TestCase("a_c", ExpectedResult = false)]
        public bool MailAdresiGecerliMiTest(string metin)
        {
            return MetinIslemleri.MailAdresiGecerliMi(metin);
        }
        
        /// <summary>
        /// Metni şifreleme ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>KVKK Kapsamında Tc ve Vergi Noların Şifrelenmiş Hali</returns>
        [Test]
        [TestCase("2013123817", ExpectedResult = "20******17")]
        [TestCase("11111111111", ExpectedResult = "11*******11")]
        [TestCase("serdar", ExpectedResult = "serdar")]
        public string MetinSifreleTest(string metin)
        {
            return MetinIslemleri.MetinSifrele(metin);
        }
        
        /// <summary>
        /// Boşluk Kaldırma ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Boşluksuz Hali</returns>
        [Test]
        [TestCase("2013123817  ", ExpectedResult = "2013123817")]
        [TestCase("ses ss", ExpectedResult = "sesss")]
        public string BoslukKaldirTest(string metin)
        {
            return MetinIslemleri.BoslukKaldir(metin);
        }
        
        /// <summary>
        /// Metnin zararlı karakterlerinin düzeltilmesine dair test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Özel Karakterler Çıkarılmış Metin</returns>
        [Test]
        [TestCase("2013123817", ExpectedResult = "2013123817")]
        [TestCase("sesss&#252;", ExpectedResult = "sesssü")]
        public string MetinZararliKarakterDuzeltTest(string metin)
        {
            return MetinIslemleri.MetinZararliKarakterDuzelt(metin);
        }
        
        /// <summary>
        /// Metnin ilk karakterinin büyük harf yapılması ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Sadece İlk Karakterinin Büyük Hali</returns>
        [Test]
        [TestCase("serdar", ExpectedResult = "Serdar")]
        [TestCase("bu BİR test metnidir", ExpectedResult = "Bu BİR test metnidir")]
        public string MetinIlkKarakterBuyukDigerleriKucukYapTest(string metin)
        {
            return MetinIslemleri.MetinIlkKarakterBuyukDigerleriKucukYap(metin);
        }
        
        /// <summary>
        /// Metnin kelimelerinin ilk harflerinin büyük harf yapılması ile ilgili test metodudur.
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Kelimelerinin İlk Harflerinin Büyük Hali</returns>
        [Test]
        [TestCase("serdar", ExpectedResult = "Serdar ")]
        [TestCase("bu BİR test metnidir", ExpectedResult = "Bu Bir Test Metnidir ")]
        public string MetinIlkKarakterleriBuyukYapTest(string metin)
        {
            return MetinIslemleri.MetinIlkKarakterleriBuyukYap(metin);
        }
        
        /// <summary>
        /// İdeal Metin Getirme ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Virgülsüz Hali</returns>
        [Test]
        [TestCase("serdar", ExpectedResult = "serdar")]
        [TestCase(",test metni", ExpectedResult = "test metni")]
        public string IdealMetinGetirTest(string metin)
        {
            return MetinIslemleri.IdealMetinGetir(metin);
        }
        
        /// <summary>
        /// Telefon No bilgisinin düzeltilmesi ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Telefon No Bilgisinin Düzeltilmiş Hali</returns>
        [Test]
        [TestCase("0(505)333-44-55", ExpectedResult = "5053334455")]
        [TestCase("0 505 123 45 67", ExpectedResult = "5051234567")]
        [TestCase("0-312-123-45-67", ExpectedResult = "3121234567")]
        public string TelefonNoDuzenleTest(string metin)
        {
            return MetinIslemleri.TelefonNoDuzenle(metin);
        }
        
        /// <summary>
        /// Türkçe Karakter Düzeltme ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Türkçe Karaktersiz Hali</returns>
        [Test]
        [TestCase("fıstıkçı şahap", ExpectedResult = "fistikci sahap")]
        [TestCase("uğulu", ExpectedResult = "ugulu")]
        [TestCase("öğrenci", ExpectedResult = "ogrenci")]
        public string TurkceKarakterleriDuzeltTest(string metin)
        {
            return MetinIslemleri.TurkceKarakterleriDuzelt(metin);
        }
        
        /// <summary>
        /// UTF8 Metnin Düzeltilmesi ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>UTF8'e Göre Metnin Düzeltilmiş Hali</returns>
        [Test]
        [TestCase("fıstıkçı şahap&amp;ccedil;", ExpectedResult = "fıstıkçı şahapç")]
        [TestCase("uğulu&ouml;", ExpectedResult = "uğuluö")]
        [TestCase("öğrenci&uuml;", ExpectedResult = "öğrenciü")]
        public string UTF8DuzeltTest(string metin)
        {
            return MetinIslemleri.UTF8Duzelt(metin);
        }
        
        /// <summary>
        /// HTML Metnin Düzeltilmesi ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>HTML'e Göre Metnin Düzeltilmiş Hali</returns>
        [Test]
        [TestCase("fıstıkçı şahap<.*?>", ExpectedResult = "fıstıkçı şahap")]
        [TestCase("uğulu  ", ExpectedResult = "uğulu")]
        public string HTMLDuzeltTest(string metin)
        {
            return MetinIslemleri.HTMLDuzelt(metin);
        }
    }
}