# Factorials

This is a completely silly project to scratch an itch and do something unreleated to Drupal, PHP, or content management.

Factorials are calculated by taking a non-negative integer and multiplying it by the factorial of the next lower integer. Both 1 factorial and 0 factorial are defined as being equal to 1.

So, 4 factorial then would be `4 x 3 x 2 x 1`. The usual shorthand is the number (or a variable) followed by an exclamation point. (e.g. `4!`)

The `Factorial` class provides methods to calculate `N!` in one of three ways:

* By iterating over the numbers `1` to `N` and multiplying them.
* By recursively multiplying `N` by `N-1`.
* By looking up `N!` in a list of pre-calculated values.

The list of pre-calculated values is interesting because it the runtime is O(1) while the others are O(n). The tradeoff of course is that the pre-calculated list of values requires additional storage.

An additional challenge is that even with a 64-bit `long`, the largest factorial you can compute is `20!`. Larger values won't fit in 64 bits.  Toward this end, the `Factorial` class also provides a set of "Safe" methods which return [BigInteger](https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=netcore-3.1) values.

Because C# doesn't detect integer overflow by default, an additional method exists to perform the calcuation iteratively with `long` values.

## Methods

* `DoIteratively` - Iterative calculation with longs.
* `DoRecursively` - Recursive calculation with longs.
* `DoQuickly` - Table lookup with longs.
* `DoSafelyIteratively` - Iterative calculation with BigInteger.
* `DoSafelyRecursively` - Recursive calculation with BigInteger.
* `DoSafelyQuickly` - Table lookup with BigInteger (up to 256!).
* `DoIterativelyWithChecking` - Iterative calcuation with longs and overflow checks.

## Fun Stuff

(For some atypical meaning of "fun")

Renaud Sirdey's [Factorial table](http://sirdeyre.free.fr/maths/facttabl.htm)

