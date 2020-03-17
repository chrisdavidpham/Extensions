using System;

namespace LongExtensions
{
    public static class LongExtensions
    {
        // Largest power of 10 less than Int64.MaxValue (10^18)
        public static readonly long MAX_MAGNITUDE = 1000000000000000000L;

        /// <summary>
        /// Returns 10^n where n = floor log10 x 
        /// </summary>
        public static long Magnitude(this long x)
        {
            x = Math.Abs(x);
            // Prevent overflow
            if (x >= MAX_MAGNITUDE)
                return MAX_MAGNITUDE;
            long magnitude = 1L;
            for (long m = 1L; m <= x; m *= 10L)
                magnitude = m;
            return magnitude;
        }

        /// <summary>
        /// Returns the concatenation of two non-negative numbers <paramref name="x"/> and <paramref name="y"/>
        /// </summary>
        /// <exception cref="OverflowException">
        /// Thrown if a concatenation results in a number too large to represent as <c>long</c>
        /// </exception>
        /// <exception cref="LongAppendException">
        /// Thrown if a parameter is negative
        /// </exception>
        public static long Append(this long x, long y)
        {
            if (y < 0L || x < 0L) throw new LongAppendException("Appended numbers must be non-negative");
            if (y < 10L) return checked(10L * x + y);
            if (y < 100L) return checked(100L * x + y);
            if (y < 1000L) return checked(1000L * x + y);
            if (y < 10000L) return checked(10000L * x + y);
            if (y < 100000L) return checked(100000L * x + y);
            if (y < 1000000L) return checked(1000000L * x + y);
            if (y < 10000000L) return checked(10000000L * x + y);
            if (y < 100000000L) return checked(100000000L * x + y);
            if (y < 1000000000L) return checked(1000000000L * x + y);
            if (y < 10000000000L) return checked(10000000000L * x + y);
            if (y < 100000000000L) return checked(100000000000L * x + y);
            if (y < 1000000000000L) return checked(1000000000000L * x + y);
            if (y < 10000000000000L) return checked(10000000000000L * x + y);
            if (y < 100000000000000L) return checked(100000000000000L * x + y);
            if (y < 1000000000000000L) return checked(1000000000000000L * x + y);
            if (y < 10000000000000000L) return checked(10000000000000000L * x + y);
            if (y < 100000000000000000L) return checked(100000000000000000L * x + y);
            return checked(MAX_MAGNITUDE * x + y);
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
