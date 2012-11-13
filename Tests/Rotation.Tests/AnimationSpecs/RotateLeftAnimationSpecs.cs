using System;
using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Drawing.Animations;
using Rotation.Events;
using Rotation.GameObjects.sTests.TestClasses;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.AnimationSpecs
{
    public class RotateLeftAnimationSpecs
    {
        [Specification]
        public void RotateLeftAnimationInitialisesSquaresToPlus90()
        {
            var board = default(IBoard);
            var rotateLeftAnimation = default(RotateLeftAnimation);
            var boardCoordinates = default(IEnumerable<BoardCoordinate>);

            "Given I have a standard board and a known list of coordinates".Context(() =>
                {
                    board = new BoardFactory().Create();
                    boardCoordinates = new[] { new BoardCoordinate(1, 2), new BoardCoordinate(2, 3) };
                });

            "When I create a new rotateLeftAnimation".Do(
                () => rotateLeftAnimation = new RotateLeftAnimation(boardCoordinates, board));

            "Then the square at coordinate 1, 2 will have an angle of 90".Observation(
                () => board[1, 2].Angle.ShouldEqual(90));

            "Then the square at coordinate 2, 3 will have an angle of 90".Observation(
                () => board[2, 3].Angle.ShouldEqual(90));

            "Then 2 squares will have an angle of -90".Observation(
                () => board.AllSquares().Count(sq => sq.Angle == 90).ShouldEqual(2));

            "Then the animation should not be finished".Observation(
                () => rotateLeftAnimation.Finished().ShouldBeFalse());


        }

        [Specification]
        public void EachAnimationWillDecreaseTheAngle()
        {
            var board = default(IBoard);
            var rotateLeftAnimation = default(RotateLeftAnimation);

            "Given I have a standard board and a known list of coordinates".Context(() =>
                        {
                            board = new BoardFactory().Create();
                            var boardCoordinates = new[] { new BoardCoordinate(1, 2), new BoardCoordinate(2, 3) };
                            rotateLeftAnimation = new RotateLeftAnimation(boardCoordinates, board);
                        });

            "When I call animate after 100 milliseconds has passed"
                .Do(() => rotateLeftAnimation.Animate(new GameTime { ElapsedGameTime = TimeSpan.FromMilliseconds(100) }));

            "Then the square at 1, 2 should be 90 - animation increase rate * 100".Observation(
                () => board[1, 2].Angle.ShouldEqual(90 - GameConstants.Animation.ANGLE_INCREASE_SPEED*100));

            "Then the square at 2, 3 should be 90 - animation increase rate * 100".Observation(
                () => board[2, 3].Angle.ShouldEqual(90 - GameConstants.Animation.ANGLE_INCREASE_SPEED*100));

            "Then 2 squares will have an angle other an 0".Observation(
                () => board.AllSquares().Count(sq => sq.Angle != 0).ShouldEqual(2));

        }

        [Specification]
        public void TheAnimationWillFinish()
        {
            var board = default(IBoard);
            var rotateLeftAnimation = default(RotateLeftAnimation);
            var gameTime = default(GameTime);

            "Given I set of squares in the board that need one more frame of animation".Context(() =>
                {
                    board = new BoardFactory().Create();
                    var boardCoordinates = new[] { new BoardCoordinate(1, 2), new BoardCoordinate(2, 3) };
                    rotateLeftAnimation = new RotateLeftAnimation(boardCoordinates, board);
                    board[1, 2].Angle = 1;
                    board[2, 3].Angle = 1;
                    gameTime = new GameTime()
                    {
                        ElapsedGameTime =
                            TimeSpan.FromMilliseconds(90 * GameConstants.Animation.ANGLE_INCREASE_SPEED + 1000)
                    };
                });

            "When I call animate".Do(() => rotateLeftAnimation.Animate(gameTime));

            "Then the square at 1, 2 should be 0".Observation(
                () => board[1, 2].Angle.ShouldEqual(0));

            "Then the square at 2, 3 should be 0".Observation(
                () => board[2, 3].Angle.ShouldEqual(0));

            "Then the animation should be finished".Observation(() => rotateLeftAnimation.Finished().ShouldBeTrue());


        }

        [Specification]
        public void RaisesABoardChangedEventWhenFinished()
        {
            var animation = default(RotateLeftAnimation);
            var result = default(IGameEvent);

            "Given I have a rotate right animation".Context(
                () => { 
                    
                    GameEvents.Dispatcher = new ActionEventDispatcher(a => result = a);
                    animation = new RotateLeftAnimation(new BoardCoordinate[] {}, A.Fake<IBoard>());
                    
                });


            "When I call OnFinished".Do(() => animation.OnFinished());

            "Then a board changed event will be raised".Observation(() => result.ShouldBeOfType<BoardChangedEvent>());

        }
    }
}