using System;
using Xunit;

using ThatBlairGuy.Math;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Tests for the DoIteravely method.
    /// </summary>
    public partial class FactorialTests
    {
        /// <summary>
        /// Verify handling of input values below the allowed range.
        /// </summary>
        [Theory]
        [InlineData(-1)]
        [InlineData(-30)]
        public void WithChecking_RangeCheck_Low(long n)
        {
            Exception ex = Assert.Throws<ArgumentException> (
                () => Factorial.DoIterativelyWithChecking(n)
            );

            Assert.Equal("'n' must be non-negative.", ex.Message);
        }

        /// <summary>
        /// Verify that values of n resulting in n-factorial too large for long
        /// result in an overflow exception.
        /// </summary>
        [Theory]
        [InlineData(21)]
        [InlineData(30)]
        [InlineData(500)]
        public void WithChecking_RangeCheck_High(long n)
        {
            Exception ex = Assert.Throws<OverflowException> (
                () => Factorial.DoIterativelyWithChecking(n)
            );

            Assert.Equal("Arithmetic operation resulted in an overflow.", ex.Message);
        }

        /// <summary>
        /// Verify correct output for inputs within range.
        /// </summary>
        [Theory, MemberData(nameof(InLongRangeData))]
        public void WithChecking_ValidInputs(Factorial_ValidInput data)
        {
            long actual = Factorial.DoIterativelyWithChecking(data.N);

            Assert.Equal(data.ExpectedValue, actual);
        }
    }
    
}