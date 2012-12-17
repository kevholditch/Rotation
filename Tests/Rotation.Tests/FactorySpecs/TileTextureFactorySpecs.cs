using System.Collections.Generic;
using FakeItEasy;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Textures;
using Rotation.Tiles;
using SubSpec;

namespace Rotation.GameObjects.sTests.FactorySpecs
{
    public class TileTextureFactorySpecs
    {
        [Specification]
        public void CanCreateTheCorrectTileTextureCreator()
        {
            var tileTextureFactory = default(TileTextureFactory);
            var result = default(ITileTextureCreator);

            "Given I have a tile texture factory with a test texture creator installed".Context(
                () =>
                tileTextureFactory =
                new TileTextureFactory(new List<ITileTextureCreator> {new TestTileTextureCreator()}));

            "When I call create passing in a test tile".Do(
                () => result = tileTextureFactory.Create(new TestTile(1)));

            "Then a TestTileTextureCreator should be returned".Observation(
                () => result.ShouldBeOfType<TestTileTextureCreator>());

        }

        [Specification]
        public void CanCreateABlankTileTextureCreator()
        {
            var tileTextureFactory = default(TileTextureFactory);
            var result = default(ITileTextureCreator);

            "Given I have a tile texture factory with a blank tile texture creator installed".Context(
                () =>
                tileTextureFactory =
                new TileTextureFactory(new List<ITileTextureCreator>
                                           {new BlankTileTextureCreator(A.Fake<ITextureLoader>())})
                );

            "When I call create passing in null".Do(() => result = tileTextureFactory.Create(null));

            "Then a BlankTileTextureCreator should be returned".Observation(
                () => result.ShouldBeOfType<BlankTileTextureCreator>());


        }

        public class TestTile : Tile
        {
            public TestTile(int colour) : base(colour)
            {
            }
        }

        public class TestTileTextureCreator : BaseTileTextureCreator<TestTile>
        {
            
            protected override Texture2D CreateImp(Tile tile)
            {
                return null;
            }
        }

    }
}