using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxElebris.Core.ViewModels
{
    public class ShellViewModel : MvxViewModel
    {
        public ShellViewModel()
        {
           
        }
        private NavBarViewModel _navigationVM;
        private MvxViewModel _displayVM;
        public NavBarViewModel NavigationVM { get => _navigationVM; set => _navigationVM = value; }
        public MvxViewModel DisplayVM { get => _displayVM; set => _displayVM = value; }


        public IMvxAsyncCommand UpdateViewCommand { get; set; }
    }
}


