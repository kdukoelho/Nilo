using System;

namespace Password_Manager
{
    static public class Cryptography
    {
        static public string CaesarCipherEncrypt(string forEncrypt, int key = 7)
        {
            if (key < 0) { throw new InvalidOperationException(); }
            else
            {
                string encryptedString = "";
                char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                               'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                               '!', '@', '$', '%', '*', '(', ')', '&', '-', '+', '=', ':', ';', ',', '.', '?', '#', '/', '<', '>', '1', '2', '3', '4', '5', '6',
                               '7', '8', '9', '0', ' '};

                foreach (char letter in forEncrypt)
                {
                    if (!alphabet.Contains(letter)) { throw new InvalidDataException(); }
                    else
                    {
                        int letterIndex = Array.IndexOf(alphabet, letter);

                        char newLetter = alphabet[(letterIndex + key) % alphabet.Length];
                        encryptedString += newLetter;
                    }                    
                }
                return encryptedString;
            }
           
        }

        static public string CaesarCipherDecrypt(string forDecrypt, int key = 7)
        {
            if (key <= 0) { throw new InvalidOperationException(); }
            else
            {
                string decryptedString = "";
                char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                   'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                   '!', '@', '$', '%', '*', '(', ')', '&', '-', '+', '=', ':', ';', ',', '.', '?', '#', '/', '<', '>', '1', '2', '3', '4', '5', '6',
                                   '7', '8', '9', '0', ' '};

                foreach (char letter in forDecrypt)
                {
                    if (!alphabet.Contains(letter)) { throw new InvalidDataException(); }
                    else
                    {
                        int letterIndex = Array.IndexOf(alphabet, letter);
                        if (letterIndex - key < 0) { letterIndex += 82; }
                        char newLetter = alphabet[(letterIndex - key)];
                        decryptedString += newLetter;
                    }    
                }

                return decryptedString;
            }          
        }

        static public string EncodeString(string forEncrypt)
        {
            string encryptedString = String.Empty;
            
            foreach (char letter in forEncrypt)
            {
                switch (letter)
                {
                    case ' ':
                        encryptedString += "7ig54";
                        break;
                    case 'a':
                        encryptedString += "r2t5e";
                        break;
                    case 'b':
                        encryptedString += "gf32h";
                        break;
                    case 'c':
                        encryptedString += "h2y4g";
                        break;
                    case 'd':
                        encryptedString += "h1f2q";
                        break;
                    case 'e':
                        encryptedString += "1yf4r";
                        break;
                    case 'f':
                        encryptedString += "s1d2w";
                        break;
                    case 'g':
                        encryptedString += "tyr52";
                        break;
                    case 'h':
                        encryptedString += "u1y3d";
                        break;
                    case 'i':
                        encryptedString += "1we2d";
                        break;
                    case 'j':
                        encryptedString += "n2jm3";
                        break;
                    case 'k':
                        encryptedString += "3tç3a";
                        break;
                    case 'l':
                        encryptedString += "w21ny";
                        break;
                    case 'm':
                        encryptedString += "es2a3";
                        break;
                    case 'n':
                        encryptedString += "d3fr6";
                        break;
                    case 'o':
                        encryptedString += "gm40q";
                        break;
                    case 'p':
                        encryptedString += "g51to";
                        break;
                    case 'q':
                        encryptedString += "rf2d5";
                        break;
                    case 'r':
                        encryptedString += "1cde3";
                        break;
                    case 's':
                        encryptedString += "h41sl";
                        break;
                    case 't':
                        encryptedString += "ç6w2f";
                        break;
                    case 'u':
                        encryptedString += "6y2um";
                        break;
                    case 'v':
                        encryptedString += "1a6er";
                        break;
                    case 'w':
                        encryptedString += "e1si8";
                        break;
                    case 'x':
                        encryptedString += "w2r3s";
                        break;
                    case 'y':
                        encryptedString += "h3ed4";
                        break;
                    case 'z':
                        encryptedString += "lo2u4";
                        break;
                    case 'A':
                        encryptedString += "9i3re";
                        break;
                    case 'B':
                        encryptedString += "ui34f";
                        break;
                    case 'C':
                        encryptedString += "2t434";
                        break;
                    case 'D':
                        encryptedString += "y3h5h";
                        break;
                    case 'E':
                        encryptedString += "8g4dj";
                        break;
                    case 'F':
                        encryptedString += "0k3l5";
                        break;
                    case 'G':
                        encryptedString += "6gp3f";
                        break;
                    case 'H':
                        encryptedString += "0jew4";
                        break;
                    case 'I':
                        encryptedString += "oj326";
                        break;
                    case 'J':
                        encryptedString += "4y6f0";
                        break;
                    case 'K':
                        encryptedString += "jk39k";
                        break;
                    case 'L':
                        encryptedString += "9o2t3";
                        break;
                    case 'M':
                        encryptedString += "2ky2s";
                        break;
                    case 'N':
                        encryptedString += "li262";
                        break;
                    case 'O':
                        encryptedString += "u6d06";
                        break;
                    case 'P':
                        encryptedString += "o2d8r";
                        break;
                    case 'Q':
                        encryptedString += "1e3td";
                        break;
                    case 'R':
                        encryptedString += "9ç2f2";
                        break;
                    case 'S':
                        encryptedString += "2t8h5";
                        break;
                    case 'T':
                        encryptedString += "dr036";
                        break;
                    case 'U':
                        encryptedString += "t5p37";
                        break;
                    case 'V':
                        encryptedString += "m2s18";
                        break;
                    case 'W':
                        encryptedString += "0d2i7";
                        break;
                    case 'X':
                        encryptedString += "7sp2i";
                        break;
                    case 'Y':
                        encryptedString += "2h2o4";
                        break;
                    case 'Z':
                        encryptedString += "ts212";
                        break;                    
                    case '1':
                        encryptedString += "7u2q1";
                        break;
                    case '2':
                        encryptedString += "m3i0t";
                        break;
                    case '3':
                        encryptedString += "a52yu";
                        break;
                    case '4':
                        encryptedString += "w2150";
                        break;
                    case '5':
                        encryptedString += "23it4";
                        break;
                    case '6':
                        encryptedString += "s14dx";
                        break;
                    case '7':
                        encryptedString += "20s76";
                        break;
                    case '8':
                        encryptedString += "ds12g";
                        break;
                    case '9':
                        encryptedString += "28sçw";
                        break;
                    case '0':
                        encryptedString += "0ki8t";
                        break;
                    case '!':
                        encryptedString += "i14ds";
                        break;
                    case '#':
                        encryptedString += "yt324";
                        break;
                    case '$':
                        encryptedString += "q2352";
                        break;
                    case '%':
                        encryptedString += "38jsn";
                        break;
                    case '&':
                        encryptedString += "0k28n";
                        break;
                    case '(':
                        encryptedString += "s01lj";
                        break;
                    case ')':
                        encryptedString += "67shb";
                        break;
                    case '*':
                        encryptedString += "54ft6";
                        break;
                    case '+':
                        encryptedString += "08kçh";
                        break;
                    case ',':
                        encryptedString += "08652";
                        break;
                    case '=':
                        encryptedString += "8kgcs";
                        break;
                    case '.':
                        encryptedString += "18hw6";
                        break;
                    case '/':
                        encryptedString += "tw4pu";
                        break;
                    case ':':
                        encryptedString += "pf8q4";
                        break;
                    case ';':
                        encryptedString += "jf824";
                        break;
                    case '<':
                        encryptedString += "w2k03";
                        break;
                    case '>':
                        encryptedString += "420ja";
                        break;
                    case '?':
                        encryptedString += "9k2ss";
                        break;
                    case '@':
                        encryptedString += "plk3s";
                        break;
                    case '-':
                        encryptedString += "29mzs";
                        break;
                    default:
                        throw new InvalidDataException();                        
                        
                }                
            }
            return encryptedString;
        }
        
        static public string DecodeString(string forDecrypt)
        {
            string decryptedString = String.Empty;
            int codesQtt = forDecrypt.Length / 5;
            string[] decryptedStringArray = new string[codesQtt];
            int arrayIteration = 0;
            for (int i = 0; i < forDecrypt.Length; i += 5)
            {
                decryptedStringArray[arrayIteration] = forDecrypt.Substring(i, 5);
                arrayIteration++;
                                
            }            
            foreach (string code in decryptedStringArray)
            {                                  
                switch (code)
                {
                    case "7ig54":
                        decryptedString += ' ';
                        break;
                    case "r2t5e":
                        decryptedString += 'a';
                        break;
                    case "gf32h":
                        decryptedString += 'b';
                        break;
                    case "h2y4g":
                        decryptedString += 'c';
                        break;
                    case "h1f2q":
                        decryptedString += 'd';
                        break;
                    case "1yf4r":
                        decryptedString += 'e';
                        break;
                    case "s1d2w":
                        decryptedString += 'f';
                        break;
                    case "tyr52":
                        decryptedString += 'g';
                        break;
                    case "u1y3d":
                        decryptedString += 'h';
                        break;
                    case "1we2d":
                        decryptedString += 'i';
                        break;
                    case "n2jm3":
                        decryptedString += 'j';
                        break;
                    case "3tç3a":
                        decryptedString += 'k';
                        break;
                    case "w21ny":
                        decryptedString += 'l';
                        break;
                    case "es2a3":
                        decryptedString += 'm';
                        break;
                    case "d3fr6":
                        decryptedString += 'n';
                        break;
                    case "gm40q":
                        decryptedString += 'o';
                        break;
                    case "g51to":
                        decryptedString += 'p';
                        break;
                    case "rf2d5":
                        decryptedString += 'q';
                        break;
                    case "1cde3":
                        decryptedString += 'r';
                        break;
                    case "h41sl":
                        decryptedString += 's';
                        break;
                    case "ç6w2f":
                        decryptedString += 't';
                        break;
                    case "6y2um":
                        decryptedString += 'u';
                        break;
                    case "1a6er":
                        decryptedString += 'v';
                        break;
                    case "e1si8":
                        decryptedString += 'w';
                        break;
                    case "w2r3s":
                        decryptedString += 'x';
                        break;
                    case "h3ed4":
                        decryptedString += 'y';
                        break;
                    case "lo2u4":
                        decryptedString += 'z';
                        break;
                    case "9i3re":
                        decryptedString += 'A';
                        break;
                    case "ui34f":
                        decryptedString += 'B';
                        break;
                    case "2t434":
                        decryptedString += 'C';
                        break;
                    case "y3h5h":
                        decryptedString += 'D';
                        break;
                    case "8g4dj":
                        decryptedString += 'E';
                        break;
                    case "0k3l5":
                        decryptedString += 'F';
                        break;
                    case "6gp3f":
                        decryptedString += 'G';
                        break;
                    case "0jew4":
                        decryptedString += 'H';
                        break;
                    case "oj326":
                        decryptedString += 'I';
                        break;
                    case "4y6f0":
                        decryptedString += 'J';
                        break;
                    case "jk39k":
                        decryptedString += 'K';
                        break;
                    case "9o2t3":
                        decryptedString += 'L';
                        break;
                    case "2ky2s":
                        decryptedString += 'M';
                        break;
                    case "li262":
                        decryptedString += 'N';
                        break;
                    case "u6d06":
                        decryptedString += 'O';
                        break;
                    case "o2d8r":
                        decryptedString += 'P';
                        break;
                    case "1e3td":
                        decryptedString += 'Q';
                        break;
                    case "9ç2f2":
                        decryptedString += 'R';
                        break;
                    case "2t8h5":
                        decryptedString += 'S';
                        break;
                    case "dr036":
                        decryptedString += 'T';
                        break;
                    case "t5p37":
                        decryptedString += 'U';
                        break;
                    case "m2s18":
                        decryptedString += 'V';
                        break;
                    case "0d2i7":
                        decryptedString += 'W';
                        break;
                    case "7sp2i":
                        decryptedString += 'X';
                        break;
                    case "2h2o4":
                        decryptedString += 'Y';
                        break;
                    case "ts212":
                        decryptedString += 'Z';
                        break;
                    case "7u2q1":
                        decryptedString += '1';
                        break;
                    case "m3i0t":
                        decryptedString += '2';
                        break;
                    case "a52yu":
                        decryptedString += '3';
                        break;
                    case "w2150":
                        decryptedString += '4';
                        break;
                    case "23it4":
                        decryptedString += '5';
                        break;
                    case "s14dx":
                        decryptedString += '6';
                        break;
                    case "20s76":
                        decryptedString += '7';
                        break;
                    case "ds12g":
                        decryptedString += '8';
                        break;
                    case "28sçw":
                        decryptedString += '9';
                        break;
                    case "0ki8t":
                        decryptedString += '0';
                        break;
                    case "i14ds":
                        decryptedString += '!';
                        break;
                    case "yt324":
                        decryptedString += '#';
                        break;
                    case "q2352":
                        decryptedString += '$';
                        break;
                    case "38jsn":
                        decryptedString += '%';
                        break;
                    case "0k28n":
                        decryptedString += '&';
                        break;
                    case "s01lj":
                        decryptedString += '(';
                        break;
                    case "67shb":
                        decryptedString += ')';
                        break;
                    case "54ft6":
                        decryptedString += '*';
                        break;
                    case "08kçh":
                        decryptedString += '+';
                        break;
                    case "29mzs":
                        decryptedString += '-';
                        break;
                    case "08652":
                        decryptedString += ',';
                        break;
                    case "8kgcs":
                        decryptedString += '=';
                        break;
                    case "18hw6":
                        decryptedString += '.';
                        break;
                    case "tw4pu":
                        decryptedString += '/';
                        break;
                    case "pf8q4":
                        decryptedString += ':';
                        break;
                    case "jf824":
                        decryptedString += ';';
                        break;
                    case "w2k03":
                        decryptedString += '<';
                        break;
                    case "420ja":
                        decryptedString += '>';
                        break;
                    case "9k2ss":
                        decryptedString += '?';
                        break;
                    case "plk3s":
                        decryptedString += '@';
                        break;
                    default:
                        throw new InvalidDataException();                        
                }                    
            }
            return decryptedString;
        }
    }
    
}
