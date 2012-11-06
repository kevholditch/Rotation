using Autofac;
using MonoRotation;
using Rotation.Drawing.Configuration;
 using Rotation.Drawing.ItemDrawers;
 using Rotation.Drawing.Textures;
 using Rotation.GameObjects.Configuration;
 using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Events;
 using Rotation.GameObjects.StandardBoard;

namespace Rotation.Game
{
    public class Builder
    {
        public IContainer Build()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new InterfaceConventionModule(new[] { typeof(IItemDrawer).Assembly, typeof(IBoard).Assembly }));
            containerBuilder.RegisterModule(new TypeModule());
            containerBuilder.RegisterModule(new DrawingModule());
            containerBuilder.RegisterModule(new EventsInstaller(new[]{ typeof(IGameEvent).Assembly}));
            containerBuilder.Register(c => new BoardFactory().Create())
                        .As<IBoard>()
                        .As<IGetMainSelectedSquare>()
                        .As<IGetAnimatableItems>()
                        .SingleInstance();

            containerBuilder.RegisterType<RotationGame>().AsSelf().As<ITextureLoader>().SingleInstance();

            return containerBuilder.Build();
        }
    }
}
