using System;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace Multithreading
{
	public class ActionBlock
	{
		public void Run(Action action, int degree = 0)
		{
			var options = new ExecutionDataflowBlockOptions();

			if (degree > 0)
			{
				options.MaxDegreeOfParallelism = degree;
			}

			var actionBlock = new ActionBlock<int>((i) =>
			{
				Console.WriteLine($"Processing on thread {Thread.CurrentThread.ManagedThreadId}");
				action();
			}, options);

			for (int i = 0; i < 10; i++)
			{
				actionBlock.Post(i);
			}

			actionBlock.Complete();
			actionBlock.Completion.Wait();
		}
	}
}
