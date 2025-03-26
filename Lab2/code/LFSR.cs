using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti_2tr
{
    public class LFSR
    {
        public const int length = 31;
        public Int64 reg;
        public LFSR(Int64 initReg) {
            reg = initReg;
        }
        public byte[] GetKey(int keyLength)
        {
            byte[] res = new byte[keyLength];
            for (int i = 0; i < keyLength; i++)
            {
                res[i] = (byte)(reg >> (length - 8));
                for (int j = 0; j < 8; j++)
                    reg = (reg << 1) + (((reg >> 30) & 1) ^ ((reg >> 2) & 1));
            }

            return res;
        }
    }
}
