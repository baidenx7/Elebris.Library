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
            RegisterAppStart<HomeViewModel>();
        }
    }
}
