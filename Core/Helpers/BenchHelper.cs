using System;
using System.Diagnostics;

namespace Benchmarks.Core.Helpers
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

				total += s.ElapsedMilliseconds;
			}

			Console.WriteLine($"Total: {total:n0} ms");

			if (times > 1)
			{
				Console.WriteLine($"Avg: {total / times:n0} ms");
			}

			Console.WriteLine();
		}
	}
}