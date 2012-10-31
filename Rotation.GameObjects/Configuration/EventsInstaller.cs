using System;
using System.Reflection;
using Autofac;
using Rotation.GameObjects.Events;
using Module = Autofac.Module;
using System.Linq;

namespace Rotation.GameObjects.Configuration
{
    public class EventsInstaller : Module
    {

        private readonly Assembly[] _assemblies;

        public EventsInstaller(Assembly[] assemblies)
        {
            _assemblies = assemblies;
        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(_assemblies).Where(
                t => t.IsAssignableTo<IGameEvent>()).AsSelf();

            builder.RegisterAssemblyTypes(_assemblies).Where(
                t => t.GetInterfaces().Where(i => i.IsGenericType)
                    .Select(i => i.GetGenericTypeDefinition()).Contains(typeof (IGameEventHandler<>)))
                .AsImplementedInterfaces();
        }
    }
}