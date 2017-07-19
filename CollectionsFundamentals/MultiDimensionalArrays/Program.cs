using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = 10;
			int height = 10;
			int[,] battleshipBoard = new int[width, height];

			battleshipBoard[2, 2] = 1;
			battleshipBoard[2, 3] = 1;
			battleshipBoard[2, 4] = 1;
			battleshipBoard[2, 5] = 1;
			battleshipBoard[2, 6] = 1;
			battleshipBoard[2, 7] = 1;

			battleshipBoard[3, 5] = 1;
			battleshipBoard[4, 5] = 1;

			battleshipBoard[5, 2] = 1;
			battleshipBoard[5, 3] = 1;
			battleshipBoard[5, 4] = 1;
			battleshipBoard[5, 5] = 1;
			battleshipBoard[5, 6] = 1;
			battleshipBoard[5, 7] = 1;

			battleshipBoard[7, 2] = 1;
			battleshipBoard[7, 3] = 1;
			battleshipBoard[7, 4] = 1;
			battleshipBoard[7, 5] = 1;
			battleshipBoard[7, 6] = 1;
			battleshipBoard[7, 7] = 1;

			for (int y = height - 1; y > -1; y--)
			{
				string line = "";

				for (int x = 0; x < width; x++)
				{
					if (battleshipBoard[x, y] == 1)
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
. . . . . . . . . .
. . O . . O . O . .
. . O . . O . O . .
. . O O O O . O . .
. . O . . O . O . .
. . O . . O . O . .
. . O . . O . O . .
. . . . . . . . . .
. . . . . . . . . .
*/