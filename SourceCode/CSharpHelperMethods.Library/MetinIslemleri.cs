using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpHelperMethods.Library
{
    /// <summary>
    /// Metinsel veri kontrol metotlarını barındıran sınıf
    /// </summary>
    public static class MetinIslemleri
    {
        /// <summary>
        /// Girilen metnin başında virgül olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Olması Gerektiği Hali</returns>
        public static string IdealMetinGetir(string text)
        {
            if (!string.IsNullOrEmpty(text) && text[0] == ',')
            {
                text = text.Substring(1, text.Length - 1);
            }
            return text;
        }

        public static string MetinZararliKarakterDuzelt(string text)
        {
            text = text.Replace("&#252;", "ü");
            return text;
        }

        public static string MetinSifrele(string metin)
        {
            if (string.IsNullOrEmpty(metin)) return metin;
            var metinDuzenleyici = new StringBuilder(metin);
            switch (metin.Length)
            {
                case 10:
                    metinDuzenleyici.Remove(2, 6);
                    metinDuzenleyici.Insert(2, "******");
                    metin = metinDuzenleyici.ToString();
                    break;
                case 11:
                    metinDuzenleyici.Remove(2, 7);
                    metinDuzenleyici.Insert(2, "*******");
                    metin = metinDuzenleyici.ToString();
                    break;
            }
            return metin;
        }

        /// <summary>
        /// Girilen metnin başında virgül olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Olması Gerektiği Hali</returns>
        public static string TurkceKarakterleriDuzelt(string text)
        {
            text = text.Replace("ü", "u");
            text = text.Replace("ı", "i");
            text = text.Replace("ö", "o");
            text = text.Replace("ü", "u");
            text = text.Replace("ş", "s");
            text = text.Replace("ğ", "g");
            text = text.Replace("ç", "c");
            text = text.Replace("Ü", "U");
            text = text.Replace("İ", "I");
            text = text.Replace("Ö", "O");
            text = text.Replace("Ü", "U");
            text = text.Replace("Ş", "S");
            text = text.Replace("Ğ", "G");
            text = text.Replace("Ç", "C");
            return text;
        }

        /// <summary>
        /// Girilen metnin başında virgül olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Olması Gerektiği Hali</returns>
        public static string UTF8Duzelt(string text)
        {
            text = text.Replace("&amp;ccedil;", "ç");
            text = text.Replace("&amp;ouml;", "ö");
            text = text.Replace("&amp;uuml;", "ü");
            text = text.Replace("&ccedil;", "ç");
            text = text.Replace("&ouml;", "ö");
            text = text.Replace("&uuml;", "ü");
            return text;
        }

        /// <summary>
        /// Girilen metnin başında virgül olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Olması Gerektiği Hali</returns>
        public static string HTMLDuzelt(string text)
        {
            var sc = new List<string>
            {
                // get rid of unnecessary tag spans (comments and title)
                @"<!--(\w|\W)+?-->",
                @"<title>(\w|\W)+?</title>",
                // Get rid of classes and styles
                @"\s?class=\w+",
                @"\s+style='[^']+'",
                // Get rid of unnecessary tags
                @"<(meta|link|/?o:|/?style|/?div|/?st\d|/?head|/?html|body|/?body|/?span|!\[)[^>]*?>",
                // Get rid of empty paragraph tags
                @"(<[^>]+>)+&nbsp;(</\w+>)+",
                @"<a[^>]*>([^<]+)</a>",
                @"<p[^>]*>([^<]+)</p>",
                // remove bizarre v: element attached to <img> tag
                @"\s+v:\w+=""[^""]+""",
                // remove extra lines
                @"(\n\r){2,}",
                "&nbsp;"
            };
            text = sc.Aggregate(text, (current, s) => Regex.Replace(current, s, string.Empty, RegexOptions.IgnoreCase));
            text = Regex.Replace(text, "<.*?>", String.Empty);
            text = text.Replace("\r", " ").Replace("\n", " ").Replace("  ", " ").Trim();
            text = text.Replace("&rsquo;", "'");
            text = text.Replace("rsquo;", "'");
            text = text.Replace("&rdquo;", "\"");
            text = text.Replace("rdquo;", "\"");

            text = text.Replace("&lsquo;", "'");
            text = text.Replace("lsquo;", "'");
            text = text.Replace("&ldquo;", "\"");
            text = text.Replace("ldquo;", "\"");

            text = text.Replace("&lt;", "<");
            text = text.Replace("&gt;", ">");
            text = text.Replace("&amp;", "&");
            //text = text.Replace("&lt;", "");
            //text = text.Replace("p&gt;", "");
            //text = text.Replace("/p&gt;", "");
            //text = text.Replace("&gt;", "");
            //return text;
            return text;
        }

        public static string MetinIlkKarakterBuyukDigerleriKucukYap(string text) => text.First().ToString().ToUpper() + text.Substring(1);

        /// <summary>
        /// Girilen bir metindeki tüm kelimelerin ilk harflerinin
        /// Büyük yapılması için hazırlanan metottur
        /// </summary>
        /// <param name="input">Girilen metin</param>
        /// <returns>Metnin Kelimelerinin İlk Harflerinin Büyültülmüş Hali</returns>
        public static string MetinIlkKarakterleriBuyukYap(this string input)
        {
            var metinDuzenleyici = new StringBuilder();
            var wordList = input.Split(' ');
            var cultureInfo = new CultureInfo("tr-TR");
            foreach (var item in wordList)
            {
                if (item.Length > 1)
                {
                    metinDuzenleyici.Append(item.Substring(0, 1).ToUpper(cultureInfo));
                    metinDuzenleyici.Append(item.Substring(1).ToLower(cultureInfo));
                    metinDuzenleyici.Append(" ");
                }
                else if (item.Length == 1)
                {
                    metinDuzenleyici.Append(item.ToUpper(cultureInfo));
                    metinDuzenleyici.Append(" ");
                }
            }
            return metinDuzenleyici.ToString();
        }

        /// <summary>
        /// Telefon No, E-Posta Adresi vb. metinsel veriler içerisindeki
        /// Boşluk, parantez, kısa çizgi gibi verilerin silinmesi için hazırlanmış metottur
        /// </summary>
        /// <param name="metin">Girdi Metin Bilgisi</param>
        /// <returns>Çıktı Metin Bilgisi</returns>
        private static string GereksizKarakterTemizle(string metin)
        {
            return metin.Replace("-", "").Replace(" ", "").Replace("(", "").Replace(")", "");
        }

        /// <summary>
        /// Girilen telefon numarasının SMS gönderilecek hale getirilmesini sağlayan metottur.
        /// </summary>
        /// <param name="telefonNo">Telefon No Bilgisi</param>
        /// <returns>Girilen Telefon Numarasının SMS Gönderilecek Hali</returns>
        public static string TelefonNoDuzenle(string telefonNo)
        {
            if (string.IsNullOrEmpty(telefonNo)) return string.Empty;
            telefonNo = GereksizKarakterTemizle(telefonNo);
            if (telefonNo.Length == 11)
            {
                telefonNo = telefonNo.Substring(telefonNo.Length - 10);
            }
            return telefonNo;

        }

        /// <summary>
        /// Girilen metnin boşluklarının kaldırılmasını sağlayan metottur.
        /// </summary>
        /// <param name="metin">Telefon No Bilgisi</param>
        /// <returns>Girilen Metnin İstenen Hali</returns>
        public static string BoslukKaldir(string metin)
        {
            if (string.IsNullOrEmpty(metin)) return string.Empty;
            metin = GereksizKarakterTemizle(metin);
            return metin;
        }
        
        /// <summary>
        /// Girilen mail adresinin geçerli olup olmadığını kontrol eden bir metottur
        /// </summary>
        /// <param name="email">E-Posta Adresi</param>
        /// <returns>Geçerli veya Değil Bilgisi</returns>
        public static bool MailAdresiGecerliMi(string email)
        {
            var gecerliMi = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                gecerliMi = false;
            }
            return gecerliMi;
        }
    }
}
