using System;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace Multithreading
{
	public class Transform
	{
		public void Run(Action action, int degree = 0)
		{
			var options = new ExecutionDataflowBlockOptions();

			if (degree > 0)
			{
				options.MaxDegreeOfParallelism = degree;
			}

			var printResult = new ActionBlock<string>(message =>
			{
				Console.WriteLine(message);
			});

			var transformBlock = new TransformBlock<int, string>((i) =>
			{
				Console.WriteLine($"Processing on thread {Thread.CurrentThread.ManagedThreadId}");
				action();

				return $"Action {i} completed.";
			}, options);

			transformBlock.LinkTo(printResult);
			transformBlock.Completion.ContinueWith(delegate { printResult.Complete(); });

			for (int i = 0; i < 10; i++)
			{
				transformBlock.Post(i);
			}

			transformBlock.Complete();

			printResult.Completion.Wait();
		}
	}
}
