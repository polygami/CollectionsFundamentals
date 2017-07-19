using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = 10;
			int height = 10;
			int[][] battleshipBoard = new int[width] [];

			battleshipBoard[0] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			battleshipBoard[1] = new int[] { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 };
			battleshipBoard[2] = new int[] { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 };
			battleshipBoard[3] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			battleshipBoard[4] = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 };
			battleshipBoard[5] = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 };
			battleshipBoard[6] = new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 1, 0 };
			battleshipBoard[7] = new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 };
			battleshipBoard[8] = new int[] { 0, 0, 0, 1, 1, 1, 1, 0, 0, 0 };
			battleshipBoard[9] = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


			for (int x = 0; x < width; x++)
			{
				string line = "";

				for (int y = 0; y < height; y++)
				{
					if (battleshipBoard[x] [y]== 1)
						line += "O ";
					else
						line += ". ";

				}

				Console.WriteLine($"{line}");
			}
		}
	}
}

/*
. . . . . . . . . .
. . . O . . O . . .
. . . O . . O . . .
. . . . . . . . . .
. O . . . . . . O .
. O . . . . . . O .
. O . . . . . . O .
. . O . . . . O . .
. . . O O O O . . .
. . . . . . . . . .
*/