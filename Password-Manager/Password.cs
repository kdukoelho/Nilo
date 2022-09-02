namespace Password_Manager
{
    static public class Password
    {
        static private int qttNums, qttSymbols, qttLetter, qttUpperLetter;  

        static public string NumGen(int qttNums) // Generate a string with numbers.
        {
            if (qttNums <= 0)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genNums = "";               
                for (int i = 0; i < qttNums; i++)
                {
                    string strNums = Convert.ToString(rnd.Next(0, 9));
                    genNums = genNums + strNums;
                }
                return genNums;
            }            
        }

        static public string UpperLetterGen(int qttUpperLetter) // Generate a string with upper letters.
        {
            if (qttUpperLetter <= 0)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genLetters = "";

                for (int i = 0; i < qttUpperLetter; i++)
                {
                    genLetters += Convert.ToChar(rnd.Next(65, 91));
                }
                return genLetters;
            }
        }

        static public string LetterGen(int qttLetter) // Generate a string with letters.
        {
            if (qttLetter <= 0)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genLetters = "";

                for (int i = 0; i < qttLetter; i++)
                {
                    genLetters += Convert.ToChar(rnd.Next(97, 122));
                }
                return genLetters;
            }            
        }

        static public string SymbolsGen(int qttSymbols) // Generate a string with symbols.
        {
            if (qttSymbols <= 0)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genSymbols = "";

                for (int i = 0; i < qttSymbols; i++)
                {
                    int symbolsCheck = rnd.Next(33, 64);                    
                    if (symbolsCheck > 48 && symbolsCheck < 57 || symbolsCheck == 34 || symbolsCheck == 39)
                    {
                        i--;
                    }
                    else 
                    { 
                        genSymbols += Convert.ToChar(symbolsCheck);
                    }
                }
                return genSymbols;
            }            
        }

        static public string ShuflePassword(int charQtt, string letters, string nums, string upperLetters, string symbols) // Shuffle all chars and defines password lenght.
        {
            string finalPass = letters + nums + upperLetters + symbols;
            string[] wordsList = new string[finalPass.Length];

            for (int i = 0; i < finalPass.Length; i++) { wordsList[i] += finalPass[i]; }

            Random random = new Random();
            for (int i = 0; i < (wordsList.Length - 1); i++)
            {
                int x = random.Next(wordsList.Length);
                string tempString = wordsList[i];
                wordsList[i] = wordsList[x];
                wordsList[x] = tempString;
            }

            finalPass = String.Empty;
            for (int i = 0; i < charQtt; i++)
            {
                finalPass += wordsList[i];
            }

            return finalPass;
        }
    }
}