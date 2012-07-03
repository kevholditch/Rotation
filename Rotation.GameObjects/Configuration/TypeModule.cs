using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using Rotation.GameObjects.Drawing.ItemAnimators;
using Rotation.GameObjects.Tiles;

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
