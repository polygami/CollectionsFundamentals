using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeekArray = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
			ICollection<string> daysOfWeekCollection = (ICollection<string>)daysOfWeekArray; //Casting

			daysOfWeekCollection.Contains("Thursday");
			Console.WriteLine(daysOfWeekCollection.Contains("Thursday"));

			Console.WriteLine(daysOfWeekCollection.GetType());
			if (!daysOfWeekCollection.IsReadOnly)
				daysOfWeekCollection.Add("Slaveday");
			else
				Console.WriteLine("Collection is read-only");


			//daysOfWeekCollection.Add("Slaveday");

			if (!daysOfWeekCollection.IsReadOnly)
				daysOfWeekCollection.Add("Slaveday");
			else
				Console.WriteLine("Collection is read-only");

			(daysOfWeekCollection as string[])[5] = "Slaveday"; 

			foreach (string day in daysOfWeekCollection)
			{
				Console.WriteLine(day);
			}

		}
	}
}
