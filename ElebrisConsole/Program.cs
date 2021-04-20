
using Autofac;
using Elebris.Rpg.Library.AutoFac;
using System;

namespace ElebrisConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}
