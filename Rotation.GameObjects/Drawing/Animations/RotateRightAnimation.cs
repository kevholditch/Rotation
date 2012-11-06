using System.Collections.Generic;
using Rotation.GameObjects.Constants;
using Rotation.GameObjects.Events;
using Rotation.GameObjects.StandardBoard;

namespace Rotation.GameObjects.Drawing.Animations
{
    public class RotateRightAnimation : IAnimation
    {
        private readonly IEnumerable<BoardCoordinate> _boardCoordinates;
        private readonly IBoard _board;
        private bool _finished;

        public RotateRightAnimation(IEnumerable<BoardCoordinate> boardCoordinates, IBoard board)
        {
            _boardCoordinates = boardCoordinates;
            _board = board;
            _finished = false;

            foreach (var boardCoordinate in _boardCoordinates)
                _board[boardCoordinate.X, boardCoordinate.Y].Angle = -90;
 
        }

        public bool Finished()
        {
            return _finished;
        }

        public void Animate()
        {
            foreach (var boardCoordinate in _boardCoordinates)
            {
                var square = _board[boardCoordinate.X, boardCoordinate.Y];

                square.Angle = square.Angle + GameConstants.Animation.ANGLE_INCREASE_RATE;

                if (square.Angle >= 0)
                {
                    square.Angle = 0;
                    _finished = true;
                }
            }
        }

        public void OnFinished()
        {
            GameEvents.Raise(new BoardChangedEvent());
        }
    }
}