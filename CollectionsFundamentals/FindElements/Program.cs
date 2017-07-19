using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElements
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };


			int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday"); //Can also use LastIndexOf() to search backwards
			int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W'); //Can also use FindLastIndex() to search backwards
			string[] allWith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);


			Console.WriteLine(indexOfTues); //Returns 1
			Console.WriteLine(indexOfW); //Returns 2
			foreach (string item in allWith6Chars)
				Console.WriteLine(item); //Returns Monday, Friday, Sunday

			Array.Sort(daysOfWeek);


			string[] sortedDaysOfWeek = { "Friday", "Monday", "Saturday", "Sunday", "Thursday", "Tuesday", "Wednesday" };

			int indexOfSun = Array.BinarySearch(sortedDaysOfWeek, "Sunday");
			Console.WriteLine(indexOfSun);

		}
	}
}
