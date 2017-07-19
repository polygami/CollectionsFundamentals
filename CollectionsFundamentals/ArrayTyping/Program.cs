using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTyping
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] objArray = new object[3] { "Hello World", 4, 2.2d };

			foreach (object item in objArray)
			{
				Console.WriteLine(item);
			}
		}
	}
}
