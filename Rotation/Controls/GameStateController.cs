using Microsoft.Xna.Framework;
using Rotation.Controls.Input;

namespace Rotation.Controls
{
    public class GameStateController : IGameStateController
    {

        private readonly IGameController _gameController;
        private readonly IGameInputCollector _gameInputCollector;

        public GameStateController(IGameController gameController, IGameInputCollector gameInputCollector)
        {
            _gameController = gameController;
            _gameInputCollector = gameInputCollector;
        }

        public void Initialise()
        {
            _gameController.Initialise();
        }

        public void Update(GameTime gameTime)
        {
            var action = _gameInputCollector.Collect();

            if (action != null)
            {
                var actionToRun = action.Compile();
                actionToRun(_gameController);
            }
        }
    }
}