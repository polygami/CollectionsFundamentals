using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEnumeration
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

			foreach (string day in daysOfWeek)
			{
				Console.WriteLine(day);
			}

			Console.WriteLine("----");

			for (int i = 0; i < daysOfWeek.Length; i++)
			{
				Console.WriteLine(daysOfWeek[i]);
			}
		}
	}
}
