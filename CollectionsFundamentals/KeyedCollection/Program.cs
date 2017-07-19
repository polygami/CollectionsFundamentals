using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			var champions = new ChampionsByNameDictionary()
			{
				new Champion("John Cena", 13),
				new Champion("Triple H", 9),
				new Champion("Randy Orton", 9),
				new Champion("The Rock", 8),
				new Champion("Stone Cold Steve Austin", 6),
				new Champion("Hulk Hogan", 6),
				new Champion("Bret Hart", 5)
			};

			Console.WriteLine(champions["John Cena"]);

			foreach (var champ in champions)
			{
				Console.WriteLine(champ);
			}

			//var list = (IList<MyType>)myKeyedCollection;
			//Console.WriteLine($"The value in index 0 is {list[0]}");
		}

		class ChampionsByNameDictionary : KeyedCollection<string, Champion>
		{
			protected override string GetKeyForItem(Champion item)
			{
				return item.Name;
			}
		}
	}
}
