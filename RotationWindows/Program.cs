
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;


namespace MonoRotation
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
     

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (var container = new Builder().Build())
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
}
