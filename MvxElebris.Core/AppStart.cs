using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxElebris.Core.Helpers;
using MvxElebris.Core.ViewModels;
using System.Threading.Tasks;

namespace MvxElebris.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication app, IMvxNavigationService mvxNavigationService)
            : base(app, mvxNavigationService)
        {
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            //Mvx.IoCProvider.RegisterSingleton<IApiHelper>(new ApiHelper());//create singleton for <IApiHelper, ApiHelper>? one per app, one per page? comparable to the simplecontainer from caliburn https://www.mvvmcross.com/documentation/fundamentals/inversion-of-control-ioc
           
            
            return NavigationService.Navigate<ShellViewModel>();


        }
    }
}
