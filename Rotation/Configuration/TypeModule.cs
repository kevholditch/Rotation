using Autofac;
using Rotation.Controls;
using Rotation.Drawing.Animations;
using Rotation.StandardBoard;
using Rotation.Tiles;

namespace Rotation.Configuration
{
    public class TypeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<StandardTileFactory>().As<ITileFactory>();
            
            builder.RegisterType<StandardBoardFiller>().As<IBoardFiller>();

            builder.RegisterType<SingleAnimationStore>().As<IAnimationStore>().SingleInstance();

            builder.RegisterType<GameController>().As<IGameController>().SingleInstance();

            builder.RegisterType<GameStateController>().As<IGameStateController>().SingleInstance();
        }
    }
}
