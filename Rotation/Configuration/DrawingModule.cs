using Autofac;
using Rotation.ItemDrawers;
using Rotation.ItemDrawers.Squares;
using Rotation.Textures;

namespace Rotation.Configuration
{
    public class DrawingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlankTileTextureCreator>().As<ITileTextureCreator>();
            builder.RegisterType<StandardTileTextureCreator>().As<ITileTextureCreator>();

            builder.RegisterType<SquareDrawer>().As<IItemDrawer>();
            


        }
    }
}
