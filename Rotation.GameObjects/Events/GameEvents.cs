namespace Rotation.GameObjects.Events
{
    public static class GameEvents
    {
        public static IGameEventDispatcher Dispatcher { get; set; }

        public static void Raise(IGameEvent gameEvent)
        {
            Dispatcher.Dispatch(gameEvent);
        }
    }
}