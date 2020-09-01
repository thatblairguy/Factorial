using System.Collections.Generic;

namespace ThatBlairGuy.Tests
{
    /// <summary>
    /// Members common to the various groups of tests.
    /// </summary>
    public partial class FactorialTests
    {
        /// <summary>
        /// Shared collection of data objects for testing inputs greater than zero
        /// and resulting in n-factorial fitting within a long.
        /// </summary>
        public static IEnumerable<object[]> InLongRangeData => new[]
        {
            new object[] { new Factorial_ValidInput(0, 1)},
            new object[] { new Factorial_ValidInput(1, 1)},
            new object[] { new Factorial_ValidInput(12, 479001600)},
            new object[] { new Factorial_ValidInput(13, 6227020800)},
            new object[] { new Factorial_ValidInput(14, 87178291200)},
            new object[] { new Factorial_ValidInput(19, 121645100408832000)},
            new object[] { new Factorial_ValidInput(20, 2432902008176640000)}
        };

        /// <summary>
        /// Shared collection of data objects for testing inputs with an expected
        /// N-Factorial out of range for a long.
        /// </summary>
        public static IEnumerable<object[]> BigIntegerValidData => new[]
        {
            new object[] { new Factorial_ValidInput(0, 1)},
            new object[] { new Factorial_ValidInput(1, 1)},
            new object[] { new Factorial_ValidInput(12, 479001600)},
            new object[] { new Factorial_ValidInput(13, 6227020800)},
            new object[] { new Factorial_ValidInput(14, 87178291200)},
            new object[] { new Factorial_ValidInput(19, 121645100408832000)},
            new object[] { new Factorial_ValidInput(20, 2432902008176640000)},
            new object[] { new Factorial_ValidInput(21, "51090942171709440000")},
            new object[] { new Factorial_ValidInput(25, "15511210043330985984000000")},
            new object[] { new Factorial_ValidInput(30, "265252859812191058636308480000000")},
            new object[] { new Factorial_ValidInput(81, "5797126020747367985879734231578109105412357244731625958745865049716390179693892056256184534249745940480000000000000000000")},
            new object[] { new Factorial_ValidInput(256, "857817775342842654119082271681232625157781520279485619859655650377269452553147589377440291360451408450375885342336584306157196834693696475322289288497426025679637332563368786442675207626794560187968867971521143307702077526646451464709187326100832876325702818980773671781454170250523018608495319068138257481070252817559459476987034665712738139286205234756808218860701203611083152093501947437109101726968262861606263662435022840944191408424615936000000000000000000000000000000000000000000000000000000000000000")}
        };
    }
}