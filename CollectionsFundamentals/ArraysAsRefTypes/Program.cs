using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsRefTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x1 = { 1, 4, 9, 16 };
			var x2 = x1;
			int[] x3 = { 1, 4, 9, 16 };
			Console.WriteLine(ReferenceEquals(x1, x2)); //Returns TRUE
			Console.WriteLine(ReferenceEquals(x1, x3)); //Returns FALSE
			Console.WriteLine(x1 == x2);                //Returns TRUE
			Console.WriteLine(x1 == x3);                //Returns FALSE
		}
	}
}
