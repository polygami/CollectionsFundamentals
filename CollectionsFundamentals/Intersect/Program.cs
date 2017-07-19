using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect
{
	class Program
	{
		static void Main(string[] args)
		{
			var bigCities = new HashSet<string> { "New York", "Manchester", "Sheffield", "Paris" };

			string[] citiesInUk = { "Sheffield", "Ripon", "Truro", "Manchester" };

			bigCities.ExceptWith(citiesInUk); //New York, Paris

			foreach (string city in bigCities)
			{
				Console.WriteLine(city);
			}

			#region Linq Intersect()
			//var newCities = bigCities.Intersect(citiesInUk);
			//foreach (string city in newCities)
			//	Console.WriteLine(city); //Manchester, Sheffield
			#endregion

			#region ISet<T> IntersectWith()
			//bigCities.IntersectWith(citiesInUk);
			//foreach (string city in new)
			//	Console.WriteLine(city);
			#endregion
		}
	}
}
