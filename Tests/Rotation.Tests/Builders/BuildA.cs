namespace Rotation.GameObjects.sTests.Builders
{
    public static class BuildA
    {
        public static SquareBuilder DefaultSquare()
        {
            return new SquareBuilder(true, 0, 0);
        }

        public static SquareBuilder Square(bool isSelectable, int x, int y)
        {
            return new SquareBuilder(isSelectable, x, y);
        }
    }
}