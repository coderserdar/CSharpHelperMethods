﻿using CSharpHelperMethods.Library;
using NUnit.Framework;

namespace CSharpHelperMethods.Test
{
    /// <summary>
    /// Library kısmında Kişi İşlemleri bölümünde
    /// Yer alan metotların örnek test durumları ve beklenen sonuçları ile
    /// Test edildikleri sınıftır
    /// </summary>
    [TestFixture]
    public class KisiIslemleriTest
    {
        /// <summary>
        /// TC Kimlik No Doğrulaması ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>TC Kimlik Algoritmasına Uygun Olup Olmadığı Bilgisi</returns>
        [Test]
        [TestCase("18085082002", ExpectedResult = true)]
        [TestCase("20135404436", ExpectedResult = true)]
        [TestCase("18085082001", ExpectedResult = false)]
        [TestCase("20135404435", ExpectedResult = false)]
        public bool DogrulaTcKimlikNoTest(string metin)
        {
            return KisiIslemleri.DogrulaTcKimlikNo(metin);
        }
        
        /// <summary>
        /// IBAN No Doğrulaması ile ilgili test metodudur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>IBAN No Algoritmasına Uygun Olup Olmadığı</returns>
        [Test]
        [TestCase("TR49 0011 1000 0000 0083 8470 08", ExpectedResult = true)]
        [TestCase("TR53 0011 1000 0000 0083 8467 42", ExpectedResult = true)]
        [TestCase("TR76 0011 3333 1111 0083 4867 66", ExpectedResult = false)]
        [TestCase("TR76 0911 3333 1121 0093 9999 16", ExpectedResult = false)]
        public bool DogrulaIBANTest(string metin)
        {
            return KisiIslemleri.DogrulaIBAN(metin);
        }
        
        /// <summary>
        /// E-Posta adresinin geçerli olup olmadığına dair test metodurur
        /// </summary>
        /// <param name="metin">Girdi Metni</param>
        /// <returns>E-Posta Adresinin Geçerli Olup Olmadığı Bilgisi</returns>
        [Test]
        [TestCase("serdargul@outlook.com", ExpectedResult = true)]
        [TestCase("fuchserdar@gmail.com", ExpectedResult = true)]
        [TestCase("serdar@aol", ExpectedResult = false)]
        [TestCase("ahmet_sk", ExpectedResult = false)]
        public bool DogrulaEPostaTest(string metin)
        {
            return KisiIslemleri.DogrulaEPosta(metin);
        }
    }
}