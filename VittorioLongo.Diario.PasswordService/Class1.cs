using System;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

namespace VittorioLongo.Diario.PasswordService
{
    public static class PasswordService
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerificaPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
