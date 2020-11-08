using Benchmarks.Core.Helpers;
using System.Threading.Tasks;

namespace Multithreading
{
	class Program
	{
		public static HardCoreService hardCoreService = new HardCoreService();

		public static void Main()
		{
			MainAsync().GetAwaiter().GetResult();

			//Peasant();
			Task();
			//Parallel();
			//ActionBlock();
			//TransformBlock();
		}

		private static void Peasant()
		{
			var peasant = new Peasant();

			BenchHelper.Count("Peasant simple", () =>
			{
				peasant.Run(() => hardCoreService.OnePlusOne());
			});

			BenchHelper.Count("Peasant complex", () =>
			{
				peasant.Run(() => hardCoreService.VeryIntensiveTask());
			});
		}

		private static void Task()
		{
			var task = new TaskWait();

			BenchHelper.Count("Task simple", () =>
			{
				task.Run(() => hardCoreService.OnePlusOne());
			});

			BenchHelper.Count("Task complex", () =>
			{
				task.Run(() => hardCoreService.VeryIntensiveTask());
			});

			//BenchHelper.Count("Task complex", () =>
			//{
			//	task.Run(() => hardCoreService.VeryIntensiveTask());
			//});
		}

		private static void Parallel()
		{
			var parallel = new ParallelForeach();

			BenchHelper.Count("Parallel Foreach simple", () =>
			{
				parallel.Run(() => hardCoreService.OnePlusOne());
			});

			BenchHelper.Count("Parallel Foreach complex", () =>
			{
				parallel.Run(() => hardCoreService.VeryIntensiveTask());
			});

			BenchHelper.Count("Parallel Foreach complex, Degree = 5", () =>
			{
				parallel.Run(() => hardCoreService.VeryIntensiveTask(), 5);
			});
		}

		private static void ActionBlock()
		{
			var action = new ActionBlock();

			BenchHelper.Count("ActionBlock simple", () =>
			{
				action.Run(() => hardCoreService.OnePlusOne());
			});

			BenchHelper.Count("ActionBlock complex, Degree = 5", () =>
			{
				action.Run(() => hardCoreService.VeryIntensiveTask(), 5);
			});
		}

		private static void TransformBlock()
		{
			var transform = new Transform();

			BenchHelper.Count("TransformBlock simple", () =>
			{
				transform.Run(() => hardCoreService.OnePlusOne());
			});

			BenchHelper.Count("TransformBlock complex, Degree = 5", () =>
			{
				transform.Run(() => hardCoreService.VeryIntensiveTask(), 5);
			});
		}

		private static async Task MainAsync()
		{

			//var tasksWaitWhen = new TaskWaitWhen();
			//await tasksWaitWhen.WaitAll(hardCoreService.VeryIntensiveTask());
			//await tasksWaitWhen.WhenAll(hardCoreService.VeryIntensiveTask());

			// PEASANT -------------------------------------------------------------------
			

			// PARALLEL FOREACH -------------------------------------------------------------------
			
		}
	}
}
