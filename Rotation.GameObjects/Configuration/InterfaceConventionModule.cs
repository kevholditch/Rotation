using System.Linq;
using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace Rotation.GameObjects.Configuration
{
    public class InterfaceConventionModule : Module
    {

        private readonly Assembly[] _assemblies;

        public InterfaceConventionModule(Assembly[] assemblies)
        {
            _assemblies = assemblies;
        }


        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(_assemblies)
                .Where(t => t.GetInterfaces().Any(i => i.Name.TrimFirstChar('I').Equals(t.Name)))
                .AsImplementedInterfaces();
    
        }
    }

    public static class StringExtensions
    {
        public static string TrimFirstChar(this string str, char chr)
        {
            return str[0] == chr ? str.Substring(1) : str;
        }
    }
}
