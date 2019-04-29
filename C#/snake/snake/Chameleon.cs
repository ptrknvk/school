using System;
using System.Windows.Forms;
using System.Drawing;

namespace chameleon
{
	public class Chameleon
	{
		public Image pic = Image.FromFile ("chameleon-icon.png");
		public int hungry;
		public int x = 400;
		public int y = 16;
		public bool alive = true;

		public Chameleon()
		{

		}

		public void KeyPressed(object sender, KeyPressEventArgs e)
		{
			int newX = this.x;
			int newY = this.y;
			int i = (int)(newX / Cell.width);
			int j = (int)(newY / Cell.width);

			switch (e.KeyChar) {
			case 'a':
				newX -= Cell.width;
				i = (int)(newX * 1.0 / Cell.width);
				break;
			case 'd':
				newX += Cell.width;
				i = (int)(newX * 1.0 / Cell.width);
				break;
			case 'w':
				newY -= Cell.width;
				j = (int)(newY * 1.0 / Cell.width);
				break;
			case 's':
				newY += Cell.width;
				j = (int)(newY * 1.0 / Cell.width);
				break;
			}

			if (MapParser.map [i, j].cellType != "wall") {
				this.x = newX;
				this.y = newY;
			} else {
				Console.WriteLine(String.Format("x {0}, y {1}", this.x, this.y));
				Console.WriteLine ("Can't");
			}
		}
	}
}

