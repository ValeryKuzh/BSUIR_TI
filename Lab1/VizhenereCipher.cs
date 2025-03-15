using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public class VizhenereCipher
    {
        public string? PlainText { get; set; }
        public string? CipherText { get; set; }
        public string key { get; set; } = string.Empty;

        private const int quantityOfAlphabet = 'Я' - 'А' + 2;

        private static char[] alphabet = {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й',
            'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф',
            'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
        };

        public string Ciphe(string Plain, string key, out string error)
        {
            error = "";
            StringBuilder sb = new StringBuilder();
            int keyIndex = 0;

            for (int i = 0; i < Plain.Length; i++)
            {
                if (char.IsLetter(Plain[i]))
                {
                    char upperCh = char.ToUpper(Plain[i]);
                    int a = FindIndex(upperCh, alphabet);
                    int k = FindIndex(char.ToUpper(key[keyIndex % key.Length]), alphabet);
                    int c = (a + k) % quantityOfAlphabet;
                    sb.Append(alphabet[c]);
                    keyIndex++;
                }
                else
                {
                    sb.Append(Plain[i]);
                }
            }

            return sb.ToString();
        }

        public string Deciphe(string Cipher, string key, out string error)
        {
            error = "";
            StringBuilder sb = new StringBuilder();
            int keyIndex = 0;

            for (int i = 0; i < Cipher.Length; i++)
            {
                if (char.IsLetter(Cipher[i]))
                {
                    char upperCh = char.ToUpper(Cipher[i]);
                    int c = FindIndex(upperCh, alphabet);
                    int k = FindIndex(char.ToUpper(key[keyIndex % key.Length]), alphabet);
                    int a = (c - k + quantityOfAlphabet) % quantityOfAlphabet;
                    sb.Append(alphabet[a]);
                    keyIndex++;
                }
                else
                {
                    sb.Append(Cipher[i]);
                }
            }

            return sb.ToString();
        }

        private static int FindIndex(char v, char[] alph)
        {
            return Array.IndexOf(alph, v);
        }

        internal static bool IsValidKey(string key)
        {
            foreach (char let in key)
            {
                char upperCh = char.ToUpper(let);
                if (char.IsLetter(let))
                {
                    if (FindIndex(upperCh, alphabet) == -1)
                    {
                        return false;
                    }
                    continue;
                }
                return false;
            }
            return true;
        }

        internal static string ToUpper(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char let in text)
                sb.Append(char.ToUpper(let));
            return sb.ToString();
        }

        internal static string GetValidKey(string key)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char let in key)
                if (let >= 'А' && let <= 'Я' || let == 'Ё')
                    sb.Append(let);
            return sb.ToString();
        }

        public string getValidString(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char let in text)
            {
                if (Data.IsRussian(let))
                    sb.Append(let);
            }
            return sb.ToString();
        }
    }
}