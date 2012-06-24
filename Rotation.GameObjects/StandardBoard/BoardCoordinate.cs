namespace Rotation.GameObjects.StandardBoard
{
	public class BoardCoordinate
	{
		public BoardCoordinate(int y, int x)
		{
			Y = y;
			X = x;
		}

		public int X { get; private set; }
		public int Y { get; private set; }
	}
}