using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) { "New York", "Manchester", "Sheffield", "Paris" };
			bool addedSheffield = bigCities.Add("Sheffield"); //Returns false
			bool addedBeijing = bigCities.Add("Beijing");     //Returns true


			Console.WriteLine($"Added Sheffield? {addedSheffield}");
			Console.WriteLine($"Added Beijing? {addedBeijing}");
			Console.WriteLine();

			foreach (string city in bigCities)
				Console.WriteLine(city);
		}
	}
}
