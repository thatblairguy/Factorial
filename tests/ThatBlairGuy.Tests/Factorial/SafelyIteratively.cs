using System;
using System.Numerics;
using Xunit;

using ThatBlairGuy.Math;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Tests for the DoSafely method.
    /// </summary>
    public partial class FactorialTests
    {
        /// <summary>
        /// Verify handling of input values below the allowed range.
        /// </summary>
        [Theory]
        [InlineData(-1, "'n' must be non-negative.")]
        [InlineData(-10, "'n' must be non-negative.")]
        public void SafelyIterative_RangeCheck(long n, string expectedMessage)
        {
            Exception ex = Assert.Throws<ArgumentException> (
                () => Factorial.DoBigIteratively(n)
            );

            Assert.Equal(expectedMessage, ex.Message);
        }

        /// <summary>
        /// Verify correct output for inputs within range.
        /// </summary>
        [Theory, MemberData(nameof(BigIntegerValidData))]
        public void SafelyIterative_ValidInputs(Factorial_ValidInput data)
        {
            BigInteger actual = Factorial.DoBigIteratively(data.N);

            Assert.Equal(data.ExpectedValue, actual);
        }

    }
}