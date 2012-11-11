namespace Rotation.Events
{
    public interface IGameEventDispatcher
    {
        void Dispatch<TGameEvent>(TGameEvent gameEvent) where TGameEvent : IGameEvent;
    }
}
