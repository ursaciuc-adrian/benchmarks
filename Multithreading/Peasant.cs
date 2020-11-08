using System;

namespace Multithreading
{
	public class Peasant
	{
		public void Run(Action action)
		{
			for(int i = 0; i < 10; i++)
			{
				action.Invoke();
			}
		}
	}
}
