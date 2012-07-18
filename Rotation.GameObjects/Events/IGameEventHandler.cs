namespace Rotation.GameObjects.Events
{
    public interface IGameEventHandler<in T> where T : IGameEvent
    {
        void Handle(T gameEvent);
    }
}