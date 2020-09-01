using System;
using System.Diagnostics;
using System.Numerics;

using ThatBlairGuy.Math;

namespace ThatBlairGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 21; i++)
            {
                long iterative = Factorial.DoIteratively(i);
                long quick = Factorial.DoQuickly(i);
                long recursive = Factorial.DoRecursively(i);
                BigInteger safe = Factorial.DoSafelyIteratively(i);

                System.Console.WriteLine($"{i}\t{iterative:N0}\t{quick:N0}\t{recursive:N0}\t{safe:N0}");
            }


            Stopwatch stopwatch = new Stopwatch();
            long junk = -1;

            stopwatch.Start();
            for(int i = 0; i < int.MaxValue; ++i)
            {
                int factor = getFactor();
                junk ^= Factorial.DoIteratively(factor);
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format($"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds/10:00}");
            System.Console.WriteLine($"Ran in {elapsedTime}");
            System.Console.WriteLine($"Junk: {junk}");
        }

        private static Random rand = new Random();
        private static int getFactor()
        {
            return rand.Next(21);
        }

    }
}
