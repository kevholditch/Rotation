using System.Collections.Generic;
using FakeItEasy;
using Microsoft.Xna.Framework.Graphics;
using Rotation.StandardBoard;
using Rotation.Textures;
using Rotation.Tiles;
using SubSpec;

namespace Rotation.GameObjects.sTests.FactorySpecs
{
    public class SquareTextureFactorySpecs
    {
        [Specification]
        public void CanCreateTheCorrectTileTextureCreator()
        {
            var tileTextureFactory = default(TileTextureFactory);
            var result = default(ISquareTextureCreator);

            "Given I have a square texture factory with a test texture creator installed".Context(
                () =>
                tileTextureFactory =
                new TileTextureFactory(new List<ISquareTextureCreator> {new TestSquareTextureCreator()}));

            "When I call create passing in a test square".Do(
                () => result = tileTextureFactory.Create(new Square(true, 1, 1)));

            "Then a TestSquareTextureCreator should be returned".Observation(
                () => result.ShouldBeOfType<TestSquareTextureCreator>());

        }

        [Specification]
        public void CanCreateABlankTileTextureCreator()
        {
            var tileTextureFactory = default(TileTextureFactory);
            var result = default(ISquareTextureCreator);

            "Given I have a square texture factory with a blank square texture creator installed".Context(
                () =>
                tileTextureFactory =
                new TileTextureFactory(new List<ISquareTextureCreator>
                                           {new BlankSquareTextureCreator()})
                );

            "When I call create passing in no square".Do(() => result = tileTextureFactory.Create(new Square(false, 1, 1)));

            "Then a BlankSquareTextureCreator should be returned".Observation(
                () => result.ShouldBeOfType<BlankSquareTextureCreator>());


        }

        public class TestTile : Tile
        {
            public TestTile(int colour) : base(colour)
            {
            }
        }

        public class TestSquareTextureCreator : ISquareTextureCreator
        {
            public bool CanCreateTexture(Square square)
            {
                return true;
            }

            public Texture2D Create(Square tile)
            {
                return null;
            }
        }

    }
}