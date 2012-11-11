using System.Collections.Generic;

namespace Rotation.Events
{
    public interface IGameEventHandlerFactory
    {
        IEnumerable<IGameEventHandler<T>> FetchHandlers<T>(T gameEvent) where T : IGameEvent;
    }
}