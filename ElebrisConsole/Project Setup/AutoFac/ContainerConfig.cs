using Autofac;
using System.Linq;
using System.Reflection;
using Elebris.Library.Units;
using System;

namespace Elebris
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
        
            var builder = new ContainerBuilder();
            ////store definitions

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<UnitLogic>().As<IUnitLogic>();

            //Could not load file or assembly 'Units, Culture=neutral, PublicKeyToken=null'. The system cannot find the file specified.
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library.Units)))
                .Where(t => t.Namespace.Contains("Creation"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            //could do .Where(t => t.Name.Contains("Factory"))//Builder

            return builder.Build();
        }
    }
}
