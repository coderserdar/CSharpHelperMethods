using System;

namespace CSharpHelperMethods.HelperClasses
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
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dogumTarihi).Ticks).Year - 1;
            DateTime PastYearDate = dogumTarihi.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            return Years;
        }

        /// <summary>  
        /// Yaş hesaplamak için kullanılan metottur
        /// </summary>  
        /// <param name="dogumTarihi">Doğum Tarihi Bilgisi</param>  
        /// <returns>Yaş Bilgisi (Metinsel olarak)</returns>  
        public static string YasHesaplaMetinsel(DateTime dogumTarihi)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dogumTarihi).Ticks).Year - 1;
            DateTime PastYearDate = dogumTarihi.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("Yaş: {0} Yıl {1} Ay {2} Gün",
            Years, Months, Days);
            //return String.Format("Yaş: {0} Yıl {1} Ay {2} Gün {3} Saat {4} Saniye",
            //Years, Months, Days, Hours, Seconds);
        }

        /// <summary>  
        /// İki tarih arasında kaç gün olduğunu hesaplamak için kullanılan metottur
        /// </summary>  
        /// <param name="baslangicTarihi">Başlangıç Tarihi Bilgisi</param> 
        /// <param name="bitisTarihi">Bitiş Tarihi Bilgisi</param>
        /// <returns>Tarih Aralığı Bilgisi</returns>  
        public static string TarihAraligiHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            int Years = new DateTime(bitisTarihi.Subtract(baslangicTarihi).Ticks).Year - 1;
            DateTime PastYearDate = baslangicTarihi.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == bitisTarihi)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= bitisTarihi)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = bitisTarihi.Subtract(PastYearDate.AddMonths(Months)).Days;
            var result = "";
            if (Years < 10)
                result = result + "0" + Years;
            else
                result = result + Years;
            result += " Yıl, ";
            if (Months < 10)
                result = result + "0" + Months;
            else
                result = result + Months;
            result += " Ay, ";
            if (Days < 10)
                result = result + "0" + Days;
            else
                result = result + Days;
            result += " Gün";
            return result;
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
            for (DateTime date = (DateTime)baslangicTarihi; date <= (DateTime)bitisTarihi; date = date.AddDays(1))
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
            if (baslangicTarihi?.Day > bitisTarihi?.Day)
                result--;
            return result;
        }
    }
}
