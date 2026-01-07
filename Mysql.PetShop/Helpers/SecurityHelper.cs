using System.Security.Cryptography;
using System.Text;

namespace PetShopAPI.Helpers
{
    public static class SecurityHelper
    {
        // Chaves de configuração (em produção, use variáveis de ambiente)
        private static readonly string Key = "E#sT@cio$Sen@i%Pr0j3t0PetSh0p2026";
        private static readonly string Iv = "VetorDeInic12345";

        // O método Encrypt deve ser público e estático
        public static string Encrypt(string plainText)
        {
            // Se o texto for nulo ou vazio, retorna string vazia para não dar erro
            if (string.IsNullOrEmpty(plainText)) return "";

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = Encoding.UTF8.GetBytes(Iv);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText)) return "";

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = Encoding.UTF8.GetBytes(Iv);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] encryptedBytes = Convert.FromBase64String(cipherText);
                byte[] plainBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(plainBytes);
            }
        }
    }
}