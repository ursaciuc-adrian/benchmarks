using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Multithreading
{
	public class TaskWait
	{
		public void Run(Action action)
		{
			var tasks = new List<Task>();

			for (int i = 0; i < 10; i++)
			{
				tasks.Add(Task.Run(() => action.Invoke()));
			}

			Task.WaitAll(tasks.ToArray());
		}
	}
}
