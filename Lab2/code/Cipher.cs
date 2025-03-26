using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti_2tr
{
    public class Cipher
    {
        LFSR lfsr;
        public byte[] Encrypt(byte[] bytes, Int64 key)
        {
            lfsr = new LFSR(key);
            byte[] fullkey = lfsr.GetKey(bytes.Length);
            for (int i = 0; i < fullkey.Length; i++)
                bytes[i] = (byte)(fullkey[i]^bytes[i]);
            return fullkey;
        }
    }
}
