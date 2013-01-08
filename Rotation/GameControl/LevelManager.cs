namespace Rotation.GameControl
{
    public class LevelManager : ILevelManager
    {
        
        private readonly INextLevel _nextLevel;
        public int Level { get; private set; }
        public int SquaresToNextLevel { get; private set; }

        public LevelManager(int level, INextLevel nextLevel)
        {
            Level = level;
            _nextLevel = nextLevel;
            SquaresToNextLevel = _nextLevel.AmountOfSquaresForLevelUp;
        }

        public void UpdateProgress(IScore score)
        {
            var totalSquaresForLevelUp = ((Level - 1)*_nextLevel.AmountOfSquaresForLevelUp) 
                + SquaresToNextLevel;

            if (totalSquaresForLevelUp > score.TotalSquaresMade)
            {
                SquaresToNextLevel = totalSquaresForLevelUp - score.TotalSquaresMade;
            }

        }
    }
}