using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareInitialiseArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x1; //Declare an array of type int
			int[] x2 = new int[5]; //Declare and initialise an array of type int with a length of 5
			int[] x3 = new int[5] { 1, 4, 9, 16, 25 }; //Declare and initialise an array with 5 ints 
			int[] x4 = new int[] { 1, 4, 9, 16, 25 }; //Declare and initialise an array with 5 ints, without specifying the length
			var x5 = new int[] { 1, 4, 9, 16, 25 }; //Declare and initialise an array using var
			int[] x6 = { 1, 4, 9, 16, 25 }; //Declare and initialise an array without the "new int[]"
		}
	}
}
