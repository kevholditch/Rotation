namespace Rotation.GameControl
{
    public class Score : IScore
    {

        public Score(int currentScore, int squaresMade)
        {
            CurrentScore = currentScore;
            SquaresMade = squaresMade;
        }

        public int CurrentScore { get; private set; }
        public int SquaresMade { get; private set; }

    }

    public interface IScore
    {
        int CurrentScore { get; }
        int SquaresMade { get; }
    }

    public interface ILevelManager
    {
        int Level { get; }
        int SquaresToNextLevel { get; }
    }
}