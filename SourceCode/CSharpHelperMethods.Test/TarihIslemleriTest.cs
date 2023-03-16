using System;
using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    /// <summary>
    /// Library kısmında Tarih İşlemleri bölümünde
    /// Yer alan metotların örnek test durumları ve beklenen sonuçları ile
    /// Test edildikleri sınıftır
    /// </summary>
    [TestFixture]
    public class TarihIslemleriTest
    {
        /// <summary>
        /// Yaş Hesaplama ile ilgili Test Metodudur
        /// </summary>
        /// <param name="yil">Doğum Yılı Bilgisi</param>
        /// <returns>Kaç Yaşında Olduğu Bilgisi</returns>
        [Test]
        [TestCase(1987, ExpectedResult = 36)]
        [TestCase(2023, ExpectedResult = 0)]
        public int YasHesaplaTest(int yil)
        {
            var tarih = new DateTime(yil, 1, 1);
            return TarihIslemleri.YasHesapla(tarih);
        }
        
        /// <summary>
        /// Metinsel Yaş Hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="yil">Doğduğu Yıl Bilgisi</param>
        /// <param name="ay">Doğduğu Ay Bilgisi</param>
        /// <param name="gun">Doğduğu Gün Bilgisi</param>
        /// <returns>Yaşın Metinsel Hali</returns>
        [Test]
        [TestCase(1987, 3, 7, ExpectedResult = "Yaş: 36 Yıl 0 Ay 0 Gün")]
        [TestCase(2022, 1, 7, ExpectedResult = "Yaş: 1 Yıl 2 Ay 0 Gün")]
        public string YasHesaplaMetinselTest(int yil, int ay, int gun)
        {
            var tarih = new DateTime(yil, ay, gun);
            return TarihIslemleri.YasHesaplaMetinsel(tarih);
        }
        
        /// <summary>
        /// Tarih Aralığı hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="yil">Doğduğu Yıl Bilgisi</param>
        /// <param name="ay">Doğduğu Ay Bilgisi</param>
        /// <param name="gun">Doğduğu Gün Bilgisi</param>
        /// <returns>İki Tarih Arasındaki Zaman Bilgisi</returns>
        [Test]
        [TestCase(1987, 3, 7, ExpectedResult = "36 Yıl, 00 Ay, 00 Gün")]
        [TestCase(2022, 1, 7, ExpectedResult = "01 Yıl, 02 Ay, 00 Gün")]
        public string TarihAraligiHesaplaTest(int yil, int ay, int gun)
        {
            var tarih = new DateTime(yil, ay, gun);
            return TarihIslemleri.TarihAraligiHesapla(tarih, DateTime.Now);
        }
        
        /// <summary>
        /// Kıdem Tazminatı Tarih Aralığı hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="yil">Doğduğu Yıl Bilgisi</param>
        /// <param name="ay">Doğduğu Ay Bilgisi</param>
        /// <param name="gun">Doğduğu Gün Bilgisi</param>
        /// <returns>İki Tarih Arasındaki Kıdem Tazminatına Esas Zaman Bilgisi</returns>
        [Test]
        [TestCase(1987, 3, 7, ExpectedResult = 12961)]
        [TestCase(2022, 1, 7, ExpectedResult = 421)]
        public int KidemTazminatiTarihAraligiHesapla(int yil, int ay, int gun)
        {
            var tarih = new DateTime(yil, ay, gun);
            return TarihIslemleri.KidemTazminatiTarihAraligiHesapla(tarih, DateTime.Now);
        }
        
        /// <summary>
        /// İki Tarih arasında kaç ay olduğuna dair hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="yil">Doğduğu Yıl Bilgisi</param>
        /// <param name="ay">Doğduğu Ay Bilgisi</param>
        /// <param name="gun">Doğduğu Gün Bilgisi</param>
        /// <returns>İki Tarih Arasındaki Kaç Ay Olduğu Bilgisi</returns>
        [Test]
        [TestCase(1987, 3, 7, ExpectedResult = 432)]
        [TestCase(2022, 1, 7, ExpectedResult = 14)]
        public int AyFarkiTest(int yil, int ay, int gun)
        {
            var tarih = new DateTime(yil, ay, gun);
            return TarihIslemleri.AyFarki(tarih, DateTime.Now);
        }
    }
}