using System;
using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    /// <summary>
    /// Library kısmında Şifreleme İşlemleri bölümünde
    /// Yer alan metotların örnek test durumları ve beklenen sonuçları ile
    /// Test edildikleri sınıftır
    /// </summary>
    [TestFixture]
    public class SifrelemeIslemleriTest
    {
        /// <summary>
        /// MDS Hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin MD5 Hashlenmiş Hali</returns>
        [Test]
        [TestCase("1", ExpectedResult = "C4CA4238A0B923820DCC509A6F75849B")]
        [TestCase("serdar", ExpectedResult = "11A37959E906860A34392F586E544FD3")]
        public string HesaplaMD5Test(string metin)
        {
            return SifrelemeIslemleri.HesaplaMD5(metin);
        }
        
        /// <summary>
        /// SHA256 Hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin SHA256 Hashlenmiş Hali</returns>
        [Test]
        [TestCase("deneme", ExpectedResult = "25B80B3556CA3A15353DD2FD312062FAD27ADCF5A1DE51B75BDADEA1FA8214AB")]
        [TestCase("12", ExpectedResult = "6B51D431DF5D7F141CBECECCF79EDF3DD861C3B4069F0B11661A3EEFACBBA918")]
        public string HesaplaSHA256Test(string metin)
        {
            return SifrelemeIslemleri.HesaplaSHA256(metin);
        }
        
        /// <summary>
        /// SHA512 Hesaplama ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Metnin SHA512 Hashlenmiş Hali</returns>
        [Test]
        [TestCase("34", ExpectedResult = "E5397F14C44F8DF754617194051DAB1AD38F59F08580406C2EFD59AA4C0F71616713C2ABE76BC503E08F2F5EDA4863634F6FE99AD39D46C947C09623B91E53CA")]
        [TestCase("test", ExpectedResult = "EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF")]
        public string HesaplaSHA512Test(string metin)
        {
            return SifrelemeIslemleri.HesaplaSHA512(metin);
        }
        
        /// <summary>
        /// Girilen parolanın gerekli şartları sağlayıp sağlamaması ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>Şifrenin Uygun Olup Olmaması İle İlgili Mesaj Bilgisi</returns>
        [Test]
        [TestCase("1aS_", ExpectedResult = "Parola en az 8 karakter olmalıdır.")]
        [TestCase("56Serdar", ExpectedResult = "Parola en az bir noktalama işareti içermelidir.")]
        [TestCase("54serdar_", ExpectedResult = "Parola en az bir büyük harf içermelidir.")]
        [TestCase("12SERADR_", ExpectedResult = "Parola en az bir küçük harf içermelidir.")]
        [TestCase("SerdarGul_", ExpectedResult = "Parola en az bir rakam içermelidir.")]
        [TestCase("SerdarGul1_", ExpectedResult = "Uygun")]
        public string SifreUygunMuTest(string metin)
        {
            return SifrelemeIslemleri.SifreUygunMu(metin);
        }
    }
}