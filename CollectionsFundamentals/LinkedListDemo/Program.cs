using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			#region star wars
			var starWarsMovies = new LinkedList<string>();

			//1977 - Star Wars First Release
			starWarsMovies.AddLast("Star Wars"); //Fast

			//1980 - Empire Strikes Back
			LinkedListNode<string> empireStrikesBack = starWarsMovies.AddLast("Empire Strikes Back"); //Fast

			//1981 - Star Wars Retitled
			starWarsMovies.RemoveFirst(); //Fast
			LinkedListNode<string> aNewHope = starWarsMovies.AddFirst("A New Hope"); //Fast

			//1983 - Return of the Jedi
			LinkedListNode<string> returnOfTheJedi = starWarsMovies.AddLast("Return of the Jedi"); //Fast

			//1999 - The Phantom Menace
			LinkedListNode<string> thePhantomMenace = starWarsMovies.AddFirst("The Phantom Menace"); //Fast

			//2002 - Attack of the Clones
			LinkedListNode<string> attackOfTheClones = starWarsMovies.AddAfter(thePhantomMenace, "Attack of the Clones"); //Fast

			//2005 - Revenge of the Sith
			LinkedListNode<string> revengeOfTheSith = starWarsMovies.AddAfter(attackOfTheClones, "Revenge of the Sith"); //Fast

			//2015 - The Force Awakens
			LinkedListNode<string> theForceAwakens = starWarsMovies.AddLast("The Force Awakens"); //Fast

			//2016 - Rogue One
			LinkedListNode<string> rogueOne = starWarsMovies.AddBefore(aNewHope, "Rogue One"); //Fast

			foreach (string movie in starWarsMovies)
			{
				Console.WriteLine(movie);
			}
			#endregion

		}
	}
}