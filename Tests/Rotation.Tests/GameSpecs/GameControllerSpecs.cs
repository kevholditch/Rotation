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
                                board = new BoardFactory().Create();
                                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), board);
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
            var board = default(IBoard);

            "Given I have a standard 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), board);
                gameController.Initialise();
            });

            "When I move the selection up".Do(() => gameController.MoveSelectionUp());

            "Then the X value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will be 3".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(3));
        }

     

        [Specification]
        public void CanMoveSelectionDown()
        {
            var gameController = default(GameController);
            var board = default(IBoard);

            "Given I have a standard 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), board);
                gameController.Initialise();
            });

            "When I move the selection down".Do(() => gameController.MoveSelectionDown());

            "Then the X value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(4));

            "Then the Y value of the current selected square will be 5".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(5));
        }


        [Specification]
        public void CanMoveSelectionLeft()
        {
            var gameController = default(GameController);
            var board = default(IBoard);

            "Given I have a standard 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), board);
                gameController.Initialise();
            });

            "When I move the selection left".Do(() => gameController.MoveSelectionLeft());

            "Then the X value of the current selected square will be 3".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(3));

            "Then the Y value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

       

        [Specification]
        public void CanMoveSelectionRight()
        {
            var gameController = default(GameController);
            var board = default(IBoard);

            "Given I have a standard 9x9 board".Context(() =>
            {
                board = new BoardFactory().Create();
                gameController = new GameController(A.Fake<ISquareSelector>(), A.Fake<ISelectionRotatator>(), board);
                gameController.Initialise();
            });

            "When I move the selection left".Do(() => gameController.MoveSelectionRight());

            "Then the X value of the current selected square will be 5".Observation(() =>
                gameController.CurrentSelectedSquare.X.ShouldEqual(5));

            "Then the Y value of the current selected square will be 4".Observation(() =>
                gameController.CurrentSelectedSquare.Y.ShouldEqual(4));
        }

        


    }
}