namespace Rotation.GameObjects.Events
{
    public class GameEventDispatcher : IGameEventDispatcher
    {
        private readonly IGameEventHandlerFactory _gameEventHandlerFactory;

        public GameEventDispatcher(IGameEventHandlerFactory gameEventHandlerFactory)
        {
            _gameEventHandlerFactory = gameEventHandlerFactory;
        }

        public void Dispatch<TGameEvent>(TGameEvent gameEvent) where TGameEvent : IGameEvent
        {
            foreach(var handler in _gameEventHandlerFactory.FetchHandlers(gameEvent))
                handler.Handle(gameEvent);
        }
    }

}