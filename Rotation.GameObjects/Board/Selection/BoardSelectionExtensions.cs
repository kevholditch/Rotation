namespace Rotation.GameObjects.Board.Selection
{
	public static class BoardSelectionExtensions
	{
		public static void DeselectAll(this IBoard board)
		{
			board.ForEachSquare(sq => sq.IsSelected = false);
		}
	}
}