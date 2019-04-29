using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace chameleon
{
	public class Game : Form
	{
		public Game ()
		{
			DoubleBuffered = true;
			ClientSize = new Size (432, 624);
			var chameleon = new Chameleon ();
			var cells = MapParser.map;
			var label = new Label ();
			label.Location = new Point (0, 0);
			label.Text = String.Format("Hungry:{0}", chameleon.hungry);
			label.Size = new Size (300, 14);
			Controls.Add (label);
			var timer = new Timer ();
			timer.Interval = 100;
			timer.Start ();
			timer.Tick += (eventHandler, args) => Invalidate ();
			Paint += (eventHandler, args) => {
			foreach (var cell in cells) {
				args.Graphics.FillRectangle (cell.color, cell.x, cell.y, Cell.width, Cell.width);
			}
			};


			this.KeyPress += chameleon.KeyPressed;
			Console.WriteLine (chameleon.x);
			Console.WriteLine (chameleon.y);

			Paint += (eventHandler, args) => {
				args.Graphics.DrawImage(chameleon.pic, chameleon.x, chameleon.y);
			};

			timer.Tick += (eventHandler, args) => Invalidate ();
			Paint += (eventHandler, args) => {
				var flies = new Flies();
				var coords = new int[10][] {new int [2] {flies.x1, flies.y1}, 
					new int [2] {flies.x2, flies.y2},
					new int [2] {flies.x3, flies.y3},
					new int [2] {flies.x4, flies.y4},
					new int [2] {flies.x5, flies.y5},
					new int [2] {flies.x6, flies.y6},
					new int [2] {flies.x7, flies.y7},
					new int [2] {flies.x8, flies.y8},
					new int [2] {flies.x9, flies.y9},
					new int [2] {flies.x10, flies.y10}};
				foreach (var coord in coords) {
					if (chameleon.y < coord[1] && coord[1] < chameleon.y+16) 
						if (chameleon.x < coord[0] && coord[0] < chameleon.x+16){
							chameleon.hungry -= 1;
							Console.WriteLine("gotcha!");}
				}
				args.Graphics.FillRectangle(Brushes.Black, flies.x1, flies.y1, 4, 4);
				args.Graphics.FillRectangle(Brushes.Red, flies.x2, flies.y2, 4, 4);
				args.Graphics.FillRectangle(Brushes.White, flies.x3, flies.y3, 4, 4);
				args.Graphics.FillRectangle(Brushes.Pink, flies.x4, flies.y4, 4, 4);
				args.Graphics.FillRectangle(Brushes.Blue, flies.x5, flies.y5, 4, 4);
				args.Graphics.FillRectangle(Brushes.Violet, flies.x6, flies.y6, 4, 4);
				args.Graphics.FillRectangle(Brushes.Yellow, flies.x7, flies.y7, 4, 4);
				args.Graphics.FillRectangle(Brushes.Gray, flies.x8, flies.y8, 4, 4);
				args.Graphics.FillRectangle(Brushes.DarkRed, flies.x9, flies.y9, 4, 4);
				args.Graphics.FillRectangle(Brushes.Lavender, flies.x10, flies.y10, 4, 4);
				};

		}
	}
}

