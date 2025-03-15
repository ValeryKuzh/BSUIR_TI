using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DecimationCipher
    {
        public string? PlainText { get; set; }
        public string? CipherText { get; set; }

        private const int quantityOfLetters = (int)'Z' - (int)'A' + 1;

        public string Ciphe(string Plain, int key, out string error)
        {
            PlainText = Plain;
            StringBuilder sb = new StringBuilder();
            int code;
            error = "";
            
            if (IsMutuallyPrime(quantityOfLetters, key, out error))
            {
                foreach (char ch in Plain)
                {
                    if (char.IsLetter(ch))
                    {
                        char upperCh = char.ToUpper(ch);
                        code = (upperCh - 'A') * key % quantityOfLetters;
                        sb.Append((char)(code + 'A'));
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
            }
            CipherText = sb.ToString();
            return sb.ToString();
        }

        private static bool IsMutuallyPrime(int valueOfAlphabet, int key, out string error)
        {
            error = "";
            while (key != 0)
            {
                int temp = key;
                key = valueOfAlphabet % key;
                valueOfAlphabet = temp;
            }
            if (valueOfAlphabet != 1)
            {
                error = "Ваше число не является взаимнопростым с количеством букв в алфавите";
                return false;
            }
            return true;
        }

        public string Deciphe(string Cipher, int key, out string error)
        {
            CipherText = Cipher;
            StringBuilder sb = new StringBuilder();
            int code;
            error = "";
            int quantityOfLetters = (int)'Z' - (int)'A' + 1;
            int deciphedKey = FindKey(key, quantityOfLetters);
            if (IsMutuallyPrime(quantityOfLetters, deciphedKey, out error))
            {
                foreach (char ch in Cipher)
                {
                    if (char.IsLetter(ch))
                    {
                        char upperCh = char.ToUpper(ch);
                        code = (upperCh - 'A') * deciphedKey % quantityOfLetters;
                        sb.Append((char)(code + 'A'));
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
            }
            CipherText = sb.ToString();
            return sb.ToString();
        }
        private int FindKey(int key, int quantityOfAlphabet)
        {
            int res = 1;
            while (key * res % quantityOfAlphabet != 1)
                res++;
            return res;
        }

        internal static string ToUpper(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char let in text)
                sb.Append(char.ToUpper(let));
            return sb.ToString();
        }

        internal static string GetValidKey(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char let in text)
                if (char.IsDigit(let))
                    sb.Append(let);
            return sb.ToString();
        }

        public string getValidString(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char let in text)
            {
                if (Data.IsEnglish(let))
                    sb.Append(let);
            }
            return sb.ToString();
        }
    }
}
