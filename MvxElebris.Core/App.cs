using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxElebris.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxElebris.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //CreatableTypes()
            //    .EndingWith("Service")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();

            //CreatableTypes()
            //    .EndingWith("Client")
            //    .AsInterfaces()
            //    .RegisterAsLazySingleton();

            //Mvx.IoCProvider.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

            // register the appstart object
            RegisterCustomAppStart<AppStart>();
        }
    }
}
