using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing;
using Rotation.ItemDrawers;
using SubSpec;

namespace Rotation.GameObjects.sTests.FactorySpecs
{
    public class ItemDrawerFactorySpecs
    {
        [Specification]
        public void CanCorrectlyCreateItemDrawerFactory()
        {
            var itemDrawerFactory = default(ItemDrawerFactory);
            var result = default(IItemDrawer);

            "Given I have a item drawerer factory with a test item drawerer factory registered".Context(() =>
                itemDrawerFactory = new ItemDrawerFactory(new List<IItemDrawer>{ new TestItemDrawer()})
                );

            "When I create the factory for a TestDrawableItem".Do(
                () => result = itemDrawerFactory.Create(new TestDrawableItem()));

            "Then a TestItemDrawer should be returned".Observation(() => result.ShouldBeOfType<TestItemDrawer>());
        }


        internal class TestDrawableItem : IAnimatableItem
        {

        }

        internal class TestItemDrawer : ItemDrawerBase<TestDrawableItem>
        {
            protected override void DrawImp(SpriteBatch spriteBatch, TestDrawableItem drawableItem)
            {
                
            }

            
        }

        
    }
}
