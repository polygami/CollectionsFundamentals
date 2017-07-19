using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonBlankStringList
{
	class Program
	{
		static void Main(string[] args)
		{
			NonBlankStringList list = new NonBlankStringList();
			list.Add("Item added at index 0");
			list[0] = "Item changed at index 0";
			list.Add("item added at index 1");
			list.Insert(2, "Item inserted at index 2");
			list.Add("    "); //Throws error

			foreach (string item in list)
			{
				Console.WriteLine(item);
			}
		}
	}
}
