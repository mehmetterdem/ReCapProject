using CoreLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constant
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductListed = "Listelendi";
        public static string ProductError = "Beklenmedik hata";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerListed = "Müşteriler Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";
        public static string RentalAdd = "Araç kiralandı";
        public static string RentalAddError = "Araç teslim edilmemiş";
        public static string RentalListed = "Kiralama Listelendi";
        public static string RentalUpdated = "Kiralama Güncellendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string CarImageAdded = "Arac Fotoğrafı Eklendi";
        public static string ImageDeleted = "Fotoğraf Silindi";
        public static string CarImagesListed = "Fotoğraflar Listelendi";
        public static string ImageUpdated = "Fotoğraf Güncellendi";
        public static string AuthorizationDenied="";
        public static string UserRegistered="Kullanıcı kaydedildi";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Hatalı";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="Kullanıcı Zaten Mevcut";
        public static string AccessTokenCreated="Access Token Created";
    }
}
