using System;
using Xunit;

using ThatBlairGuy.Math;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Tests for the DoRecursively method.
    /// </summary>
    public partial class FactorialTests
    {
        /// <summary>
        /// Verify handling of input values above and below the allowed range.
        /// </summary>
        [Theory]
        [InlineData(-10, "'n' must be non-negative.")]
        [InlineData(-1, "'n' must be non-negative.")]
        [InlineData(21, "'n' must be less than 21.")]
        [InlineData(30, "'n' must be less than 21.")]
        public void Recursively_RangeCheck(long n, string expectedMessage)
        {
            Exception ex = Assert.Throws<ArgumentException> (
                () => Factorial.DoRecursively(n)
            );

            Assert.Equal(expectedMessage, ex.Message);
        }

        /// <summary>
        /// Verify correct output for inputs within range.
        /// </summary>
        [Theory, MemberData(nameof(InLongRangeData))]
        public void Recursively_ValidInputs(Factorial_ValidInput data)
        {
            long actual = Factorial.DoRecursively(data.N);

            Assert.Equal(data.ExpectedValue, actual);
        }
    }
}