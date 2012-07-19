using Autofac;

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

