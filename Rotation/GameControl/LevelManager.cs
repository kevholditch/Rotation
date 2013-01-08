using Rotation.Events;

namespace Rotation.GameControl
{
    public class LevelManager : ILevelManager
    {
        
        private readonly INextLevel _nextLevel;
        public ILevel Level { get; private set; }

        public LevelManager(ILevel level, INextLevel nextLevel)
        {
            Level = level;
            _nextLevel = nextLevel;
            Level.SquaresToNextLevel = _nextLevel.AmountOfSquaresForLevelUp;
        }

        public void UpdateProgress(IScore score)
        {
            var totalSquaresForLevelUp = ((Level.CurrentLevel - 1)*_nextLevel.AmountOfSquaresForLevelUp) 
                + Level.SquaresToNextLevel;

            if (totalSquaresForLevelUp > score.TotalSquaresMade)
            {
                Level.SquaresToNextLevel = totalSquaresForLevelUp - score.TotalSquaresMade;
            }
            else
            {
                var tempTotalSquaresMade = score.TotalSquaresMade;

                while (tempTotalSquaresMade >= _nextLevel.AmountOfSquaresForLevelUp)
                {
                    tempTotalSquaresMade -= _nextLevel.AmountOfSquaresForLevelUp;
                    Level.CurrentLevel++;
                    GameEvents.Raise(new LevelUpEvent(Level.CurrentLevel - 1, Level.CurrentLevel));
                }

                Level.SquaresToNextLevel = _nextLevel.AmountOfSquaresForLevelUp - tempTotalSquaresMade;
            }

        }
    }
}