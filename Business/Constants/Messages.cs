using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "kategori maksimum 15 olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün bulunmakta";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı yeni ürün eklenemiyor";
    }
   
}
