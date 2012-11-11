using System.Collections.Generic;
using System.Linq;
using Rotation.Drawing;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingInterfaceSpecs
{
    public class GetAnimatableItemsFromBoardSpecs
    {
        [Specification]
        public void CanGetAnimatableItemsFromTheBoard()
        {
            var board = default(Board);
            var result = default(IEnumerable<IAnimatableItem>);

            "Given that I have a standard board board".Context(() =>

                                                              board = new BoardFactory().Create()
                );

            "When I get all drawable items".Do(() => result = board.GetAnimatables());

            "Then all of the animatable items returned should be squares".Observation(
                () => result.Count(i => i.GetType() != typeof (Square)).ShouldEqual(0));

            "Then 81 items should be returned".Observation(() => result.Count().ShouldEqual(81));

        }
    }
}
