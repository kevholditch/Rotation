namespace Rotation.StandardBoard
{
    public class BoardCoordinate
    {
        public BoardCoordinate(int x, int y)
        {
            Y = y;
            X = x;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}