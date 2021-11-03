﻿using System;
using System.Linq;
using System.Text;

namespace CSharpHelperMethods.YardimciSiniflar
{
    /// <summary>
    /// Sayısal veri kontrol metotlarını barındıran sınıf
    /// </summary>
    public static class SayisalVeriKontrol
    {
        /// <summary>
        /// Girilen bir metnin sayı olup olmadığını kontrol eden metottur.
        /// </summary>
        /// <param name="text">Girdi metni</param>
        /// <returns>Girilen Metnin Sayısal Olup Olmadığı Bilgisi</returns>
        public static bool SayisalMi(string text) => text.All(char.IsNumber);

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
            var yazi = "";

            string[] birler = { "", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            var grupSayisi = 6;
            //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
            //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.          

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                var grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";

            return yazi;
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
                var ascii = rastgele.Next(48, 57);//Rakamlar
                var karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            return sb.ToString();
        }
    }
}
