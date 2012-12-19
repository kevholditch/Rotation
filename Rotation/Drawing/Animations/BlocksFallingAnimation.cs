using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Rotation.StandardBoard;

namespace Rotation.Drawing.Animations
{
    public class BlocksFallingAnimation : IAnimation
    {

        public List<BoardCoordinate> SquaresToAnimate { get; private set; }


        public BlocksFallingAnimation(List<BoardCoordinate> squaresToAnimate)
        {
            SquaresToAnimate = squaresToAnimate;
        }


        public bool Finished()
        {
            throw new System.NotImplementedException();
        }

        public void Animate(GameTime gameTime)
        {
            throw new System.NotImplementedException();
        }

        public void OnFinished()
        {
            throw new System.NotImplementedException();
        }
    }
}