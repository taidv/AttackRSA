using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Wiener
{
    class RsaKey
    {
        private BigInteger modulus; // modulus = pq
        private BigInteger publicExponent_e; // public exponent = e
        private BigInteger privateExponent_d; // private exponent = d
        private BigInteger prime_p; // prime p
        private BigInteger prime_q; // prime q

        public BigInteger Modulus
        {
            get { return modulus; }
            set { modulus = value; }
        }
        public BigInteger Public_exponent
        {
            get { return publicExponent_e; }
            set { publicExponent_e = value; }
        }
        public BigInteger Private_exponent
        {
            get { return privateExponent_d; }
            set { privateExponent_d = value; }
        }

        public RsaKey(BigInteger e, BigInteger n)
        {
            Public_exponent = e;
            Modulus = n;
        }

        public bool TestKey()
        {
            BigInteger m = 2;
            BigInteger c = BigInteger.ModPow(m, Public_exponent, Modulus);
            BigInteger rm = BigInteger.ModPow(c, Private_exponent, Modulus);
            if (m == rm)
                return true;
            else
                return false;
        }
        
    }
}
