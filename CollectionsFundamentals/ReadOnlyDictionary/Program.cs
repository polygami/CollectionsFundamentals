using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var champions = new Dictionary<string, Champion>(StringComparer.CurrentCultureIgnoreCase)
			{
				{ "JC", new Champion("John Cena", 13) },
				{ "HHH", new Champion("Triple H", 9) },
				{ "RO", new Champion("Randy Orton", 9)},
				{ "TR", new Champion("The Rock", 8)},
				{ "SCSA", new Champion("Stone Cold Steve Austin", 6)},
				{ "HH", new Champion("Hulk Hogan", 6)},
				{ "BH", new Champion("Bret Hart", 5)}
			};

			var championsReadOnly = new ReadOnlyDictionary<string, Champion>(champions);

			foreach (var champ in championsReadOnly)
			{
				Console.WriteLine(champ.Value);
			}
		}
	}
}
