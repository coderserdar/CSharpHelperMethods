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
        [Test]
        [TestCase("serdargul@outlook.com", ExpectedResult = true)]
        [TestCase("serdar@aol.com", ExpectedResult = true)]
        [TestCase("a.b", ExpectedResult = false)]
        [TestCase("a_c", ExpectedResult = false)]
        public bool MailAdresiGecerliMiTest(string metin)
        {
            return MetinIslemleri.MailAdresiGecerliMi(metin);
        }
        
        [Test]
        [TestCase("2013123817", ExpectedResult = "20******17")]
        [TestCase("11111111111", ExpectedResult = "11*******11")]
        [TestCase("serdar", ExpectedResult = "serdar")]
        public string MetinSifreleTest(string metin)
        {
            return MetinIslemleri.MetinSifrele(metin);
        }
        
        [Test]
        [TestCase("2013123817  ", ExpectedResult = "2013123817")]
        [TestCase("ses ss", ExpectedResult = "sesss")]
        public string BoslukKaldirTest(string metin)
        {
            return MetinIslemleri.BoslukKaldir(metin);
        }
        
        [Test]
        [TestCase("2013123817", ExpectedResult = "2013123817")]
        [TestCase("sesss&#252;", ExpectedResult = "sesssü")]
        public string MetinZararliKarakterDuzeltTest(string metin)
        {
            return MetinIslemleri.MetinZararliKarakterDuzelt(metin);
        }
        
        [Test]
        [TestCase("serdar", ExpectedResult = "Serdar")]
        [TestCase("bu BİR test metnidir", ExpectedResult = "Bu BİR test metnidir")]
        public string MetinIlkKarakterBuyukDigerleriKucukYapTest(string metin)
        {
            return MetinIslemleri.MetinIlkKarakterBuyukDigerleriKucukYap(metin);
        }
        
        [Test]
        [TestCase("serdar", ExpectedResult = "Serdar ")]
        [TestCase("bu BİR test metnidir", ExpectedResult = "Bu Bir Test Metnidir ")]
        public string MetinIlkKarakterleriBuyukYapTest(string metin)
        {
            return MetinIslemleri.MetinIlkKarakterleriBuyukYap(metin);
        }
        
        [Test]
        [TestCase("serdar", ExpectedResult = "serdar")]
        [TestCase(",test metni", ExpectedResult = "test metni")]
        public string IdealMetinGetirTest(string metin)
        {
            return MetinIslemleri.IdealMetinGetir(metin);
        }
        
        [Test]
        [TestCase("0(505)333-44-55", ExpectedResult = "5053334455")]
        [TestCase("0 505 123 45 67", ExpectedResult = "5051234567")]
        [TestCase("0-312-123-45-67", ExpectedResult = "3121234567")]
        public string TelefonNoDuzenleTest(string metin)
        {
            return MetinIslemleri.TelefonNoDuzenle(metin);
        }
        
        [Test]
        [TestCase("fıstıkçı şahap", ExpectedResult = "fistikci sahap")]
        [TestCase("uğulu", ExpectedResult = "ugulu")]
        [TestCase("öğrenci", ExpectedResult = "ogrenci")]
        public string TurkceKarakterleriDuzeltTest(string metin)
        {
            return MetinIslemleri.TurkceKarakterleriDuzelt(metin);
        }
    }
}