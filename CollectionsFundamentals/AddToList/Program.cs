using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> fruits = new List<string>()
			{
				"apple",
				"orange",
				"pear",
				"plum",
				"strawberry",
				"banana",
				"pineapple"
			};

			List<string> myList = new List<string>();


			ReadOnlyCollection<string> myReadOnlyList = new ReadOnlyCollection<string>(myList);
			//ReadOnlyCollection<string> myReadOnlyList = myList.AsReadOnly();

			ReadOnlyCollection<string> readOnlyFruits = fruits.AsReadOnly();
			//IReadOnlyCollection<string> readOnlyFruits = new IReadOnlyCollection<string>(fruits);

			Console.WriteLine();

			ChangeSomething(fruits);

			foreach (string fruit in readOnlyFruits)
			{
				Console.WriteLine(fruit);
			}

		}

		static void ChangeSomething(IList<string> list)
		{
			list.RemoveAt(3);
		}
	}
}