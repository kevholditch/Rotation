using Rotation.Blocks;
using Rotation.GameControl;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.GameControlSpecs
{
    public class ScoreManagerSpecs
    {
        [Specification]
        public void ScoreIsInitialisedToZeroAtTheStart()
        {
            var progressManager = default(ScoreManager);
            var result = default(IScore);

            "Given I have just started the game with a new ScoreManager"
                .Context(() => progressManager = new ScoreManager());

            "When I get the player progress"
                .Do(() => result = progressManager.GetScore());

            "Then the current score will be 0"
                .Observation(() => result.CurrentScore.ShouldEqual(0));

            "Then the total squares made this level will be 0"
                .Observation(() => result.TotalSquaresMade.ShouldEqual(0));
        }

      

        [Specification]
        public void SquaresMadeIsInitialisedToZero()
        {
            var progressManager = default(ScoreManager);
            var result = default(IScore);

            "Given I have just started the game with a new ScoreManager"
                .Context(() => progressManager = new ScoreManager());

            "When I get the player progress"
                .Do(() => result = progressManager.GetScore());

            "Then the squares made will be 0"
                .Observation(() => result.TotalSquaresMade.ShouldEqual(0));

        }

        

        [Specification]
        public void PlayerProgressIncrementsCorrectlyWhenOneBlockFound()
        {
            var progressManager = default(ScoreManager);

            "Given I have just started the game with a new ScoreManager"
                .Context(() => progressManager = new ScoreManager());

            "When I have found a block with 4 squares"
                .Do(
                    () => progressManager.FoundBlock(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(2, 3), 
                                    new BoardCoordinate(3, 3), 
                                    new BoardCoordinate(2, 4),
                                    new BoardCoordinate(3, 4)
                                }),
                        }));

            "Then there should be 4 squares made"
                .Observation(() => progressManager.GetScore().TotalSquaresMade.ShouldEqual(4));

            "Then the current score should be 4"
                .Observation(() => progressManager.GetScore().CurrentScore.ShouldEqual(4));


        }

        [Specification]
        public void PlayerProgressIncrementsCorrectlyWhenTwoBlocksAreFound()
        {
            var progressManager = default(ScoreManager);

            "Given I have just started the game with a new ScoreManager"
                .Context(() => progressManager = new ScoreManager());

            "When I have found 2 blocks with 4 squares each"
                .Do(
                    () => progressManager.FoundBlock(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(2, 3), 
                                    new BoardCoordinate(3, 3), 
                                    new BoardCoordinate(2, 4),
                                    new BoardCoordinate(3, 4)
                                }),
                            new Block(new []
                                {
                                    new BoardCoordinate(6, 3), 
                                    new BoardCoordinate(7, 3), 
                                    new BoardCoordinate(6, 4),
                                    new BoardCoordinate(7, 4)
                                }) 
                        }));

            "Then there should be 8 squares made"
                .Observation(() => progressManager.GetScore().TotalSquaresMade.ShouldEqual(8));

            "Then the current score should be 16"
                .Observation(() => progressManager.GetScore().CurrentScore.ShouldEqual(16));


        }

        [Specification]
        public void ScoreIncrementsCorrectlyWhenItStartsOffNonZero()
        {
            var progressManager = default(ScoreManager);

            "Given I have already made one block with 4 squares"
                .Context(() => 
                { 
                    progressManager = new ScoreManager();
                    progressManager.FoundBlock(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(2, 3),
                                    new BoardCoordinate(3, 3),
                                    new BoardCoordinate(2, 4),
                                    new BoardCoordinate(3, 4)
                                })
                        });

                });

            "When I have found 1 more blocks with 4 squares"
                .Do(
                    () => progressManager.FoundBlock(new[]
                        {
                            new Block(new[]
                                {
                                    new BoardCoordinate(2, 3), 
                                    new BoardCoordinate(3, 3), 
                                    new BoardCoordinate(2, 4),
                                    new BoardCoordinate(3, 4)
                                })
                        }));

            "Then there should be 8 squares made"
                .Observation(() => progressManager.GetScore().TotalSquaresMade.ShouldEqual(8));

            "Then the current score should be 8"
                .Observation(() => progressManager.GetScore().CurrentScore.ShouldEqual(8));

        }

     
   
    }
}
