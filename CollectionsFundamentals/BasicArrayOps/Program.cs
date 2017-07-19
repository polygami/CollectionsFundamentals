using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayOps
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek =
			{
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday",
			};

			Console.WriteLine("Type in index of day to lookup");
			int day = int.Parse(Console.ReadLine());
			Console.WriteLine(daysOfWeek[day]);
		}
	}
}
