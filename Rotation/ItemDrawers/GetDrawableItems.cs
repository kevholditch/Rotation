using System;
using System.Collections.Generic;
using Rotation.Drawing;
using Rotation.GameControl;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers
{
    public class GetDrawableItems : IGetDrawableItems
    {
        private readonly IBoard _board;
        private readonly IScoreManager _scoreManager;
        private readonly ILevelManager _levelManager;
        private readonly IRotationManager _rotationManager;

        public GetDrawableItems(IBoard board, IScoreManager scoreManager, ILevelManager levelManager, IRotationManager rotationManager)
        {
            _board = board;
            _scoreManager = scoreManager;
            _levelManager = levelManager;
            _rotationManager = rotationManager;
        }

        public IEnumerable<IDrawableItem> GetDrawables()
        {
            foreach (var square in _board.AllSquares())
                yield return square;

            yield return _scoreManager.GetScore();

            yield return _levelManager.Level;

            yield return _rotationManager.GetRotationInformation();
        }
    }
}
