using Rotation.Blocks;
using Rotation.Constants;
using Rotation.Events;
using Rotation.GameControl;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.GameControlSpecs
{
    public class RotationManagerSpecs
    {
        [Specification]
        public void RotationsStartOffAtTheConstStartingValue()
        {
            var rotationManager = default(RotationManager);
            var result = default(IRotationInformation);

            "Given I have initialised a new RotationManager with 20 rotations"
                .Context(() => rotationManager = new RotationManager(new TestGameStartConditions{StartRotations = 20}));

            "When I get the rotation information"
                .Do(() => result = rotationManager.GetRotationInformation());

            "Then there should be 20 rotations left"
                .Observation(() => result.RotationsLeft.ShouldEqual(20));
        }

        [Specification]
        public void WhenARotationIsMadeTheAmountOfRotationsDecreasesByOne()
        {
            var rotationManager = default(RotationManager);

            "Given I have initialised a new RotationManager with 20 rotations"
                .Context(() => rotationManager = new RotationManager(new TestGameStartConditions{StartRotations = 20}));

            "When a rotation is made"
                .Do(() => rotationManager.RotationMade());

            "Then there shoud be 19"
                .Observation(() =>
                    rotationManager
                         .GetRotationInformation()
                         .RotationsLeft
                         .ShouldEqual(19));
        }

        [Specification]
        public void WhenABlockIsMadeWith4SquaresRotationsIncreaseBy4()
        {
            var rotationManager = default(RotationManager);

            "Given I have initialised a new RotationManager with 20 rotations"
                .Context(() => rotationManager = new RotationManager(new TestGameStartConditions{StartRotations = 20}));

            "When 1 block is found with 4 squares"
                .Do(
                    () =>
                    rotationManager.BlocksFound(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(4, 5), 
                                    new BoardCoordinate(5, 5), 
                                    new BoardCoordinate(4, 6),
                                    new BoardCoordinate(5, 6)
                                })
                        }));

            "Then there shoud be 24"
                .Observation(() =>
                    rotationManager
                         .GetRotationInformation()
                         .RotationsLeft
                         .ShouldEqual(24));
        }

        [Specification]
        public void When2BlocksAreMadeWithATotalOf8SquaresRotationsIncreaseBy8()
        {
            var rotationManager = default(RotationManager);

            "Given I have initialised a new RotationManager with 20 rotations"
                .Context(() => rotationManager = new RotationManager(new TestGameStartConditions{StartRotations = 20}));

            "When 2 blocks are found each with 4 squares"
                .Do(
                    () =>
                    rotationManager.BlocksFound(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(4, 5), 
                                    new BoardCoordinate(5, 5), 
                                    new BoardCoordinate(4, 6),
                                    new BoardCoordinate(5, 6)
                                }),
                            new Block(new[]
                                {
                                    new BoardCoordinate(1, 5), 
                                    new BoardCoordinate(2, 5), 
                                    new BoardCoordinate(1, 6),
                                    new BoardCoordinate(2, 6)
                                })
                        }));

            "Then there shoud be 28 rotations left"
                .Observation(() =>
                    rotationManager
                         .GetRotationInformation()
                         .RotationsLeft
                         .ShouldEqual(28));
        }

        
    }
}