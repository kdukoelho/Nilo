using System.Text;

namespace Password_Manager
{
    public static class Database
    {
        public static string CreateDatabase(string username, string password, string email, string keyword, string path)
        {
            try
            {                
                if (File.Exists(path))
                {
                    return $"File database already exist in the current directory {path}";
                }
            else
                {
                    username = Cryptography.EncodeString(Cryptography.CaesarCipherEncrypt(username));
                    password = Cryptography.EncodeString(Cryptography.CaesarCipherEncrypt(password));
                    email = Cryptography.EncodeString(Cryptography.CaesarCipherEncrypt(email));
                    keyword = Cryptography.EncodeString(Cryptography.CaesarCipherEncrypt(keyword));
                   
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine($"{username},{password},{email},{keyword}");
                    File.WriteAllText(path, stringBuilder.ToString());
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return $"Unexpected error in method CreateDatabase: {ex.Message}";
            }
        }
    }
}
