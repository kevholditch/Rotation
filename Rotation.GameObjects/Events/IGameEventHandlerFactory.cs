using System.Collections.Generic;

namespace Rotation.GameObjects.Events
{
    public interface IGameEventHandlerFactory
    {
        IEnumerable<IGameEventHandler<T>> FetchHandlers<T>(T gameEvent) where T : IGameEvent;
    }
}