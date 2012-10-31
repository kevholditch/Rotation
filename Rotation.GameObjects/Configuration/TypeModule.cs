using Autofac;
using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.StandardBoard;
using Rotation.GameObjects.Tiles;
using Rotation.GameObjects.Words;
using Module = Autofac.Module;

namespace Rotation.GameObjects.Configuration
{
    public class TypeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<StandardTileFactory>().As<ITileFactory>();

            //builder.RegisterType<StandardBoardFiller>().As<IBoardFiller>();
            builder.RegisterType<RiggedBoardFiller>().As<IBoardFiller>();

            builder.RegisterType<SingleAnimationStore>().As<IAnimationStore>().SingleInstance();

            builder.RegisterType<WordListFactory>().As<IWordListFactory>()
                .WithParameter(new NamedParameter("filename","Words/Words.txt"));
        }
    }

    
}
