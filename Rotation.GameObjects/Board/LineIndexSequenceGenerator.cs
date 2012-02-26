using System;
using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class LineIndexSequenceGenerator : ILineIndexSequenceGenerator
	{
		public IEnumerable<int> Create(int length)
		{

			if (length % 2 != 1)
				throw new ArgumentException("length has to be odd");
						
			bool countUp = true;			

			for (int i = 0, j = -1; i < length; i++)
			{

				if (countUp)
				{
					j++;
				}else
				{
					j--;
				}

				if (j == (length - 1) / 2)
					countUp = false;

				yield return j;

			}
			

		}
	}
}