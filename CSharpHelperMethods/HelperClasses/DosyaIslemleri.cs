using System;

namespace CSharpHelperMethods.HelperClasses
{
    /// <summary>
    /// Dosya işlemleri ile ilgili yardımıcı sınıf
    /// </summary>
    public static class DosyaIslemleri
    {
        /// <summary>
        /// Dosya uzantısından dosyanın türünün ne olduğunu getiren metottur
        /// </summary>
        /// <param name="extension">Dosya Uzantısı</param>
        /// <returns>Dosya Türü Bilgisi</returns>
        public static string GetirIcerikTipiDosyaUzantisiIle(string extension)
        {
            string contentType = String.Empty;
            extension = extension.Replace(".", "").ToLower();
            switch (extension)
            {
                case "pdf": contentType = "application/pdf"; break;
                case "jpeg": contentType = "image/jpeg"; break;
                case "jpg": contentType = "image/jpg"; break;
                case "png": contentType = "image/png"; break;
                case "bmp": contentType = "image/bmp"; break;
                case "doc": contentType = "application/msword"; break;
                case "pptx": contentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation"; break;
                case "xls": contentType = "application/vnd.ms-excel"; break;
                case "txt": contentType = "text/plain"; break;
                case "xlsx": contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"; break;
                case "rtf": contentType = "application/rtf"; break;
                case "docx": contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"; break;
                case "ppt": contentType = "application/vnd.ms-powerpoint"; break;
                case "zip": contentType = "application/zip"; break;
                case "rar": contentType = "application/x-rar-compressed"; break;
                case "7z": contentType = "application/x-7z-compressed"; break;
                default: contentType = "application/octet-stream"; break;
            }

            return contentType;
        }

        /// <summary>
        /// Dosyanın türünden dosyanın uzantısının ne olduğunu getiren metottur
        /// </summary>
        /// <param name="mimeType">Mime Type</param>
        /// <returns>Dosya Türü Bilgisi</returns>
        public static string GetirDosyaUzantisiMimeTypeIle(string mimeType)
        {
            string dosyaUzantisi;
            mimeType = mimeType.ToLower();
            switch (mimeType)
            {
                case "application/pdf": dosyaUzantisi = "pdf"; break;
                case "image/jpeg": dosyaUzantisi = "jpeg"; break;
                case "image/jpg": dosyaUzantisi = "jpg"; break;
                case "image/png": dosyaUzantisi = "png"; break;
                case "image/bmp": dosyaUzantisi = "bmp"; break;
                case "application/msword": dosyaUzantisi = "doc"; break;
                case "application / vnd.openxmlformats - officedocument.presentationml.presentation": dosyaUzantisi = "pptx"; break;
                case "application/vnd.ms-excel": dosyaUzantisi = "xls"; break;
                case "text/plain": dosyaUzantisi = "txt"; break;
                case "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet": dosyaUzantisi = "xlsx"; break;
                case "application/vnd.openxmlformats-officedocument.wordprocessingml.document": dosyaUzantisi = "docx"; break;
                case "text/xml": dosyaUzantisi = "xml"; break;
                case "application/vnd.ms-powerpoint": dosyaUzantisi = "ppt"; break;
                case "application/zip": dosyaUzantisi = "zip"; break;
                case "application/x-rar-compressed": dosyaUzantisi = "rar"; break;
                case "application/x-7z-compressed": dosyaUzantisi = "7z"; break;
                default: dosyaUzantisi = "error"; break;
            }

            return dosyaUzantisi;
        }

        /// <summary>
        /// Sisteme yüklenecek dosyanın belirlenen kriterlere uyup uymadığını kontrol eden metottur.
        /// Dosyanın uzantısı istediğimiz formatta değilse yanlış olarak geri döndürecektir.s
        /// </summary>
        /// <param name="extension">Dosya Uzantısı</param>
        /// <returns>Eklenecek Dosyanın Uygun Olup Olmadığı Bilgisi</returns>
        public static bool DosyaUzantisiUygunMu(string extension)
        {
            extension = extension.ToLower();

            if (extension == ".jpg" || extension == ".bmp" || extension == ".png" || extension == ".doc" || extension == ".docx" || extension == ".ppt" || extension == ".pptx" || extension == ".xls" || extension == ".xlsx" || extension == ".rar" || extension == ".zip" || extension == ".7z" || extension == ".pdf" || extension == ".txt" || extension == ".rtf")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
