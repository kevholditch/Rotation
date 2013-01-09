using Autofac;
using Rotation.Controls;
using Rotation.Drawing.Animations;
using Rotation.GameControl;
using Rotation.StandardBoard;
using Rotation.StandardBoard.Selection;
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

            builder.RegisterType<SingleSquareSelector>().As<ISquareSelector>();

            builder.RegisterType<LevelManager>().As<ILevelManager>().SingleInstance();

            builder.RegisterType<ScoreManager>().As<IScoreManager>().SingleInstance();

            builder.RegisterType<Level>().As<ILevel>().SingleInstance();

            builder.RegisterType<RotationManager>().As<IRotationManager>().SingleInstance();

        }
    }
}
