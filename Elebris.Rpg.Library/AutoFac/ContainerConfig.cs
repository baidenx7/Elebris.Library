using Autofac;
using Elebris.Rpg.Library.CharacterSystems.UnitGeneration;
using Elebris.Rpg.Library.Creation.Units.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Elebris.Rpg.Library.AutoFac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<Application>();
            //Register all Builders
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Library)))
                .Where(t => t.Namespace.Contains("Builders"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }

    }
}
