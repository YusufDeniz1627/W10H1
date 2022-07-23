using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed="Araçlar Listelendi";
        public static string CarColorIdListed="Araçlar Renk Sırasına Göre Listelendi";
        public static string CarDeleted="Araç Silinmiştir";
        public static string CarUpdated="Araç Güncellenmiştir";
        //Brand
        public static string BrandNameInvalid="Marka İsmi Geçersiz";
        public static string BrandListed="Markalar Listelendi";
        //Color
        public static string ColorNameInvalid="Renk İsmi Geçersiz";
        internal static string ColorListed="Renkler Listelendi";
    }
}
