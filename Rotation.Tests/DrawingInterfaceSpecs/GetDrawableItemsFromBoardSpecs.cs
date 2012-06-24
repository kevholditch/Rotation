using System.Collections.Generic;
using System.Linq;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.StandardBoard;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingInterfaceSpecs
{
    public class GetDrawableItemsFromBoardSpecs
    {
        [Specification]
        public void CanGetDrawableItemsFromTheBoard()
        {
            var board = default(Board);
            var result = default(IEnumerable<IDrawableItem>);

            "Given that I have a standard board board".Context(() =>

                                                              board = new BoardFactory().Create()
                );

            "When I get all drawable items".Do(() => result = board.GetDrawables());

            "Then all of the drawable items returned should be squares".Observation(
                () => result.Count(i => i.GetType() != typeof (Square)).ShouldEqual(0));

            "Then 81 items should be returned".Observation(() => result.Count().ShouldEqual(81));

        }
    }
}
