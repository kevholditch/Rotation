using Microsoft.Xna.Framework.Input;

namespace Rotation.Controls.Input
{
    public class KeyboardStateCollector : IKeyboardStateCollector
    {
        public KeyboardState GetKeyboardState()
        {
            return Keyboard.GetState();
        }
    }
}