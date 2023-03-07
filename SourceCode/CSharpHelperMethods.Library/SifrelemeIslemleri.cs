using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpHelperMethods.Library
{
    /// <summary>
    /// Şifre ile ilgili işlemler sınıfı
    /// </summary>
    public static class SifrelemeIslemleri
    {
        /// <summary>
        /// Kullanıcı şifresinin SHA yöntemiyle şifrelenmesini sağlayan metottur.
        /// </summary>
        /// <param name="text">Şifrelenecek Metin</param>
        /// <returns>Girdi Metninin Şifrelenmiş Hali</returns>
        public static string HesaplaSHA512(string text)
        {
            var sha512 = new SHA512Managed();
            var encryptedSha512 = sha512.ComputeHash(Encoding.UTF8.GetBytes(text));
            var strHex = encryptedSha512.Aggregate("", (current, b) => $"{current}{b:x2}");
            return strHex.ToUpper();
        }

        /// <summary>
        /// Kullanıcı şifresinin SHA yöntemiyle şifrelenmesini sağlayan metottur.
        /// </summary>
        /// <param name="text">Şifrelenecek Metin</param>
        /// <returns>Girdi Metninin Şifrelenmiş Hali</returns>
        public static string HesaplaSHA256(string text)
        {
            var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(text);
            var hash = sha256.ComputeHash(bytes);
            var result = new StringBuilder();
            foreach (var t in hash)
            {
                result.Append(t.ToString("X2"));
            }
            return result.ToString();
        }

        /// <summary>
        /// Kullanıcı şifresinin MD5 yöntemiyle şifrelenmesini sağlayan metottur.
        /// </summary>
        /// <param name="text">Şifrelenecek Metin</param>
        /// <returns>Girdi Metninin Şifrelenmiş Hali</returns>
        public static string HesaplaMD5(string text)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(text);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// şifreyi kriterlere göre kontrol edip
        /// uymayan koşullarını string listesine geri dönüş yapan methoddur.
        /// Uygun olması durumunda null döndürecektir.
        /// </summary>
        /// <param name="text">Kullanıcı Şifresi</param>
        /// <returns>Şifrenin Uygun Olup Olmadığı Bilgisi (Açıklaması ile beraber)</returns>
        public static string SifreUygunMu(string text)
        {
            //bu kısımda şifrenin olması gereken koşulları değerlendirilecek.
            var mesajlar = new List<string>();

            if (text.Length < 8)
                mesajlar.Add("Parola en az 8 karakter olmalıdır.");

            if (!Regex.IsMatch(text, @"^(?=.*[a-z])", RegexOptions.ECMAScript))
                mesajlar.Add("Parola en az bir küçük harf içermelidir.");

            if (!Regex.IsMatch(text, @"^(?=.*[A-Z])", RegexOptions.ECMAScript))
                mesajlar.Add("Parola en az bir büyük harf içermelidir.");

            if (!Regex.IsMatch(text, @"^(?=.*[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)])", RegexOptions.ECMAScript))
                mesajlar.Add("Parola en az bir noktalama işareti içermelidir.");

            if (!Regex.IsMatch(text, @"^(?=.*[0-9])", RegexOptions.ECMAScript))
                mesajlar.Add("Parola en az bir rakam içermelidir.");

            if (mesajlar.Count < 1)
                return "Uygun";
            var sonuc = mesajlar.Aggregate("", (current, item) => current + item + ", ");
            sonuc = sonuc.Substring(0, sonuc.Length - 2);
            return sonuc;
        }

        /// <summary>
        /// 8 karakter uzunluğunda Rastgele şifre oluşturur.
        /// </summary>
        /// <returns>Şifrelenmiş Metin Bilgisi</returns>
        public static string RastgeleSifreUret()
        {
            var sifreUzunluk = 8;
            const string gecerliKarakterler = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890";
            var sifre = new StringBuilder(100);
            var random = new Random();
            while (0 < sifreUzunluk--)
            {
                sifre.Append(gecerliKarakterler[random.Next(gecerliKarakterler.Length)]);
            }
            return sifre.ToString();
        }
    }
}
