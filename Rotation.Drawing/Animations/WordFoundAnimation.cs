using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rotation.GameObjects.Drawing.Animations;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.Drawing.Animations
{
    public class WordFoundAnimation : IAnimation
    {
        private bool _finished;
        private int _frameCount;
        private IEnumerable<BoardCoordinate> _boardCoordinates;
        private IBoard _board;

        public WordFoundAnimation(IEnumerable<BoardCoordinate> boardCoordinates, IBoard board)
        {
            _boardCoordinates = boardCoordinates;
            _board = board;
            _finished = false;
            _frameCount = 60;
        }

        public bool Finished()
        {
            return _finished;
        }

        public void Animate()
        {
            _frameCount--;

            if (_frameCount <= 0)
                _finished = true;
        }

        public void OnFinished()
        {
            throw new NotImplementedException();
        }
    }
}
