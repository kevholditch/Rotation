namespace Rotation.GameControl
{
    public class LevelManager : ILevelManager
    {
        public int Level { get; private set; }
        public int SquaresToNextLevel { get; private set; }

        public LevelManager(int level, int squaresToNextLevel)
        {
            Level = level;
            SquaresToNextLevel = squaresToNextLevel;
        }

    }
}