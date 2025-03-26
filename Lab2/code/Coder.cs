using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti_2tr
{
    public class Coder
    {
        public byte[] BinaryToBytes(string s)
        {
            int ost = s.Length & 7;
            if (ost != 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 8 - ost; i++) 
                    sb.Append("0");
                s = s + sb.ToString();
            }
            byte[] res = new byte[s.Length>>3];
            int j;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                j = i >> 3;
                res[j] = (byte)((res[j] << 1) + (chars[i]-'0'));
            }
            return res;
        }
        public string BytesToBinary(byte[] bytes)
        {
            char[] chars = new char[bytes.Length << 3];
            for (int i = 0; i < bytes.Length; i++)
                for (int j = 7; j >= 0; j--)
                {
                    int b = (bytes[i] >> j) & 1;
                    chars[(i << 3) + 7- j] = (char)(b + 48);
                }
            return new string(chars);
        }
    }
}
