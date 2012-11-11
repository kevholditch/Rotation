using System;
using System.Collections.Generic;

namespace Rotation.StandardBoard.Sequences
{
	public class RowIndexSequence
	{
		public IEnumerable<int> Get(int rowIndex, int boardSize)
		{

			int halfVal = (boardSize - 1)/2;

			int difference = Math.Abs(halfVal - rowIndex);

			for (int i = difference; i < boardSize - difference; i++)
				yield return i;

				
		}
	}
}