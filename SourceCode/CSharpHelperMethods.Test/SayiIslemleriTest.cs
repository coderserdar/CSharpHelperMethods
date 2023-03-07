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
        [Test]
        [TestCase("15", ExpectedResult = true)]
        [TestCase("15123132", ExpectedResult = true)]
        [TestCase("3242a", ExpectedResult = false)]
        [TestCase("asdada", ExpectedResult = false)]
        public bool SayisalMiTest(string metin)
        {
            return SayiIslemleri.SayisalMi(metin);
        }
        
        [Test]
        [TestCase("15_05", ExpectedResult = 15.05)]
        [TestCase("456.11", ExpectedResult = 456.11)]
        public decimal SayiHalineCevirTest(string metin)
        {
            return SayiIslemleri.SayiHalineCevir(metin);
        }
        
        [Test]
        [TestCase(1500, ExpectedResult = "BİNBEŞYÜZ TL SIFIR KR.")]
        [TestCase(456789.76, ExpectedResult = "DÖRTYÜZELLİALTIBİNYEDİYÜZSEKSENDOKUZ TL YETMİŞALTI KR.")]
        public string SayiyiYaziyaCevirTest(decimal sayi)
        {
            return SayiIslemleri.SayiyiYaziyaCevir(sayi);
        }
    }
}