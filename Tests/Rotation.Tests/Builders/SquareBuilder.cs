using FakeItEasy;
using Rotation.GameObjects.Letters;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.sTests.Builders
{

    public class SquareBuilder
    {
        private readonly ISquare _square;

        public SquareBuilder()
        {
            _square = A.Fake<ISquare>();
        }

        public SquareBuilder WithLetter(int points, char value)
        {
            A.CallTo(() => _square.Letter).Returns(new Letter(points, value));
            return this;
        }

        public SquareBuilder WithXPos(int value)
        {
            A.CallTo(() => _square.XPos).Returns(value);
            return this;
        }

        public SquareBuilder WithYPos(int value)
        {
            A.CallTo(() => _square.YPos).Returns(value);
            return this;
        }
        
        public ISquare Build()
        {
            return _square;
        }
    }
}