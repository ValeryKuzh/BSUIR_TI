using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public enum Cipher
    {
        Decimation,
        Vizhinera
    }
    public class Data
    {
        public string PlainText { get; set; }
        public string CipherText { get; set; }
        public Cipher cipherType { get; set; }

        public Data(string Plaintext, string CipherText, Cipher cipherType)
        {
            this.PlainText = Plaintext;
            this.CipherText = CipherText;
            this.cipherType = cipherType;
        }

        public static bool IsRussian(string text)
        {
            foreach (char c in text) 
            {
                if(!(c >= 'А' && c <= 'Я' || c == 'Ё' || c == ' ' || c == ',' || c == '!' || c == '.' || c == '-' || c == ':' || c == '?'))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsEnglish(string text)
        {
            foreach (char c in text)
            {
                if (!(c >= 'A' && c <= 'Z' || c == ' ' || c == ',' || c == '!' || c == '.' || c == '-' || c == ':' || c == '?'))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsRussian(char c)
        {
            if (!(c >= 'А' && c <= 'Я' || c == 'Ё'))
            {
                return false;
            }
            return true;
        }

        public static bool IsEnglish(char c)
        {
            if (!(c >= 'A' && c <= 'Z'))
            {
                return false;
            }
            return true;
        }
    }
}
