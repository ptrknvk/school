using System;
using System.Drawing;

namespace chameleon
{
	public class Flies
	{
		public int x1;
		public int y1;
		public int x2;
		public int y2;
		public int x3;
		public int y3;
		public int x4;
		public int y4;
		public int x5;
		public int y5;
		public int x6;
		public int y6;
		public int x7;
		public int y7;
		public int x8;
		public int y8;
		public int x9;
		public int y9;
		public int x10;
		public int y10;

		public Flies ()
		{
			var rnd = new Random ();
			x1 = rnd.Next (16, 400);
			y1 = rnd.Next (16, 600);
			x2 = rnd.Next (16, 400);
			y2 = rnd.Next (16, 600);
			x3 = rnd.Next (16, 400);
			y3 = rnd.Next (16, 600);
			x4 = rnd.Next (16, 400);
			y4 = rnd.Next (16, 600);
			x5 = rnd.Next (16, 400);
			y5 = rnd.Next (16, 600);
			x6 = rnd.Next (16, 400);
			y6 = rnd.Next (16, 600);
			x7 = rnd.Next (16, 400);
			y7 = rnd.Next (16, 600);
			x8 = rnd.Next (16, 400);
			y8 = rnd.Next (16, 600);
			x9 = rnd.Next (16, 400);
			y9 = rnd.Next (16, 600);
			x10 = rnd.Next (16, 400);
			y10 = rnd.Next (16, 600);
		}
	}
}

