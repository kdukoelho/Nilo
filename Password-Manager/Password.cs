namespace Password_Manager
{
    public class Password
    {
        int individuallyCharQtt;
        bool[] charsBool;
        public Password(bool[] charsBool, int charsQtt)
        {
            this.individuallyCharQtt = CalculateCharsQtt(charsBool, charsQtt);
            this.charsBool = charsBool;
        }

        private int CalculateCharsQtt(bool[] charsBool, int charsQtt)
        {
            charsQtt = charsQtt % 2 != 0 ? charsQtt + 1 : charsQtt;
            int charTypesQtt = 0;
            foreach (bool type in charsBool)
            {
                charTypesQtt = type ? charTypesQtt + 1 : charTypesQtt;
            }
            return charTypesQtt > 0 ? charsQtt / charTypesQtt : 1;
        }

        public string NumGen(bool willGenerate) // Generate a string with numbers.
        {
            if (!willGenerate)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genNums = "";
                for (int i = 0; i < individuallyCharQtt; i++)
                {
                    string strNums = Convert.ToString(rnd.Next(0, 9));
                    genNums = genNums + strNums;
                }
                return genNums;
            }            
        }

        public string UpperLetterGen(bool willGenerate) // Generate a string with upper letters.
        {
            if (!willGenerate)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genLetters = "";

                for (int i = 0; i < individuallyCharQtt; i++)
                {
                    genLetters += Convert.ToChar(rnd.Next(65, 91));
                }
                return genLetters;
            }
        }

        public string LetterGen(bool willGenerate) // Generate a string with letters.
        {
            if (!willGenerate)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genLetters = "";

                for (int i = 0; i < individuallyCharQtt; i++)
                {
                    genLetters += Convert.ToChar(rnd.Next(97, 122));
                }
                return genLetters;
            }            
        }

        public string SymbolsGen(bool willGenerate) // Generate a string with symbols.
        {
            if (!willGenerate)
            {
                return "";
            }
            else
            {
                Random rnd = new Random();
                string genSymbols = "";

                for (int i = 0; i < individuallyCharQtt; i++)
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
        
        public string GeneratePassword()
        {
            return RandomizeString(NumGen(charsBool[0]) + LetterGen(charsBool[1]) + UpperLetterGen(charsBool[2]) + SymbolsGen(charsBool[3]));
        }

        public static string RandomizeString(string input)
        {
            char[] chars = input.ToCharArray();
            Random random = new Random();
            char[] result = new char[chars.Length];
            int remaining = chars.Length;
            for (int i = 0; i < result.Length; i++)
            {
                int j = random.Next(0, remaining);
                result[i] = chars[j];
                chars[j] = chars[--remaining];
            }
            return new string(result);
        }
    }
}