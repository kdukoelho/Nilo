using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    public static class Database
    {
        public static string CreateDatabase(string username, string password, string email, string keyword, string DbName)
        {
            try
            {
                string path = $@"C:\Users\Cadu\Documents\Test\{DbName}.csv";
                if (File.Exists(path))
                {
                    return $"File {DbName} already exist in the current directory {path}";
                }
            else
                {

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
