namespace Rotation.GameControl
{
    public interface ILevelManager
    {
        ILevel Level { get;  }
        void UpdateProgress(IScore score);
    }
}