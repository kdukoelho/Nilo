namespace Password_Manager_Tests
{
    public class PasswordGeneratorTests
    {
        const int qttChars = 20;
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        const string upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string symbols = "!@$%*()[]&-+=:;,.?#/< >";
        const string numbers = "1234567890";


        

        [Fact]
        public void NumGen_ShouldReturn_Nums()
        {
            bool check = false;
            bool[] boolsArray = { true, false, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.NumGen(true);
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
            bool[] boolsArray = { false, false, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.NumGen(false);
            string expectedStr = "";
            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void SymbolsGen_ShouldReturn_Symbols()
        {
            bool check = false;
            bool[] boolsArray = { false, false, false, true };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.SymbolsGen(true);
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
            bool[] boolsArray = { false, false, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.SymbolsGen(false);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void LetterGen_ShouldReturn_Letters()
        {
            bool check = false;
            bool[] boolsArray = { false, true, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.LetterGen(true);
            string possibleLetters = "qwertyuiopasdfghjklçzxcvbnm";

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
            bool[] boolsArray = { false, false, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.LetterGen(false);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void UpperLetterGen_ShouldReturn_UpperLetters()
        {
            bool check = false;
            bool[] boolsArray = { false, false, true, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.UpperLetterGen(true);
            string possibleLetters = "QWERTYUIOPASDFGHJKLÇZXCVBNM";

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
        public void UpperLetterGen_ShouldReturn_EmptyString()
        {
            bool[] boolsArray = { false, false, false, false };
            Password password = new Password(boolsArray, 20);
            string generatedStr = password.LetterGen(false);
            string expectedStr = "";

            Assert.Equal(expectedStr, generatedStr);
        }

        [Fact]
        public void RandomizeString_ShouldReturnRandomizedStringWithAtLeastOneLowercaseLetterOneUppercaseLetterOneSpecialCharacterAndOneNumber()
        {
            // Arrange
            string input = "Abc123!@#";

            // Act
            string output = Password.RandomizeString(input);

            // Assert
            bool hasLowercaseLetter = output.Any(c => char.IsLower(c));
            bool hasUppercaseLetter = output.Any(c => char.IsUpper(c));
            bool hasSpecialCharacter = output.Any(c => !char.IsLetterOrDigit(c));
            bool hasNumber = output.Any(c => char.IsNumber(c));

            Assert.True(hasLowercaseLetter && hasUppercaseLetter && hasSpecialCharacter && hasNumber);
        }

        [Fact]
        public void GeneratePassword_ShouldReturn_GeneratedPassword()
        {
            bool[] boolsArray = { true, true, true, true };
            Password password = new Password(boolsArray, 20);
            string output = password.GeneratePassword();

            bool hasLowercaseLetter = output.Any(c => char.IsLower(c));
            bool hasUppercaseLetter = output.Any(c => char.IsUpper(c));
            bool hasSpecialCharacter = output.Any(c => !char.IsLetterOrDigit(c));
            bool hasNumber = output.Any(c => char.IsNumber(c));

            Assert.True(hasLowercaseLetter && hasUppercaseLetter && hasSpecialCharacter && hasNumber);
            Assert.Equal(20, output.Length);
        }
    }
}