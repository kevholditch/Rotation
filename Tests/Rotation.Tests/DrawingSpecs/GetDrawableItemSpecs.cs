using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Rotation.Drawing;
using Rotation.GameControl;
using Rotation.ItemDrawers;
using Rotation.StandardBoard;
using SubSpec;

namespace Rotation.GameObjects.sTests.DrawingSpecs
{
    public class GetDrawableItemSpecs
    {
        [Specification]
        public void CanGetAllDrawableItems()
        {
            var getDrawableItems = default(IGetDrawableItems);
            var results = default(IEnumerable<IDrawableItem>);

            "Given I have a drawable item class with a full game"
                .Context(() =>
                    {
                        var fakeBoard = A.Fake<IBoard>();
                        var rows = new List<List<Square>>(){new List<Square>() {new Square(true, 0, 1)}};
                        A.CallTo(() => fakeBoard.Rows).Returns(rows);
                        var fakeScoreManager = A.Fake<IScoreManager>();
                        A.CallTo(() => fakeScoreManager.GetScore()).Returns(A.Fake<IScore>());
                        var fakeLevelManager = A.Fake<ILevelManager>();
                        A.CallTo(() => fakeLevelManager.Level).Returns(A.Fake<ILevel>());
                        getDrawableItems = new GetDrawableItems(fakeBoard, fakeScoreManager, fakeLevelManager);
                    });

            "When I get all of the drawable items"
                .Do(() => results = getDrawableItems.GetDrawables());

            "Then 3 items should be returned"
                .Observation(() => results.Count().ShouldEqual(3));

            "Then there should be 1 square"
                .Observation(() => results.OfType<Square>().Count().ShouldEqual(1));

            "Then there should be 1 score"
                .Observation(() => results.OfType<IScore>().Count().ShouldEqual(1));

            "Then there should be 1 level"
                .Observation(() => results.OfType<ILevel>().Count().ShouldEqual(1));
        }
    }
}
