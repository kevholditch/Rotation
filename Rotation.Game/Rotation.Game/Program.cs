using System;
using Autofac;
using Autofac.Core;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;
using Microsoft.Xna.Framework.Graphics;
using Rotation.Drawing.Configuration;
using Rotation.Drawing.ItemDrawers;
using Rotation.Drawing.Textures;
using Rotation.GameObjects.Configuration;
using Rotation.GameObjects.Drawing;
using Rotation.GameObjects.Drawing.ItemAnimators;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Game
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            
            using(var container = new Builder().Build())
            {

                var childContainerBuilder = new ContainerBuilder();
                childContainerBuilder.RegisterInstance(container).As<IContainer>();
                childContainerBuilder.Update(container);

                using (var game = container.Resolve<RotationGame>())
                {
                    game.Run();
                }
            }
 
        }
    }
#endif
}

