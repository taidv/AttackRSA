using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Wiener
{
    class BVector
    {
        private BigInteger _x;
        private BigInteger _y;

        public BigInteger X
        {
            get { return _x; }
            set { _x = value; }
        }

        public BigInteger Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public BVector()
        {
            X = 0;
            Y = 0;
        }

        public BVector(BigInteger __x, BigInteger __y)
        {
            X = __x;
            Y = __y;
        }
        /// <summary>
        /// The length of the vector is ................................
        /// </summary>
        public BigInteger Length
        {
            get
            {
                return BigInteger.Subtract(BigInteger.Abs(_x), BigInteger.Abs(_y));
            }
        }

        /// <summary>
        /// Add 2 Big Vector 
        /// </summary>
        /// <param name="a"> The first param is a big vector </param>
        /// <param name="b"> The second parm is a big vector too </param>
        /// <returns> A big vector is the sum of two big vector </returns>
        public static BVector operator + (BVector a, BVector b)
        {
            return new BVector(BigInteger.Add(a.X, b.X), BigInteger.Add(a.Y, b.Y));
        }

        /// <summary>
        /// Subtract 2 Big Vector 
        /// </summary>
        /// <param name="a"> The first param is a big vector </param>
        /// <param name="b"> The second parm is a big vector too </param>
        /// <returns> A big vector is the subtract of two big vector </returns>
        public static BVector operator -(BVector a, BVector b)
        {
            return new BVector(BigInteger.Subtract(a.X, b.X), BigInteger.Subtract(a.Y, b.Y));
        }

        /// <summary>
        /// "Tich trong" of 2 Big Vector 
        /// </summary>
        /// <param name="a"> The first param is a big vector </param>
        /// <param name="b"> The second parm is a big vector too </param>
        /// <returns> A big vector is the *** of two big vector </returns>
        public static BigInteger operator *(BVector a, BVector b)
        {
            return BigInteger.One;
        }

        public static BVector operator * (BigInteger a, BVector b)
        {
            return new BVector(BigInteger.Multiply(a, b.X), BigInteger.Multiply(a, b.Y));
        }
    }
}
