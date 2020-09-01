using System;
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
        /// Verify handling of input values above and below the allowed range.
        /// </summary>
        [Theory]
        [InlineData(-10, "'n' must be non-negative.")]
        [InlineData(-1, "'n' must be non-negative.")]
        [InlineData(21, "'n' must be less than 21.")]
        [InlineData(30, "'n' must be less than 21.")]
        public void Quickly_RangeCheck(int n, string expectedMessage)
        {
            Exception ex = Assert.Throws<ArgumentException> (
                () => Factorial.DoQuickly(n)
            );

            Assert.Equal(expectedMessage, ex.Message);
        }

        /// <summary>
        /// Verify correct output for inputs within range.
        /// </summary>
        [Theory, MemberData(nameof(InLongRangeData))]
        public void Quickly_ValidInputs(Factorial_ValidInput data)
        {
            long actual = Factorial.DoQuickly(data.N);

            Assert.Equal(data.ExpectedValue, actual);
        }
    }
}