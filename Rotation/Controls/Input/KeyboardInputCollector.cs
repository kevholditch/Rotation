using System;
using System.Linq.Expressions;
using Microsoft.Xna.Framework.Input;

namespace Rotation.Controls.Input
{
    public class KeyboardInputCollector : IGameInputCollector
    {
        private KeyboardState _oldkeyboardState;
        private readonly IKeyboardStateCollector _keyboardStateCollector;

        public KeyboardInputCollector(IKeyboardStateCollector keyboardStateCollector)
        {
            _keyboardStateCollector = keyboardStateCollector;
        }

        public Expression<Action<IGameController>> Collect()
        {
            var currentKeyboardState = _keyboardStateCollector.GetKeyboardState();

            if (currentKeyboardState.IsKeyDown(Keys.Down) && !_oldkeyboardState.IsKeyDown(Keys.Down))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.MoveSelectionDown();
            }

            if (currentKeyboardState.IsKeyDown(Keys.Right) && !_oldkeyboardState.IsKeyDown(Keys.Right))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.MoveSelectionRight();
            }

            if (currentKeyboardState.IsKeyDown(Keys.Up) && !_oldkeyboardState.IsKeyDown(Keys.Up))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.MoveSelectionUp();
            }

            if (currentKeyboardState.IsKeyDown(Keys.Left) && !_oldkeyboardState.IsKeyDown(Keys.Left))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.MoveSelectionLeft();
            }

            if (currentKeyboardState.IsKeyDown(Keys.A) && !_oldkeyboardState.IsKeyDown(Keys.A))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.RotateLeft();
            }

            if (currentKeyboardState.IsKeyDown(Keys.S) && !_oldkeyboardState.IsKeyDown(Keys.S))
            {
                _oldkeyboardState = currentKeyboardState;
                return c => c.RotateRight();
            }

            return null;
        }
    }
}