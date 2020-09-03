using System;
using System.Diagnostics;

namespace ThatBlairGuy
{
    public class BenchMarker
    {
        private static Random rand = new Random();
        
        /// <summary>
        /// Runs <paramref name"method"/> with random inputs <paramref name="iterations"/> times,
        /// tracking the total execution time.
        /// </summary>
        /// <param name="iterations">The number of times <paramref name"method"/> is to be executed.</param>
        /// <param name="MaxFactor">The maximum factorial to calculate.</param>
        /// <param name="method">The method to execute.</param>
        /// <typeparam name="TReturn">The return type of <paramref name"method"/>.</typeparam>
        /// <returns></returns>
        public TimeSpan TimeIt<TReturn>(int iterations, int MaxFactor, Func<long, TReturn> method) where TReturn : struct
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            for(int i = 0; i < iterations; ++i)
            {
                int factor = rand.Next(MaxFactor+1);
                method(factor);
            }

            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}