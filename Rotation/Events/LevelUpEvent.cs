namespace Rotation.Events
{
    public class LevelUpEvent : IGameEvent
    {
        public LevelUpEvent(int oldLevel, int newLevel)
        {
            OldLevel = oldLevel;
            NewLevel = newLevel;
        }

        public int OldLevel { get; private set; }
        public int NewLevel { get; private set; }
    }
}