using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace chameleon
{
	public class MapParser
	{
		public static Cell[,] map = MapParser.Parse();

		public static Cell[,] Parse() 
		{
			string[] map = File.ReadAllLines("lab.txt");
			var height = map.Length;
			var width = map [0].Length;
			var matrix = new Cell[height, width];

			for (var i = 0; i < height; i++) {
				for (var j = 0; j < width; j++) {
					if (map [i][j] == ' ') {
						matrix[i, j] = new Cell { color = Brushes.White, x = i * Cell.width, y = j * Cell.width, cellType = "terrain" };
					} else {
						matrix[i, j] = new Cell { color = Brushes.DarkGreen, x = i * Cell.width, y = j * Cell.width, cellType = "wall" };
					}
				}
			}
			return matrix;
		}	
	}
}

