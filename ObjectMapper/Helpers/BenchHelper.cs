using System;
using System.Diagnostics;

namespace ObjectMapperBenchmarks.Helpers
{
    public static class BenchHelper
    {
        public static void Count(string message, Action action, int times = 1)
        {
            Console.WriteLine(message);

            long total = 0;

            for (var i = 0; i < times; i++)
            {
                var s = new Stopwatch();
                s.Start();
            
                action.Invoke();
            
                s.Stop();

//                Console.WriteLine($"I{i}: {s.ElapsedMilliseconds}");
                total += s.ElapsedMilliseconds;
            }

            Console.WriteLine($"Milliseconds: {total}");

            if (times > 1)
            {
                Console.WriteLine($"Avg: {total / times}");
            }

            Console.WriteLine();
        }
    }
}