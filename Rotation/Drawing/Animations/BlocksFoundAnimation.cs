using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Rotation.Blocks;

namespace Rotation.Drawing.Animations
{
    public class BlocksFoundAnimation : IAnimation
    {

        public IEnumerable<Block> Blocks { get; private set; }

        public BlocksFoundAnimation(IEnumerable<Block> blocks)
        {
            Blocks = blocks;
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