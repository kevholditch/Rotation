using Autofac;
using Rotation.GameObjects.Drawing.ItemAnimators;
using Rotation.GameObjects.Tiles;
using Module = Autofac.Module;

namespace Rotation.GameObjects.Configuration
{
    public class TypeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RotationAnimator>().As<IItemAnimator>();

            builder.RegisterType<StandardTileFactory>().As<ITileFactory>();
        }
    }
}
