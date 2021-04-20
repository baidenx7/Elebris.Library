using Autofac;
using Elebris.Rpg.Library.Project_Setup.Logic;
using System.Linq;
using System.Reflection;

namespace Elebris.Rpg.Library.AutoFac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //store definitions

            builder.RegisterType<Application>();
            builder.RegisterType<UnitLogic>().As<IUnitLogic>();
            //Register all Builders
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library)))
                .Where(t => t.Namespace.Contains("Creation"))
                //could do .Where(t => t.Name.Contains("Factory"))//Builder
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
           
            return builder.Build();
        }

    }
}
