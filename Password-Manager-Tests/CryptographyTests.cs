namespace Password_Manager_Tests
{
    public class CryptographyTests
    {
        const int key = 7;
        const string badString = "T3st&'";
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        const string upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string symbols = "!@$%*()&-+=:;,.?#/<>";
        const string numbers = "1234567890";

        const string caesarEncryptedString = "hGH)&a";
        const string caesarDecryptedString = "azAZ!4";
        const string caesarEncryptAlphabet = "hijklmnopqrstuvwxyzABCDEFG";
        const string caesarEncryptUpperAlphabet = "HIJKLMNOPQRSTUVWXYZ!@$%*()";
        const string caesarEncryptNumbers = "890abcdefg";
        const string caesarEncryptSymbols = "&-+=:;,.?#/<>1234567";

        const string encodedAlphabet = "r2t5egf32hh2y4gh1f2q1yf4rs1d2wtyr52u1y3d1we2dn2jm33tç3aw21nyes2a3d3fr6gm40qg51torf2d51cde3h41slç6w2f6y2um1a6ere1si8w2r3sh3ed4lo2u4";
        const string encodedUpperAlphabet = "9i3reui34f2t434y3h5h8g4dj0k3l56gp3f0jew4oj3264y6f0jk39k9o2t32ky2sli262u6d06o2d8r1e3td9ç2f22t8h5dr036t5p37m2s180d2i77sp2i2h2o4ts212";
        const string encodedNumbers = "7u2q1m3i0ta52yuw215023it4s14dx20s76ds12g28sçw0ki8t";
        const string encodedSymbols = "i14dsplk3sq235238jsn54ft6s01lj67shb0k28n29mzs08kçh8kgcspf8q4jf8240865218hw69k2ssyt324tw4puw2k03420ja";

        // Caesar cipher encryptation method tests.

        [Fact]
        public void CaesarCipherEncrypt_ShouldReturn_EncryptedMessage()
        {
            string stringExpected = caesarEncryptedString;
            string stringGenerated = Cryptography.CaesarCipherEncrypt(caesarDecryptedString, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldReturn_EncryptedAlphabet()
        {
            string stringExpected = caesarEncryptAlphabet;
            string stringGenerated = Cryptography.CaesarCipherEncrypt(alphabet, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldReturn_EncryptedUpperAlphabet()
        {
            string stringExpected = caesarEncryptUpperAlphabet;
            string stringGenerated = Cryptography.CaesarCipherEncrypt(upperAlphabet, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldReturn_EncryptedNumbers()
        {
            string stringExpected = caesarEncryptNumbers;
            string stringGenerated = Cryptography.CaesarCipherEncrypt(numbers, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldReturn_EncryptedSymbols()
        {
            string stringExpected = caesarEncryptSymbols;
            string stringGenerated = Cryptography.CaesarCipherEncrypt(symbols, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Cryptography.CaesarCipherEncrypt(caesarDecryptedString, -1));
        }

        [Fact]
        public void CaesarCipherEncrypt_ShouldThrow_InvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => Cryptography.CaesarCipherDecrypt(badString, key));
        }

        // Caesar cipher decryptation method tests.

        [Fact]
        public void CaesarCipherDecrypt_ShouldReturn_DecryptedMessage()
        {
            string stringExpected = caesarDecryptedString;
            string stringGenerated = Cryptography.CaesarCipherDecrypt(caesarEncryptedString, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherDencrypt_ShouldReturn_DecryptedAlphabet()
        {
            string stringExpected = alphabet;
            string stringGenerated = Cryptography.CaesarCipherDecrypt(caesarEncryptAlphabet, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherDecrypt_ShouldReturn_DecryptedUpperAlphabet()
        {
            string stringExpected = upperAlphabet;
            string stringGenerated = Cryptography.CaesarCipherDecrypt(caesarEncryptUpperAlphabet, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherDecrypt_ShouldReturn_DecryptedNumbers()
        {
            string stringExpected = numbers;
            string stringGenerated = Cryptography.CaesarCipherDecrypt(caesarEncryptNumbers, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherDecrypt_ShouldReturn_DecryptedSymbols()
        {
            string stringExpected = symbols;
            string stringGenerated = Cryptography.CaesarCipherDecrypt(caesarEncryptSymbols, key);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void CaesarCipherDecrypt_ShouldThrow_InvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => Cryptography.CaesarCipherDecrypt(caesarEncryptedString, -1));
        }

        [Fact]
        public void CaesarCipherDecrypt_ShouldThrow_InvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => Cryptography.CaesarCipherDecrypt(badString, key));
        }

        // My encode pattern method tests.        

        [Fact]
        public void EncodeString_ShouldReturn_EncodedAlphabet()
        {
            string stringExpected = encodedAlphabet;
            string stringGenerated = Cryptography.EncodeString(alphabet);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void EncodeString_ShouldReturn_EncodedUpperAlphabet()
        {
            string stringExpected = encodedUpperAlphabet;
            string stringGenerated = Cryptography.EncodeString(upperAlphabet);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void EncodeString_ShouldReturn_EncodedNumbers()
        {
            string stringExpected = encodedNumbers;
            string stringGenerated = Cryptography.EncodeString(numbers);

            Assert.Equal(stringExpected, stringGenerated);

        }        

        [Fact]
        public void EncodeString_ShouldReturn_EncodedSymbols()
        {
            string stringExpected = encodedSymbols;
            string stringGenerated = Cryptography.EncodeString(symbols);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void EncodeString_ShouldReturn_EncodedStringWithAllCharsTypes()
        {
            string stringExpected = "rf2d5n2jm36y2um2t8h56gp3fdr0367u2q1s14dxm3i0t38jsn54ft6s01lj";
            string stringGenerated = Cryptography.EncodeString("qjuSGT162%*(");

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void EncodeString_ShouldThrow_InvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => Cryptography.EncodeString("'"));
        }

        // My decode pattern method tests.

        [Fact]
        public void DecodeString_ShouldReturn_DecodedAlphabet()
        {
            string stringExpected = alphabet;
            string generatedString = Cryptography.DecodeString(encodedAlphabet);

            Assert.Equal(stringExpected, generatedString);
        }

        [Fact]
        public void DecodeString_ShouldReturn_DecodedUpperAlphabet()
        {
            string stringExpected = upperAlphabet;
            string generatedString = Cryptography.DecodeString(encodedUpperAlphabet);

            Assert.Equal(stringExpected, generatedString);
        }

        [Fact]
        public void DecodeString_ShouldReturn_DecodedNumbers()
        {
            string stringExpected = numbers;
            string generatedString = Cryptography.DecodeString(encodedNumbers);

            Assert.Equal(stringExpected, generatedString);
        }

        [Fact]
        public void DecodeString_ShouldReturn_DecodedSymbols()
        {
            string stringExpected = symbols;
            string stringGenerated = Cryptography.DecodeString(encodedSymbols);

            Assert.Equal(stringExpected, stringGenerated);
        }

        [Fact]
        public void DecodeString_ShouldThrow_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Cryptography.DecodeString("a"));
        }

        [Fact]
        public void DecodeString_ShouldThrow_InvalidDataException()
        {
            Assert.Throws<InvalidDataException>(() => Cryptography.DecodeString("hd58e"));
        }
    }
}
