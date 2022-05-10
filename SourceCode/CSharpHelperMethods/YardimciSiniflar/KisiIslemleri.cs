using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpHelperMethods.YardimciSiniflar
{
    /// <summary>
    /// Kişi ile ilişkili yardımcı metotların tamamını içeren sınıf
    /// </summary>
    public static class KisiIslemleri
    {
        /// <summary>
        /// Girilen TC Kimlik Numarasının, standart TC Kimlik No algoritmasına uygun olup
        /// olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="tcKimlikNo">TC Kimlik No</param>
        /// <returns>TC Kimlik No'nun Uygun Olup Olmadığı Bilgisi</returns>
        public static bool DogrulaTcKimlikNo(string tcKimlikNo)
        {
            var tcNo = Convert.ToInt64(tcKimlikNo);
            var atcno = tcNo / 100;
            var btcno = tcNo / 100;
            var c1 = atcno % 10; atcno /= 10;
            var c2 = atcno % 10; atcno /= 10;
            var c3 = atcno % 10; atcno /= 10;
            var c4 = atcno % 10; atcno /= 10;
            var c5 = atcno % 10; atcno /= 10;
            var c6 = atcno % 10; atcno /= 10;
            var c7 = atcno % 10; atcno /= 10;
            var c8 = atcno % 10; atcno /= 10;
            var c9 = atcno % 10;
            var q1 = (10 - ((c1 + c3 + c5 + c7 + c9) * 3 + c2 + c4 + c6 + c8) % 10) % 10;
            var q2 = (10 - ((c2 + c4 + c6 + c8 + q1) * 3 + c1 + c3 + c5 + c7 + c9) % 10) % 10;
            var dogrula = btcno * 100 + q1 * 10 + q2 == tcNo;
            return dogrula;
        }

        /// <summary>
        /// Girilen IBAN'ın standar IBAN algoritmasına uygun olup olmadığını doğrular
        /// </summary>
        /// <code>DogrulaIBAN("TR560006200000012990022604")</code>
        /// <param name="iban">Uluslar arası banka hesap numarası (IBAN) </param>
        /// <returns>IBAN uygunsa true, değilse false değeri döner</returns>
        public static bool DogrulaIBAN(string iban)
        {
            iban = iban.ToUpper();

            if (string.IsNullOrEmpty(iban))
                return false;

            if (!Regex.IsMatch(iban, "^[A-Z0-9]"))
                return false;

            iban = iban.Replace(" ", String.Empty);
            var bank = iban.Substring(4, iban.Length - 4) + iban.Substring(0, 4);
            const int asciiShift = 55;
            var sb = new StringBuilder();
            foreach (var c in bank)
            {
                sb.Append(char.IsLetter(c) ? c - asciiShift : int.Parse(c.ToString()));
            }

            var checkSumString = sb.ToString();
            var checksum = int.Parse(checkSumString.Substring(0, 1));
            for (var i = 1; i < checkSumString.Length; i++)
            {
                var v = int.Parse(checkSumString.Substring(i, 1));
                checksum *= 10;
                checksum += v;
                checksum %= 97;
            }
            return checksum == 1;
        }

        /// <summary>
        /// Ekranlardan girilen bir e-posta adresinin geçerli bir e-posta adresi olup olmadığını
        /// Kontrol eden metottur
        /// </summary>
        /// <param name="ePosta">E-Posta Adresi</param>
        /// <returns>E-Posta Adresinin Geçerli Olup Olmadığı Bilgisi</returns>
        public static bool DogrulaEPosta(string ePosta)
        {
            const string pattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                   + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                   + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                   + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
            return Regex.IsMatch(ePosta, pattern);
        }
    }
}
