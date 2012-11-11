using System.Collections.Generic;
using Autofac;

namespace Rotation.Events
{
    public class GameEventHandlerFactory : IGameEventHandlerFactory
    {
        private readonly ILifetimeScope _lifetimeScope;

        public GameEventHandlerFactory(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
        }

        public IEnumerable<IGameEventHandler<T>> FetchHandlers<T>(T gameEvent) where T : IGameEvent
        {
            return _lifetimeScope.Resolve<IEnumerable<IGameEventHandler<T>>>();
        }
    }
}