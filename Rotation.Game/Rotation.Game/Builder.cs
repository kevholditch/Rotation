 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using Autofac;
 using Rotation.Drawing.Configuration;
 using Rotation.Drawing.ItemDrawers;
 using Rotation.GameObjects.Configuration;
 using Rotation.GameObjects.Drawing;
 using Rotation.GameObjects.Drawing.ItemAnimators;
 using Rotation.GameObjects.StandardBoard;

namespace Rotation.Game
{
    public class Builder
    {
        public IContainer Build()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new InterfaceConventionModule(new[] { typeof(IItemDrawer).Assembly, typeof(IItemAnimator).Assembly }));
            containerBuilder.RegisterModule(new TypeModule());
            containerBuilder.RegisterModule(new DrawingModule());
            containerBuilder.Register(c => new BoardFactory().Create())
                        .As<IBoard>()
                        .As<IGetMainSelectedSquare>()
                        .As<IGetAnimatableItems>()
                        .SingleInstance();

            containerBuilder.RegisterType<RotationGame>();

            return containerBuilder.Build();
        }
    }
}
