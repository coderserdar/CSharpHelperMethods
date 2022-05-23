using System;
using System.Text;

namespace CSharpHelperMethods.YardimciSiniflar
{
    /// <summary>
    /// Metin Sabitlerinin Bulunduğu Sınıf
    /// </summary>
    public static class Sabitler
    {
        public static string BaslangicTarihiGirilmedi = "Başlangıç Tarihi girilmediği için bu işlem gerçekleştirilemez.";
        public static string BitisTarihiGirilmedi = "Bitiş Tarihi girilmediği için bu işlem gerçekleştirilemez.";
        public static string BaslangicVeyaBitisTarihiGirilmedi = "Başlangıç Tarihi veya Bitiş Tarihi girilmediği için bu işlem gerçekleştirilemez.";
        public static string BaslangicTarihiBuyuk = "Başlangıç Tarihi Bitiş Tarihinden büyük olamaz.";
        public static string SifrelenecekMetinGirilmedi = "Şifrelenecek metin girilmediği için bu işlem gerçekleştirilemez.";
        public static string SifreMetniGirilmedi = "Şifre metni girilmediği için bu işlem gerçekleştirilemez.";
        public static string MetinGirilmedi = "Metin girilmediği için bu işlem gerçekleştirilemez.";
        public static string MetinSayisalDegil = "Girilen metin sayısal bir değer olmadığı için bu işlem gerçekleştirilemez.";
        public static string MetinTcKimlikNoDegil = "Girilen metin 11 karakter olmadığı için bu işlem gerçekleştirilemez. Karakter Sayısı: ";
        public static string MetinIbanNoDegil = "Girilen metin 26 karakter olmadığı için bu işlem gerçekleştirilemez.";
        public static string MetinTcKimlikNoVeyaVergiNoDegil = "Girilen metin 10 veya 11 karakter olmadığı için bu işlem gerçekleştirilemez.";
    }
}