using Microsoft.Xna.Framework.Input;

namespace Rotation.Controls.Input
{
    public interface IKeyboardStateCollector
    {
        KeyboardState GetKeyboardState();
    }
}