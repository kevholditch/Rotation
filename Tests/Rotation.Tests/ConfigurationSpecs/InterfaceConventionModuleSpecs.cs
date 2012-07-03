using System;
using Autofac;
using Autofac.Core.Registration;
using Rotation.GameObjects.Configuration;
using SubSpec;
using Rotation.Tests.Common;
using Xunit;

namespace Rotation.GameObjects.sTests.ConfigurationSpecs
{
    public class InterfaceConventionModuleSpecs
    {
        [Specification]
        public void CanCorrectlyInstallAClassByConvention()
        {
            var container = default(IContainer);
            var result = default (ITest);

            "Given I have installed the instant convention installer with this assembly".Context(() =>
                 {
                    var containerBuilder = new ContainerBuilder();
                    containerBuilder
                        .RegisterModule(new InterfaceConventionModule(new[] { typeof(ITest).Assembly }));
                     container = containerBuilder.Build();
                 });

            "When I resolve an ITest interface".Do(() => result = container.Resolve<ITest>());

            "Then the returned type should be a Test class".Observation(() => result.ShouldBeOfType<Test>());
        }

        [Specification]
        public void CanCorrectlyDetermineAClassThatIsNotImplementedByConvention()
        {
            var container = default(IContainer);
            var result = default(Exception);

            "Given I have installed the instant convention installer with this assembly".Context(() =>
            {
                var containerBuilder = new ContainerBuilder();
                containerBuilder
                    .RegisterModule(new InterfaceConventionModule(new[] { typeof(ITest).Assembly }));
                container = containerBuilder.Build();
            });

            "When I resolve an IRandomInterface interface".Do(() => result = Record.Exception(() => container.Resolve<IRandomInterface>()));

            "Then a component not registered exception should be thrown"
                .Observation(() => result.ShouldBeOfType<ComponentNotRegisteredException>());
        }

    }

    public interface ITest { }

    public class Test : ITest { }

    public interface IRandomInterface { }

    public class SomeTestClass : IRandomInterface { }

}
