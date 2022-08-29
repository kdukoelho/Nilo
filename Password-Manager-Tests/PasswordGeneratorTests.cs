namespace Password_Manager_Tests
{
    public class PasswordGeneratorTests
    {
        const int qttChars = 5;

        [Fact]
        public void Init_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Password.Init(-qttChars, -qttChars, -qttChars, -qttChars));
        }
        
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
        public void NumGen_ShouldThrow_InvalidOperationExcepiton()
        {
            Assert.Throws<InvalidOperationException>(() => Password.NumGen(-qttChars));
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
        public void SymbolsGen_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Password.SymbolsGen(-qttChars));
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
        public void LetterGen_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Password.LetterGen(-qttChars));
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
        public void UpperLetterGen_ShouldThrows_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Password.UpperLetterGen(-qttChars));
        }

        [Fact]
        public void GeneratePassword_ShouldReturn_Password()
        {

            bool check = false;
            string possibleChars = "qwertyuiopasdfghjklçzxcvbnmQWERTYUIOPASDFGHJKLÇZXCVBNM1234567890!#$%&()*+,=./:;<=>?@";
            Password.Init(qttChars, qttChars, qttChars, qttChars);
            string generatedPassword = Password.GeneratePassword();
            foreach (char charac in generatedPassword)
            {
                if (possibleChars.Contains(charac))
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
            Assert.Equal(qttChars * 4, generatedPassword.Length);
        }
    }
}