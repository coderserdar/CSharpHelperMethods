using System;
using System.Text;

namespace CSharpHelperMethods.YardimciSiniflar
{
    /// <summary>
    /// Tarihsel veri kontrol metotlarını barındıran sınıf
    /// </summary>
    public static class TarihIslemleri
    {
        /// <summary>
        /// Filtre ekranlarında başlangıç ve bitiş tarihi üzerinden sorgulama yapıldığında
        /// Eğer aynı gün için sorgulama yapılıyorsa
        /// Bitiş tarihini o günün 23.59.59.999'una ayarlamak için
        /// Hazırlanan metottur
        /// </summary>
        /// <param name="dateTime">Tarih Bilgisi</param>
        /// <param name="hours">Saat Bilgisi</param>
        /// <param name="minutes">Dakika Bilgisi</param>
        /// <param name="seconds">Saniye Bilgisi</param>
        /// <param name="milliseconds">Mili Saniye Bilgisi</param>
        /// <returns>Yeni Tarih Bilgisi</returns>
        public static DateTime ZamaniDegistir(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }

        /// <summary>  
        /// Yaş hesaplamak için kullanılan metottur
        /// </summary>  
        /// <param name="dogumTarihi">Doğum Tarihi Bilgisi</param>  
        /// <returns>Yaş Bilgisi</returns>  
        public static int YasHesapla(DateTime dogumTarihi)
        {
            var now = DateTime.Now;
            var years = new DateTime(DateTime.Now.Subtract(dogumTarihi).Ticks).Year - 1;
            var pastYearDate = dogumTarihi.AddYears(years);
            for (var i = 1; i <= 12; i++)
            {
                if (pastYearDate.AddMonths(i) == now)
                    break;
                if (pastYearDate.AddMonths(i) < now) continue;
                break;
            }
            return years;
        }

        /// <summary>  
        /// Yaş hesaplamak için kullanılan metottur
        /// </summary>  
        /// <param name="dogumTarihi">Doğum Tarihi Bilgisi</param>  
        /// <returns>Yaş Bilgisi (Metinsel olarak)</returns>  
        public static string YasHesaplaMetinsel(DateTime dogumTarihi)
        {
            var now = DateTime.Now;
            var years = new DateTime(DateTime.Now.Subtract(dogumTarihi).Ticks).Year - 1;
            var pastYearDate = dogumTarihi.AddYears(years);
            var months = 0;
            for (var i = 1; i <= 12; i++)
            {
                if (pastYearDate.AddMonths(i) == now)
                {
                    months = i;
                    break;
                }

                if (pastYearDate.AddMonths(i) < now) continue;
                months = i - 1;
                break;
            }
            var days = now.Subtract(pastYearDate.AddMonths(months)).Days;
            // var hours = now.Subtract(pastYearDate).Hours;
            // var minutes = now.Subtract(pastYearDate).Minutes;
            // var seconds = now.Subtract(pastYearDate).Seconds;
            return $"Yaş: {years} Yıl {months} Ay {days} Gün";
            //return String.Format("Yaş: {0} Yıl {1} Ay {2} Gün {3} Saat {4} Saniye",
            //years, months, Days, Hours, Seconds);
        }

        /// <summary>  
        /// İki tarih arasında kaç gün olduğunu hesaplamak için kullanılan metottur
        /// </summary>  
        /// <param name="baslangicTarihi">Başlangıç Tarihi Bilgisi</param> 
        /// <param name="bitisTarihi">Bitiş Tarihi Bilgisi</param>
        /// <returns>Tarih Aralığı Bilgisi</returns>  
        public static string TarihAraligiHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            var years = new DateTime(bitisTarihi.Subtract(baslangicTarihi).Ticks).Year - 1;
            var pastYearDate = baslangicTarihi.AddYears(years);
            var months = 0;
            for (var i = 1; i <= 12; i++)
            {
                if (pastYearDate.AddMonths(i) == bitisTarihi)
                {
                    months = i;
                    break;
                }

                if (pastYearDate.AddMonths(i) < bitisTarihi) continue;
                months = i - 1;
                break;
            }
            var days = bitisTarihi.Subtract(pastYearDate.AddMonths(months)).Days;
            var result = new StringBuilder();
            result.Append(years.ToString().PadLeft(2, '0'));
            result.Append(" Yıl, ");
            result.Append(months.ToString().PadLeft(2, '0'));
            result.Append(" Ay, ");
            result.Append(days.ToString().PadLeft(2, '0'));
            result.Append(" Gün");
            return result.ToString();
        }

        /// <summary>  
        /// Kıdem Tazminatı Hesaplaması Yapılırken ayda kaç gün olursa olsun tamamında çalışmışsa
        /// 30 gün üzerinden hesaplanması gerektiği için
        /// İşten ayrılış ve iş başlangıç tarihleri arasında kaç gün geçtiğini belirtmek için
        /// Hesaplama yapılmasını sağlayan metottur.
        /// </summary>  
        /// <param name="baslangicTarihi">Başlangıç Tarihi Bilgisi</param> 
        /// <param name="bitisTarihi">Bitiş Tarihi Bilgisi</param>
        /// <returns>Gün Sayısı Bilgisi</returns>  
        public static int KidemTazminatiTarihAraligiHesapla(DateTime? baslangicTarihi, DateTime? bitisTarihi)
        {
            var artacakMi = true;
            var result = 0;
            var baslangicMi = false;
            var bitisMi = false;
            var aylikGunSayisi = 0;
            for (var date = (DateTime)baslangicTarihi; date <= (DateTime)bitisTarihi; date = date.AddDays(1))
            {
                if (!artacakMi)
                    result++;
                else
                    artacakMi = false;

                if (date.Day == 1)
                    baslangicMi = true;
                else if (date.Day == DateTime.DaysInMonth(date.Year, date.Month))
                    bitisMi = true;

                if (baslangicMi)
                    aylikGunSayisi++;
                if (baslangicMi && bitisMi && aylikGunSayisi != 30)
                {
                    result = result - aylikGunSayisi + 30;
                    baslangicMi = false;
                    bitisMi = false;
                    aylikGunSayisi = 0;
                }
                else if (bitisMi)
                {
                    baslangicMi = false;
                    bitisMi = false;
                    aylikGunSayisi = 0;
                }

            }
            if (baslangicTarihi.Value.Day > bitisTarihi.Value.Day)
                result--;
            return result;
        }

        /// <summary>
        /// Girilen iki tarih arasında kaç ay olduğunu bulan metottur
        /// </summary>
        /// <param name="lValue">İlk tarih bilgisi</param>
        /// <param name="rValue">Son tarih bilgisi</param>
        /// <returns>Ay Farkı Bilgisi</returns>
        public static int AyFarki(DateTime lValue, DateTime rValue) => Math.Abs(lValue.Month - rValue.Month + 12 * (lValue.Year - rValue.Year));
    }
}