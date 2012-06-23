using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.ItemDrawers;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.Drawing;
using Rotation.Tests.Common;
using SubSpec;

namespace Rotation.Drawing.Tests.FactorySpecs
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


        internal class TestDrawableItem : IDrawableItem
        {

        }

        internal class TestItemDrawer : ItemDrawerBase<TestDrawableItem>
        {
            protected override void DrawImp(SpriteBatch spriteBatch, ITextureLoader textureLoader, TestDrawableItem drawableItem)
            {
                
            }
        }

        
    }
}
