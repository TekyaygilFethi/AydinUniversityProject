using System.Web.Helpers;

namespace AydinUniversityProject.Business.SecurityFolder
{
    public static class Security
    {
        public static string GetEncryptedPassword(string password)//şifreyi hashle döndür
        {
            return Crypto.HashPassword(password);
        }

        public static bool VerifyPassword(string actualPassword, string userEnteredPassword) //haslenmiş şifre ile kullanıcı girişli şifre kontrol ediliyor.
        {
            return Crypto.VerifyHashedPassword(actualPassword, userEnteredPassword);
        }

    }
}
