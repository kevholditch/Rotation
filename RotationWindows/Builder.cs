using Autofac;
using Rotation.Configuration;
using Rotation.Drawing;
using Rotation.Events;
using Rotation.ItemDrawers;
using Rotation.StandardBoard;
using Rotation.Textures;

namespace MonoRotation
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
                        .As<IGetDrawableItems>()
                        .SingleInstance();

            containerBuilder.RegisterType<RotationGame>().AsSelf().As<ITextureLoader>().SingleInstance();

            return containerBuilder.Build();
        }
    }
}
