using System;
using System.Drawing;
using System.Collections.Generic;

namespace chameleon
{
	public class Cell: IEnumerable <Cell>
	{
		public int x;
		public int y;
		public Brush color;
		public static int width = 16;
		public string cellType;
		public int count = 0;
		public Cell[] collection;

		public Cell ()
		{
		
		}

		public Cell this[int index]
		{
			get
			{
				if (index < 0 || index >= count) throw new IndexOutOfRangeException();
				return collection[index];
			}
			set
			{
				if (index < 0 || index >= count) throw new IndexOutOfRangeException();
				collection[index] = value;
			}	
		}

		public IEnumerator<Cell> GetEnumerator()
		{
			for (int i = 0; i < count; i++)
				yield return collection[i];
		}
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

