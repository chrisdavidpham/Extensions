using System;

namespace LongExtensions
{
    public static class LongExtensions
    {
        // Largest power of 10 less than Int64.MaxValue (10^18)
        public static readonly long MAX_MAGNITUDE = 1000000000000000000L;

        /// <summary>
        /// Returns <c>10^n</c> where <code>n = Math.Floor(Math.Log10(<paramref name="a"/>))</code> 
        /// </summary>
        /// <exception cref="OverflowException">
        /// Thrown if the absolute value of <paramref name="a"/> results in overflow.
        /// </exception>
        /// <param name="a">
        /// This <c>long</c> number.
        /// </param>
        public static long Magnitude(this long a)
        {
            a = Math.Abs(a);
            // Prevent overflow
            if (a >= MAX_MAGNITUDE)
                return MAX_MAGNITUDE;
            long magnitude = 1L;
            for (long m = 1L; m <= a; m *= 10L)
                magnitude = m;
            return magnitude;
        }

        /// <summary>
        /// Returns the concatenation of two non-negative numbers <paramref name="b"/> and <paramref name="a"/>
        /// </summary>
        /// <exception cref="OverflowException">
        /// Thrown if a concatenation results in a number too large to represent as <c>long</c>.
        /// </exception>
        /// <exception cref="LongAppendException">
        /// Thrown if a parameter is negative.
        /// </exception>
        /// <param name="b">
        /// This <c>long</c> non-negative number.
        /// </param>
        /// <param name="a">
        /// The <c>long</c> non-negative number to append.
        /// </param>
        public static long Append(this long b, long a)
        {
            if (a < 0L || b < 0L) throw new LongAppendException("Appended numbers must be non-negative");
            if (a < 10L) return checked(10L * b + a);
            if (a < 100L) return checked(100L * b + a);
            if (a < 1000L) return checked(1000L * b + a);
            if (a < 10000L) return checked(10000L * b + a);
            if (a < 100000L) return checked(100000L * b + a);
            if (a < 1000000L) return checked(1000000L * b + a);
            if (a < 10000000L) return checked(10000000L * b + a);
            if (a < 100000000L) return checked(100000000L * b + a);
            if (a < 1000000000L) return checked(1000000000L * b + a);
            if (a < 10000000000L) return checked(10000000000L * b + a);
            if (a < 100000000000L) return checked(100000000000L * b + a);
            if (a < 1000000000000L) return checked(1000000000000L * b + a);
            if (a < 10000000000000L) return checked(10000000000000L * b + a);
            if (a < 100000000000000L) return checked(100000000000000L * b + a);
            if (a < 1000000000000000L) return checked(1000000000000000L * b + a);
            if (a < 10000000000000000L) return checked(10000000000000000L * b + a);
            if (a < 100000000000000000L) return checked(100000000000000000L * b + a);
            return checked(MAX_MAGNITUDE * b + a);
        }
    }

    public class LongAppendException : Exception
    {
        public LongAppendException()
        {
        }
        public LongAppendException(string message) : base(message)
        {
        }
        public LongAppendException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
