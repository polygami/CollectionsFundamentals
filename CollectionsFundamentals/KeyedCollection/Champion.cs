using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedCollection
{
	class Champion
	{
		public string Name { get; private set; }
		public int TitlesWon { get; private set; }

		public Champion(string name, int titlesWon)
		{
			this.Name = name;
			this.TitlesWon = titlesWon;
		}

		public override string ToString()
		{
			return $"{Name} has won {TitlesWon} titles.";
		}
	}
}
