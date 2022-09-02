namespace Password_Manager_Tests
{
    public class PasswordGeneratorTests
    {
        const int qttChars = 5;
               
        [Fact]
        public void NumGen_ShouldReturn_Nums()
        {
            bool check = false;
            string generatedStr = Password.NumGen(qttChars);
            string possibleNums = "1234567890";

            foreach (char num in generatedStr)
            {
                if (possibleNums.Contains(num))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            Assert.True(check);
            Assert.Equal(qttChars, generatedStr.Length);
        }

        [Fact]
        public void NumGen_ShouldReturn_EmptyString()
        {
            string generatedStr = Password.NumGen(0);
            string expectedStr = "";
            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void SymbolsGen_ShouldReturn_Symbols()
        {
            bool check = false;
            string generatedStr = Password.SymbolsGen(qttChars);
            string possibleSymbols = "!#$%&()*+,./:;<=>?@";

            foreach (char symbol in generatedStr)
            {
                if (possibleSymbols.Contains(symbol))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }

                Assert.True(check);
                Assert.Equal(qttChars, generatedStr.Length);
            }
        }

        [Fact]
        public void SymbolsGen_ShouldReturn_EmptyString()
        {
            string generatedStr = Password.SymbolsGen(0);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void LetterGen_ShouldReturn_Letters()
        {
            bool check = false;
            string possibleLetters = "qwertyuiopasdfghjklçzxcvbnm";
            string generatedStr = Password.LetterGen(qttChars);

            foreach (char letter in generatedStr)
            {
                if (possibleLetters.Contains(letter))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            Assert.True(check);
            Assert.Equal(qttChars, generatedStr.Length);
        }

        [Fact]
        public void LetterGen_ShouldReturn_EmptyString()
        {
            string generatedStr = Password.LetterGen(0);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void UpperLetterGen_ShouldReturn_UpperLetters()
        {
            bool check = false;
            string possibleLetters = "QWERTYUIOPASDFGHJKLÇZXCVBNM";
            string generatedStr = Password.UpperLetterGen(qttChars);

            foreach(char letter in generatedStr)
            {
                if (possibleLetters.Contains(letter))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            Assert.True(check);
            Assert.Equal(qttChars, generatedStr.Length);
        }

        [Fact]
        public void UpperLetterGen_ShouldReturn_EmptyString()
        {
            string generatedStr = Password.UpperLetterGen(0);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        
        
    }
}