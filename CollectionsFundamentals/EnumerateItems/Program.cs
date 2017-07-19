using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerateItems
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };

			DisplayItems(seasons);
		}

		public static void DisplayItems<T>(IEnumerable<T> collection)		// (1)
		{
			using (IEnumerator<T> enumerator = collection.GetEnumerator())	// (3)(7)
			{
				bool moreItems = enumerator.MoveNext();						// (4)
				while (moreItems)											// (5)
				{
					T item = enumerator.Current;
					Console.WriteLine(item);								// (2)
					moreItems = enumerator.MoveNext();						// (6)
				}
			}
		}

	}
}


/*
	1. Generic function, which takes an IEnumerable<T> as a parameter
	2. The purpose is to display each member of the collection by calling Console.WriteLine()
	3. To do this, GetEnumerator() is called on the collection
	4. Then using the enumerator, MoveNext() is called to get to the first element
	5. Then while loop is used to keep running through the items until there are none left
	6. This is detected my MoveNext() returning false
	7. The whole thing is in a using block, which recognizes that IEnumerator<T> implements IDisposable and may have unmanaged resources to clean up once complete (rare)
*/

