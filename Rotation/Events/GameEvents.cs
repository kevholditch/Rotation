namespace Rotation.Events
{
    public static class GameEvents
    {
        public static IGameEventDispatcher Dispatcher { get; set; }

        public static void Raise<TGameEvent>(TGameEvent gameEvent) where TGameEvent : IGameEvent
        {
            Dispatcher.Dispatch(gameEvent);
        }
    }
}