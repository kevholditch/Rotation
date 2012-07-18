namespace Rotation.GameObjects.Events
{
    public interface IGameEventDispatcher
    {
        void Dispatch(IGameEvent gameEvent);
    }
}
