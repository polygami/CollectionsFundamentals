using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			var reversed = daysOfWeek.Reverse(); //Method returns a new IEnumerable object

			foreach (string day in daysOfWeek)
				Console.WriteLine(day);
		}
	}
}
