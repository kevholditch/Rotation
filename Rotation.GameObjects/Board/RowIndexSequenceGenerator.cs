using System;
using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class RowIndexSequenceGenerator : IRowIndexSequenceGenerator
	{
		public IEnumerable<int> Create(int mid, int length)
		{
			if (length % 2 != 1)
				throw new ArgumentException("the length must be odd");

			for (int i = 0, j = mid - ((length-1)/2); i < length; i++, j++)
			{
				yield return j;
			}
		}
	}
}