namespace Rotation.GameControl
{
    public interface IScore
    {
        int CurrentScore { get; }
        int TotalSquaresMade { get; }
    }
}