using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace CSharpHelperMethodsLibrary
{
    /// <summary>
    /// Raporlama için lazım olan DataTable vb. verilerin düzenlenmesini sağlayan sınıflardır.
    /// </summary>
    public static class DataTableIslemleri
    {
        /// <summary>
        /// Parametre olarak girilen herhangi bir sınıf türünden listeyi
        /// İdael bir şekilde Nullable alan içermeyen bir DataTable'a çevirmek için kullanılan metottur.
        /// </summary>
        /// <typeparam name="T">Generic Nesne Tipi</typeparam>
        /// <param name="liste">Liste Bilgisi</param>
        /// <returns>DataTable cinsinde Nesne</returns>
        public static DataTable ToDataTable<T>(List<T> liste)
        {
            try
            {
                var sonuc = new DataTable(typeof(T).Name);

                var ozellikler = typeof(T).GetFields(BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreReturn | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.OptionalParamBinding | BindingFlags.SuppressChangeType);

                var ozellikler2 = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.CreateInstance | BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.ExactBinding | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreReturn | BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.OptionalParamBinding | BindingFlags.SuppressChangeType);

                foreach (var ozellik in ozellikler)
                {
                    var varMi = false;
                    foreach (var ozellik2 in ozellikler2)
                    {
                        if (!ozellik.Name.Contains(ozellik2.Name)) continue;
                        varMi = true;
                        var ozellikAdi = ozellik.Name.Replace("<", "");
                        var ozellikDizi = ozellikAdi.Split('>');
                        var ozellikTemp = ozellikDizi[0].Trim();
                        //ozellikTemp = ozellikTemp.Substring(0, ozellikTemp.Length - 1);
                        if (ozellikTemp == ozellik2.Name)
                        {
                            if (sonuc.Columns.IndexOf(new DataColumn(ozellik2.Name)) >= 0) continue;
                            sonuc.Columns.Add(ozellik2.Name, BaseType(ozellik2.PropertyType));
                            break;
                        }

                        if (sonuc.Columns.IndexOf(new DataColumn(ozellikTemp)) >= 0) continue;
                        sonuc.Columns.Add(ozellikTemp, BaseType(ozellik2.PropertyType));
                        break;
                    }

                    if (varMi) continue;
                    if (sonuc.Columns.IndexOf(new DataColumn(ozellik.Name)) < 0)
                    {
                        sonuc.Columns.Add(ozellik.Name, BaseType(ozellik.FieldType));
                    }

                }

                foreach (var nesne in liste)
                {
                    var degerler = new object[ozellikler.Length];

                    for (var i = 0; i < ozellikler.Length; i++)
                    {
                        var varMi = false;
                        foreach (var item in ozellikler2)
                        {
                            if (!ozellikler[i].Name.Contains(item.Name)) continue;
                            varMi = true;
                            degerler[i] = item.GetValue(nesne, null);
                            break;
                        }
                        if (!varMi)
                        {
                            degerler[i] = ozellikler[i].GetValue(nesne);
                        }

                    }

                    sonuc.Rows.Add(degerler);
                }

                return sonuc;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Nesnenin içindeki her hangi bir değerin (DateTime, decimal vb.)
        /// Eğer Nullable ise, Nullable olmamasını sağlayan metottur
        /// (Çünkü Crystal Report, Telerik vb. Nullable alan kabul etmiyor)
        /// </summary>
        /// <param name="oType">Veri Tipi</param>
        /// <returns>Verinin İdeal Tipi</returns>
        private static Type BaseType(Type oType) => oType != null && oType.IsValueType && oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(oType) : oType;
    }
}
