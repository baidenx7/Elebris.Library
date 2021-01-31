using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using System.Threading.Tasks;

namespace MvxElebris.Core.ViewModels
{
    //caliburn uses conductor<object>
    public class ShellViewModel : MvxViewModel
    {
        private IMvxViewDispatcher _dispatcher;
        public ShellViewModel(IMvxViewDispatcher dispatcher)
        {
            _dispatcher = dispatcher;

            var home = Mvx.IoCProvider.Resolve<HomeViewModel>();
            var model = UpdateViewModel(home);
            
        }
        //public bool ToggleIsChecked { get; set; }

        

        //https://www.mvvmcross.com/documentation/fundamentals/data-binding MethodBinding
        public async Task UpdateViewModel(MvxViewModel model)
        {
            await _dispatcher.ShowViewModel(new MvxViewModelRequest(model.GetType()));
        }
    }
}


