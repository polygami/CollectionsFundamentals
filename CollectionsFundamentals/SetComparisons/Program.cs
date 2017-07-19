using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetComparisons
{
	class Program
	{
		static void Main(string[] args)
		{
			var footballTeams = new SortedSet<string> { "Chelsea", "Arsenal","Tottenham","Man United", "Liverpool", "Man City" };

			foreach (string team in footballTeams)
				Console.WriteLine(team);
		}
	}
}
