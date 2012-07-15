using Rotation.GameObjects.Letters;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Tests.Common.Builders
{

    public class SquareBuilder
    {
        private readonly Square _square;

        public SquareBuilder(bool isSelectable, int x, int y)
        {
            _square = new Square(isSelectable, x, y);
        }

        public SquareBuilder WithLetter(int points, char value)
        {
            _square.Tile = new TestTile(new Letter(points, value));
            return this;
        }

        public SquareBuilder WithCanUseInWord(bool value)
        {
            _square.CanUseInWord = value;
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