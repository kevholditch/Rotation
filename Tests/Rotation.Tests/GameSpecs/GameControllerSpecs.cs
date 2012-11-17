using FakeItEasy;
using Rotation.Controls;
using Rotation.StandardBoard;
using Rotation.StandardBoard.Rotation;
using Rotation.StandardBoard.Selection;
using SubSpec;

namespace Rotation.GameObjects.sTests.GameSpecs
{
    public class GameControllerSpecs
    {
        [Specification]
        public void CurrentSelectedSquareStartsOffInTheCentre()
        {
            var gameController = default(GameController);
            var board = default(IBoard);

            "Given I have a standard 9x9 board".Context(() =>
                            {
                                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                                A.CallTo(() => fakeSquareSelectable
                                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                                    .Returns(true);
                                board = new BoardFactory().Create();
                                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                            });

            "When I initialise the controller".Do(() => gameController.Initialise());

            "Then the X value of the selected square should be the centre square x value of the boards centre square"
                .Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(board.CentreSquare.X));

            "Then the Y value of the selected square should be the centre square x value of the boards centre square"
                .Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(board.CentreSquare.Y));



        }

        [Specification]
        public void CanMoveSelectionUp()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var board = new BoardFactory().Create();
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I move the selection up".Do(() => gameController.MoveSelectionUp());

            "Then the X value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will be 3".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(3));
        }

        [Specification]
        public void CanIgnoreSelectionUpIfItWouldGoOutOfBounds()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(false);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board); 
                gameController.Initialise();
            });

            "When I try move the selection up".Do(() => gameController.MoveSelectionUp());

            "Then the X value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }
     

        [Specification]
        public void CanMoveSelectionDown()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I move the selection down".Do(() => gameController.MoveSelectionDown());

            "Then the X value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will be 5".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(5));
        }

        [Specification]
        public void CanIgnoreSelectionDownIfItWouldGoOutOfBounds()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(false);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I try move the selection down".Do(() => gameController.MoveSelectionDown());

            "Then the X value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

        [Specification]
        public void CanMoveSelectionLeft()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I move the selection left".Do(() => gameController.MoveSelectionLeft());

            "Then the X value of the current selected square will be 3".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(3));

            "Then the Y value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));

        }

        [Specification]
        public void CanIgnoreSelectionLeftIfItWouldGoOutOfBounds()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(false);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I try move the selection left".Do(() => gameController.MoveSelectionLeft());

            "Then the X value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }
       

        [Specification]
        public void CanMoveSelectionRight()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I move the selection left".Do(() => gameController.MoveSelectionRight());

            "Then the X value of the current selected square will be 5".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(5));

            "Then the Y value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

        [Specification]
        public void CanIgnoreSelectionRightIfItWouldGoOutOfBounds()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(false);
                var board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I try move the selection right".Do(() => gameController.MoveSelectionRight());

            "Then the X value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

        [Specification]
        public void CanSelectASquare()
        {
            var gameController = default(GameController);

            "Given I have a standard 9x9 board".Context(() =>
            {
                var board = new BoardFactory().Create();
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I select square 3, 2".Do(() => gameController.SelectSquare(3, 2));

            "Then the X value of the current selected square will be 3".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(3));

            "Then the Y value of the current selected square will be 2".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(2));
        }

        [Specification]
        public void CanIgnoreAnOutOfBoundSquareSelection()
        {
            var gameController = default(GameController);

            "Given I have current selected square 4 4".Context(() =>
            {
                var board = new BoardFactory().Create();
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(false);
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), fakeSquareSelectable, board);
                gameController.Initialise();
            });

            "When I select square 10, 10".Do(() => gameController.SelectSquare(10, 10));

            "Then the X value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will still be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

        [Specification]
        public void CanRotateTheBoardRight()
        {
            var gameController = default(GameController);
            var fakeSelectionRotator = default(ISelectionRotatator);
            var board = default(IBoard);

            "Given I have a game controller".Context(() =>
                    {
                        fakeSelectionRotator = A.Fake<ISelectionRotatator>();
                        var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                        board = A.Fake<IBoard>();
                        A.CallTo(() => fakeSquareSelectable
                            .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                            .Returns(true);
                        gameController = new GameController(A.Fake<ISquareSelector>(), fakeSelectionRotator, fakeSquareSelectable, board);
                    });

            "When I rotate right".Do(() => gameController.RotateRight());

            "Then the board should be rotated right".Observation(
                () => A.CallTo(() => fakeSelectionRotator.Right(board)).MustHaveHappened());
        }

        [Specification]
        public void CanRotateTheBoardLeft()
        {
            var gameController = default(GameController);
            var fakeSelectionRotator = default(ISelectionRotatator);
            var board = default(IBoard);

            "Given I have a game controller".Context(() =>
            {
                fakeSelectionRotator = A.Fake<ISelectionRotatator>();
                var fakeSquareSelectable = A.Fake<ISquareSelectable>();
                board = A.Fake<IBoard>();
                A.CallTo(() => fakeSquareSelectable
                    .CanSelectSquare(A<IBoard>.Ignored, A<int>.Ignored, A<int>.Ignored))
                    .Returns(true);
                gameController = new GameController(A.Fake<ISquareSelector>(), fakeSelectionRotator, fakeSquareSelectable, board);
            });

            "When I rotate left".Do(() => gameController.RotateLeft());

            "Then the board should be rotated left".Observation(
                () => A.CallTo(() => fakeSelectionRotator.Left(board)).MustHaveHappened());
        }
    }
}