using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace COMBINE_CHECKLIST_2024.SQLFolder
{
    class savecacheHandler
    {
        private static readonly byte[] key = Encoding.UTF8.GetBytes("MySecretKey12345");  // 16 bytes
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("MySecretIV123456");   // 16 bytes

        private readonly string folderPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "machinehistory_cache");
        private readonly string filePath;

        public string Password => LoadCacheValue("_password");
        public string User => LoadCacheValue("_user");
        public string Theme => LoadCacheValue("_theme");
        public string ConnectionString => LoadCacheValue("_connection_string");

        public savecacheHandler()
        {
            filePath = Path.Combine(folderPath, "cache.json");

            EnsureFolderExists();
            if (!File.Exists(filePath))
            {
                SaveCache("standard", "none", "", "");
            }

        }

        private void EnsureFolderExists()
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        private void SaveCache(string theme, string connectionString, string user, string password)
        {
            var data = new Dictionary<string, string>
            {
                { "_theme", theme },
                { "_connection_string", connectionString },
                { "_user", user },
                { "_password", password }
            };

            string json = JsonSerializer.Serialize(data);
            byte[] encrypted = EncryptStringToBytes_Aes(json, key, iv);
            File.WriteAllBytes(filePath, encrypted);
        }
        public void EditUser(string newUser)
        {
            if (!File.Exists(filePath))
                return;

            string decrypted = DecryptStringFromBytes_Aes(File.ReadAllBytes(filePath), key, iv);
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(decrypted);

            data["_user"] = newUser;

            string updatedJson = JsonSerializer.Serialize(data);
            byte[] encrypted = EncryptStringToBytes_Aes(updatedJson, key, iv);
            File.WriteAllBytes(filePath, encrypted);
        }
        public void EditPassword(string newPassword)
        {
            if (!File.Exists(filePath))
                return;

            string decrypted = DecryptStringFromBytes_Aes(File.ReadAllBytes(filePath), key, iv);
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(decrypted);

            data["_password"] = newPassword;

            string updatedJson = JsonSerializer.Serialize(data);
            byte[] encrypted = EncryptStringToBytes_Aes(updatedJson, key, iv);
            File.WriteAllBytes(filePath, encrypted);
        }
        public void EditCacheTheme(string newTheme)
        {
            if (!File.Exists(filePath))
                return;

            string decrypted = DecryptStringFromBytes_Aes(File.ReadAllBytes(filePath), key, iv);
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(decrypted);

            data["_theme"] = newTheme;

            string updatedJson = JsonSerializer.Serialize(data);
            byte[] encrypted = EncryptStringToBytes_Aes(updatedJson, key, iv);
            File.WriteAllBytes(filePath, encrypted);
        }

        public void EditConnection(string connection)
        {
            if (!File.Exists(filePath))
                return;

            string decrypted = DecryptStringFromBytes_Aes(File.ReadAllBytes(filePath), key, iv);
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(decrypted);

            data["_connection_string"] = connection;

            string updatedJson = JsonSerializer.Serialize(data);
            byte[] encrypted = EncryptStringToBytes_Aes(updatedJson, key, iv);
            File.WriteAllBytes(filePath, encrypted);
        }

        private string LoadCacheValue(string keyName)
        {
            if (!File.Exists(filePath))
                return null;

            string decrypted = DecryptStringFromBytes_Aes(File.ReadAllBytes(filePath), key, iv);
            var data = JsonSerializer.Deserialize<Dictionary<string, string>>(decrypted);

            return data.ContainsKey(keyName) ? data[keyName] : null;
        }

        private byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        private string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
