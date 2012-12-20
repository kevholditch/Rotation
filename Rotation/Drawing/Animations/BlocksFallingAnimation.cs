using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Rotation.Constants;
using Rotation.Events;
using Rotation.StandardBoard;

namespace Rotation.Drawing.Animations
{
    public class BlocksFallingAnimation : IAnimation
    {

        public List<BoardCoordinate> SquaresToAnimate { get; private set; }
    	private IBoard _board;	
		private bool _finished;

        public BlocksFallingAnimation(List<BoardCoordinate> squaresToAnimate, IBoard board)
        {
        	SquaresToAnimate = squaresToAnimate;
        	_board = board;
        	_finished = false;
        }


    	public bool Finished()
    	{
    		return SquaresToAnimate.Count == 0;
    	}

        public void Animate(GameTime gameTime)
        {
        	var squaresFinished = new List<BoardCoordinate>();

			foreach (var boardCoordinate in SquaresToAnimate)
			{
				var square = _board[boardCoordinate.X, boardCoordinate.Y];

				square.YOffset = (float)(square.YOffset - (GameConstants.Animation.BLOCK_FALL_SPEED * gameTime.ElapsedGameTime.TotalMilliseconds));

				if (square.YOffset <= 0)
				{
					square.YOffset = 0;	
					squaresFinished.Add(boardCoordinate);
				}
			}

			foreach (var square in squaresFinished)
				SquaresToAnimate.Remove(square);
        }

        public void OnFinished()
        {
            GameEvents.Raise(new BoardChangedEvent());
        }
    }
}