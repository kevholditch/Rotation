using Autofac;
using Rotation.Controls.Input;

namespace Rotation.Configuration
{
    public class KeyboardInputModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<KeyboardInputCollector>().As<IGameInputCollector>().SingleInstance();

        }
    }
}