using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
	class Program
	{
		static void Main(string[] args)
		{
			var champions = new SortedList<string, Champion>()
			{
				{ "JC", new Champion("John Cena", 13) },
				{ "HHH", new Champion("Triple H", 9) },
				{ "RO", new Champion("Randy Orton", 9)},
				{ "TR", new Champion("The Rock", 8)},
				{ "SCSA", new Champion("Stone Cold Steve Austin", 6)},
				{ "HH", new Champion("Hulk Hogan", 6)},
				{ "BH", new Champion("Bret Hart", 5)}
			};

			foreach (var champ in champions)
			{
				Console.WriteLine(champ.Value);
			}
		}
	}
}
