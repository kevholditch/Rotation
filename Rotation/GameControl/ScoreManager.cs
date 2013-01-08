using System.Collections.Generic;
using Rotation.Blocks;
using System.Linq;

namespace Rotation.GameControl
{
    public class ScoreManager : IScoreManager
    {

        private Score _score;

        public ScoreManager()
        {
            _score = new Score(0, 0);
        }

        public IScore GetScore()
        {
            return _score;
        }

        public void FoundBlock(IEnumerable<Block> blocksFound)
        {
            var squaresFound = blocksFound.SelectMany(b => b.BoardCoordinates).Count();

            _score = new Score(_score.CurrentScore + (squaresFound * blocksFound.Count()),
                               _score.TotalSquaresMade + squaresFound);

        }


    }
}