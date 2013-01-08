using Autofac;
using Rotation.ItemDrawers;
using Rotation.ItemDrawers.Levels;
using Rotation.ItemDrawers.Scoring;
using Rotation.ItemDrawers.Squares;
using Rotation.Textures;

namespace Rotation.Configuration
{
    public class DrawingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BlankSquareTextureCreator>().As<ISquareTextureCreator>().SingleInstance();
            builder.RegisterType<StandardSquareTextureCreator>().As<ISquareTextureCreator>().SingleInstance();
            builder.RegisterType<SelectedSquareTextureCreator>().As<ISquareTextureCreator>().SingleInstance();

            builder.RegisterType<SquareDrawer>().As<IItemDrawer>();
            builder.RegisterType<ScoreDrawer>().As<IItemDrawer>();
            builder.RegisterType<LevelDrawer>().As<IItemDrawer>();
        }
    }
}
