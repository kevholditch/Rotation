using System;
using System.Collections.Generic;
using Rotation.Drawing;
using Rotation.GameControl;
using Rotation.StandardBoard;

namespace Rotation.ItemDrawers
{
    public class GetDrawableItems : IGetDrawableItems
    {
        private IBoard _board;
        private IScoreManager _scoreManager;
        private ILevelManager _levelManager;

        public GetDrawableItems(IBoard board, IScoreManager scoreManager, ILevelManager levelManager)
        {
            _board = board;
            _scoreManager = scoreManager;
            _levelManager = levelManager;
        }

        public IEnumerable<IDrawableItem> GetDrawables()
        {
            foreach (var square in _board.AllSquares())
                yield return square;

            yield return _scoreManager.GetScore();

            yield return _levelManager.Level;
        }
    }
}
