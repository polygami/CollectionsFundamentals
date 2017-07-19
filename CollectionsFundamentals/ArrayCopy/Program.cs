using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myArr1 = { 1, 4, 9, 16 };
			int[] myArr2 = new int[4];
			Array.Copy(myArr1, myArr2, 4); //Array.Copy (array, array, length)
			myArr2 = myArr1.ToArray();

			foreach (int x in myArr2)
			{
				Console.WriteLine(x);
			}

		}
	}
}