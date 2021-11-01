using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpHelperMethods.YardimciSiniflar
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
            SHA512Managed sha512 = new SHA512Managed();
            Byte[] encryptedSha512 = sha512.ComputeHash(Encoding.UTF8.GetBytes(text));
            string strHex = "";
            foreach (byte b in encryptedSha512)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex.ToUpper();
        }

        /// <summary>
        /// Kullanıcı şifresinin SHA yöntemiyle şifrelenmesini sağlayan metottur.
        /// </summary>
        /// <param name="text">Şifrelenecek Metin</param>
        /// <returns>Girdi Metninin Şifrelenmiş Hali</returns>
        public static string HesaplaSHA256(string text)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
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
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(text);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            foreach (byte t in hash)
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
        public static List<string> SifreUygunMu(string text)
        {
            //bu kısımda şifrenin olması gereken koşulları değerlendirilecek.
            List<string> mesajlar = new List<string>();

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

            return mesajlar.Count == 0 ? null : mesajlar;
        }

        /// <summary>
        /// 8 karakter uzunluğunda Rastgele şifre oluşturur.
        /// </summary>
        /// <returns></returns>
        public static string RastgeleSifreUret()
        {
            int sifreUzunluk = 8;
            string gecerliKarakterler = "abcdefghijklmnozABCDEFGHIJKLMNOZ1234567890";
            StringBuilder strB = new StringBuilder(100);
            Random random = new Random();
            while (0 < sifreUzunluk--)
            {
                strB.Append(gecerliKarakterler[random.Next(gecerliKarakterler.Length)]);
            }
            return strB.ToString();
        }
    }
}
