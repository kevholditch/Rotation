using System.Collections.Generic;
using Rotation.Blocks;

namespace Rotation.GameControl
{
    public class GameManager : IGameManager
    {

        private readonly IRotationManager _rotationManager;
        private readonly ILevelManager _levelManager;
        private readonly IScoreManager _scoreManager;

        public GameManager(IRotationManager rotationManager, ILevelManager levelManager, IScoreManager scoreManager)
        {
            _rotationManager = rotationManager;
            _levelManager = levelManager;
            _scoreManager = scoreManager;
        }

        public void RotationMade()
        {
            _rotationManager.RotationMade();
        }

        public void BlockFound(IEnumerable<Block> blocks)
        {
            _rotationManager.BlocksFound(blocks);
            _scoreManager.BlocksFound(blocks);
            _levelManager.UpdateProgress(_scoreManager.GetScore());
        }

    }
}