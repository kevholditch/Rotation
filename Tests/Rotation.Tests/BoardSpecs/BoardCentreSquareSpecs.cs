using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.BoardSpecs
{
    public class BoardCentreSquareSpecs
    {
        [Specification]
        public void CanGetTheCentreSquareOfTheBoard()
        {
            var board = default(IBoard);
            var result = default(BoardCoordinate);

            "Given I have a standard 9x9 board".Context(() =>
                       board = new BoardFactory().Create());

            "When I get the centre square".Do(() => result = board.CentreSquare);

            "Then the X value of the centre square will be 4".Observation(() =>
                result.X.ShouldEqual(4));

            "Then the Y value of the centre square will be 4".Observation(() =>
                result.Y.ShouldEqual(4));

        }
    }
}
