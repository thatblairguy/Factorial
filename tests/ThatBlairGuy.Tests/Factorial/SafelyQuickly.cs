using System;
using System.Numerics;
using Xunit;

using ThatBlairGuy.Math;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Tests for the DoQuickly method.
    /// </summary>
    public partial class FactorialTests
    {
        /// <summary>
        /// Verify handling of input values outside the allowed range.
        /// </summary>
        [Theory]
        [InlineData(-1, "'n' must be non-negative.")]
        [InlineData(-10, "'n' must be non-negative.")]
        [InlineData(257, "'n' must be less than 257.")]
        [InlineData(800, "'n' must be less than 257.")]
        public void SafelyQuickly_RangeCheck(long n, string expectedMessage)
        {
            Exception ex = Assert.Throws<ArgumentException> (
                () => Factorial.DoSafelyQuickly(n)
            );

            Assert.Equal(expectedMessage, ex.Message);
        }

        /// <summary>
        /// Verify correct output for inputs within range.
        /// </summary>
        [Theory, MemberData(nameof(BigIntegerValidData))]
        public void SafelyQuickly_ValidInputs(Factorial_ValidInput data)
        {
            BigInteger actual = Factorial.DoSafelyQuickly(data.N);

            Assert.Equal(data.ExpectedValue, actual);
        }
    }
}