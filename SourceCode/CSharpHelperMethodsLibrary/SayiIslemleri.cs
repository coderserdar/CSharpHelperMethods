using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CSharpHelperMethodsLibrary
{
    /// <summary>
    /// Sayısal veri kontrol metotlarını barındıran sınıf
    /// </summary>
    public static class SayiIslemleri
    {
        /// <summary>
        /// Girilen bir metnin sayı olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Sayısal Olup Olmadığı Bilgisi</returns>
        public static bool SayisalMi(string text) => text.All(char.IsNumber);

        /// <summary>
        /// Ekrandan alınan string değerde virgül olduğundan ajax metodu patladığı için
        /// Burada string olarak tutar verisi alınıyor
        /// Ve decimala çevriliyor
        /// </summary>
        /// <param name="metin">Girilen String Değer</param>
        /// <returns>Decimal Değer</returns>
        public static decimal SayiHalineCevir(string metin)
        {
            decimal val;
            if (metin.Contains("_") || metin.Contains(".") || metin.Contains("."))
            {
                if (!decimal.TryParse(metin.Replace(",", "").Replace(".", "").Replace("_", ""), NumberStyles.Number,
                        CultureInfo.InvariantCulture, out val))
                    return 0;
                return val / 100;
            }

            var value = decimal.TryParse(metin.Replace(",", "").Replace(".", "").Replace("_", ""), NumberStyles.Number,
                CultureInfo.InvariantCulture, out val);
            return value ? val : 0;
        }

        /// <summary>
        /// Elimizdeki tutar verilerinin
        /// Yazı formatında gösterilmesini sağlayacak bir metottur
        /// </summary>
        /// <param name="tutar">Girilen Sayı Bilgisi</param>
        /// <returns>Sayının Yazıya Dönüştürülmüş Hali</returns>
        public static string SayiyiYaziyaCevir(decimal tutar)
        {
            var sTutar = tutar.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            var lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            var kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            var yazi = new StringBuilder();

            var birler = new[] {"", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ"};
            var onlar = new[] {"", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN"};
            var binler = new[] {"KENTRİLYON", "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", ""};

            const int grupSayisi = 7;
            //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
            //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.          

            for (var i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                var grupDegeri = new StringBuilder();

                if (lira.Substring(i, 1) != "0")
                    grupDegeri.Append(birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"); //yüzler       
                if (grupDegeri.ToString().Equals("BİRYÜZ"))
                    grupDegeri.Replace("BİRYÜZ", "YÜZ");
                grupDegeri.Append(onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]); //onlar
                grupDegeri.Append(birler[Convert.ToInt32(lira.Substring(i + 2, 1))]);//birler                
                if (grupDegeri.Length > 0) //binler
                    grupDegeri.Append(binler[i / 3]);
                if (grupDegeri.ToString().Equals("BİRBİN"))
                    grupDegeri.Replace("BİRBİN", "BİN");

                yazi.Append(grupDegeri);
            }

            if (yazi.Length > 0)
                yazi.Append(" TL ");

            var yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi.Append(onlar[Convert.ToInt32(kurus.Substring(0, 1))]);

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi.Append(birler[Convert.ToInt32(kurus.Substring(1, 1))]);

            yazi.Append(yazi.Length > yaziUzunlugu ? " KR." : "SIFIR KR.");

            return yazi.ToString();
        }

        /// <summary>
        /// Sadece rakamlardan oluşan 6 haneli random sayı üreten metottur.
        /// </summary>
        /// <returns>6 Haneli Onay Kodu</returns>
        public static string AltiHaneliOnayKoduOlustur()
        {
            var rastgele = new Random();
            var sb = new StringBuilder();
            for (var i = 0; i < 6; i++)
            {
                var ascii = rastgele.Next(48, 57); //Rakamlar
                var karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }

            return sb.ToString();
        }
    }
}