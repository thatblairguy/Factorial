using System.Numerics;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Stores a number N and the expected value of N-factorial.
    /// </summary>
    public class Factorial_ValidInput
    {
        /// <summary>
        /// Input for a factorial function.
        /// </summary>
        public long N { get; private set; }

        /// <summary>
        /// Expected result.
        /// </summary>
        public BigInteger ExpectedValue { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="n">The number to take the factorial of.</param>
        /// <param name="expectedValue">String representation of the expected value</param>
        public Factorial_ValidInput(long n, string expectedValue)
        {
            N = n;
            ExpectedValue = BigInteger.Parse(expectedValue);
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="n">The number to take the factorial of.</param>
        /// <param name="expectedValue">long representation of the expected value</param>
        public Factorial_ValidInput(long n, long expectedValue)
        {
            N = n;
            ExpectedValue = new BigInteger(expectedValue);
        }
    }
}