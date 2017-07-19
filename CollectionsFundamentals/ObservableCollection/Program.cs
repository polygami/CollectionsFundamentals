using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			ObservableCollection<string> bondActors = new ObservableCollection<string>
			{
				"Sean Connery",
				"Roger Moore",
				"George Lazenby",
				"Timothy Dalton"
			};

			bondActors.CollectionChanged += OnCollectionChanged;

			bondActors.Add("Pierce Brosnan");
			bondActors.Remove("George Lazenby");

			Console.WriteLine("-----");
			foreach (string actor in bondActors)
			{
				Console.WriteLine(actor);
			}
		}

		static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.OldItems != null)
				Console.WriteLine($"{e.Action} {e.OldItems[0]}");
			if (e.NewItems != null)
				Console.WriteLine($"{e.Action} {e.NewItems[0]}");

		}
	}
}


//Add Pierce Brosnan
//Remove George Lazenby
//-----
//Sean Connery
//Roger Moore
//Timothy Dalton
//Pierce Brosnan
