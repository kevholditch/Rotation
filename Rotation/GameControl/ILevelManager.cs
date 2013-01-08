namespace Rotation.GameControl
{
    public interface ILevelManager
    {
        int Level { get; }
        int SquaresToNextLevel { get; }
        void UpdateProgress(IScore score);
    }
}