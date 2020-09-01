using System;
using System.Numerics;

namespace ThatBlairGuy.Math
{
    /// <summary>
    /// Implements a variety of methods for calculating factorials.
    /// </summary>
    public static partial class Factorial
    {
        /// <summary>
        /// Calculates n-factorial iteratively. Throws ArgumentException if n
        /// is negative or if n! would be too large to return in type long.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static long DoIteratively(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n > 20)
                throw new ArgumentException($"'{nameof(n)}' must be less than 21.");

            if (n == 0)
                return 1;

            long result = 1;
            for (long i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        /// <summary>
        /// Calculates n-factorial recursively. Throws ArgumentException if n
        /// is negative or if n! would be too large to return in type long.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static long DoRecursively(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n > 20)
                throw new ArgumentException($"'{nameof(n)}' must be less than 21.");

            if (n == 0 || n == 1)
                return 1;

            return n * DoRecursively(n - 1);
        }

        /// <summary>
        /// Calculates n-factorial by looking it up in a table of known factorials.
        /// Throws ArgumentException if n is negative or outside the set of known values
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static long DoQuickly(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n >= LongFactorial.Length)
                throw new ArgumentException($"'{nameof(n)}' must be less than {LongFactorial.Length}.");

            return LongFactorial[n];
        }

        /// <summary>
        /// Calculates n-factorial iteratively, allowing for n to be greater than 20.
        /// Throws ArgumentException if n is negative.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>The BigInteger value of n-factorial.</returns>
        public static BigInteger DoSafelyIteratively(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n == 0)
                return 1;

            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        /// <summary>
        /// Calculates n-factorial recursively, allowing for n to be greater than 20.
        /// Throws ArgumentException if n is negative.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static BigInteger DoSafelyRecursively(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");

            if (n == 0 || n == 1)
                return 1;

            return n * DoSafelyRecursively(n - 1);
        }

        /// <summary>
        /// Calculates n-factorial through by looking it up in a table of known factorials.
        /// Throws ArgumentException if n is negative or outside the set of known values.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static BigInteger DoSafelyQuickly(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n >= BigFactorial.Length)
                throw new ArgumentException($"'{nameof(n)}' must be less than {BigFactorial.Length}.");

            return BigFactorial[n];
        }

        /// <summary>
        /// Calculates n-factorial iteratively, but instead of checking for an upper bound, uses
        /// runtime integer overflow checking. Throws ArgumentException if n is negative.
        /// </summary>
        /// <param name="n">The number to calculate the factorial for.</param>
        /// <returns>n-factorial</returns>
        public static long DoIterativelyWithChecking(long n)
        {
            if (n < 0)
                throw new ArgumentException($"'{nameof(n)}' must be non-negative.");
            if (n == 0)
                return 1;
           
            long result = 1;
            for (long i = 1; i <= n; i++)
            {
                result = checked(result * i);
            }

            return result;
        }
    }
}
