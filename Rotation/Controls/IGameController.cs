using Microsoft.Xna.Framework;

namespace Rotation.Controls
{
    public interface IGameController
    {
        void SelectSquare(int x, int y);
        void MoveSelectionUp();
        void MoveSelectionDown();
        void MoveSelectionLeft();
        void MoveSelectionRight();
        void RotateRight();
        void RotateLeft();
        void Initialise();
    }

    public interface IGameControl
    {
        void UpdateControl(GameTime gameTime);
    }


    public class KeyboardGameControl : IGameControl
    {
 
        private readonly IGameController _gameController;

        public KeyboardGameControl(IGameController gameController)
        {
            _gameController = gameController;
            
        }

        public void UpdateControl(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }
    }
}