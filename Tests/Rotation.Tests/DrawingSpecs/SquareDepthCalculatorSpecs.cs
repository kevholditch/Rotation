using Rotation.GameObjects.sTests.Builders;
using Rotation.StandardBoard;
using Rotation.Textures;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingSpecs
{
    public class SquareDepthCalculatorSpecs
    {
        [Specification]
        public void CanCalculateTheLayerDepthOfAStillSquare()
        {
            var square = default(Square);
            var squareDepthCalculator = default(SquareDepthCalculator);
            var result = default (float);

            "Given that I have a square that is not moving".Context(() =>
                                                                        {
                                                                            squareDepthCalculator = new SquareDepthCalculator();
                                                                            square = BuildA.DefaultSquare().Build();
                                                                        });

            "When I call calculate".Do(() => result = squareDepthCalculator.Calculate(square));

            "Then the depth returned should be 0.2f".Observation(() => result.ShouldEqual(0.2f));
        }

        [Specification]
        public void CanCalculateTheLayerDepthOfAMovingSquare()
        {
            var square = default(Square);
            var squareDepthCalculator = default(SquareDepthCalculator);
            var result = default(float);

            "Given that I have a square that is moving".Context(() =>
            {
                squareDepthCalculator = new SquareDepthCalculator();
                square = BuildA.DefaultSquare().WithAngle(90).Build();
            });

            "When I call calculate".Do(() => result = squareDepthCalculator.Calculate(square));

            "Then the depth returned should be 0.1f".Observation(() => result.ShouldEqual(0.1f));
        }


    }
}
