using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // Program içerisinde gösterilecek sabit mesajların depolandığı sınıf 
    // Her kullanışımızda new() 'lememek için static tanımlama yaptık
    // Burayı oluşturmamızın nedeni toplu değişiklik yapıldığı tek bir yerden hepsini değiştirebilmek .
    public static class Messages
    {
        public static string SuccessRegisteredUser  = "Kayıt işlemi başarılı şekilde gerçekleşti.";
        public static string FailedRegisteredUser  = "Kayıt işlemi başarısız";
        public static string FailedRegisteredUser1  = "Kullanıcı kayıt işlemi başarısız.";

        public static string AddedProduct = "Ürün ekleme başarılı .6 saat içerisinde onaylanacaktır.";
        public static string UpdatedProduct = "Ürün güncelleme başarılı.";
        public static string AddedBalance = "Bakiye ekleme başarılı.6 saat içerisinde onaylanacaktır.";
        public static string BuyedProduct = "Ürün Alımı Başarıyla gerçekleştirilmiştir.";


        public static string approvedProduct = "Ürün başarılı bir şekilde onaylanmıştır.";
        public static string approvedBalance = "Bakiye başarılı bir şekilde onaylanmıştır.";

        public static string SuccessedSale = "Satın Alım Başarılı bir şekilde gerçekleşti";
        public static string SuccessedGetOrder = "\nAlım emri başarıyla alındı.";

        public static string FailedSale = "Satın Alım Başarısız .";

        public static string InsufficientDemandPrice = "Geçersiz Alım Fiyatı";
        public static string InsufficientBalance = "\nYetersiz Bakiye";
        public static string InsufficientStock = "\nYetersiz ürün stoğu";

    }
}
