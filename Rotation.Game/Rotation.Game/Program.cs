using System;

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
            using (RotationGame game = new RotationGame())
            {
                game.Run();
            }
        }
    }
#endif
}

