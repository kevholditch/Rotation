using System.Collections.Generic;

namespace Rotation.GameObjects.Board
{
	public interface IBoard
	{
		List<Line> Rows { get; }
		List<Line> Columns { get; }
		Square this[int x, int y] { get; }
	}
}