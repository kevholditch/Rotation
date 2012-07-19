using Autofac;
using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.Tiles;
using Module = Autofac.Module;

namespace Rotation.GameObjects.Configuration
{
    public class TypeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<StandardTileFactory>().As<ITileFactory>();

            builder.RegisterType<SingleAnimationStore>().As<IAnimationStore>().SingleInstance();
        }
    }

    
}
