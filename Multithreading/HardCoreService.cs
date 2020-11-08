using System;
using System.Threading;

namespace Multithreading
{
	public class HardCoreService
	{
		public int OnePlusOne()
		{
			var result = 1 + 1;

			Console.WriteLine($"T {Thread.CurrentThread.ManagedThreadId}: The result is two.");

			return result;
		}

		public void VeryIntensiveTask()
		{
			var seconds = 5;

			Thread.Sleep(seconds * 1000);

			Console.WriteLine($"T {Thread.CurrentThread.ManagedThreadId}: Waited {seconds} sec.");
		}
	}
}
