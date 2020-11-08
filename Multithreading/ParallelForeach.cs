using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
	public class ParallelForeach
	{
		public void Run(Action action, int degree = 0)
		{
			var options = new ParallelOptions();

			if(degree > 0)
			{
				options.MaxDegreeOfParallelism = degree;
			}

			Parallel.ForEach(Enumerable.Range(1, 10), options, i =>
			{
				Console.WriteLine($"Processing on thread {Thread.CurrentThread.ManagedThreadId}");

				action.Invoke();
			});
		}
	}
}
