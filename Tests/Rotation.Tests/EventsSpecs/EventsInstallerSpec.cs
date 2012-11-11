using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Autofac;
using Rotation.Configuration;
using Rotation.Events;
using SubSpec;

namespace Rotation.GameObjects.sTests.EventsSpecs
{
    public class EventsInstallerSpec
    {
        [Specification]
        public void CanInstallAnEventWithASingleEventHanlder()
        {

            var container = default(IContainer);
            var result = default(IEnumerable<IGameEventHandler<SingleGameTestEvent>>);

            "Given I have installed the game events installer".Context(() =>
                        {
                            var builder = new ContainerBuilder();
                            builder.RegisterModule(
                                new EventsInstaller(new[] { typeof (SingleGameTestEventHandler).Assembly}));

                            container = builder.Build();
                        });

            "When I resolve an enumerable of handlers for single game test event".Do(
                () => result = container.Resolve<IEnumerable<IGameEventHandler<SingleGameTestEvent>>>());

            "Then 1 handler should be returned".Observation(() => result.Count().ShouldEqual(1));

        }

        [Specification]
        public void CanInstallAnEventWithMulitpleEventHanlders()
        {

            var container = default(IContainer);
            var result = default(IEnumerable<IGameEventHandler<MultipleGameTestEvent>>);

            "Given I have installed the game events installer".Context(() =>
            {
                var builder = new ContainerBuilder();
                builder.RegisterModule(
                    new EventsInstaller(new[] { typeof(SingleGameTestEventHandler).Assembly }));
                container = builder.Build();
            });

            "When I resolve an enumerable of handlers for single game test event".Do(
                () => result = container.Resolve<IEnumerable<IGameEventHandler<MultipleGameTestEvent>>>());

            "Then 2 handlers should be returned".Observation(() => result.Count().ShouldEqual(2));

        }

        public class MultipleGameTestEvent : IGameEvent
        {
            
        }

        public class TestEventHandler : IGameEventHandler<MultipleGameTestEvent>
        {
            public void Handle(MultipleGameTestEvent gameEvent)
            {
            }
        }

        public class TestEventHandler2 : IGameEventHandler<MultipleGameTestEvent>
        {
            public void Handle(MultipleGameTestEvent gameEvent)
            {
            }
        }

        public class SingleGameTestEvent : IGameEvent
        {   
        }

        public class SingleGameTestEventHandler : IGameEventHandler<SingleGameTestEvent>
        {
            public void Handle(SingleGameTestEvent gameEvent)
            {
            }
        }
        
    }
}
