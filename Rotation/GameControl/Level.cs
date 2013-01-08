namespace Rotation.GameControl
{
    public class Level : ILevel
    {
        public int CurrentLevel { get;  set; }
        public int SquaresToNextLevel { get; set; }

        public Level(int currentLevel)
        {
            CurrentLevel = currentLevel;
        }
    }
}