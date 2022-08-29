﻿using System.Text;

namespace Password_Manager
{


    public static class Database
    {
        private static string EncodeData(string password)
        {
            try
            {                
                password = Cryptography.EncodeString(Cryptography.CaesarCipherEncrypt(password));
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"{password}");
                string encodedData = stringBuilder.ToString();
                
                return encodedData;
            }
            catch (Exception ex)
            {
                return $"Unexpected error in EncodeData: {ex.Message}";
            }
        }

        public static string CreateDatabase(string password, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return $"Database file already exist in the current directory {path}";
                }
                else
                {
                    string buildedString = EncodeData(password);
                    File.WriteAllText(path, buildedString);
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return $"Unexpected error in CreateDatabase: {ex.Message}";
            }
        }       

        private static string DecodeData(string password)
        {
            try
            {
                password = Cryptography.CaesarCipherDecrypt(Cryptography.DecodeString(password));
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"{password}");
                string decodedData = stringBuilder.ToString();
                
                return decodedData;
            }
            catch (Exception ex)
            {
                return $"Unexpected error in DecodeData: {ex.Message}";
            }
        }       
    }
}
    
