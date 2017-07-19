using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> dollHouse = new Stack<string>();

			dollHouse.Push("Ground Floor");
			dollHouse.Push("First Floor");
			dollHouse.Push("Attic/Roof");

			foreach (string floor in dollHouse)
			{
				Console.WriteLine(floor);
			}

			string topItem = dollHouse.Peek(); //Gets the top item, doesn't remove it
			Console.WriteLine($"Top item is {topItem}");

			topItem = dollHouse.Pop(); //Removes the top item
			Console.WriteLine($"{topItem} removed");

			topItem = dollHouse.Peek();
			Console.WriteLine($"Next item is {topItem}");
		}
	}
}
