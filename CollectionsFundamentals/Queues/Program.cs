using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> tasks = new Queue<string>();

			tasks.Enqueue("C# Collections Fundamentals");
			tasks.Enqueue("C# Interfaces");
			tasks.Enqueue("C# Best Practices: Collections and Generics");
			tasks.Enqueue("C# Events, Delegates and Lambdas");

			Console.WriteLine("\r\nAll Tasks:");
			foreach (string title in tasks)
				Console.WriteLine(title);

			string nextTask = tasks.Dequeue();
			Console.WriteLine($"\r\nNext task is {nextTask}");

			Console.WriteLine("\r\nAll Tasks:");
			foreach (string title in tasks)
				Console.WriteLine(title);

			nextTask = tasks.Peek(); //Won't remove from queue
			Console.WriteLine($"\r\nNext task is {nextTask}");


		}
	}
}
