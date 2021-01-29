using MvvmCross.Navigation;
using MvvmCross.ViewModels;
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
            return NavigationService.Navigate<ShellViewModel>();
            //create singleton for <IApiHelper, ApiHelper>? one per app, one per page?
        }
    }
}
