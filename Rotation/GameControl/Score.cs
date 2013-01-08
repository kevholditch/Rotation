namespace Rotation.GameControl
{
    public class Score : IScore
    {

        public Score(int currentScore, int squaresMade)
        {
            CurrentScore = currentScore;
            TotalSquaresMade = squaresMade;
        }

        public int CurrentScore { get; private set; }
        public int TotalSquaresMade { get; private set; }


    }
}