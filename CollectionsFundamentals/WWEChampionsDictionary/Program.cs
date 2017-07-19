using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWEChampionsDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var champions = new Dictionary<string, Champion> (StringComparer.CurrentCultureIgnoreCase)
			{
				//...//
				{ "JC", new Champion("John Cena", 13) },
				{ "HHH", new Champion("Triple H", 9) },
				{ "RO", new Champion("Randy Orton", 9)},
				{ "TR", new Champion("The Rock", 8)},
				{ "SCSA", new Champion("Stone Cold Steve Austin", 6)},
				{ "HH", new Champion("Hulk Hogan", 6)},
				{ "BH", new Champion("Bret Hart", 5)}
			};

			//Replace or add
			champions["HHH"] = new Champion("Hunter Hearst Helmsley", 9); //If the key already exists for an item, the item will be replaced
			champions["TU"] = new Champion("The Undertaker", 4);

			//Only add
			//IDictionary<TKey, TValue>
			champions.Add("KA", new Champion("Kurt Angle", 4));

			//IDictionary<TKey, TValue>
			champions.Remove("KA");

			#region looking up dictionary items
			/*
			Console.WriteLine(champions["JC"]); // Works if the key exists, otherwise throws an exceptiong

			Champion champ;
			bool found = champions.TryGetValue("RF", out champ);
			if (found)
				Console.WriteLine(champ);
			else
				Console.WriteLine("Not found in dictionary");
			*/
			#endregion

			#region enumerating dictionary items

			//Enumerating dictionary items
			foreach (var champ in champions)
				Console.WriteLine(champ.Value);
			/*
			//...is the same as...
			foreach (var champ in champions.Values)
				Console.WriteLine(champ);

			foreach (var champ in champions)
				Console.WriteLine(champ.Key);
			//...is the same as...
			foreach (var champ in champions.Keys)
				Console.WriteLine(champ);
			*/
			#endregion


		}
	}
}
