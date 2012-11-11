using Microsoft.Xna.Framework;
using Rotation.Engine;
using Rotation.StandardBoard;
using Rotation.Textures;
using SubSpec;

namespace Rotation.GameObjects.sTests.SelectorSpecs
{
    public class SquareColourSelectorSpecs
    {
        [Specification]
        public void CanGetCorrectColourForNotSelectableSquare()
        {
            var square = default(Square);
            var squareColourSelector = default(SquareColourSelector);
            var result = default(Color);

            "Given I have a square that is not selectable".Context(() =>
                    {
                        square = new Square(false, 0, 0);
                        squareColourSelector = new SquareColourSelector();
                    });

            "When I get the square colour".Do(() => result = squareColourSelector.SelectColour(square));

            "Then the colour returned should be the same as the SQUARE_NOT_SELECTABLE_COLOUR constant".Observation(
                () => result.ShouldEqual(DrawingConstants.SquareColours.SQUARE_NOT_SELECTABLE_COLOUR));


        }

        [Specification]
        public void CanGetCorrectColourForSelectedSquare()
        {
            var square = default(Square);
            var squareColourSelector = default(SquareColourSelector);
            var result = default(Color);

            "Given I have a selected square".Context(() =>
            {
                square = new Square(true, 0, 0);
                square.IsSelected = true;
                squareColourSelector = new SquareColourSelector();
            });

            "When I get the square colour".Do(() => result = squareColourSelector.SelectColour(square));

            "Then the colour returned should be the same as the SQUARE_SELECTED_COLOUR constant".Observation(
                () => result.ShouldEqual(DrawingConstants.SquareColours.SQUARE_SELECTED_COLOUR));

        }

        [Specification]
        public void CanGetCorrectColourForMainSelectedSquare()
        {
            var square = default(Square);
            var squareColourSelector = default(SquareColourSelector);
            var result = default(Color);

            "Given I have a selected square that is the main selection".Context(() =>
            {
                square = new Square(true, 0, 0);
                square.IsSelected = true;
                square.IsMainSelection = true;
                squareColourSelector = new SquareColourSelector();
            });

            "When I get the square colour".Do(() => result = squareColourSelector.SelectColour(square));

            "Then the colour returned should be the same as the MAIN_SQUARE_SELECTED_COLOUR constant".Observation(
                () => result.ShouldEqual(DrawingConstants.SquareColours.MAIN_SQUARE_SELECTED_COLOUR));

        }

        [Specification]
        public void CanGetCorrectColourForNotSelectedButSelectableSquare()
        {
            var square = default(Square);
            var squareColourSelector = default(SquareColourSelector);
            var result = default(Color);

            "Given I have a square that is selectable but not selected".Context(() =>
            {
                square = new Square(true, 0, 0);
                square.IsSelected = false;
                squareColourSelector = new SquareColourSelector();
            });

            "When I get the square colour".Do(() => result = squareColourSelector.SelectColour(square));

            "Then the colour returned should be the same as the SQUARE_NOT_SELECTED_COLOUR constant".Observation(
                () => result.ShouldEqual(DrawingConstants.SquareColours.SQUARE_NOT_SELECTED_COLOUR));

        }
    }
}