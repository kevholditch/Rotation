using Rotation.Letters;
using Rotation.StandardBoard;

namespace Rotation.GameObjects.sTests.Builders
{

    public class SquareBuilder
    {
        private readonly Square _square;

        public SquareBuilder(bool isSelectable, int x, int y)
        {
            _square = new Square(isSelectable, x, y);
        }

        public SquareBuilder WithColour(int value)
        {
            _square.Tile = new TestTile(value);
            return this;
        }

        public SquareBuilder WithCanUseInWord(bool value)
        {
            _square.CanUseInWord = value;
            return this;
        }

        public SquareBuilder WithInWord(bool value)
        {
            _square.InWord = value;
            return this;
        }

        public SquareBuilder WithAngle(int value)
        {
            _square.Angle = value;
            return this;
        }
        
        public Square Build()
        {
            return _square;
        }
    }
}