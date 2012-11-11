using Autofac;
using Rotation.Drawing.Animations;
using Rotation.StandardBoard;
using Rotation.Tiles;
using Rotation.Words;

namespace Rotation.Configuration
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
