using System.Collections.Generic;

namespace CSharpHelperMethods.UI
{
    /// <summary>
    /// Burada kod içerisinde gerekli olabilecek bazı dictionary, list gibi sabitlerin tutulduğu
    /// Bir sınıftır
    /// </summary>
    public class OnemliBilgiler
    {
        /// <summary>
        /// Panel adları ve kodları
        /// Burada beraber tutularak
        /// Combobox'ta yapılan değişikliğe göre
        /// İlgili panelin açılabilmesi için gerekli bilgilerin tutulduğu Dictionary'dir.
        /// </summary>
        public static Dictionary<int, string> PanelListesi = new Dictionary<int, string>
        {
            {0, "pnlMetinIslemleri"},
            {1, "pnlTarihIslemleri"},
            {2, "pnlSayiIslemleri"},
            {3, "pnlSifreIslemleri"},
            {4, "pnlKisiIslemleri"},
            {5, "Hicbiri"}
        };
    }
}