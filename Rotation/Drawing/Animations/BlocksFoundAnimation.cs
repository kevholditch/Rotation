using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Rotation.Blocks;
using Rotation.Constants;
using Rotation.StandardBoard;
using System.Linq;

namespace Rotation.Drawing.Animations
{
    public class BlocksFoundAnimation : IAnimation
    {

        private double _elapsedTime = 0;
        private List<BoardCoordinate> _boardCoordinates;
        private readonly IBoard _board;

        public BlocksFoundAnimation(IEnumerable<Block> blocks, IBoard board)
        {
            _board = board;
            _boardCoordinates = new List<BoardCoordinate>();

            foreach (var boardCoordinate in blocks.SelectMany(b => b.BoardCoordinates))
            {
                _board[boardCoordinate].IsInBlock = true;
                _boardCoordinates.Add(boardCoordinate);
            }
        }

        public bool Finished()
        {
            return _elapsedTime >= GameConstants.Animation.BLOCK_FOUND_LIGHT_UP_DURATION;
        }

        public void Animate(GameTime gameTime)
        {
            _elapsedTime += gameTime.ElapsedGameTime.TotalMilliseconds;
        }

        public void OnFinished()
        {
            foreach (var boardCoordinate in _boardCoordinates)
                _board[boardCoordinate].IsInBlock = false;
        }
    }
}