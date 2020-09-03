using System;
using System.Diagnostics;
using System.Numerics;

using ThatBlairGuy.Math;

namespace ThatBlairGuy
{
    /// <summary>
    /// Runs a series of speed tests against the various methods for calculating factorials.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BenchMarker bench = new BenchMarker();

            // Timing for methods returning a long.
            TimeSpan iterativeTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoIteratively);
            TimeSpan recursiveTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoRecursively);
            TimeSpan quickTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoQuickly);
            TimeSpan checkedTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoIterativelyWithChecking);

            // Timing for methods returning a BigInteger.
            TimeSpan safeIterativeTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoBigIteratively);
            TimeSpan safeRecursiveTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoBigRecursively);
            TimeSpan safeQuickTime = bench.TimeIt(int.MaxValue, 20, Factorial.DoBigQuickly);

            String FormatElapsed(TimeSpan ts) => String.Format($"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds/10:00}");

            System.Console.WriteLine($"Iterative ran in {FormatElapsed(iterativeTime)}");
            System.Console.WriteLine($"Recursive ran in {FormatElapsed(recursiveTime)}");
            System.Console.WriteLine($"Quickly ran in {FormatElapsed(quickTime)}");
            System.Console.WriteLine($"Iteratively with checking ran in {FormatElapsed(checkedTime)}");

            System.Console.WriteLine($"BigInteger Iterative ran in {FormatElapsed(safeIterativeTime)}");
            System.Console.WriteLine($"BigInteger Recursive ran in {FormatElapsed(safeRecursiveTime)}");
            System.Console.WriteLine($"BigInteger Quickly ran in {FormatElapsed(safeQuickTime)}");

        }
    }
}
