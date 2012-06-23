using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public class Line
	{
		private List<Square> _squares;

		public Line(List<Square> squares)
		{
			_squares = squares;
		}

		public List<Square> Squares { get { return _squares; } } 
	}
}