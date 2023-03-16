using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    /// <summary>
    /// Library kısmında Sayı İşlemleri bölümünde
    /// Yer alan metotların örnek test durumları ve beklenen sonuçları ile
    /// Test edildikleri sınıftır
    /// </summary>
    [TestFixture]
    public class SayiIslemleriTest
    {
        /// <summary>
        /// Metnin sayısal olup olmadığı ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Sayı Olup Olmadığı Bilgisi</returns>
        [Test]
        [TestCase("15", ExpectedResult = true)]
        [TestCase("15123132", ExpectedResult = true)]
        [TestCase("3242a", ExpectedResult = false)]
        [TestCase("asdada", ExpectedResult = false)]
        public bool SayisalMiTest(string metin)
        {
            return SayiIslemleri.SayisalMi(metin);
        }
        
        /// <summary>
        /// Metni sayıya çevirme ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin Sayı Hali</returns>
        [Test]
        [TestCase("15_05", ExpectedResult = 15.05)]
        [TestCase("456.11", ExpectedResult = 456.11)]
        public decimal SayiHalineCevirTest(string metin)
        {
            return SayiIslemleri.SayiHalineCevir(metin);
        }
        
        /// <summary>
        /// Girilen sayısal para bilgisini yazıya çevirmekle ilgili test metodudur
        /// </summary>
        /// <param name="sayi">Sayı Bilgisi</param>
        /// <returns>Sayının Metinsel Hali</returns>
        [Test]
        [TestCase(1500, ExpectedResult = "BİNBEŞYÜZ TL SIFIR KR.")]
        [TestCase(456789.76, ExpectedResult = "DÖRTYÜZELLİALTIBİNYEDİYÜZSEKSENDOKUZ TL YETMİŞALTI KR.")]
        public string SayiyiYaziyaCevirTest(decimal sayi)
        {
            return SayiIslemleri.SayiyiYaziyaCevir(sayi);
        }
    }
}