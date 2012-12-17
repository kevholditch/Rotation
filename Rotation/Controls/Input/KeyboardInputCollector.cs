using System;
using System.Linq.Expressions;
using Microsoft.Xna.Framework.Input;

namespace Rotation.Controls.Input
{
    public class KeyboardInputCollector : IGameInputCollector
    {
        private KeyboardState _oldkeyboardState;
        private readonly IKeyboardStateCollector _keyboardStateCollector;
    	private readonly IGameController _gameController;

        public KeyboardInputCollector(IKeyboardStateCollector keyboardStateCollector, IGameController gameController)
        {
        	_keyboardStateCollector = keyboardStateCollector;
        	_gameController = gameController;
        }

    	public ICommand Collect()
        {
            var currentKeyboardState = _keyboardStateCollector.GetKeyboardState();

            if (currentKeyboardState.IsKeyDown(Keys.Down) && !_oldkeyboardState.IsKeyDown(Keys.Down))
            {
                _oldkeyboardState = currentKeyboardState;
                return new MoveDownCommand(_gameController);
            }

            if (currentKeyboardState.IsKeyDown(Keys.Right) && !_oldkeyboardState.IsKeyDown(Keys.Right))
            {
                _oldkeyboardState = currentKeyboardState;
                return new MoveRightCommand(_gameController);
            }

            if (currentKeyboardState.IsKeyDown(Keys.Up) && !_oldkeyboardState.IsKeyDown(Keys.Up))
            {
                _oldkeyboardState = currentKeyboardState;
                return new MoveUpCommand(_gameController);
            }

            if (currentKeyboardState.IsKeyDown(Keys.Left) && !_oldkeyboardState.IsKeyDown(Keys.Left))
            {
                _oldkeyboardState = currentKeyboardState;
                return new MoveLeftCommand(_gameController);
            }

            if (currentKeyboardState.IsKeyDown(Keys.A) && !_oldkeyboardState.IsKeyDown(Keys.A))
            {
                _oldkeyboardState = currentKeyboardState;
                return new RotateLeftCommand(_gameController);
            }

            if (currentKeyboardState.IsKeyDown(Keys.S) && !_oldkeyboardState.IsKeyDown(Keys.S))
            {
                _oldkeyboardState = currentKeyboardState;
                return new RotateRightCommand(_gameController);
            }

            _oldkeyboardState = currentKeyboardState;
            return null;
        }
    }

	public interface ICommand
	{
		void Execute();
	}

	public class MoveUpCommand : ICommand
	{
		private readonly IGameController _gameController;

		public MoveUpCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.MoveSelectionUp();
		}
	}

	public class MoveDownCommand : ICommand
	{
		private readonly IGameController _gameController;

		public MoveDownCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.MoveSelectionDown();
		}
	}

	public class MoveLeftCommand : ICommand
	{
		private readonly IGameController _gameController;

		public MoveLeftCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.MoveSelectionLeft();
		}
	}

	public class MoveRightCommand : ICommand
	{
		private readonly IGameController _gameController;

		public MoveRightCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.MoveSelectionRight();
		}
	}

	public class RotateRightCommand : ICommand
	{
		private readonly IGameController _gameController;

		public RotateRightCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.RotateRight();
		}
	}

	public class RotateLeftCommand : ICommand
	{
		private readonly IGameController _gameController;

		public RotateLeftCommand(IGameController gameController)
		{
			_gameController = gameController;
		}

		public void Execute()
		{
			_gameController.RotateLeft();
		}
	}
}